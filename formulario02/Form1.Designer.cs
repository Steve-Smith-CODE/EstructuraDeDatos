namespace formulario02
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
            cboCargo = new ComboBox();
            label1 = new Label();
            txtNombres = new TextBox();
            label2 = new Label();
            txtDNI = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cboArea = new ComboBox();
            label6 = new Label();
            txtAñosAntiguedad = new TextBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // cboCargo
            // 
            cboCargo.BackColor = SystemColors.InactiveBorder;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(37, 149);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(176, 28);
            cboCargo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(37, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombres";
            // 
            // txtNombres
            // 
            txtNombres.BackColor = SystemColors.InactiveBorder;
            txtNombres.Location = new Point(37, 46);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(176, 27);
            txtNombres.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(37, 76);
            label2.Name = "label2";
            label2.Size = new Size(35, 20);
            label2.TabIndex = 3;
            label2.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.InactiveBorder;
            txtDNI.Location = new Point(37, 99);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(176, 27);
            txtDNI.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 152);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 129);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Cargo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 180);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 7;
            label5.Text = "Área";
            // 
            // cboArea
            // 
            cboArea.BackColor = SystemColors.InactiveBorder;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificación" });
            cboArea.Location = new Point(37, 203);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(176, 28);
            cboArea.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 234);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 9;
            label6.Text = "Años de Antiguedad";
            // 
            // txtAñosAntiguedad
            // 
            txtAñosAntiguedad.BackColor = SystemColors.InactiveBorder;
            txtAñosAntiguedad.Location = new Point(37, 257);
            txtAñosAntiguedad.Name = "txtAñosAntiguedad";
            txtAñosAntiguedad.Size = new Size(176, 27);
            txtAñosAntiguedad.TabIndex = 10;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = SystemColors.HighlightText;
            txtResultado.Location = new Point(280, 46);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(475, 291);
            txtResultado.TabIndex = 13;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = SystemColors.ActiveCaption;
            btnCrear.ForeColor = SystemColors.ActiveCaptionText;
            btnCrear.Location = new Point(281, 346);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(94, 29);
            btnCrear.TabIndex = 14;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.ActiveCaption;
            btnMostrar.Location = new Point(381, 346);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(174, 29);
            btnMostrar.TabIndex = 15;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.Location = new Point(561, 346);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaption;
            btnSalir.Location = new Point(661, 346);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(txtAñosAntiguedad);
            Controls.Add(label6);
            Controls.Add(cboArea);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDNI);
            Controls.Add(label2);
            Controls.Add(txtNombres);
            Controls.Add(label1);
            Controls.Add(cboCargo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboCargo;
        private Label label1;
        private TextBox txtNombres;
        private Label label2;
        private TextBox txtDNI;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboArea;
        private Label label6;
        private TextBox txtAñosAntiguedad;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
