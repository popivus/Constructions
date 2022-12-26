using ConstructionsObjects.Models;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Document = iTextSharp.text.Document;
using System.IO;
using iTextSharp.text.pdf;

namespace ConstructionObjects
{
    public partial class FormExport : Form
    {
        Models.Object current;
        List<Type_object> typesObject;
        List<Sector> sectors;
        List<Employee> employees;
        List<Materials_Objects> compositionsMaterial;
        List<Technics_Objects> compositionsTech;
        List<Materials> materials;
        List<Technics> technics;

        public FormExport()
        {
            InitializeComponent();
        }

        private void wordExportButton_Click(object sender, EventArgs e)
        {
            object oMissing = Missing.Value;
            object oEndOfDoc = "\\endofdoc";

            Word._Application oWord;
            Word._Document oDoc;
            oWord = new Word.Application();
            oWord.Visible = true;
            oDoc = oWord.Documents.Add(ref oMissing, ref oMissing, ref oMissing, ref oMissing);

            Word.Paragraph oPara1;
            oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara1.Range.Text = $"Объект №{current.ID_Object}";
            oPara1.Range.Font.Bold = 1;
            oPara1.Range.Font.Size = 16;
            oPara1.Format.SpaceAfter = 24;
            oPara1.Range.InsertParagraphAfter();

            object oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oPara1.Range.Font.Size = 9;

            
            Word.Table oTable;
            Word.Range wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            wrdRng = oDoc.Bookmarks.get_Item(ref oEndOfDoc).Range;
            oTable = oDoc.Tables.Add(wrdRng, 9, 2, ref oMissing, ref oMissing);
            oTable.Range.ParagraphFormat.SpaceAfter = 6;

            oTable.Cell(1, 1).Range.Text = "Тип объекта";
            oTable.Cell(1, 2).Range.Text = typesObject.Where(t => t.ID_Type_object == current.ID_Type_object).FirstOrDefault().Name;
            oTable.Cell(2, 1).Range.Text = "Площадь";
            oTable.Cell(2, 2).Range.Text = current.Area.ToString();
            oTable.Cell(3, 1).Range.Text = "Этажность";
            oTable.Cell(3, 2).Range.Text = current.Flats.ToString();
            oTable.Cell(4, 1).Range.Text = "Начало строительства";
            oTable.Cell(4, 2).Range.Text = current.Start_date.ToString("dd.MM.yyyy");
            oTable.Cell(5, 1).Range.Text = "Окончание строительства";
            oTable.Cell(5, 2).Range.Text = current.End_date.ToString("dd.MM.yyyy");
            oTable.Cell(6, 1).Range.Text = "Разрешение на строительство";
            oTable.Cell(6, 2).Range.Text = current.Building_permit;
            oTable.Cell(7, 1).Range.Text = "Участок";
            oTable.Cell(7, 2).Range.Text = sectors.Where(s => s.ID_Sector == current.ID_Sector).FirstOrDefault().Address;
            oTable.Cell(8, 1).Range.Text = "Номер владения";
            oTable.Cell(8, 2).Range.Text = current.Number_building.ToString();
            oTable.Cell(9, 1).Range.Text = "Ответственное лицо";
            var face = employees.Where(e => e.ID_Employee == current.ID_Employee).FirstOrDefault();
            oTable.Cell(9, 2).Range.Text = $"{face.Surname} {face.Name} {face.Middlename}";

            oTable.Columns[1].Width = oWord.InchesToPoints(2);
            oTable.Columns[2].Width = oWord.InchesToPoints(3);
            Close();
        }

        private void pdfExportButton_Click(object sender, EventArgs e)
        {
            var document = new Document(PageSize.A4, 20, 20, 30, 20);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALNBI.TTF");
            var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            var font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
            var fontTitle = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE + 4, iTextSharp.text.Font.NORMAL);

            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            using (var writer = PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create)))
            {
                document.Open();
                document.NewPage();
                document.Add(new Paragraph($"Объект №{current.ID_Object}", fontTitle));
                document.Add(new Paragraph($"Тип объекта: {typesObject.Where(t => t.ID_Type_object == current.ID_Type_object).FirstOrDefault().Name}", font));
                document.Add(new Paragraph($"Площадь: {current.Area}", font));
                document.Add(new Paragraph($"Этажность: {current.Flats}", font));
                document.Add(new Paragraph($"Начало строительства: {current.Start_date.ToString("dd.MM.yyyy")}", font));
                document.Add(new Paragraph($"Окончание строительства: {current.End_date.ToString("dd.MM.yyyy")}", font));
                document.Add(new Paragraph($"Разрешение на строительство: {current.Building_permit}", font));
                document.Add(new Paragraph($"Участок: {sectors.Where(s => s.ID_Sector == current.ID_Sector).FirstOrDefault().Address}", font));
                document.Add(new Paragraph($"Номер владения: {current.Number_building}", font));
                var face = employees.Where(e => e.ID_Employee == current.ID_Employee).FirstOrDefault();
                document.Add(new Paragraph($"Ответственное лицо: {face.Surname} {face.Name} {face.Middlename}", font));
                document.Close();
                writer.Close();
            }
            Close();
        }

        private void FormExport_Load(object sender, EventArgs e)
        {
            FormObjects form = Owner as FormObjects;
            int objectId = Convert.ToInt32(form.objectsGrid.SelectedRows[0].Cells[0].Value.ToString());
            current = APIHelper.GET<Models.Object>($"Objects/{objectId}");
            typesObject = APIHelper.GET<List<Type_object>>("Type_object");
            sectors = APIHelper.GET<List<Sector>>("Sectors");
            employees = APIHelper.GET<List<Employee>>("Employees");
            technics = APIHelper.GET<List<Technics>>("Technics");
            materials = APIHelper.GET<List<Materials>>("Materials");
            compositionsTech = APIHelper.GET<List<Technics_Objects>>("Technics_Objects");
            compositionsMaterial = APIHelper.GET<List<Materials_Objects>>("Materials_Objects");
            saveFileDialog1.Filter = "PDF (*.pdf)|*.pdf";
        }
    }
}
