﻿namespace Alfazema.Framework.Util.Extensions
{
    using Extensions;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;


    public static class UtilExtension
    {
        public static int ToInt32(this object valor)
        {
            return Convert.ToInt32(valor);
        }

        public static bool IfNegative<T>(this T value) where T : IComparable<T>
        {
            return value.CompareTo(default(T)) < 0;
        }

        public static T IfNegative<T>(this T value, Func<T, T> actionReturn) where T : IComparable<T>
        {
            return value.IfNegative() ? actionReturn(value) : value;
        }

        public static T IfNull<T>(this T value, T ret)
        {
            return value == null ? ret : value;
        }

        public static Ret IfNull<T, Ret>(this T value, Ret valorSeNull, Func<T, Ret> valorfalse)
        {
            if (value == null)
                return valorSeNull;
            else
                return valorfalse(value);
        }



        #region IfOnly

        public static T IfOnly<T>(this T value, bool condit, T ret)
        {
            return condit ? ret : value;
        }
        public static T IfOnly<T>(this T value, Func<T, bool> condit, T ret)
        {
            return condit(value) ? ret : value;
        }

        /// <summary>
        /// Compara as key de um dictionary e retorna value.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <param name="ret"></param>
        /// <returns></returns>
        public static T IfOnly<T>(this T value, Dictionary<T, T> ret)
        {
            if (ret.ContainsKey(value))
                return ret[value];

            return value;
        }


        /// <summary>
        /// Compara as key de um dictionary e retorna value, se não existir, retorna o parâmetro valorelse;
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="value"></param>
        /// <param name="ret"></param>
        /// <param name="valorelse"></param>
        /// <returns></returns>
        public static V IfOnly<T, V>(this T value, Dictionary<T, V> ret, V valorelse)
        {
            if (ret.ContainsKey(value))
                return ret[value];

            return valorelse;
        }

        #endregion



        /// <summary>
        /// IfGreaterLessOrZero
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="seMaior"></param>
        /// <param name="seMenor"></param>
        /// <param name="seZero"></param>
        /// <returns></returns>
        public static string MaiorMenorOuZero(this decimal valor, string seMaior, string seMenor, string seZero)
        {
            switch (valor.CompareTo(0))
            {
                case -1:
                    return seMenor;
                case 0:
                    return seZero;
                default:
                    return seMaior;
            }
        }

        public static string ToMesExtenso(this int mes)
        {
            return Geral.Meses()[mes - 1];
        }

        public static byte[] ToByteArray(this Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }


        public static Dictionary<int, T> ToDictionary<T>(this T[] lista)
        {
            return lista.Select((item, index) => new { index, item }).ToDictionary(c => c.index, d => d.item);
        }





        public static string ToJson<T>(this T obj)
        {
            return obj.ToJson(new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore,
            });
        }

        public static string ToJson<T>(this T lista, JsonSerializerSettings jsonSerializerSettings)
        {
            return JsonConvert.SerializeObject(lista, jsonSerializerSettings);
        }

        public static string ToJson<T>(this T lista, Formatting formatting)
        {
            return lista.ToJson(new JsonSerializerSettings
            {
                Formatting = formatting,
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
        }
        public static string ToJson<T>(this T lista, ReferenceLoopHandling referenceLoopHandling)
        {
            return lista.ToJson(new JsonSerializerSettings
            {
                ReferenceLoopHandling = referenceLoopHandling
            });
        }

        public static string ToJson<T>(this T obj, DefaultValueHandling defaultValueHandling)
        {
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
            {
                DefaultValueHandling = defaultValueHandling
            });
        }


        public static string FormataCep(this string cep)
        {
            try
            {
                return string.Format("{0}.{1}-{2}", cep.Substring(0, 2), cep.Substring(2, 3), cep.Substring(5, 3));
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string FormataCpf(this string valor)
        {
            if (string.IsNullOrEmpty(valor)) return valor;
            return string.Format(@"{0:000\.000\.000\-00}", Convert.ToInt64(valor));
        }

        public static string FormataCnpj(this string valor)
        {
            if (string.IsNullOrEmpty(valor)) return valor;
            return string.Format(@"{0:00\.000\.000\/0000\-00}", Convert.ToInt64(valor));
        }

        public static string FormataCpfCnpj(this string valor)
        {
            if (string.IsNullOrEmpty(valor))
                return string.Empty;

            if (valor.Length == 11)
                return valor.FormataCpf();
            else
                return valor.FormataCnpj();
        }

        public static String DateToStr(this DateTime valor)
        {
            return Convert.ToDateTime(valor).ToString("dd/MM/yyyy");
        }

        public static String DateToStr(this DateTime? valor)
        {
            if (valor == null)
            {
                return String.Empty;
            }
            else
            {
                return Convert.ToDateTime(valor).ToString("dd/MM/yyyy");
            }
        }

        public static string FormatarTelefone(this string telefone)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(telefone))
                {
                    return string.Empty;
                }
                else
                {
                    telefone = telefone.Replace("-", "").Replace("(", "").Replace(")", "").Replace(" ", "");

                    if (telefone.Length == 11)
                    {
                        return string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 5), telefone.Substring(7, 4));
                    }
                    if (telefone.Length == 10)
                    {
                        return string.Format("({0}) {1}-{2}", telefone.Substring(0, 2), telefone.Substring(2, 4), telefone.Substring(6, 4));
                    }
                    else if (telefone.Length == 8 || telefone.Length == 9)
                    {

                        return string.Format("{0}-{1}", telefone.Substring(0, 4), telefone.Substring(4, 4));
                    }
                    else
                    {
                        return string.Empty;
                    }
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        public static T IfContainsOnlyOne<T>(this IEnumerable<T> lista)
        {
            if (lista.Count() == 1)
                return lista.Single();
            return default(T);
        }

        public static T[] Remove<T>(this T[] arr, T itemRemover)
        {
            var lista = arr.ToList();
            lista.Remove(itemRemover);
            return lista.ToArray();
        }
    }
}