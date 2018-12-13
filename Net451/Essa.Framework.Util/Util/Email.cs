namespace Alfazema.Framework.Util
{
    using System.IO;
    using System.Net.Mail;
    using System.Net.Mime;


    public class Email
    {
        private System.Net.NetworkCredential _credencial;
        private SmtpClient _smtp;

        MailMessage _mailMessage;

        public string Titulo
        {
            get
            {
                return _mailMessage.Subject;
            }
            set
            {
                _mailMessage.Subject = value;
            }
        }


        public Email(string userName, string password, string servidor, int porta, string emailDe)
        {
            _credencial = new System.Net.NetworkCredential(userName, password);
            _smtp = new SmtpClient(servidor, porta);
            _smtp.EnableSsl = true;
            _smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            _smtp.UseDefaultCredentials = false;
            _smtp.Credentials = _credencial;

            _mailMessage = new MailMessage()
            {
                From = new MailAddress(emailDe)
            };
        }


        public Email Conteudo(string cont, bool IsBodyHtml)
        {
            _mailMessage.Body = cont;
            _mailMessage.IsBodyHtml = IsBodyHtml;

            return this;
        }

        public Email AddDestinatario(string email)
        {
            _mailMessage.To.Add(email);

            return this;
        }


        public Email AddArquivoIncorporado(string conteudo, string cid, byte[] imagem, string contentType)
        {
            MemoryStream image1 = new MemoryStream(imagem);
            AlternateView av = AlternateView.CreateAlternateViewFromString(conteudo, null, MediaTypeNames.Text.Html);

            LinkedResource headerImage = new LinkedResource(image1);
            headerImage.ContentId = cid;
            headerImage.ContentType = new ContentType(contentType);
            av.LinkedResources.Add(headerImage);
            _mailMessage.AlternateViews.Add(av);

            return this;
        }


        public void Enviar()
        {
            _smtp.Send(_mailMessage);
        }
    }
}
