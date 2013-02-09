using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CCMM
{
    class Printing
    {
        private class MyPageEventHandler : PdfPageEventHelper
        {
            /*
             * We use a __single__ Image instance that's assigned __once__;
             * the image bytes added **ONCE** to the PDF file. If you create 
             * separate Image instances in OnEndPage()/OnEndPage(), for example,
             * you'll end up with a much bigger file size.
             */
            public Image ImageHeader { get; set; }
            private string[] ReportType = new string[4] { "Reporte de Ingresos", "Reporte de Adeudos", "Historial de Pagos", "Historial de Adeudos" };

            public override void OnEndPage(PdfWriter writer, Document document)
            {
                // cell height 
                float cellHeight = 90;
                // PDF document size      
                Rectangle page = document.PageSize;

                // create two column table
                PdfPTable head = new PdfPTable(2);
                head.TotalWidth = page.Width / 2;

                // add image; PdfPCell() overload sizes image to fit cell
                PdfPCell c = new PdfPCell(ImageHeader, true);
                c.HorizontalAlignment = Element.ALIGN_CENTER;
                c.FixedHeight = cellHeight;
                c.Colspan = 2;
                c.Border = PdfPCell.NO_BORDER;
                head.AddCell(c);


                Chunk c1 = new Chunk(ReportType[_reportType] + "\n\n");
                Chunk c2 = new Chunk("Ciclo Escolar 2012 - 2013 \n");
                Chunk c3 = new Chunk("Dia Consultado " + _checkedDate.ToShortDateString());
                Phrase tit = new Phrase(c1);
                tit.Add(c2);
                tit.Add(c3);
                PdfPCell pfce = new PdfPCell(tit);
                pfce.Colspan = 2;
                pfce.Border = PdfPCell.NO_BORDER;
                pfce.HorizontalAlignment = Element.ALIGN_CENTER;
                pfce.FixedHeight = cellHeight;
                head.AddCell(pfce);

                head.WriteSelectedRows(0, -1, page.Width / 4, page.Height - cellHeight + head.TotalHeight - 100, writer.DirectContent);

                PdfPTable head2 = new PdfPTable(1);
                head2.TotalWidth = (page.Width) - (page.Width / 5);

                PdfPCell coc = new PdfPCell(new Phrase(" "));
                coc.Border = PdfPCell.BOTTOM_BORDER;
                head2.AddCell(coc);
                head2.WriteSelectedRows(0, -1, page.Width / 10, 695, writer.DirectContent);
            }
        }

        private static List<string[]> _reportData;
        private static DateTime _checkedDate;
        private static int _reportType;
        private static string _reportLevel;

        private static void PrintEarningsReport()
        {
            System.Drawing.Image imageHeader = (System.Drawing.Image)CCMM.Properties.Resources.logo;
            var logo = iTextSharp.text.Image.GetInstance(imageHeader, System.Drawing.Imaging.ImageFormat.Png);
            double totalEarningsComplete = 0;

            MyPageEventHandler e = new MyPageEventHandler()
            {
                ImageHeader = logo
            };

            // Create a Document object
            var document = new Document(PageSize.A4, 50, 50, 180, 25);

            string file = "ReporteIngresos" + _checkedDate.ToString("MM-dd-yy") + ".pdf";
            // Create a new PdfWriter object, specifying the output stream
            var output = new MemoryStream();
            //var writer = PdfWriter.GetInstance(document, output);
            var writer = PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            writer.PageEvent = e;

            // Open the Document for writing
            document.Open();

            var fontLevelTitle = FontFactory.GetFont("Arial", 12, Font.BOLD);
            var subTitleFont = FontFactory.GetFont("Arial", 16);
            var boldTableFont = FontFactory.GetFont("Arial", 13);
            var cellTitle = FontFactory.GetFont("Arial", 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont("Arial", 10);

            //Table
            //Go trough each level
            for (int j = 5; j >= 1; j--)
            {
                bool foundPayment = false;

                //Check if there's at least one payment for X level
                foreach (var payment in _reportData)
                {
                    if (int.Parse(payment[0]) == j)
                        foundPayment = true;
                }

                //If no payment was found, just skip to next one
                if (!foundPayment)
                    continue;

                //Create base table and level table
                var levelTable = new PdfPTable(7);
                levelTable.TotalWidth = 475f;
                levelTable.LockedWidth = true;
                levelTable.SpacingBefore = 45f;
                float[] widths = new float[] { 40f, 40f, 50f, 137f, 47f, 94f, 67f };
                levelTable.SetWidths(widths);

                string levelTitle = "Nivel Escolar: " + getLevelName(j).ToUpper();
                PdfPCell cellLevelName = new PdfPCell(new Phrase(levelTitle, fontLevelTitle));
                cellLevelName.Border = PdfPCell.NO_BORDER;
                cellLevelName.Colspan = 7;
                cellLevelName.PaddingBottom = 10;
                levelTable.AddCell(cellLevelName);

                //Column names
                PdfPCell cellGrade = new PdfPCell(new Phrase("Grado", cellTitle));
                cellGrade.Border = PdfPCell.NO_BORDER;
                PdfPCell cellGroup = new PdfPCell(new Phrase("Grupo", cellTitle));
                cellGroup.Border = PdfPCell.NO_BORDER;
                PdfPCell cellCuenta = new PdfPCell(new Phrase("Cuenta", cellTitle));
                cellCuenta.Border = PdfPCell.NO_BORDER;
                cellCuenta.PaddingLeft = 5f;
                PdfPCell cellStudent = new PdfPCell(new Phrase("Alumno", cellTitle));
                cellStudent.Border = PdfPCell.NO_BORDER;
                PdfPCell cellFolio = new PdfPCell(new Phrase("Folio", cellTitle));
                cellFolio.Border = PdfPCell.NO_BORDER;
                PdfPCell cellConcept = new PdfPCell(new Phrase("Concepto", cellTitle));
                cellConcept.Border = PdfPCell.NO_BORDER;
                PdfPCell cellCharge = new PdfPCell(new Phrase("Importe", cellTitle));
                cellCharge.Border = PdfPCell.NO_BORDER;
                cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                levelTable.AddCell(cellGrade);
                levelTable.AddCell(cellGroup);
                levelTable.AddCell(cellCuenta);
                levelTable.AddCell(cellStudent);
                levelTable.AddCell(cellFolio);
                levelTable.AddCell(cellConcept);
                levelTable.AddCell(cellCharge);

                double totalAmount = 0.0;
             

                //Go trough each payment that fits the level and print it. 
                foreach (var payment in _reportData)
                {
                    ////Nivel, Grado, Grupo, SID, Nombre, Folio, Conceptop, Importe

                    if (int.Parse(payment[0]) == j)
                    {
                        totalAmount += double.Parse(payment[7]);

                        cellGrade = new PdfPCell(new Phrase(payment[1], bodyFont));
                        cellGrade.Border = PdfPCell.BOTTOM_BORDER;

                        cellGroup = new PdfPCell(new Phrase(payment[2], bodyFont));
                        cellGroup.Border = PdfPCell.BOTTOM_BORDER;

                        cellCuenta = new PdfPCell(new Phrase(payment[3], bodyFont));
                        cellCuenta.Border = PdfPCell.BOTTOM_BORDER;
                        cellCuenta.PaddingLeft = 5f;

                        cellStudent = new PdfPCell(new Phrase(payment[4], bodyFont));
                        cellStudent.Border = PdfPCell.BOTTOM_BORDER;

                        cellFolio = new PdfPCell(new Phrase(payment[5], bodyFont));
                        cellFolio.Border = PdfPCell.BOTTOM_BORDER;

                        cellConcept = new PdfPCell(new Phrase(payment[6], bodyFont));
                        cellConcept.Border = PdfPCell.BOTTOM_BORDER;

                        double tempPayment = double.Parse(payment[7]);
                        cellCharge = new PdfPCell(new Phrase(tempPayment.ToString(BAL.MoneyFormat), bodyFont));
                        cellCharge.Border = PdfPCell.BOTTOM_BORDER;
                        cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                        levelTable.AddCell(cellGrade);
                        levelTable.AddCell(cellGroup);
                        levelTable.AddCell(cellCuenta);
                        levelTable.AddCell(cellStudent);
                        levelTable.AddCell(cellFolio);
                        levelTable.AddCell(cellConcept);
                        levelTable.AddCell(cellCharge);
                    }
                }

                string levelFooterText = "Total Ingresado en " + getLevelName(j);
                PdfPCell celllevelTotalText = new PdfPCell(new Phrase(levelFooterText));
                celllevelTotalText.Border = PdfPCell.TOP_BORDER;
                PdfPCell celllevelTotalAmount = new PdfPCell(new Phrase(totalAmount.ToString(BAL.MoneyFormat)));
                celllevelTotalAmount.Border = PdfPCell.TOP_BORDER;

                celllevelTotalText.Colspan = 6;
                celllevelTotalText.HorizontalAlignment = 2;
                celllevelTotalText.PaddingRight = 30f;
                celllevelTotalText.Border = 0;
                celllevelTotalAmount.Border = 0;
                celllevelTotalAmount.Colspan = 1;
                celllevelTotalAmount.HorizontalAlignment = 2;

                levelTable.AddCell(celllevelTotalText);
                levelTable.AddCell(celllevelTotalAmount);

                document.Add(levelTable);

                totalEarningsComplete += totalAmount;

            }

            //Print totals 
            string txtTotalEarings = "Total Ingresado en " + _reportLevel;
            PdfPCell cellTotalEarnings = new PdfPCell(new Phrase(txtTotalEarings));
            cellTotalEarnings.Border = PdfPCell.NO_BORDER;
            PdfPCell cellnumEarnings = new PdfPCell(new Phrase(totalEarningsComplete.ToString(BAL.MoneyFormat)));
            cellnumEarnings.Border = PdfPCell.NO_BORDER;

            var totalsTable = new PdfPTable(2);
            totalsTable.TotalWidth = 475f;
            totalsTable.LockedWidth = true;
            totalsTable.SpacingBefore = 45f;
            float[] totalsWidth = new float[] { 200f, 275f };
            totalsTable.SetWidths(totalsWidth);

            totalsTable.AddCell(cellTotalEarnings);
            totalsTable.AddCell(cellnumEarnings);

            document.Add(totalsTable);

            document.Close();
            System.Diagnostics.Process.Start(file);
        }

        private static void PrintDebtReport()
        {
            System.Drawing.Image imageHeader = (System.Drawing.Image)CCMM.Properties.Resources.logo;
            var logo = iTextSharp.text.Image.GetInstance(imageHeader, System.Drawing.Imaging.ImageFormat.Png);

            MyPageEventHandler e = new MyPageEventHandler()
            {
                ImageHeader = logo
            };

            // Create a Document object
            var document = new Document(PageSize.A4, 50, 50, 180, 25);
            double totalEarningsComplete = 0;

            string file = "ReporteAdeudos" + _checkedDate.ToString("MM-dd-yy") + ".pdf";
            // Create a new PdfWriter object, specifying the output stream
            var output = new MemoryStream();
            //var writer = PdfWriter.GetInstance(document, output);
            var writer = PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            writer.PageEvent = e;

            // Open the Document for writing
            document.Open();

            var fontLevelTitle = FontFactory.GetFont("Arial", 12, Font.BOLD);
            var subTitleFont = FontFactory.GetFont("Arial", 16);
            var boldTableFont = FontFactory.GetFont("Arial", 13);
            var cellTitle = FontFactory.GetFont("Arial", 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont("Arial", 10);

            //sid,  slvl, concept  name, concept amount
            //[ 0 ],[ 1 ], [     2     ], [     3      ]

            //Table
            //Go trough each level
            for (int j = 5; j >= 1; j--)
            {
                bool foundPayment = false;

                //Check if there's at least one payment for X level
                foreach (var payment in _reportData)
                {
                    if (int.Parse(payment[1]) == j)
                        foundPayment = true;
                }

                //If no payment was found, just skip to next one
                if (!foundPayment)
                    continue;

                //Create base table and level table
                var levelTable = new PdfPTable(6);
                levelTable.TotalWidth = 475f;
                levelTable.LockedWidth = true;
                levelTable.SpacingBefore = 45f;
                float[] widths = new float[] { 40f, 40f, 60f, 137f, 110f, 67f };
                levelTable.SetWidths(widths);

                string levelTitle = "Nivel Escolar: " + getLevelName(j).ToUpper();
                PdfPCell cellLevelName = new PdfPCell(new Phrase(levelTitle, fontLevelTitle));
                cellLevelName.Border = PdfPCell.NO_BORDER;
                cellLevelName.Colspan = 6;
                cellLevelName.PaddingBottom = 10;
                levelTable.AddCell(cellLevelName);

                //Column names
                PdfPCell cellGrade = new PdfPCell(new Phrase("Grado", cellTitle));
                cellGrade.Border = PdfPCell.NO_BORDER;
                PdfPCell cellGroup = new PdfPCell(new Phrase("Grupo", cellTitle));
                cellGroup.Border = PdfPCell.NO_BORDER;
                PdfPCell cellCuenta = new PdfPCell(new Phrase("Cuenta", cellTitle));
                cellCuenta.Border = PdfPCell.NO_BORDER;
                cellCuenta.PaddingLeft = 5f;
                PdfPCell cellStudent = new PdfPCell(new Phrase("Alumno", cellTitle));
                cellStudent.Border = PdfPCell.NO_BORDER;
                PdfPCell cellConcept = new PdfPCell(new Phrase("Concepto", cellTitle));
                cellConcept.Border = PdfPCell.NO_BORDER;
                PdfPCell cellCharge = new PdfPCell(new Phrase("A Pagar", cellTitle));
                cellCharge.Border = PdfPCell.NO_BORDER;
                cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                levelTable.AddCell(cellGrade);
                levelTable.AddCell(cellGroup);
                levelTable.AddCell(cellCuenta);
                levelTable.AddCell(cellStudent);
                levelTable.AddCell(cellConcept);
                levelTable.AddCell(cellCharge);

                double totalAmount = 0.0;

                //sid,  slvl, concept  name, concept amount
                //[ 0 ],[ 1 ], [     2     ], [     3      ]

                //Go trough each payment that fits the level and print it. 
                foreach (var payment in _reportData)
                {
                    ////Nivel, Grado, Grupo, SID, Nombre, Folio, Conceptop, Importe

                    if (int.Parse(payment[1]) == j)
                    {
                        totalAmount += double.Parse(payment[3]);
                        //Get student information from ID
                        infoStudent temptStudent = new infoStudent();
                        temptStudent = DAL.getStudentDetails(Int32.Parse(payment[0]));

                        if (temptStudent == null)
                            continue;

                        cellGrade = new PdfPCell(new Phrase(BAL.getGradeLevel(temptStudent.studentLevel, temptStudent.studentGroup).ToString(), bodyFont));
                        cellGrade.Border = PdfPCell.BOTTOM_BORDER;

                        cellGroup = new PdfPCell(new Phrase("A", bodyFont));
                        cellGroup.Border = PdfPCell.BOTTOM_BORDER;

                        cellCuenta = new PdfPCell(new Phrase(temptStudent.studentID.ToString(), bodyFont));
                        cellCuenta.Border = PdfPCell.BOTTOM_BORDER;
                        cellCuenta.PaddingLeft = 5f;

                        cellStudent = new PdfPCell(new Phrase(temptStudent.studentLastName + " " + temptStudent.studentLastName2 + " " +
                        temptStudent.studentFistName, bodyFont));
                        cellStudent.Border = PdfPCell.BOTTOM_BORDER;

                        cellConcept = new PdfPCell(new Phrase(payment[2], bodyFont));
                        cellConcept.Border = PdfPCell.BOTTOM_BORDER;

                        double tempPayment = double.Parse(payment[3]);
                        cellCharge = new PdfPCell(new Phrase(tempPayment.ToString(BAL.MoneyFormat), bodyFont));
                        cellCharge.Border = PdfPCell.BOTTOM_BORDER;
                        cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                        levelTable.AddCell(cellGrade);
                        levelTable.AddCell(cellGroup);
                        levelTable.AddCell(cellCuenta);
                        levelTable.AddCell(cellStudent);
                        levelTable.AddCell(cellConcept);
                        levelTable.AddCell(cellCharge);
                    }
                }

                string levelFooterText = "Total de DEUDAS en " + getLevelName(j);
                PdfPCell celllevelTotalText = new PdfPCell(new Phrase(levelFooterText));
                celllevelTotalText.Border = PdfPCell.TOP_BORDER;
                PdfPCell celllevelTotalAmount = new PdfPCell(new Phrase(totalAmount.ToString(BAL.MoneyFormat)));
                celllevelTotalAmount.Border = PdfPCell.TOP_BORDER;

                celllevelTotalText.Colspan = 5;
                celllevelTotalText.HorizontalAlignment = 2;
                celllevelTotalText.PaddingRight = 30f;
                celllevelTotalText.Border = 0;
                celllevelTotalAmount.Border = 0;
                celllevelTotalAmount.Colspan = 1;
                celllevelTotalAmount.HorizontalAlignment = 2;

                levelTable.AddCell(celllevelTotalText);
                levelTable.AddCell(celllevelTotalAmount);

                document.Add(levelTable);

                totalEarningsComplete += totalAmount;

            }

            //Print totals 
            string txtTotalEarings = "Total en Deudas en " + _reportLevel;
            PdfPCell cellTotalEarnings = new PdfPCell(new Phrase(txtTotalEarings));
            cellTotalEarnings.Border = PdfPCell.NO_BORDER;
            cellTotalEarnings.Colspan = 4;
            PdfPCell cellnumEarnings = new PdfPCell(new Phrase(totalEarningsComplete.ToString(BAL.MoneyFormat)));
            cellnumEarnings.Border = PdfPCell.NO_BORDER;
            cellnumEarnings.HorizontalAlignment = PdfPCell.ALIGN_LEFT;
            cellnumEarnings.Colspan = 2;

            var totalsTable = new PdfPTable(6);
            totalsTable.TotalWidth = 475f;
            totalsTable.LockedWidth = true;
            totalsTable.SpacingBefore = 45f;
            float[] totalsWidth = new float[] { 40f, 40f, 60f, 137f, 110f, 67f };
            totalsTable.SetWidths(totalsWidth);

            totalsTable.AddCell(cellTotalEarnings);
            totalsTable.AddCell(cellnumEarnings);

            document.Add(totalsTable);

            document.Close();
            System.Diagnostics.Process.Start(file);
        }

        private static void PrintPaymentHistory()
        {
            System.Drawing.Image imageHeader = (System.Drawing.Image)CCMM.Properties.Resources.logo;
            var logo = iTextSharp.text.Image.GetInstance(imageHeader, System.Drawing.Imaging.ImageFormat.Png);

            MyPageEventHandler e = new MyPageEventHandler()
            {
                ImageHeader = logo
            };

            // Create a Document object
            var document = new Document(PageSize.A4, 50, 50, 180, 25);

            //ID, Name, Folio, Amount, Date, Complete, Concept(Title)
            string file = "HistorialPagos-" + _reportData[0][0] + ".pdf";
            // Create a new PdfWriter object, specifying the output stream
            var output = new MemoryStream();
            //var writer = PdfWriter.GetInstance(document, output);
            var writer = PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            writer.PageEvent = e;

            // Open the Document for writing
            document.Open();

            var fontLevelTitle = FontFactory.GetFont("Arial", 12, Font.BOLD);
            var subTitleFont = FontFactory.GetFont("Arial", 16);
            var boldTableFont = FontFactory.GetFont("Arial", 13);
            var cellTitle = FontFactory.GetFont("Arial", 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont("Arial", 10);

            //Check if there's at least one payment 

            if (_reportData.Count > 0)
            {

                infoStudent selectedStudent = DAL.getStudentDetails(Int32.Parse(_reportData[0][0]));
                //Create base table and level table
                var levelTable = new PdfPTable(4);
                levelTable.TotalWidth = 475f;
                levelTable.LockedWidth = true;
                levelTable.SpacingBefore = 45f;
                float[] widths = new float[] {  97f, 177f, 94f, 107f };
                levelTable.SetWidths(widths);

                string levelTitle = "Pagos por: " + _reportData[0][1];
                PdfPCell cellLevelName = new PdfPCell(new Phrase(levelTitle, fontLevelTitle));
                cellLevelName.Border = PdfPCell.NO_BORDER;
                cellLevelName.Colspan = 4;
                cellLevelName.PaddingBottom = 3;
                levelTable.AddCell(cellLevelName);

                string studentInfo = "Cuenta #" + _reportData[0][0] + " || Nivel: " + getLevelName(selectedStudent.studentLevel).ToUpper();
                PdfPCell cellStudentAccount = new PdfPCell(new Phrase(studentInfo, fontLevelTitle));
                cellStudentAccount.Border = PdfPCell.NO_BORDER;
                cellStudentAccount.Colspan = 4;
                cellStudentAccount.PaddingBottom = 3;
                levelTable.AddCell(cellStudentAccount);

                string studentInfo2 = "Grado: " + BAL.getGradeLevel(selectedStudent.studentLevel, selectedStudent.studentGroup).ToString() +
                    "  Grupo: A";
                PdfPCell cellStudentAccount2 = new PdfPCell(new Phrase(studentInfo2, fontLevelTitle));
                cellStudentAccount2.Border = PdfPCell.NO_BORDER;
                cellStudentAccount2.Colspan = 4;
                cellStudentAccount2.PaddingBottom = 10;
                levelTable.AddCell(cellStudentAccount2);

                //Column names
                PdfPCell cellFolio = new PdfPCell(new Phrase("Folio", cellTitle));
                cellFolio.Border = PdfPCell.NO_BORDER;
                PdfPCell cellConcept = new PdfPCell(new Phrase("Concepto", cellTitle));
                cellConcept.Border = PdfPCell.NO_BORDER;
                PdfPCell cellPayDate = new PdfPCell(new Phrase("Fecha de Pago", cellTitle));
                cellPayDate.Border = PdfPCell.NO_BORDER;
                PdfPCell cellCharge = new PdfPCell(new Phrase("Importe", cellTitle));
                cellCharge.Border = PdfPCell.NO_BORDER;
                cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                levelTable.AddCell(cellFolio);
                levelTable.AddCell(cellConcept);
                levelTable.AddCell(cellPayDate);
                levelTable.AddCell(cellCharge);

                double totalAmount = 0.0;

                //Go trough each payment that fits the level and print it. 
                foreach (var payment in _reportData)
                {
                    //ID, Name, Folio, Amount, Date, Complete, Concept(Title)

                    totalAmount += double.Parse(payment[3]);

                    cellPayDate = new PdfPCell(new Phrase(DateTime.Parse(payment[5]).ToShortDateString(), bodyFont));
                    cellPayDate.Border = PdfPCell.BOTTOM_BORDER;

                    cellFolio = new PdfPCell(new Phrase(payment[3], bodyFont));
                    cellFolio.Border = PdfPCell.BOTTOM_BORDER;

                    cellConcept = new PdfPCell(new Phrase(payment[7], bodyFont));
                    cellConcept.Border = PdfPCell.BOTTOM_BORDER;

                    double tempPayment = double.Parse(payment[3]);
                    cellCharge = new PdfPCell(new Phrase(tempPayment.ToString(BAL.MoneyFormat), bodyFont));
                    cellCharge.Border = PdfPCell.BOTTOM_BORDER;
                    cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                    levelTable.AddCell(cellFolio);
                    levelTable.AddCell(cellConcept);
                    levelTable.AddCell(cellPayDate);
                    levelTable.AddCell(cellCharge);

                }

                document.Add(levelTable);

                //Print totals 
                string txtTotalEarings = "Total PAGADO por " + _reportData[0][1];
                PdfPCell cellTotalEarnings = new PdfPCell(new Phrase(txtTotalEarings));
                cellTotalEarnings.Border = PdfPCell.NO_BORDER;
                cellTotalEarnings.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                PdfPCell cellnumEarnings = new PdfPCell(new Phrase(totalAmount.ToString(BAL.MoneyFormat)));
                cellnumEarnings.Border = PdfPCell.NO_BORDER;
                cellnumEarnings.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                var totalsTable = new PdfPTable(2);
                totalsTable.TotalWidth = 475f;
                totalsTable.LockedWidth = true;
                totalsTable.SpacingBefore = 45f;
                float[] totalsWidth = new float[] { 325f, 150f };
                totalsTable.SetWidths(totalsWidth);

                totalsTable.AddCell(cellTotalEarnings);
                totalsTable.AddCell(cellnumEarnings);

                document.Add(totalsTable);

                document.Close();
                System.Diagnostics.Process.Start(file);
            }
        }

        private static void PrintDebtHistory()
        {
            System.Drawing.Image imageHeader = (System.Drawing.Image)CCMM.Properties.Resources.logo;
            var logo = iTextSharp.text.Image.GetInstance(imageHeader, System.Drawing.Imaging.ImageFormat.Png);

            MyPageEventHandler e = new MyPageEventHandler()
            {
                ImageHeader = logo
            };

            // Create a Document object
            var document = new Document(PageSize.A4, 50, 50, 180, 25);

            //ID, NAME, CONCEPT, LIMIT DATE, AMOUNT
            string file = "HistorialDeudas-" + _reportData[0][0] + ".pdf";
            // Create a new PdfWriter object, specifying the output stream
            var output = new MemoryStream();
            //var writer = PdfWriter.GetInstance(document, output);
            var writer = PdfWriter.GetInstance(document, new FileStream(file, FileMode.Create));
            writer.PageEvent = e;

            // Open the Document for writing
            document.Open();

            var fontLevelTitle = FontFactory.GetFont("Arial", 12, Font.BOLD);
            var subTitleFont = FontFactory.GetFont("Arial", 16);
            var boldTableFont = FontFactory.GetFont("Arial", 13);
            var cellTitle = FontFactory.GetFont("Arial", 11, Font.BOLD);
            var bodyFont = FontFactory.GetFont("Arial", 10);

            //Check if there's at least one payment 

            if (_reportData.Count > 0)
            {

                //ID, NAME, CONCEPT, LIMIT DATE, AMOUNT
                infoStudent selectedStudent = DAL.getStudentDetails(Int32.Parse(_reportData[0][0]));
                //Create base table and level table
                var levelTable = new PdfPTable(3);
                levelTable.TotalWidth = 475f;
                levelTable.LockedWidth = true;
                levelTable.SpacingBefore = 45f;
                float[] widths = new float[] { 197f, 177f, 101f };
                levelTable.SetWidths(widths);

                string levelTitle = "Deudas por: " + _reportData[0][1];
                PdfPCell cellLevelName = new PdfPCell(new Phrase(levelTitle, fontLevelTitle));
                cellLevelName.Border = PdfPCell.NO_BORDER;
                cellLevelName.Colspan = 3;
                cellLevelName.PaddingBottom = 3;
                levelTable.AddCell(cellLevelName);

                string studentInfo = "Cuenta #" + _reportData[0][0] + " || Nivel: " + getLevelName(selectedStudent.studentLevel).ToUpper();
                PdfPCell cellStudentAccount = new PdfPCell(new Phrase(studentInfo, fontLevelTitle));
                cellStudentAccount.Border = PdfPCell.NO_BORDER;
                cellStudentAccount.Colspan = 3;
                cellStudentAccount.PaddingBottom = 3;
                levelTable.AddCell(cellStudentAccount);

                string studentInfo2 = "Grado: " + BAL.getGradeLevel(selectedStudent.studentLevel, selectedStudent.studentGroup).ToString() +
                    "  Grupo: A";
                PdfPCell cellStudentAccount2 = new PdfPCell(new Phrase(studentInfo2, fontLevelTitle));
                cellStudentAccount2.Border = PdfPCell.NO_BORDER;
                cellStudentAccount2.Colspan = 3;
                cellStudentAccount2.PaddingBottom = 10;
                levelTable.AddCell(cellStudentAccount2);

                //Column names
                PdfPCell cellConcept = new PdfPCell(new Phrase("Concepto", cellTitle));
                cellConcept.Border = PdfPCell.NO_BORDER;
                PdfPCell cellPayDate = new PdfPCell(new Phrase("Fecha Limite", cellTitle));
                cellPayDate.Border = PdfPCell.NO_BORDER;
                PdfPCell cellCharge = new PdfPCell(new Phrase("Importe", cellTitle));
                cellCharge.Border = PdfPCell.NO_BORDER;
                cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                levelTable.AddCell(cellConcept);
                levelTable.AddCell(cellPayDate);
                levelTable.AddCell(cellCharge);

                double totalAmount = 0.0;

                //Go trough each payment that fits the level and print it. 
                foreach (var payment in _reportData)
                {
                    //ID, NAME, CONCEPT, LIMIT DATE, AMOUNT

                    totalAmount += double.Parse(payment[4]);

                    cellPayDate = new PdfPCell(new Phrase(DateTime.Parse(payment[3]).ToShortDateString(), bodyFont));
                    cellPayDate.Border = PdfPCell.BOTTOM_BORDER;

                    cellConcept = new PdfPCell(new Phrase(payment[2], bodyFont));
                    cellConcept.Border = PdfPCell.BOTTOM_BORDER;

                    double tempPayment = double.Parse(payment[4]);
                    cellCharge = new PdfPCell(new Phrase(tempPayment.ToString(BAL.MoneyFormat), bodyFont));
                    cellCharge.Border = PdfPCell.BOTTOM_BORDER;
                    cellCharge.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                    levelTable.AddCell(cellConcept);
                    levelTable.AddCell(cellPayDate);
                    levelTable.AddCell(cellCharge);

                }

                document.Add(levelTable);

                //Print totals 
                string txtTotalEarings = "Total de DEUDAS por " + _reportData[0][1];
                PdfPCell cellTotalEarnings = new PdfPCell(new Phrase(txtTotalEarings));
                cellTotalEarnings.Border = PdfPCell.NO_BORDER;
                cellTotalEarnings.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;
                PdfPCell cellnumEarnings = new PdfPCell(new Phrase(totalAmount.ToString(BAL.MoneyFormat)));
                cellnumEarnings.Border = PdfPCell.NO_BORDER;
                cellnumEarnings.HorizontalAlignment = PdfPCell.ALIGN_RIGHT;

                var totalsTable = new PdfPTable(2);
                totalsTable.TotalWidth = 475f;
                totalsTable.LockedWidth = true;
                totalsTable.SpacingBefore = 45f;
                float[] totalsWidth = new float[] { 325f, 150f };
                totalsTable.SetWidths(totalsWidth);

                totalsTable.AddCell(cellTotalEarnings);
                totalsTable.AddCell(cellnumEarnings);

                document.Add(totalsTable);

                document.Close();
                System.Diagnostics.Process.Start(file);
            }
        }

        public static string getLevelName(int level)
        {
            switch (level)
            {   
                case 1:
                    return "Primaria";

                case 2:
                    return "Secundaria";

                case 3:
                    return "Preparatoria";

                case 4:
                    return "Universidad";

                case 5:
                    return "Medio Internado";
                
                default:
                    return "Error";
            }

            return null;
        }

        public static void PrintReport(List<string[]> reportData, string reportType, DateTime checkedDate, string reportLevel)
        {
            _reportData = reportData;
            _checkedDate = checkedDate;

            if (reportLevel == "School")
                _reportLevel = "COLEGIO";
            else
                _reportLevel = "MEDIO INTERNADO";


            switch (reportType)
            {
                case "Earnings":
                    _reportType = 0;
                    PrintEarningsReport();
                    break;

                case "Debt":
                    _reportType = 1;
                    PrintDebtReport();
                    break;

                case "Personal Payments":
                    _reportType = 2;
                    PrintPaymentHistory();
                    break;

                case "Personal Debt":
                    _reportType = 3;
                    PrintDebtHistory();
                    break;
                    
                default:
                    break;
            }
        }

       
    }
}
