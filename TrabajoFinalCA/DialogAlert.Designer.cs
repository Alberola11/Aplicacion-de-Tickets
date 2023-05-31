namespace TrabajoFinalCA
{
    partial class DialogAlert
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
            this.btnAlerta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlerta
            // 
            this.btnAlerta.BackgroundImage = global::TrabajoFinalCA.Properties.Resources.Alerta;
            this.btnAlerta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlerta.Location = new System.Drawing.Point(93, 12);
            this.btnAlerta.Name = "btnAlerta";
            this.btnAlerta.Size = new System.Drawing.Size(443, 184);
            this.btnAlerta.TabIndex = 0;
            this.btnAlerta.UseVisualStyleBackColor = true;
            this.btnAlerta.Click += new System.EventHandler(this.btnAlerta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "No existe ningún ticket en la base de datos";
            // 
            // DialogAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlerta);
            this.Name = "DialogAlert";
            this.Text = "Alerta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlerta;
        private System.Windows.Forms.Label label1;
    }
}