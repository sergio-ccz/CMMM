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
            // step 1: creation of a document-object specifying the size
            iTextSharp.text.Rectangle pageSize = new iTextSharp.text.Rectangle(210, 297); // A4 size
            Document document = new Document(pageSize, 10, 10, 10, 10); // 10: Margins Left, Right, Top, Bottom

            string file = "Choo.pdf";

            // step 2:
            // we create a writer that listens to the document and directs a PDF-stream to a file            
            PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));

            // step 3: we open the document
            document.Open();

            PdfPTable table1 = new PdfPTable(2);

            // step 5: we close the document
            document.Close();
            System.Diagnostics.Process.Start(file);
        }
    }
}
