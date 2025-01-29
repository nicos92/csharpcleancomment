namespace GUI_Clean_Comment
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSonidoEntradaArchivo = new clean_comment.RJControls.RJToggleBtn();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSonidoSalidaArchivo = new clean_comment.RJControls.RJToggleBtn();
            this.btnAbrirArchivoSalida = new clean_comment.RJControls.RJToggleBtn();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNotificacion = new clean_comment.RJControls.RJToggleBtn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway ExtraBold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(302, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Configuracion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GUI_Clean_Comment.Properties.Resources.icons8_close_48;
            this.pictureBox1.Location = new System.Drawing.Point(765, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSonidoEntradaArchivo, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSonidoSalidaArchivo, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAbrirArchivoSalida, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnNotificacion, 1, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 399);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(18, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sonido de entrada\r\n de archivo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSonidoEntradaArchivo
            // 
            this.btnSonidoEntradaArchivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSonidoEntradaArchivo.AutoSize = true;
            this.btnSonidoEntradaArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonidoEntradaArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSonidoEntradaArchivo.Location = new System.Drawing.Point(207, 11);
            this.btnSonidoEntradaArchivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnSonidoEntradaArchivo.Name = "btnSonidoEntradaArchivo";
            this.btnSonidoEntradaArchivo.OffBckColor = System.Drawing.Color.DarkGray;
            this.btnSonidoEntradaArchivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnSonidoEntradaArchivo.OnBckColor = System.Drawing.Color.Teal;
            this.btnSonidoEntradaArchivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnSonidoEntradaArchivo.Size = new System.Drawing.Size(86, 22);
            this.btnSonidoEntradaArchivo.TabIndex = 8;
            this.btnSonidoEntradaArchivo.Text = "rjToggleBtn1";
            this.btnSonidoEntradaArchivo.UseVisualStyleBackColor = true;
            this.btnSonidoEntradaArchivo.CheckedChanged += new System.EventHandler(this.BtnSonidoEntradaArchivo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(24, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sonido de salida\r\n de archivo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSonidoSalidaArchivo
            // 
            this.btnSonidoSalidaArchivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSonidoSalidaArchivo.AutoSize = true;
            this.btnSonidoSalidaArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSonidoSalidaArchivo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSonidoSalidaArchivo.Location = new System.Drawing.Point(207, 55);
            this.btnSonidoSalidaArchivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnSonidoSalidaArchivo.Name = "btnSonidoSalidaArchivo";
            this.btnSonidoSalidaArchivo.OffBckColor = System.Drawing.Color.DarkGray;
            this.btnSonidoSalidaArchivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnSonidoSalidaArchivo.OnBckColor = System.Drawing.Color.Teal;
            this.btnSonidoSalidaArchivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnSonidoSalidaArchivo.Size = new System.Drawing.Size(86, 22);
            this.btnSonidoSalidaArchivo.TabIndex = 10;
            this.btnSonidoSalidaArchivo.Text = "rjToggleBtn2";
            this.btnSonidoSalidaArchivo.UseVisualStyleBackColor = true;
            this.btnSonidoSalidaArchivo.CheckedChanged += new System.EventHandler(this.BtnSonidoSalidaArchivo_CheckedChanged);
            // 
            // btnAbrirArchivoSalida
            // 
            this.btnAbrirArchivoSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbrirArchivoSalida.AutoSize = true;
            this.btnAbrirArchivoSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirArchivoSalida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAbrirArchivoSalida.Location = new System.Drawing.Point(626, 11);
            this.btnAbrirArchivoSalida.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnAbrirArchivoSalida.Name = "btnAbrirArchivoSalida";
            this.btnAbrirArchivoSalida.OffBckColor = System.Drawing.Color.DarkGray;
            this.btnAbrirArchivoSalida.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnAbrirArchivoSalida.OnBckColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(52)))), ((int)(((byte)(33)))));
            this.btnAbrirArchivoSalida.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirArchivoSalida.Size = new System.Drawing.Size(86, 22);
            this.btnAbrirArchivoSalida.TabIndex = 12;
            this.btnAbrirArchivoSalida.Text = "rjToggleBtn3";
            this.btnAbrirArchivoSalida.UseVisualStyleBackColor = true;
            this.btnAbrirArchivoSalida.CheckedChanged += new System.EventHandler(this.BtnAbrirArchivoSalida_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(421, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Abrir archivo de salida:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Raleway", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(40, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Notificacion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnNotificacion
            // 
            this.btnNotificacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNotificacion.AutoSize = true;
            this.btnNotificacion.Location = new System.Drawing.Point(207, 143);
            this.btnNotificacion.MinimumSize = new System.Drawing.Size(45, 22);
            this.btnNotificacion.Name = "btnNotificacion";
            this.btnNotificacion.OffBckColor = System.Drawing.Color.DarkGray;
            this.btnNotificacion.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.btnNotificacion.OnBckColor = System.Drawing.Color.MediumSlateBlue;
            this.btnNotificacion.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.btnNotificacion.Size = new System.Drawing.Size(86, 22);
            this.btnNotificacion.TabIndex = 14;
            this.btnNotificacion.Text = "rjToggleBtn1";
            this.btnNotificacion.UseVisualStyleBackColor = true;
            this.btnNotificacion.CheckedChanged += new System.EventHandler(this.BtnNotificacion_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private clean_comment.RJControls.RJToggleBtn btnSonidoEntradaArchivo;
        private System.Windows.Forms.Label label3;
        private clean_comment.RJControls.RJToggleBtn btnSonidoSalidaArchivo;
        private System.Windows.Forms.Label label4;
        private clean_comment.RJControls.RJToggleBtn btnAbrirArchivoSalida;
        private System.Windows.Forms.Label label5;
        private clean_comment.RJControls.RJToggleBtn btnNotificacion;
    }
}