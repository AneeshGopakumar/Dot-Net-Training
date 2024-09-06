using System;
using System.IO;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace iTextDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pdfPath = "TestPDF.pdf";

            using (FileStream fs = new FileStream(pdfPath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                //initialize a pdfwriter with encryption
                byte[] userPassword = System.Text.Encoding.UTF8.GetBytes("userpassword");
                byte[] ownerPassword = System.Text.Encoding.UTF8.GetBytes("ownerpassword");
                WriterProperties writerprops = new WriterProperties().
                  SetStandardEncryption(userPassword, ownerPassword, EncryptionConstants.ALLOW_PRINTING | EncryptionConstants.ALLOW_COPY, EncryptionConstants.ENCRYPTION_AES_256);

                //initialize a new pdf document with/without encryption
                //PdfWriter writer = new PdfWriter(fs, writerprops);
                PdfWriter writer = new PdfWriter(fs);
                PdfDocument pdfDocument = new PdfDocument(writer);

                //initialize a document for layout
                Document document = new Document(pdfDocument);

                //Add a sample paragraph
                document.Add(new Paragraph("Heading 1").SetFontSize(15).SetBold());
                document.Add(new Paragraph("Hello I am a sample paragraph written from C#"));
                document.Add(new Paragraph("Heading 2").SetFontSize(15).SetBold());
                document.Add(new Paragraph("You can copy and print this document"));
                //Adding a grid format in pdf

                Table table = new Table(UnitValue.CreatePercentArray(3)).UseAllAvailableWidth();// 3 columns with equal width

                // Create a header row
                Cell headerCell1 = new Cell().Add(new Paragraph("ID"));
                Cell headerCell2 = new Cell().Add(new Paragraph("Employee Name"));
                Cell headerCell3 = new Cell().Add(new Paragraph("Salary"));

                // Set background color for header cells
                Color backgroundColor = ColorConstants.BLUE;
                headerCell1.SetBackgroundColor(backgroundColor);
                headerCell2.SetBackgroundColor(backgroundColor);
                headerCell3.SetBackgroundColor(backgroundColor);
                table.AddHeaderCell(headerCell1);
                table.AddHeaderCell(headerCell2);
                table.AddHeaderCell(headerCell3);
                table.AddCell("1");
                table.AddCell("Rohit Sharma");
                table.AddCell("1M");
                table.AddCell("2");
                table.AddCell("Virat Kohli");
                table.AddCell("2M");
                document.Add(table);
                document.Close();
            }
            Console.WriteLine("PDF created.");
        }
    }
}