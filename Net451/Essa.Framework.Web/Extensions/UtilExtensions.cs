﻿namespace Alfazema.Framework.Web.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Web;
    using System.Web.Mvc;


    public static class UtilExtensions
    {
        public static SelectList ToSelectList<T>(this T[] lista)
        {
            return new SelectList(lista);
        }
        public static SelectList ToSelectList<T>(this List<T> lista)
        {
            return new SelectList(lista);
        }


        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> texto)
        {
            return ToSelectList(enumerable, texto, texto, "SELECIONE…", null, null);
        }
        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> valor, Func<T, object> texto)
        {
            return ToSelectList(enumerable, valor, texto, "SELECIONE…", null, null);
        }
        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> valor, Func<T, object> texto, object valorSelecionado)
        {
            return ToSelectList(enumerable, valor, texto, "SELECIONE…", null, valorSelecionado);
        }
        public static SelectList ToSelectList<T>(this T enumerable, Func<T, object> valor, Func<T, object> texto)
        {
            return ToSelectList(new List<T> { enumerable }, valor, texto, null, null, null);
        }

        public static SelectList ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, object> valor, Func<T, object> texto, string nomePrimeiroCampo, string valorPrimeiroCampo, object valorSelecionado = null)
        {
            var list = enumerable.Select(x => new SelectListItem
            {
                Value = valor.Invoke(x).ToString(),
                Text = texto.Invoke(x).ToString(),
            });

            if (nomePrimeiroCampo != null)
            {
                var x = list.ToList();
                x.Insert(0, new SelectListItem { Value = valorPrimeiroCampo, Text = nomePrimeiroCampo });
                list = x;
            }

            return new SelectList(list, "Value", "Text", valorSelecionado);
        }
        public static byte[] ToByteArray(this HttpPostedFileBase file)
        {
            //byte[] imageByte = null;
            //BinaryReader rdr = new BinaryReader(file.InputStream);
            //imageByte = rdr.ReadBytes(file.ContentLength);
            //return imageByte;

            var x = new byte[file.ContentLength];
            file.InputStream.Read(x, 0, file.ContentLength);
            return x;
        }

        public static DateTime StrToDateTime(this String valor)
        {
            if (valor.IndexOf("/") == -1 && valor.IndexOf("-") == -1)
            {
                return Convert.ToDateTime(valor.Substring(0, 2) + "/" + valor.Substring(2, 2) + "/" + valor.Substring(4));
            }
            else if (valor.IndexOf("-") != -1)
            {
                return new DateTime(valor.Substring(0, 4).StrToInt32(), valor.Substring(5, 2).StrToInt32(), valor.Substring(8, 2).StrToInt32());
            }
            else
                return Convert.ToDateTime(valor);
        }

        public static int StrToInt32(this String valor)
        {
            if (String.IsNullOrWhiteSpace(valor))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(valor);
            }
        }
    }
}
