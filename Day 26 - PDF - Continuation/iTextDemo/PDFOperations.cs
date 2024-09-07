using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas;
using iText.Kernel.Pdf;
using iText.Kernel.Geom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iTextDemo
{
    internal class PDFOperations
    {
        static void Main2(string[] args)
        {
            string inputpdfPath = "TestPDF.pdf";
            string outputpdfPath = "OutputTestPDF.pdf";
            //PdfReader pdfReader = new PdfReader(inputpdfPath);
            //PdfWriter pdfWriter = new PdfWriter(outputpdfPath);
            //PdfDocument pdfDocument = new PdfDocument(pdfReader, pdfWriter);

            //int numberOfPages = pdfDocument.GetNumberOfPages();

            //for (int i = 1; i <= numberOfPages; i++)
            //{
            //    PdfPage page = pdfDocument.GetPage(i);
            //    Rectangle pageSize = page.GetPageSize();

            //    PdfCanvas canvas = new PdfCanvas(page);
            //    string text = "Sample from C#";
            //    float x = pageSize.GetWidth() / 2;
            //    float y = pageSize.GetHeight() / 2;

            //    canvas.BeginText().SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 12).
            //        MoveText(x, y).ShowText(text).EndText();

            //}

            //for password protected files
            PdfReader pdfReader = new PdfReader(inputpdfPath, new ReaderProperties().SetPassword(Encoding.UTF8.GetBytes("owner123")));
            PdfWriter pdfWriter = new PdfWriter(outputpdfPath);
            PdfDocument pdfDocument = new PdfDocument(pdfReader, pdfWriter);

            int numberOfPages = pdfDocument.GetNumberOfPages();

            for (int i = 1; i <= numberOfPages; i++)
            {
                PdfPage page = pdfDocument.GetPage(i);
                Rectangle pageSize = page.GetPageSize();

                PdfCanvas canvas = new PdfCanvas(page);
                string text = "Sample from vikash with password now";
                float x = pageSize.GetWidth() / 2;
                float y = pageSize.GetHeight() / 2;

                canvas.BeginText().SetFontAndSize(PdfFontFactory.CreateFont(StandardFonts.HELVETICA), 12).
                    MoveText(x, y).ShowText(text).EndText();

            }

            pdfDocument.Close();

        }
    }
}
