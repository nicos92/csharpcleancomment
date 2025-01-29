using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using clean_comment;
using Microsoft.ProgramSynthesis.Detection.Encoding;
using clean_comment.modelo;

namespace GUI_Clean_Comment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static string archivoCreado = "";

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableLayoutPanel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void TableLayoutPanel1_DragDrop(object sender, DragEventArgs e)
        {

            txtEncoding.Text = "";
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string fileInfo = new FileInfo(archivos[0]).Name;
            if (fileInfo.ToLower().EndsWith(".txt") == true)
            {
                if (Properties.Settings.Default.sonidoEntradaArchivo == true) PlayIda();

                nameFile.Text = fileInfo;
                LeerArchivo(archivos[0], fileInfo);
            }
            else
            {
                MessageBox.Show("No es un archivo de extension .txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LeerArchivo(string path, string fileInfo)
        {
            //string archivoCreado = "";
            try
            {
                Encoding miencoding = GetEncodingNonoAndy(path);
                txtEncoding.Text = miencoding.EncodingName;
                string fecha = DateTime.Now.ToString("yyyy-MM-dd HHmmss") ;
                string clean = " Clean " + fecha + ".txt";

                archivoCreado = path.ToLower().Replace(".txt", clean);
                

                // Crear una instancia de StreamReader

                FileStream mifile = File.Create(archivoCreado);
                string delimitator = comboDelimitador.Text;

                Task tarea = new Task(() => EscrituraYlecutura(mifile, miencoding, path,  delimitator, fileInfo, fecha));
                tarea.Start();
                //CargarLista();
                //DisenioTabla();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error LeerArchivo(): " + e.Message);
            }
            finally
            {
                txtArchivoSalida.Text = new FileInfo(archivoCreado).Name;
            }
        }

        private void EscrituraYlecutura(FileStream mifile, Encoding miencoding, string path,   string delimitator, string fileInfo, string fecha)
        {
            try
            {

                using (StreamWriter writer = new StreamWriter(mifile, miencoding))
                {
                    using (StreamReader sr = new StreamReader(path, miencoding))
                    {
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            // Procesar cada línea del archivo
                            string[] parts = line.Split(new string[] { delimitator }, StringSplitOptions.None);
                            if(parts[0].Length != 0)
                            {
                                writer.WriteLine(parts[0]);
                            }
                        }
                        sr.Close();
                        sr.Dispose();
                    }
                    writer.Close();
                    writer.Dispose();
                    
                }
            }
            finally
            {

                // genera el sonido de salida
                if (Properties.Settings.Default.sonidoSalidaArchivo) PlayVuelta();


                // guarda en la base de datos
                MiArchivo miArchivo = new MiArchivo
                {
                    Archivo = fileInfo,
                    Ruta = mifile.Name,
                    Fecha = fecha
                };
                ArchivosPasados archivosPasados = new ArchivosPasados();
                archivosPasados.GuardarArchivo(miArchivo);


                // abre directamente el archivo
                if (Properties.Settings.Default.abrirArchivoSalida)
                {
                    AbrirArchivoCreado(mifile.Name);
                }


                // activa la notificacion
                if (Properties.Settings.Default.notificacaion)
                {

                    notifyIcon1.BalloonTipTitle = "Archivo Listo";
                    notifyIcon1.BalloonTipText = "Click para Abrir Ubicacion";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(5000);
                
                }

                
            }

        }

        public static Encoding GetEncodingNonoAndy(string filename)
        {
            using (var file = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                var detectedEncoding = EncodingIdentifier.IdentifyEncoding(file);
                switch (detectedEncoding)
                {
                    case EncodingType.Utf8:
                        return Encoding.UTF8;
                    case EncodingType.Utf16Be:
                        return Encoding.BigEndianUnicode;
                    case EncodingType.Utf16Le:
                        return Encoding.Unicode;
                    case EncodingType.Utf32Le:
                        return Encoding.UTF32;
                    case EncodingType.Ascii:
                        return Encoding.ASCII;
                    case EncodingType.Iso88591:

                    case EncodingType.Unknown:
                    case EncodingType.Windows1252:
                    default:
                        return Encoding.Default;
                }
            }
        }

        private void AbrirArchivoCreado(string path)
        {
            string command = "/C explorer.exe /select, \"" + path + "\"";
            Process.Start("cmd.exe", command);

        }

        private static void PlayVuelta()
        {

            SoundPlayer sonido = new SoundPlayer(Properties.Resources.vuelta);

            sonido.Play();
        }

        private static void PlayIda()
        {

            SoundPlayer sonido = new SoundPlayer(Properties.Resources.ida);
            sonido.Play();
        }

        private void TxtArchivoSalida_Click(object sender, EventArgs e)
        {
           
        }

        private void TxtArchivoSalida_DoubleClick(object sender, EventArgs e)
        {
            if (File.Exists(archivoCreado))
                AbrirArchivoCreado(archivoCreado);
            else MessageBox.Show("No existe el archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }


   

        private void NotifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            AbrirArchivoCreado(archivoCreado);
        }

        private void TxtArchivoSalida_MouseEnter_1(object sender, EventArgs e)
        {
            if (File.Exists(archivoCreado))
                txtArchivoSalida.BorderStyle = BorderStyle.Fixed3D;
        }

        private void TxtArchivoSalida_MouseLeave_1(object sender, EventArgs e)
        {
            txtArchivoSalida.BorderStyle = BorderStyle.None;
        }
    }
}
