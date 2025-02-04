﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace GUI_Clean_Comment
{
    public partial class FormPrincipal : Form
    {
       /* public FormPrincipal()
        {
            InitializeComponent();
        }*/



        //Constructor
        public FormPrincipal()
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%) @
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        #region Funcionalidades del formulario
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private readonly int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL @
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.PanelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // capturar posicion y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;


        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X; ly = this.Location.Y;
            sw = this.Size.Width; sh = this.Size.Height;

            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
            this.Size = new Size( sw, sh );
            this.Location = new Point( lx, ly );

        }

        private void PanelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void Button1_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form1>();
            button1.BackColor = Color.FromArgb(8, 52, 33);



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<Form2>();

            button2.BackColor = Color.FromArgb(8, 52, 33);



        }

       

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Button3_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<Form3>();

            button3.BackColor = Color.FromArgb(8, 52, 33);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            /*
            SonidoArchivoEntrada = Properties.Settings.Default.sonidoEntradaArchivo;
            SonidoArchivoSalida = Properties.Settings.Default.sonidoSalidaArchivo;
            AbrirArchivoSalida = Properties.Settings.Default.abrirArchivoSalida;*/
            AbrirFormulario<Form1>();
            button1.BackColor = Color.FromArgb(8, 52, 33);
        }



        #endregion

        //METODO PARA ABRIR UN FORMULARIO DENTRO DEL PANEL @
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelFormularios.Controls.OfType<MiForm>().FirstOrDefault(); // BUSCA EN LA COLECCION EL FORMULARIO
            // SI EL FORMULARIO/INSTANCIA NO EXUSTE

            if (formulario == null)
            {

                formulario = new MiForm
                {
                    TopLevel = false,

                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                PanelFormularios.Controls.Add(formulario);
                PanelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }// SI EL FORMULARIO/INSTANCIA EXISTE @
            else
            {
                formulario.BringToFront();
            }

        }

        private void CloseForms(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms["Form1"] == null)
            {
                button1.BackColor = Color.FromArgb(30, 40, 35);
            }
            if (Application.OpenForms["Form2"] == null)
            {
                button2.BackColor = Color.FromArgb(30, 40, 35);
            }
            if (Application.OpenForms["Form3"] == null)
            {
                button3.BackColor = Color.FromArgb(30, 40, 35);
            }
        }
    }
}
