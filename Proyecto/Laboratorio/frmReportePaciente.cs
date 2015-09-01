using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace Laboratorio
{
    public partial class frmReportePaciente : Form
    {
        string sCadena;
        public frmReportePaciente()
        {
            InitializeComponent();
            funActualizar();
        }

        //cortador para obtener el codigo de los combo box
        string funCortador(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }
        

        void funActualizar()
        {
            string sCodigo;
            string sNombre;
            string sApellido;
            cmbPersona.Items.Clear();

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format(
                "SELECT MaPERSONA.ncodpersona, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona FROM MaPERSONA, TrPACIENTE WHERE MaPERSONA.ncodpersona=TrPACIENTE.ncodpersona "), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                while (mReader.Read())
                {
                    sCodigo = mReader.GetString(0);
                    sNombre = mReader.GetString(1);
                    sApellido = mReader.GetString(2);
                    cmbPersona.Items.Add(sCodigo + ". " + sNombre + " " + sApellido);  
                    sCodigo = "";
                    sNombre = "";
                    sApellido = "";
                }
            }
            catch
            {
                MessageBox.Show("Se produjo un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string sNombre = cmbPersona.Text;
            string sCodigo = funCortador(sNombre);
            Document doc = new Document(PageSize.LETTER);
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("Reporte,  " + sNombre + ".pdf", FileMode.Create));
            doc.AddTitle("Reporte, " + sNombre);
            doc.AddCreator("Diego Taracena");
            doc.Open();

            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(@"C:\laboratoriologo.png");
            imagenEncabezado.Alignment = Element.ALIGN_LEFT;
            imagenEncabezado.ScaleToFit(50f, 50f);

            doc.Add(imagenEncabezado);

            Paragraph parrafoTitulo = new Paragraph("REPORTE DE PERSONA: \n" + sNombre, fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo);

            Paragraph parrafoTitulo3 = new Paragraph("\n", fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            doc.Add(parrafoTitulo3);

            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            // Creamos una tabla para el detalle
            PdfPTable tblPrueba = new PdfPTable(5);
            tblPrueba.WidthPercentage = 100;

            // Configuramos el título de las columnas de la tabla
            PdfPCell clCodigo = new PdfPCell(new Phrase("Codigo", _standardFont));
            clCodigo.BorderWidth = 0;
            clCodigo.BorderWidthBottom = 0.75f;

            PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clNombre.BorderWidth = 0;
            clNombre.BorderWidthBottom = 0.75f;

            PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
            clApellido.BorderWidth = 0;
            clApellido.BorderWidthBottom = 0.75f;

            PdfPCell clExamen = new PdfPCell(new Phrase("Examen", _standardFont));
            clExamen.BorderWidth = 0;
            clExamen.BorderWidthBottom = 0.75f;

            PdfPCell clFecha = new PdfPCell(new Phrase("Fecha", _standardFont));
            clFecha.BorderWidth = 0;
            clFecha.BorderWidthBottom = 0.75f;

            // Añadimos las columnas a la tabla
            tblPrueba.AddCell(clCodigo);
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clApellido);
            tblPrueba.AddCell(clExamen);
            tblPrueba.AddCell(clFecha);

            try
            {
                MySqlCommand mComando = new MySqlCommand(String.Format("SELECT MaPERSONA.ncodpersona, MaPERSONA.cnombrepersona, MaPERSONA.capellidopersona, MaTIPOEXAMEN.cdesctipoexamen, TrCITA.dfechacita FROM MaPERSONA, TrSERVICIO , TrCITA, MaTIPOEXAMEN, TrPACIENTE WHERE MaPERSONA.ncodpersona = TrPACIENTE.ncodpersona AND TrPACIENTE.ncodpaciente= TrCITA.ncodpaciente AND TrCITA.ncodigocita = TrSERVICIO.ncodigocita AND MaTIPOEXAMEN.ncodtipo = TrSERVICIO.ncodtipo AND MaPERSONA.ncodpersona = '{0}'", sCodigo), clasConexion.funConexion());
                MySqlDataReader mReader = mComando.ExecuteReader();

                string sCodPersona;
                string sNombrePersona;
                string sApellido;
                string sDesc;
                string sFecha;

                while (mReader.Read())
                {

                    sCodPersona = mReader.GetString(0);
                    sNombrePersona = mReader.GetString(1);
                    sApellido = mReader.GetString(2);
                    sDesc = mReader.GetString(3);
                    sFecha = mReader.GetString(4);

                    // Llenamos la tabla con información
                    clCodigo = new PdfPCell(new Phrase(sCodPersona, _standardFont));
                    clCodigo.BorderWidth = 0;

                    clNombre = new PdfPCell(new Phrase(sNombrePersona, _standardFont));
                    clNombre.BorderWidth = 0;

                    clApellido = new PdfPCell(new Phrase(sApellido, _standardFont));
                    clApellido.BorderWidth = 0;

                    clExamen = new PdfPCell(new Phrase(sDesc, _standardFont));
                    clExamen.BorderWidth = 0;

                    clFecha = new PdfPCell(new Phrase(sFecha, _standardFont));
                    clFecha.BorderWidth = 0;

                    // Añadimos las celdas a la tabla
                    tblPrueba.AddCell(clCodigo);
                    tblPrueba.AddCell(clNombre);
                    tblPrueba.AddCell(clApellido);
                    tblPrueba.AddCell(clExamen);
                    tblPrueba.AddCell(clFecha);
                }

                // Finalmente, añadimos la tabla al documento PDF y cerramos el documento

                doc.Add(tblPrueba);

                doc.Close();
                writer.Close();
                MessageBox.Show("Reporte Generado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
            
           
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarPaciente ver = new frmBuscarPaciente("frmReportePaciente", cmbPersona.Text);
            ver.MdiParent = this.MdiParent;
            ver.Show();
            this.Close();
        }
    }
}
