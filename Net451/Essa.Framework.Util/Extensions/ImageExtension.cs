namespace Alfazema.Framework.Util.Extensions
{
    using iTextSharp.text;

    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.IO;


    public static class ImageExtension
    {


        #region ToResize

        /// <summary>
        /// Redimensiona uma imagem mantendo a proporção
        /// </summary>
        /// <param name="image"></param>
        /// <param name="widthMaximo"></param>
        /// <param name="heightMaximo"></param>
        /// <returns></returns>
        public static System.Drawing.Image ToResize(this System.Drawing.Image image, int widthMaximo, int heightMaximo)
        {
            float fator;

            if (image.Width / widthMaximo > image.Height / heightMaximo)
                fator = (float)image.Width / widthMaximo;
            else
                fator = (float)image.Height / heightMaximo;

            int newWidth = (int)(image.Width / fator);
            int newHeight = (int)(image.Height / fator);

            return new Bitmap(image, new Size(newWidth, newHeight));
        }

        public enum EnumTipoRedimensionar
        {
            DiminuirSeOriginalForMaior,
            AumentarSeOriginalForMenor
        }

        public static System.Drawing.Image ToResize(this System.Drawing.Image image, int widthMaximo, int heightMaximo, EnumTipoRedimensionar enumTipoRedimensionar)
        {
            bool isRedimensionar = false;
            switch (enumTipoRedimensionar)
            {
                case EnumTipoRedimensionar.AumentarSeOriginalForMenor:
                    isRedimensionar = image.Width < widthMaximo || image.Height < heightMaximo;
                    break;
                case EnumTipoRedimensionar.DiminuirSeOriginalForMaior:
                    isRedimensionar = image.Width > widthMaximo || image.Height > heightMaximo;
                    break;
            }

            return isRedimensionar
                ? image.ToResize(widthMaximo, heightMaximo)
                : image;
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageObj"></param>
        /// <param name="pageSize">Ex.: iTextSharp.text.PageSize.A4</param>
        /// <param name="margem"></param>
        /// <returns></returns>
        public static byte[] ToPdf(this System.Drawing.Image imageObj, iTextSharp.text.Rectangle pageSize, float margem)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Document document = new Document(pageSize, margem, margem, margem, margem);
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression();
                document.Open();

                iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(imageObj, BaseColor.WHITE);
                document.Add(image);
                document.Close();

                return ms.ToArray();
            }
        }



        public static byte[] ToByteArray(this System.Drawing.Image imagem)
        {
            return (byte[])new ImageConverter().ConvertTo(imagem, typeof(byte[]));
        }



        public static System.Drawing.Image Redimensionar(this System.Drawing.Image image, int NewWidthMax, int NewHeightMax)
        {
            float Fator = 0;
            if (image.Width / NewWidthMax > image.Height / NewHeightMax)
                Fator = (float)image.Width / NewWidthMax;
            else
                Fator = (float)image.Height / NewHeightMax;

            int NewWidth = (int)(image.Width / Fator);
            int NewHeight = (int)(image.Height / Fator);

            Bitmap newImage = new Bitmap(NewWidth, NewHeight);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.HighQuality;
                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gr.DrawImage(image, new System.Drawing.Rectangle(0, 0, NewWidth, NewHeight));
            }

            return newImage;
        }


        public static System.Drawing.Image RedimensionarSeMaior(this System.Drawing.Image image, int NewWidthMax, int NewHeightMax)
        {
            if (image.Width <= NewWidthMax && image.Height <= NewHeightMax)
                return image;

            return image.Redimensionar(NewWidthMax, NewHeightMax);
        }
    }
}
