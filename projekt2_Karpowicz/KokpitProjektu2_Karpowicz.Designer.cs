namespace projekt2_Karpowicz
{
    partial class KokpitProjektu2_Karpowicz
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSzeregLaboratoryjny = new System.Windows.Forms.Button();
            this.btnSzeregIndywidualny = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(273, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizator szeregów potęgowych";
            // 
            // btnSzeregLaboratoryjny
            // 
            this.btnSzeregLaboratoryjny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzeregLaboratoryjny.Location = new System.Drawing.Point(30, 225);
            this.btnSzeregLaboratoryjny.Name = "btnSzeregLaboratoryjny";
            this.btnSzeregLaboratoryjny.Size = new System.Drawing.Size(345, 80);
            this.btnSzeregLaboratoryjny.TabIndex = 1;
            this.btnSzeregLaboratoryjny.Text = "Laboratorium Nr 2\r\n(analizator laboratoryjnego szeregu potęgowego)\r\n";
            this.btnSzeregLaboratoryjny.UseVisualStyleBackColor = true;
            this.btnSzeregLaboratoryjny.Click += new System.EventHandler(this.btnSzeregLaboratoryjny_Click);
            // 
            // btnSzeregIndywidualny
            // 
            this.btnSzeregIndywidualny.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzeregIndywidualny.Location = new System.Drawing.Point(588, 225);
            this.btnSzeregIndywidualny.Name = "btnSzeregIndywidualny";
            this.btnSzeregIndywidualny.Size = new System.Drawing.Size(345, 80);
            this.btnSzeregIndywidualny.TabIndex = 2;
            this.btnSzeregIndywidualny.Text = "Projekt Nr 2\r\n(analizator indywidualnego szeregu potęgowego)";
            this.btnSzeregIndywidualny.UseVisualStyleBackColor = true;
            this.btnSzeregIndywidualny.Click += new System.EventHandler(this.button1_Click);
            // 
            // KokpitProjektu2_Karpowicz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 486);
            this.Controls.Add(this.btnSzeregIndywidualny);
            this.Controls.Add(this.btnSzeregLaboratoryjny);
            this.Controls.Add(this.label1);
            this.Name = "KokpitProjektu2_Karpowicz";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitProjektu2_Karpowicz_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSzeregLaboratoryjny;
        private System.Windows.Forms.Button btnSzeregIndywidualny;
    }
}

