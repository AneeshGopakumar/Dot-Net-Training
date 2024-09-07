using System;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Layout.Borders;

namespace iTextDemo
{
    internal class PDFInvoiceGenerator
    {
        static void Main(string[] args)
        {
            // Define the file path for the PDF
            string dest = "Sample_Invoice.pdf";

            // Initialize the PDF writer and document
            PdfWriter writer = new PdfWriter(dest);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            

            // Add title
            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
            Paragraph title = new Paragraph("INVOICE")
                .SetFont(font)
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20)
                .SetMarginTop(0);
            document.Add(title);

            // Add image at the top left
            Image img = new Image(ImageDataFactory.Create("C:\\Users\\Administrator\\source\\repos\\AneeshGitH\\Day 26 - PDF - Continuation\\iTextDemo\\Logo.jfif"));
            img.SetFixedPosition(50, 730); // Adjust the position as needed
            img.SetHeight(100);
            img.SetWidth(100);
            document.Add(img);

            // Add Invoice details below the title
            document.Add(new Paragraph("\n\n\nInvoice Number: 12345"));
            document.Add(new Paragraph("Invoice Date: " + DateTime.Now.ToString("yyyy-MM-dd")));
            
            // Add Seller and Buyer information
            document.Add(new Paragraph("\nSeller Information:").SetBold());
            document.Add(new Paragraph("Company Name"));
            document.Add(new Paragraph("Address"));
            document.Add(new Paragraph("Phone: "));
            document.Add(new Paragraph("Email: "));

            document.Add(new Paragraph("\nBuyer Information:").SetBold());
            document.Add(new Paragraph("Customer Name"));
            document.Add(new Paragraph("Address"));
            document.Add(new Paragraph("Phone: "));
            document.Add(new Paragraph("Email: "));

            // Add Table with item details
            Table table = new Table(UnitValue.CreatePercentArray(5)).UseAllAvailableWidth();

            // Add table headers with full borders
            table.AddHeaderCell(new Cell().Add(new Paragraph("Item")).SetBold());
            table.AddHeaderCell(new Cell().Add(new Paragraph("Description")).SetBold());
            table.AddHeaderCell(new Cell().Add(new Paragraph("Quantity")).SetBold());
            table.AddHeaderCell(new Cell().Add(new Paragraph("Unit Price")).SetBold());
            table.AddHeaderCell(new Cell().Add(new Paragraph("Total")).SetBold());

            // Add item rows with full borders
            table.AddCell(new Cell().Add(new Paragraph("Product 1")));
            table.AddCell(new Cell().Add(new Paragraph("Description")));
            table.AddCell(new Cell().Add(new Paragraph("2")));
            table.AddCell(new Cell().Add(new Paragraph("$100.00")));
            table.AddCell(new Cell().Add(new Paragraph("$200.00")));

            table.AddCell(new Cell().Add(new Paragraph("Product 2")));
            table.AddCell(new Cell().Add(new Paragraph("Description")));
            table.AddCell(new Cell().Add(new Paragraph("1")));
            table.AddCell(new Cell().Add(new Paragraph("$300.00")));
            table.AddCell(new Cell().Add(new Paragraph("$300.00")));


            // Add the table to the document
            document.Add(table);

            // Add total amount
            document.Add(new Paragraph("\n\n\nTotal Amount: $500.00").SetBold());

            // Close the document
            document.Close();

            Console.WriteLine("Invoice PDF with image and full table borders created successfully!");
        }
    }
}
