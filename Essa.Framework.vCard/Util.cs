namespace Essa.Framework.vCard
{
    using MixERP.Net.VCards;
    using MixERP.Net.VCards.Models;
    using MixERP.Net.VCards.Serializer;
    using MixERP.Net.VCards.Types;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class GerarVCard
    {
        public string Montar(List<Contato> lista)
        {
            var ret = new StringBuilder();

            foreach (var c in lista.ToList())
            {
                var vcard = new VCard
                {
                    Version = VCardVersion.V4,
                    FormattedName = c.nome,
                    //FirstName = "John",
                    //LastName = "Doe",
                    //Classification = ClassificationType.Confidential,
                    Categories = c.Categorias,

                    Addresses = new List<Address>
                    {
                        new Address
                        {
                            Type= AddressType.Home,
                            Street=string.Concat(c.logradouro, ", nº ", c.numero, ", ", c.bairro),
                            Locality = c.cidade,
                        }
                    },
                    Gender = c.genero,
                    BirthDay = c.datanascimento,

                    Emails = new List<Email> { new Email { EmailAddress = c.email } },

                    Telephones = new List<Telephone>
                    {
                        new Telephone {Type = TelephoneType.Home, Number = c.telefonefixo },
                    },


                    Note = c.Observacao,

                };

                if (c.celular != null)
                {
                    vcard.Telephones = vcard.Telephones.Concat(new List<Telephone>
                    {
                        new Telephone { Type = TelephoneType.Cell, Number = c.celular },
                        new Telephone { Type = TelephoneType.Personal, Number = c.celular.Replace(") 9", ") ") },
                    });
                }



                string serialized = vcard.Serialize();

                ret.AppendLine(serialized);
            }

            return ret.ToString();
        }
    }



    public class Contato
    {
        public string telefonefixo;

        public string bairro { get; set; }
        public string celular { get; set; }
        public string cidade { get; set; }
        public DateTime? datanascimento { get; set; }
        public string email { get; set; }
        public Gender genero { get; set; }
        public string logradouro { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }

        public string Observacao { get; set; }

        public string[] Categorias { get; set; }
    }
}
