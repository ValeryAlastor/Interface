using Interface.DAL;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Interface
{
    public partial class Film : Form
    {
        private List<Films> _list;

        public Film()
        {
            InitializeComponent();

            
            _list = new List<Films>();
            bsUser.DataSource = _list;
           

            List<Films> list = SQLiteHelper.GetFilms();//получаем список из гетфилмс
            if (list != null && list.Count > 0)
            {
                _list.AddRange(list);//Добавляет элементы указанной коллекции в конец списка
                bsUser.ResetBindings(false);//повторное считывание всех элементов списка и обновление их отображаемых значений. false
            }

            dataGridView1.AutoGenerateColumns = true;
            
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
            Form f = new Start();
            f.Visible = true;
        }

        private void btnFound_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.CurrentCell = null;
                            dataGridView1.Rows[i].Visible = false;
                           // dataGridView1.Rows[i].Selected = true;
                            
                            break;
                        }
              
            }
            
            


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
              for (int i = 0; i < dataGridView1.RowCount; i++)
              {
                  dataGridView1.Rows[i].Selected = false;
                  dataGridView1.Rows[i].Visible = true;
              }
       
        }

        private void savePDF_Click(object sender, EventArgs e)
        {
            
                        BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\Arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                        Font font = new Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);


                        //Creating iTextSharp Table from the DataTable data
                        PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);

                        //Adding Header row
                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                            pdfTable.AddCell(cell);
                        }

                        //Adding DataRow
                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                pdfTable.AddCell(new Phrase(cell.Value.ToString(), font));
                            }
                        }

                        //Exporting to PDF
                        string folderPath = "D:\\PDFs\\";
                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                        using (FileStream stream = new FileStream(folderPath + "Films.pdf", FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                       MessageBox.Show("Pdf-документ сохранен");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            _list = new List<Films>();
            bsUser.DataSource = _list;

            List<Films> list = SQLiteHelper.GetFilms();

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("title like '{0}%'", textBox2.Text);
        //    dataGridView1.DataSource = dataTable;
        }
    }
}