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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            ddlConexiones = new ComboBox();
            button1 = new Button();
            lblResumen = new Label();
            label6 = new Label();
            ddlTabla = new ComboBox();
            btnConectar = new Button();
            txtPort = new TextBox();
            label5 = new Label();
            txtBaseDatos = new TextBox();
            label4 = new Label();
            txtContrasenia = new TextBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            txtServidor = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            txtAux = new TextBox();
            tabPage3 = new TabPage();
            txtVista = new TextBox();
            tabPage4 = new TabPage();
            Convertidor = new Button();
            txtConverter = new TextBox();
            DTO = new TabPage();
            txtDto = new TextBox();
            tabPage5 = new TabPage();
            txtinOut = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            DTO.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(DTO);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(610, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(ddlConexiones);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(lblResumen);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(ddlTabla);
            tabPage1.Controls.Add(btnConectar);
            tabPage1.Controls.Add(txtPort);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtBaseDatos);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtContrasenia);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtServidor);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(602, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Configuración";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(10, 12);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 16;
            label7.Text = "Conexiones";
            // 
            // ddlConexiones
            // 
            ddlConexiones.DropDownStyle = ComboBoxStyle.DropDownList;
            ddlConexiones.FormattingEnabled = true;
            ddlConexiones.Location = new Point(10, 30);
            ddlConexiones.Name = "ddlConexiones";
            ddlConexiones.Size = new Size(284, 23);
            ddlConexiones.TabIndex = 15;
            ddlConexiones.SelectedIndexChanged += ddlConexiones_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(7, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(305, 56);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(69, 15);
            lblResumen.TabIndex = 13;
            lblResumen.Text = "lblResumen";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(305, 12);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Tabla / Vista";
            // 
            // ddlTabla
            // 
            ddlTabla.FormattingEnabled = true;
            ddlTabla.Location = new Point(305, 30);
            ddlTabla.Name = "ddlTabla";
            ddlTabla.Size = new Size(284, 23);
            ddlTabla.TabIndex = 11;
            ddlTabla.SelectedIndexChanged += ddlTabla_SelectedIndexChanged;
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(10, 279);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(284, 23);
            btnConectar.TabIndex = 10;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(10, 250);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(284, 23);
            txtPort.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 232);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "Puerto";
            // 
            // txtBaseDatos
            // 
            txtBaseDatos.Location = new Point(10, 206);
            txtBaseDatos.Name = "txtBaseDatos";
            txtBaseDatos.Size = new Size(284, 23);
            txtBaseDatos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 188);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 6;
            label4.Text = "Base Datos";
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(10, 162);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(284, 23);
            txtContrasenia.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 144);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 4;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(10, 118);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(284, 23);
            txtUsuario.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 100);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // txtServidor
            // 
            txtServidor.Location = new Point(10, 74);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(284, 23);
            txtServidor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 56);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Servidor";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtAux);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(602, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Auxiliar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAux
            // 
            txtAux.Location = new Point(6, 6);
            txtAux.Multiline = true;
            txtAux.Name = "txtAux";
            txtAux.ReadOnly = true;
            txtAux.ScrollBars = ScrollBars.Both;
            txtAux.Size = new Size(590, 386);
            txtAux.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtVista);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(602, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Vista";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtVista
            // 
            txtVista.Location = new Point(6, 6);
            txtVista.Multiline = true;
            txtVista.Name = "txtVista";
            txtVista.ReadOnly = true;
            txtVista.ScrollBars = ScrollBars.Vertical;
            txtVista.Size = new Size(590, 386);
            txtVista.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(Convertidor);
            tabPage4.Controls.Add(txtConverter);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(602, 398);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "c# / string";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Convertidor
            // 
            Convertidor.Location = new Point(6, 6);
            Convertidor.Name = "Convertidor";
            Convertidor.Size = new Size(222, 23);
            Convertidor.TabIndex = 1;
            Convertidor.Text = "Convertir string to c#";
            Convertidor.UseVisualStyleBackColor = true;
            Convertidor.Click += Convertidor_Click;
            // 
            // txtConverter
            // 
            txtConverter.Location = new Point(6, 35);
            txtConverter.Multiline = true;
            txtConverter.Name = "txtConverter";
            txtConverter.Size = new Size(590, 357);
            txtConverter.TabIndex = 0;
            // 
            // DTO
            // 
            DTO.Controls.Add(txtDto);
            DTO.Location = new Point(4, 24);
            DTO.Name = "DTO";
            DTO.Padding = new Padding(3);
            DTO.Size = new Size(602, 398);
            DTO.TabIndex = 4;
            DTO.Text = "DTO";
            DTO.UseVisualStyleBackColor = true;
            // 
            // txtDto
            // 
            txtDto.Location = new Point(6, 6);
            txtDto.Multiline = true;
            txtDto.Name = "txtDto";
            txtDto.ScrollBars = ScrollBars.Vertical;
            txtDto.Size = new Size(590, 386);
            txtDto.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(txtinOut);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(602, 398);
            tabPage5.TabIndex = 5;
            tabPage5.Text = "In Out";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtinOut
            // 
            txtinOut.Location = new Point(6, 6);
            txtinOut.Multiline = true;
            txtinOut.Name = "txtinOut";
            txtinOut.ReadOnly = true;
            txtinOut.Size = new Size(590, 386);
            txtinOut.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            DTO.ResumeLayout(false);
            DTO.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
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
        private Label label7;
        private ComboBox ddlConexiones;
    }
}