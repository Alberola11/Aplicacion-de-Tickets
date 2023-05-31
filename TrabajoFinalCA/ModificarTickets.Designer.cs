namespace TrabajoFinalCA
{
    partial class ModificarTickets
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
            this.gbMasInfo = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nudImporteTotal = new System.Windows.Forms.NumericUpDown();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbDatosPersonales = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCif = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.rbParticular = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.btnModificarTicket = new System.Windows.Forms.Button();
            this.gbMasInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporteTotal)).BeginInit();
            this.gbDatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMasInfo
            // 
            this.gbMasInfo.Controls.Add(this.dtpFecha);
            this.gbMasInfo.Controls.Add(this.label7);
            this.gbMasInfo.Controls.Add(this.nudImporteTotal);
            this.gbMasInfo.Controls.Add(this.txtConcepto);
            this.gbMasInfo.Controls.Add(this.label6);
            this.gbMasInfo.Controls.Add(this.label4);
            this.gbMasInfo.Location = new System.Drawing.Point(313, 236);
            this.gbMasInfo.Name = "gbMasInfo";
            this.gbMasInfo.Size = new System.Drawing.Size(751, 171);
            this.gbMasInfo.TabIndex = 6;
            this.gbMasInfo.TabStop = false;
            this.gbMasInfo.Text = "Más información";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(277, 92);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha";
            // 
            // nudImporteTotal
            // 
            this.nudImporteTotal.DecimalPlaces = 2;
            this.nudImporteTotal.Location = new System.Drawing.Point(513, 42);
            this.nudImporteTotal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudImporteTotal.Name = "nudImporteTotal";
            this.nudImporteTotal.Size = new System.Drawing.Size(120, 20);
            this.nudImporteTotal.TabIndex = 14;
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(88, 39);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(216, 20);
            this.txtConcepto.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Importe Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Concepto";
            // 
            // gbDatosPersonales
            // 
            this.gbDatosPersonales.Controls.Add(this.txtDireccion);
            this.gbDatosPersonales.Controls.Add(this.label5);
            this.gbDatosPersonales.Controls.Add(this.label3);
            this.gbDatosPersonales.Controls.Add(this.txtCif);
            this.gbDatosPersonales.Controls.Add(this.txtDni);
            this.gbDatosPersonales.Controls.Add(this.label2);
            this.gbDatosPersonales.Controls.Add(this.rbEmpresa);
            this.gbDatosPersonales.Controls.Add(this.rbParticular);
            this.gbDatosPersonales.Controls.Add(this.txtNombre);
            this.gbDatosPersonales.Controls.Add(this.label1);
            this.gbDatosPersonales.Location = new System.Drawing.Point(313, 25);
            this.gbDatosPersonales.Name = "gbDatosPersonales";
            this.gbDatosPersonales.Size = new System.Drawing.Size(751, 188);
            this.gbDatosPersonales.TabIndex = 5;
            this.gbDatosPersonales.TabStop = false;
            this.gbDatosPersonales.Text = "Datos Personales";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(88, 137);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(216, 20);
            this.txtDireccion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "CIF";
            // 
            // txtCif
            // 
            this.txtCif.Location = new System.Drawing.Point(494, 88);
            this.txtCif.MaxLength = 9;
            this.txtCif.Name = "txtCif";
            this.txtCif.ReadOnly = true;
            this.txtCif.Size = new System.Drawing.Size(216, 20);
            this.txtCif.TabIndex = 8;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(88, 88);
            this.txtDni.MaxLength = 9;
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(216, 20);
            this.txtDni.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "DNI";
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(478, 58);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rbEmpresa.TabIndex = 5;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Tag = "Empresa";
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // rbParticular
            // 
            this.rbParticular.AutoSize = true;
            this.rbParticular.Location = new System.Drawing.Point(79, 58);
            this.rbParticular.Name = "rbParticular";
            this.rbParticular.Size = new System.Drawing.Size(69, 17);
            this.rbParticular.TabIndex = 4;
            this.rbParticular.TabStop = true;
            this.rbParticular.Tag = "Particular";
            this.rbParticular.Text = "Particular";
            this.rbParticular.UseVisualStyleBackColor = true;
            this.rbParticular.CheckedChanged += new System.EventHandler(this.rbParticular_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(247, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(216, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Persona/Empresa";
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 25);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(292, 576);
            this.lbLista.TabIndex = 0;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.lbLista_SelectedIndexChanged);
            // 
            // btnModificarTicket
            // 
            this.btnModificarTicket.Location = new System.Drawing.Point(495, 453);
            this.btnModificarTicket.Name = "btnModificarTicket";
            this.btnModificarTicket.Size = new System.Drawing.Size(338, 73);
            this.btnModificarTicket.TabIndex = 14;
            this.btnModificarTicket.Text = "Modificar Ticket";
            this.btnModificarTicket.UseVisualStyleBackColor = true;
            this.btnModificarTicket.Click += new System.EventHandler(this.btnModificarTicket_Click);
            // 
            // ModificarTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 614);
            this.Controls.Add(this.btnModificarTicket);
            this.Controls.Add(this.lbLista);
            this.Controls.Add(this.gbMasInfo);
            this.Controls.Add(this.gbDatosPersonales);
            this.Name = "ModificarTickets";
            this.Text = "ModificarTickets";
            this.gbMasInfo.ResumeLayout(false);
            this.gbMasInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporteTotal)).EndInit();
            this.gbDatosPersonales.ResumeLayout(false);
            this.gbDatosPersonales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMasInfo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudImporteTotal;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbDatosPersonales;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCif;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.RadioButton rbParticular;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btnModificarTicket;
    }
}