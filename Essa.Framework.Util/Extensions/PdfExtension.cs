namespace Essa.Framework.Util.Extensions
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;

    using System.Collections.Generic;
    using System.IO;


    public static class PdfExtension
    {

        public static byte[] Concatenar(this List<byte[]> pdf)
        {
            byte[] retorna;

            using (MemoryStream ms = new MemoryStream())
            {
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, ms);

                doc.SetPageSize(PageSize.LETTER);
                doc.Open();
                PdfContentByte cb = writer.DirectContent;

                foreach (byte[] p in pdf)
                {
                    PdfReader reader = new PdfReader(p);
                    int pages = reader.NumberOfPages;

                    for (int i = 1; i <= pages; i++)
                    {
                        doc.SetPageSize(PageSize.LETTER);
                        doc.NewPage();
                        PdfImportedPage page = writer.GetImportedPage(reader, i);
                        cb.AddTemplate(page, 0, 0);
                    }
                }

                doc.Close();
                retorna = ms.GetBuffer();

                ms.Flush();
                ms.Dispose();
            }

            return retorna;
        }

    }
}
