namespace Alfazema.Framework.Util
{
    using Alfazema.Framework.Util.Extensions;
    using Alfazema.Framework.Util.Models.OFX;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml;
    using System.Xml.Serialization;


    public static class Geral
    {
        public static Dictionary<bool, string> SimNaoBooleano()
        {
            return new Dictionary<bool, string>
            {
                {true,"Sim" },
                {false,"Não" },
            };
        }


        public static string[] Meses()
        {
            return new string[] { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        }

        public static Dictionary<int, string> MesesComNumero()
        {
            return Meses().Select((item, index) => new { index = index + 1, item }).ToDictionary(c => c.index, d => d.item);
        }

        /// <summary>
        /// Lista de anos até o ano atual
        /// </summary>
        /// <param name="primeiro"></param>
        /// <returns></returns>
        public static IEnumerable<int> Anos(int primeiro)
        {
            for (int ano = primeiro; ano <= DateTime.Today.Year; ano++)
            {
                yield return ano;
            }
        }

        public static IEnumerable<int> Anos(int primeiro, int ate)
        {
            for (int i = primeiro; i <= ate; i++)
            {
                yield return i;
            }
        }


        public static Dictionary<string, string> SimNao()
        {
            return new Dictionary<string, string>
            {
                { "S", "Sim" },
                { "N", "Não" }
            };
        }



        public static bool IsReleaseBuild()
        {
#if DEBUG
            return false;
#else
    return true;
#endif
        }


        public static BANKTRANLIST LerOFX(string xmlstr)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlstr.Substring(xmlstr.IndexOf("<OFX>"))); // suppose that myXmlString contains "<Names>...</Names>"

            var transactions = xml
                .GetElementsByTagName("BANKTRANLIST");

            var serializer = new XmlSerializer(typeof(BANKTRANLIST), new XmlRootAttribute("BANKTRANLIST"));
            var trans = (BANKTRANLIST)serializer.Deserialize(new XmlNodeReader(transactions[0]));

            return trans;
        }

    }
}
