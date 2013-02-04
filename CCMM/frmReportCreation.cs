using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using System.IO;
using iTextSharp.text;

namespace CCMM
{
    public partial class frmReportCreation : Form
    {
        public frmReportCreation()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Create a Document object
            var document = new Document(PageSize.A4, 50, 50, 25, 25);

            string file = "Choo.pdf";
            // Create a new PdfWriter object, specifying the output stream
            var output = new MemoryStream();
            //var writer = PdfWriter.GetInstance(document, output);
            var writer = PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));

            // Open the Document for writing
            document.Open();

            var titleFont = FontFactory.GetFont("Arial", 18);
            var subTitleFont = FontFactory.GetFont("Arial", 14);
            var boldTableFont = FontFactory.GetFont("Arial", 12);
            var endingMessageFont = FontFactory.GetFont("Arial", 10);
            var bodyFont = FontFactory.GetFont("Arial", 12);

            //document.Add(new Paragraph("Northwind Traders Receipt", titleFont);
            Paragraph tit = new Paragraph();
            Chunk c1 = new Chunk("  Ingresos Diarios \n", titleFont);
            Chunk c2 = new Chunk("Ciclo Escolar 2012 - 2013 \n");
            Chunk c3 = new Chunk("Dia consultado : 25/01/2013");
            tit.Add(c1);
            tit.Add(c2);
            tit.Add(c3);
            tit.IndentationLeft = 200f;
            document.Add(tit);

            PdfContentByte cb = writer.DirectContent;
            cb.MoveTo(50, document.PageSize.Height / 2);
            cb.LineTo(document.PageSize.Width - 50, document.PageSize.Height / 2);
            cb.Stroke();

           
            var orderInfoTable = new PdfPTable(2);
            orderInfoTable.HorizontalAlignment = 0;
            orderInfoTable.SpacingBefore = 10;
            orderInfoTable.SpacingAfter = 10;
            orderInfoTable.DefaultCell.Border = 0;
            orderInfoTable.SetWidths(new int[] { 1, 4 });

            orderInfoTable.AddCell(new Phrase("Order:", boldTableFont));
            orderInfoTable.AddCell("textorder");
            orderInfoTable.AddCell(new Phrase("Price:", boldTableFont));
            orderInfoTable.AddCell(Convert.ToDecimal(444444).ToString("c"));

            document.Add(orderInfoTable);
            document.Close();
            System.Diagnostics.Process.Start(file);
        }
    }
}
