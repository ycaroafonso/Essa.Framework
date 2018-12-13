﻿namespace Essa.Framework.PDF
{
    using iTextSharp.text;
    using iTextSharp.text.pdf;
    using System;
    using System.Collections.Generic;
    using System.IO;


    public class Pdf
    {
        public static byte[] MergeFiles(List<byte[]> sourceFiles)
        {
            Document document = new Document();
            MemoryStream output = new MemoryStream();
            
            try
            {
                // Inicializa pdf writer
                PdfWriter writer = PdfWriter.GetInstance(document, output);
                writer.PageEvent = new PdfPageEvents();

                // Abre Documento para escrita
                document.Open();
                PdfContentByte content = writer.DirectContent;

                // Interação entre os documentos
                for (int fileCounter = 0; fileCounter < sourceFiles.Count; fileCounter++)
                {
                    // Criar pdf reader
                    PdfReader reader = new PdfReader(sourceFiles[fileCounter]);
                    int numberOfPages = reader.NumberOfPages;

                    // Interação entre as paginas
                    for (int currentPageIndex = 1; currentPageIndex <=
                                       numberOfPages; currentPageIndex++)
                    {
                        // Determinando o tamanho da pagina
                        document.SetPageSize(
                           reader.GetPageSizeWithRotation(currentPageIndex));

                        // criando pagina
                        document.NewPage();
                        PdfImportedPage importedPage =
                          writer.GetImportedPage(reader, currentPageIndex);


                        // Determinando a orientação
                        int pageOrientation = reader.GetPageRotation(currentPageIndex);
                        if ((pageOrientation == 90) || (pageOrientation == 270))
                        {
                            content.AddTemplate(importedPage, 0, -1f, 1f, 0, 0,
                               reader.GetPageSizeWithRotation(currentPageIndex).Height);
                        }
                        else
                        {
                            content.AddTemplate(importedPage, 1f, 0, 0, 1f, 0, 0);
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                throw new Exception("Exception Inesperada: ", exception);
            }
            finally
            {
                document.Close();
            }
            return output.GetBuffer();
        }
    }

    /// <summary>
    /// Eventos da página
    /// </summary>
    internal class PdfPageEvents : IPdfPageEvent
    {
        #region members
        private BaseFont _baseFont = null;
        private PdfContentByte _content;
        #endregion

        #region IPdfPageEvent Members
        public void OnOpenDocument(PdfWriter writer, Document document)
        {
            _baseFont = BaseFont.CreateFont(BaseFont.HELVETICA,
                             BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            _content = writer.DirectContent;
        }

        public void OnStartPage(PdfWriter writer, Document document)
        { }

        public void OnEndPage(PdfWriter writer, Document document)
        {
            #region Criar Rodape
            //// Header text
            //string headerText = "";
            //_content.BeginText();
            //_content.SetFontAndSize(_baseFont, 8);
            //_content.SetTextMatrix(GetCenterTextPosition(headerText,
            //                       writer), writer.PageSize.Height - 10);
            //_content.ShowText(headerText);
            //_content.EndText();

            //// footer text (page numbers)
            //string text = "Page " + writer.PageNumber;
            //_content.BeginText();
            //_content.SetFontAndSize(_baseFont, 8);
            //_content.SetTextMatrix(GetCenterTextPosition(text, writer), 10);
            //_content.ShowText(text);
            //_content.EndText();
            #endregion
        }

        public void OnCloseDocument(PdfWriter writer, Document document)
        { }

        public void OnParagraph(PdfWriter writer,
                    Document document, float paragraphPosition)
        { }

        public void OnParagraphEnd(PdfWriter writer,
                    Document document, float paragraphPosition)
        { }

        public void OnChapter(PdfWriter writer, Document document,
                              float paragraphPosition, Paragraph title)
        { }

        public void OnChapterEnd(PdfWriter writer,
                    Document document, float paragraphPosition)
        { }

        public void OnSection(PdfWriter writer, Document document,
                    float paragraphPosition, int depth, Paragraph title)
        { }

        public void OnSectionEnd(PdfWriter writer,
                    Document document, float paragraphPosition)
        { }

        public void OnGenericTag(PdfWriter writer, Document document,
                                 Rectangle rect, string text)
        { }
        #endregion

        private float GetCenterTextPosition(string text, PdfWriter writer)
        {
            return writer.PageSize.Width / 2 - _baseFont.GetWidthPoint(text, 8) / 2;
        }
    }
}
