namespace Cédula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLugarNacimiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dgVista = new System.Windows.Forms.DataGridView();
            this.FechaDeExpiracion = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVista)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PapayaWhip;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(334, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formulario de cédulas";
            // 
            // gbGeneral
            // 
            this.gbGeneral.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbGeneral.Controls.Add(this.btnCancelar);
            this.gbGeneral.Controls.Add(this.btnGuardar);
            this.gbGeneral.Controls.Add(this.FechaDeExpiracion);
            this.gbGeneral.Controls.Add(this.cbSangre);
            this.gbGeneral.Controls.Add(this.cbSexo);
            this.gbGeneral.Controls.Add(this.cbEstadoCivil);
            this.gbGeneral.Controls.Add(this.FechaNacimiento);
            this.gbGeneral.Controls.Add(this.txtApellidos);
            this.gbGeneral.Controls.Add(this.label13);
            this.gbGeneral.Controls.Add(this.txtNombre);
            this.gbGeneral.Controls.Add(this.label12);
            this.gbGeneral.Controls.Add(this.txtCedula);
            this.gbGeneral.Controls.Add(this.pictureBox5);
            this.gbGeneral.Controls.Add(this.pictureBox3);
            this.gbGeneral.Controls.Add(this.pictureBox2);
            this.gbGeneral.Controls.Add(this.label4);
            this.gbGeneral.Controls.Add(this.label11);
            this.gbGeneral.Controls.Add(this.txtLugarNacimiento);
            this.gbGeneral.Controls.Add(this.label10);
            this.gbGeneral.Controls.Add(this.label9);
            this.gbGeneral.Controls.Add(this.label8);
            this.gbGeneral.Controls.Add(this.txtOcupacion);
            this.gbGeneral.Controls.Add(this.label7);
            this.gbGeneral.Controls.Add(this.label6);
            this.gbGeneral.Controls.Add(this.txtNacionalidad);
            this.gbGeneral.Controls.Add(this.label5);
            this.gbGeneral.Controls.Add(this.label3);
            this.gbGeneral.Controls.Add(this.label2);
            this.gbGeneral.Controls.Add(this.pictureBox4);
            this.gbGeneral.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbGeneral.Location = new System.Drawing.Point(12, 132);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(442, 313);
            this.gbGeneral.TabIndex = 2;
            this.gbGeneral.TabStop = false;
            // 
            // cbSangre
            // 
            this.cbSangre.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "O+",
            "O-",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-"});
            this.cbSangre.Location = new System.Drawing.Point(252, 205);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(40, 23);
            this.cbSangre.TabIndex = 31;
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(164, 204);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(41, 23);
            this.cbSexo.TabIndex = 30;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Soltero",
            "Casado",
            "Unión"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(357, 206);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(78, 23);
            this.cbEstadoCivil.TabIndex = 29;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FechaNacimiento.Location = new System.Drawing.Point(135, 152);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(132, 23);
            this.FechaNacimiento.TabIndex = 27;
            this.FechaNacimiento.Value = new System.DateTime(2022, 5, 26, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCancelar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(268, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 33);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardar.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.Location = new System.Drawing.Point(158, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 33);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtApellidos.Location = new System.Drawing.Point(6, 291);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(112, 17);
            this.txtApellidos.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 277);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Apellidos";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(6, 255);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(112, 17);
            this.txtNombre.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(3, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nombres";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCedula.Location = new System.Drawing.Point(158, 80);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCedula.Size = new System.Drawing.Size(140, 18);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(392, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 19;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(392, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(135, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 45);
            this.label4.TabIndex = 3;
            this.label4.Text = "República Dominicana\r\nJunta Central Electoral\r\nCédula de Identidad y Electoral";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(131, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Fecha de expiración";
            // 
            // txtLugarNacimiento
            // 
            this.txtLugarNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLugarNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLugarNacimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtLugarNacimiento.Location = new System.Drawing.Point(135, 116);
            this.txtLugarNacimiento.Multiline = true;
            this.txtLugarNacimiento.Name = "txtLugarNacimiento";
            this.txtLugarNacimiento.Size = new System.Drawing.Size(131, 18);
            this.txtLugarNacimiento.TabIndex = 15;
            this.txtLugarNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(132, 235);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Ocupación";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(291, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Estado Civil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(210, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sangre";
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOcupacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOcupacion.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOcupacion.Location = new System.Drawing.Point(194, 232);
            this.txtOcupacion.Multiline = true;
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(112, 19);
            this.txtOcupacion.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(133, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(132, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nacionalidad";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNacionalidad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNacionalidad.Location = new System.Drawing.Point(208, 181);
            this.txtNacionalidad.Multiline = true;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(130, 19);
            this.txtNacionalidad.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(133, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lugar de Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 78);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(128, 176);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // dgVista
            // 
            this.dgVista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVista.Location = new System.Drawing.Point(459, 141);
            this.dgVista.Name = "dgVista";
            this.dgVista.RowTemplate.Height = 25;
            this.dgVista.Size = new System.Drawing.Size(456, 306);
            this.dgVista.TabIndex = 3;
            // 
            // FechaDeExpiracion
            // 
            this.FechaDeExpiracion.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FechaDeExpiracion.Location = new System.Drawing.Point(241, 255);
            this.FechaDeExpiracion.Name = "FechaDeExpiracion";
            this.FechaDeExpiracion.Size = new System.Drawing.Size(117, 23);
            this.FechaDeExpiracion.TabIndex = 32;
            this.FechaDeExpiracion.Value = new System.DateTime(2022, 5, 26, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(927, 469);
            this.Controls.Add(this.dgVista);
            this.Controls.Add(this.gbGeneral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Formulario de cédula";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgVista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox gbGeneral;
        private Label label2;
        private Label label6;
        private TextBox txtNacionalidad;
        private Label label5;
        private Label label3;
        private TextBox txtCedula;
        private Label label4;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtOcupacion;
        private Label label7;
        private TextBox txtApellidos;
        private Label label13;
        private TextBox txtNombre;
        private Label label12;
        private DataGridView dgVista;
        private Button btnCancelar;
        private Button btnGuardar;
        private DateTimePicker FechaNacimiento;
        private TextBox txtLugarNacimiento;
        private ComboBox cbEstadoCivil;
        private PictureBox pictureBox5;
        private ComboBox cbSangre;
        private ComboBox cbSexo;
        private DateTimePicker FechaDeExpiracion;
    }
}