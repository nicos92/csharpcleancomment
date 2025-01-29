using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI_Clean_Comment
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        //@@@ 

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            btnAbrirArchivoSalida.Checked = Properties.Settings.Default.abrirArchivoSalida;
            btnSonidoEntradaArchivo.Checked = Properties.Settings.Default.sonidoEntradaArchivo;
            btnSonidoSalidaArchivo.Checked = Properties.Settings.Default.sonidoSalidaArchivo;
            btnNotificacion.Checked = Properties.Settings.Default.notificacaion;
        }

        private void BtnSonidoEntradaArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSonidoEntradaArchivo.Checked)
            {
                Properties.Settings.Default.sonidoEntradaArchivo = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.sonidoEntradaArchivo = false;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnSonidoSalidaArchivo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSonidoSalidaArchivo.Checked)
            {
                Properties.Settings.Default.sonidoSalidaArchivo = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.sonidoSalidaArchivo = false;
                Properties.Settings.Default.Save();
            }
        }

        private void BtnAbrirArchivoSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAbrirArchivoSalida.Checked)
            {
                Properties.Settings.Default.abrirArchivoSalida = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.abrirArchivoSalida = false;
                Properties.Settings.Default.Save();
            }
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnNotificacion_CheckedChanged(object sender, EventArgs e)
        {
            if (btnNotificacion.Checked)
            {
                Properties.Settings.Default.notificacaion = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.notificacaion = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
