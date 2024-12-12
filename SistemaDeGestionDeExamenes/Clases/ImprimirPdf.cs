using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Layout.Borders;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;


namespace SistemaDeGestionDeExamenes.Clases
{
    public class ImprimirPdf
    {
        public void GenerarPdf(Examen examen)
        {
            string outputPath = "examen_" + examen.Asignatura + "_" + examen.Id + ".pdf";
            string projectDirectory = AppContext.BaseDirectory.Substring(0, AppContext.BaseDirectory.IndexOf("bin"));
            string logoPath = Path.Combine(projectDirectory, "Assets", "logo.jpg");

            try
            {
                PdfWriter writer = new PdfWriter(outputPath);
                PdfDocument pdfDocument = new PdfDocument(writer);

                Document document = new Document(pdfDocument);

                Table headerTable = new Table(new float[] { 1, 4 })
                    .SetWidth(UnitValue.CreatePercentValue(100))
                    .SetMarginBottom(20);

                headerTable.AddCell(new Cell(1, 4) // 1 fila, 2 columnas
                    .Add(new Paragraph("Examen").SetFontSize(16).SetBold())
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                    .SetPadding(5));

                iText.Layout.Element.Image logo = new iText.Layout.Element.Image(ImageDataFactory.Create(logoPath))
                .SetWidth(80)
                .SetHeight(80);

                logo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                Div logoContainer = new Div()
                    .Add(logo)
                    .SetMarginLeft(5);
                //.SetMaxWidth(30);

                headerTable.AddCell(new Cell(3, 1)
                .Add(logoContainer)
                .SetVerticalAlignment(iText.Layout.Properties.VerticalAlignment.MIDDLE)
                .SetPadding(0)
                .SetMargin(0));


                headerTable.AddCell(new Cell(1, 3)
                    .Add(new Paragraph("Materia: " + examen.Asignatura))
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetPadding(10));


                headerTable.AddCell(new Cell(1, 3)
                    .Add(new Paragraph("ID de Examen: " + examen.Id))
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetPadding(10));


                headerTable.AddCell(new Cell(1, 3)
                    .Add(new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}"))
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetPadding(10));


                headerTable.AddCell(new Cell(1, 3)
                    .Add(new Paragraph("Nombre y Apellido:"))
                    .SetBackgroundColor(ColorConstants.WHITE)
                    .SetPadding(10));


                document.Add(headerTable);
                document.Add(new Paragraph("\n"));

                // Generar preguntas
                int numeroPregunta = 1;

                List<Pregunta> listaPreguntas = ListaExamenes.ObtenerPreguntasDeExamen(examen);

                foreach (Pregunta pregunta in listaPreguntas)
                {
                    // Agrega la pregunta
                    document.Add(new Paragraph($"{numeroPregunta}. {pregunta.TxtPregunta}")
                        .SetFontSize(12)
                        .SetBold()
                        .SetMarginBottom(5));

                    for (int j = 0; j < pregunta.Opciones.Length; j++)
                    {
                        document.Add(new Paragraph($"    {j + 1}) {pregunta.Opciones[j]}")
                            .SetFontSize(10)
                            .SetMarginBottom(2));
                    }

                    document.Add(new Paragraph("\n").SetMarginTop(10));

                    numeroPregunta++;
                }

                Process.Start(new ProcessStartInfo
                {
                    FileName = outputPath,
                    UseShellExecute = true // Usar el visor predeterminado del sistema
                });

                // Cerrar el documento
                document.Close();
            }

            catch (Exception ex)
            {
                MetodosGenericos.MostrarError($"Error en la impresion del PDF: {ex.Message}");
            }

        }

    }
}
