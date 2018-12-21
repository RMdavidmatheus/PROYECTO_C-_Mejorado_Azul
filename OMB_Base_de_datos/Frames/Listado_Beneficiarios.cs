using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMB_Base_de_datos.Frames
{
    public partial class Listado_Beneficiarios : Form
    {
        public Listado_Beneficiarios(string Usuario)
        {
            InitializeComponent();
            ListadoBen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TomarUsu = Usuario;
            txtUsuario.Text = TomarUsu;
        }

        private string TomarUsu;

        Capa_logica.Logica_Metodos Metodos = new Capa_logica.Logica_Metodos();

        private void Listado_Beneficiarios_Load(object sender, EventArgs e)
        {
            Metodos.LlenarTabla_Beneficiarios(ListadoBen);
            this.timer1.Enabled = true;

        }

        private void Buscar_Enter(object sender, EventArgs e)
        {
            if (Buscar.Text == "Buscar...")
            {
                Buscar.Text = "";
                Buscar.ForeColor = Color.Black;
            }
        }

        private void Buscar_Leave(object sender, EventArgs e)
        {
            if (Buscar.Text != "Buscar...")
            {
                Buscar.Text = "Buscar...";
                Buscar.ForeColor = Color.DimGray;
            }
        }

        private void PdfBen_Click(object sender, EventArgs e)
        {
            iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance("C:\\Users\\David PC\\source\\repos\\OMB_Base_de_datos\\OMB_Base_de_datos\\Resources\\LOGO2.png");
            iTextSharp.text.Font palatino = FontFactory.GetFont("MS GOTHIC", 15, iTextSharp.text.Font.BOLD);
            palatino.SetColor(246, 246, 246);
            //CREANDO EL ARCHIVO CON ITEXTSHARP
            PdfPTable pdfTable = new PdfPTable(ListadoBen.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.DefaultCell.BackgroundColor = new iTextSharp.text.BaseColor(224, 224, 224);
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //AÑADIENDO EL HEADER DE LA COLUMNA
            foreach (DataGridViewColumn column in ListadoBen.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, palatino));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(31, 48, 76);
                pdfTable.AddCell(cell);
            }

            //AÑADIENDO LOS REGISTROS
            foreach (DataGridViewRow row in ListadoBen.Rows)
            {
                try
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());

                        }

                    }
                }
                catch (Exception)
                {


                }

            }

            //EXPORTANDO A PDF
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Listado Beneficiarios";
            save.Filter = "PDF (*.pdf)|*.pdf";
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(save.FileName, FileMode.Create);

                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(Logo);
                pdfDoc.AddTitle("LISTADO BENEFICIARIOS");
                pdfDoc.Add(new Paragraph("LISTADO BENEFICIARIOS", FontFactory.GetFont("MS GOTHIC", 30, iTextSharp.text.Font.BOLD)));
                pdfDoc.Add(new Paragraph("                          "));
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph("FECHA REPORTE: ", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.UNDERLINE)));
                pdfDoc.Add(new Paragraph("" + System.DateTime.Now + "", FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.NORMAL)));
                pdfDoc.Close();
                stream.Close();
            }
        }
        private void Buscar_KeyUp(object sender, KeyEventArgs e)
        {
            Metodos.Buscar_Ben(ListadoBen, Buscar.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.hora.Text = DateTime.Now.ToLongTimeString();
            this.Fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
