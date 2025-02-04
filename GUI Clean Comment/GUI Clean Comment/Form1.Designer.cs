namespace GUI_Clean_Comment
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArchivoSalida = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEncoding = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nameFile = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDelimitador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.BtnAbrirArchivo = new Controles.NSButton();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hack Nerd Font Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(304, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Clean Comments";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtArchivoSalida, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtEncoding, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.nameFile, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.comboDelimitador, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BtnAbrirArchivo, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.53846F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.741259F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.048951F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TableLayoutPanel1_DragDrop);
            this.tableLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TableLayoutPanel1_DragEnter);
            this.tableLayoutPanel1.DragLeave += new System.EventHandler(this.TableLayoutPanel1_DragLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::GUI_Clean_Comment.Properties.Resources.icons8_close_48;
            this.pictureBox1.Location = new System.Drawing.Point(765, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hack Nerd Font", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(75, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Elije un delimitador de comentarios y elimina los comentarios de archivos de text" +
    "o \".txt\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArchivoSalida
            // 
            this.txtArchivoSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtArchivoSalida.AutoSize = true;
            this.txtArchivoSalida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtArchivoSalida.Font = new System.Drawing.Font("Hack Nerd Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoSalida.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtArchivoSalida.Location = new System.Drawing.Point(392, 414);
            this.txtArchivoSalida.Name = "txtArchivoSalida";
            this.txtArchivoSalida.Size = new System.Drawing.Size(15, 15);
            this.txtArchivoSalida.TabIndex = 14;
            this.txtArchivoSalida.Text = ".";
            this.txtArchivoSalida.DoubleClick += new System.EventHandler(this.TxtArchivoSalida_DoubleClick);
            this.txtArchivoSalida.MouseEnter += new System.EventHandler(this.TxtArchivoSalida_MouseEnter_1);
            this.txtArchivoSalida.MouseLeave += new System.EventHandler(this.TxtArchivoSalida_MouseLeave_1);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hack Nerd Font Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(328, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Archivo de Salida";
            // 
            // txtEncoding
            // 
            this.txtEncoding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEncoding.AutoSize = true;
            this.txtEncoding.Font = new System.Drawing.Font("Hack Nerd Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncoding.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEncoding.Location = new System.Drawing.Point(392, 336);
            this.txtEncoding.Name = "txtEncoding";
            this.txtEncoding.Size = new System.Drawing.Size(15, 15);
            this.txtEncoding.TabIndex = 13;
            this.txtEncoding.Text = ".";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hack Nerd Font Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(292, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Codificacion de caracteres";
            // 
            // nameFile
            // 
            this.nameFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameFile.AutoSize = true;
            this.nameFile.Font = new System.Drawing.Font("Hack Nerd Font", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameFile.Location = new System.Drawing.Point(392, 258);
            this.nameFile.Name = "nameFile";
            this.nameFile.Size = new System.Drawing.Size(15, 15);
            this.nameFile.TabIndex = 11;
            this.nameFile.Text = ".";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hack Nerd Font Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(316, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Archivo Seleccionado";
            // 
            // comboDelimitador
            // 
            this.comboDelimitador.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboDelimitador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(52)))), ((int)(((byte)(33)))));
            this.comboDelimitador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDelimitador.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboDelimitador.Font = new System.Drawing.Font("Fira Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDelimitador.ForeColor = System.Drawing.SystemColors.Info;
            this.comboDelimitador.FormattingEnabled = true;
            this.comboDelimitador.Items.AddRange(new object[] {
            "//",
            "::",
            "--",
            "**"});
            this.comboDelimitador.Location = new System.Drawing.Point(339, 171);
            this.comboDelimitador.Name = "comboDelimitador";
            this.comboDelimitador.Size = new System.Drawing.Size(121, 33);
            this.comboDelimitador.TabIndex = 1;
            this.comboDelimitador.Text = "//";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hack Nerd Font Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(352, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Delimitador";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.NotifyIcon1_BalloonTipClicked);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // BtnAbrirArchivo
            // 
            this.BtnAbrirArchivo.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnAbrirArchivo.BackGroudColor = System.Drawing.Color.DarkCyan;
            this.BtnAbrirArchivo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAbrirArchivo.BorderRadius = 31;
            this.BtnAbrirArchivo.BorderSize = 2;
            this.BtnAbrirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAbrirArchivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAbrirArchivo.FlatAppearance.BorderSize = 0;
            this.BtnAbrirArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAbrirArchivo.Font = new System.Drawing.Font("Hack Nerd Font", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirArchivo.ForeColor = System.Drawing.Color.White;
            this.BtnAbrirArchivo.Location = new System.Drawing.Point(43, 81);
            this.BtnAbrirArchivo.Name = "BtnAbrirArchivo";
            this.BtnAbrirArchivo.Size = new System.Drawing.Size(714, 45);
            this.BtnAbrirArchivo.TabIndex = 16;
            this.BtnAbrirArchivo.Text = "Abre ó Arrastra y Suelta tu Archivo";
            this.BtnAbrirArchivo.TextColor = System.Drawing.Color.White;
            this.BtnAbrirArchivo.UseVisualStyleBackColor = false;
            this.BtnAbrirArchivo.Click += new System.EventHandler(this.BtnAbrirArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboDelimitador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txtEncoding;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtArchivoSalida;
        private System.Windows.Forms.Label nameFile;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Controles.NSButton BtnAbrirArchivo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}