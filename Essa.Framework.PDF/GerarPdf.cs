namespace Essa.Framework.PDF
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System.Collections.Generic;
    using System.IO;


    public class GerarPdf
    {
        public Document Documento { get; set; }

        private MemoryStream memStream;
        private PdfWriter writer;


        public string FontFile
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                else
                    BaseFont = BaseFont.CreateFont(value, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            }
        }

        public BaseFont BaseFont { get; private set; } = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

        public GerarPdf(float cmLargura, float cmHeight)
        {
            Documento = new Document();

            Documento.SetPageSize(new Rectangle(Utilities.MillimetersToPoints(cmLargura), Utilities.MillimetersToPoints(cmHeight)));


            memStream = new MemoryStream();
            writer = PdfWriter.GetInstance(Documento, memStream);
            writer.CloseStream = false;
            Documento.Open();
        }

        public GerarPdf(string p = "A4", char o = 'H')
        {
            Documento = new Document();

            switch (p)
            {
                case "A4":
                    if (o == 'V')
                        Documento.SetPageSize(PageSize.A4);
                    else
                        Documento.SetPageSize(PageSize.A4.Rotate());
                    break;
                case "Carta":
                    if (o == 'V')
                        Documento.SetPageSize(PageSize.LETTER);
                    else
                        Documento.SetPageSize(PageSize.LETTER.Rotate());
                    break;
            }


            memStream = new MemoryStream();
            writer = PdfWriter.GetInstance(Documento, memStream);
            writer.CloseStream = false;
            Documento.Open();
        }

        public GerarPdf AddItem(List<TextoPdf> itens)
        {
            foreach (var item in itens)
                AddItem(item);

            return this;
        }
        public GerarPdf AddItem(TextoPdf item)
        {
            PdfContentByte cb = writer.DirectContent;
            cb.BeginText();
            cb.SetFontAndSize(BaseFont, item.fz);
            cb.ShowTextAligned(item.al == 'C' ? PdfContentByte.ALIGN_CENTER : PdfContentByte.ALIGN_LEFT, item.txt, item.pX, item.pY, 0);
            cb.EndText();

            return this;
        }




        public byte[] Gerar()
        {
            Documento.Close();
            byte[] buf = new byte[memStream.Position];
            memStream.Position = 0;
            memStream.Read(buf, 0, buf.Length);

            return buf;
        }
    }
}
