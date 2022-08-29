namespace CockroachDbMvc
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlTabla = new System.Windows.Forms.ComboBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBaseDatos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtAux = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtVista = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Convertidor = new System.Windows.Forms.Button();
            this.txtConverter = new System.Windows.Forms.TextBox();
            this.DTO = new System.Windows.Forms.TabPage();
            this.txtDto = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtinOut = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.DTO.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.DTO);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(610, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblResumen);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.ddlTabla);
            this.tabPage1.Controls.Add(this.btnConectar);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtBaseDatos);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtContrasenia);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtServidor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(602, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuración";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Location = new System.Drawing.Point(305, 56);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(69, 15);
            this.lblResumen.TabIndex = 13;
            this.lblResumen.Text = "lblResumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tabla / Vista";
            // 
            // ddlTabla
            // 
            this.ddlTabla.FormattingEnabled = true;
            this.ddlTabla.Location = new System.Drawing.Point(305, 30);
            this.ddlTabla.Name = "ddlTabla";
            this.ddlTabla.Size = new System.Drawing.Size(284, 23);
            this.ddlTabla.TabIndex = 11;
            this.ddlTabla.SelectedIndexChanged += new System.EventHandler(this.ddlTabla_SelectedIndexChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(15, 235);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(284, 23);
            this.btnConectar.TabIndex = 10;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(15, 206);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(284, 23);
            this.txtPort.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Puerto";
            // 
            // txtBaseDatos
            // 
            this.txtBaseDatos.Location = new System.Drawing.Point(15, 162);
            this.txtBaseDatos.Name = "txtBaseDatos";
            this.txtBaseDatos.Size = new System.Drawing.Size(284, 23);
            this.txtBaseDatos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Base Datos";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(15, 118);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(284, 23);
            this.txtContrasenia.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 74);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(284, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(15, 30);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(284, 23);
            this.txtServidor.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtAux);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(602, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Auxiliar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAux
            // 
            this.txtAux.Location = new System.Drawing.Point(6, 6);
            this.txtAux.Multiline = true;
            this.txtAux.Name = "txtAux";
            this.txtAux.ReadOnly = true;
            this.txtAux.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAux.Size = new System.Drawing.Size(590, 386);
            this.txtAux.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtVista);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(602, 398);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vista";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtVista
            // 
            this.txtVista.Location = new System.Drawing.Point(6, 6);
            this.txtVista.Multiline = true;
            this.txtVista.Name = "txtVista";
            this.txtVista.ReadOnly = true;
            this.txtVista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVista.Size = new System.Drawing.Size(590, 386);
            this.txtVista.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Convertidor);
            this.tabPage4.Controls.Add(this.txtConverter);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(602, 398);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "c# / string";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Convertidor
            // 
            this.Convertidor.Location = new System.Drawing.Point(6, 6);
            this.Convertidor.Name = "Convertidor";
            this.Convertidor.Size = new System.Drawing.Size(222, 23);
            this.Convertidor.TabIndex = 1;
            this.Convertidor.Text = "Convertir string to c#";
            this.Convertidor.UseVisualStyleBackColor = true;
            this.Convertidor.Click += new System.EventHandler(this.Convertidor_Click);
            // 
            // txtConverter
            // 
            this.txtConverter.Location = new System.Drawing.Point(6, 35);
            this.txtConverter.Multiline = true;
            this.txtConverter.Name = "txtConverter";
            this.txtConverter.Size = new System.Drawing.Size(590, 357);
            this.txtConverter.TabIndex = 0;
            // 
            // DTO
            // 
            this.DTO.Controls.Add(this.txtDto);
            this.DTO.Location = new System.Drawing.Point(4, 24);
            this.DTO.Name = "DTO";
            this.DTO.Padding = new System.Windows.Forms.Padding(3);
            this.DTO.Size = new System.Drawing.Size(602, 398);
            this.DTO.TabIndex = 4;
            this.DTO.Text = "DTO";
            this.DTO.UseVisualStyleBackColor = true;
            // 
            // txtDto
            // 
            this.txtDto.Location = new System.Drawing.Point(6, 6);
            this.txtDto.Multiline = true;
            this.txtDto.Name = "txtDto";
            this.txtDto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDto.Size = new System.Drawing.Size(590, 386);
            this.txtDto.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtinOut);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(602, 398);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "In Out";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtinOut
            // 
            this.txtinOut.Location = new System.Drawing.Point(6, 6);
            this.txtinOut.Multiline = true;
            this.txtinOut.Name = "txtinOut";
            this.txtinOut.ReadOnly = true;
            this.txtinOut.Size = new System.Drawing.Size(590, 386);
            this.txtinOut.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.DTO.ResumeLayout(false);
            this.DTO.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnConectar;
        private TextBox txtPort;
        private Label label5;
        private TextBox txtBaseDatos;
        private Label label4;
        private TextBox txtContrasenia;
        private Label label3;
        private TextBox txtUsuario;
        private Label label2;
        private TextBox txtServidor;
        private Label label1;
        private TabPage tabPage2;
        private Label label6;
        private ComboBox ddlTabla;
        private Label lblResumen;
        private TextBox txtAux;
        private TabPage tabPage3;
        private Button button1;
        private TabPage tabPage4;
        private Button Convertidor;
        private TextBox txtConverter;
        private TextBox txtVista;
        private TabPage DTO;
        private TextBox txtDto;
        private TabPage tabPage5;
        private TextBox txtinOut;
    }
}