namespace CabinetMedicalApp.Classes
{
    partial class FormAge
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstEnfants = new System.Windows.Forms.ListBox();
            this.lstAdultes = new System.Windows.Forms.ListBox();
            this.lblEnfant = new System.Windows.Forms.Label();
            this.lblAdulte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstEnfants
            // 
            this.lstEnfants.FormattingEnabled = true;
            this.lstEnfants.ItemHeight = 24;
            this.lstEnfants.Location = new System.Drawing.Point(42, 215);
            this.lstEnfants.Margin = new System.Windows.Forms.Padding(4);
            this.lstEnfants.Name = "lstEnfants";
            this.lstEnfants.Size = new System.Drawing.Size(313, 292);
            this.lstEnfants.TabIndex = 0;
            // 
            // lstAdultes
            // 
            this.lstAdultes.FormattingEnabled = true;
            this.lstAdultes.ItemHeight = 24;
            this.lstAdultes.Location = new System.Drawing.Point(501, 215);
            this.lstAdultes.Margin = new System.Windows.Forms.Padding(4);
            this.lstAdultes.Name = "lstAdultes";
            this.lstAdultes.Size = new System.Drawing.Size(313, 292);
            this.lstAdultes.TabIndex = 1;
            // 
            // lblEnfant
            // 
            this.lblEnfant.AutoSize = true;
            this.lblEnfant.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEnfant.Location = new System.Drawing.Point(129, 147);
            this.lblEnfant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnfant.Name = "lblEnfant";
            this.lblEnfant.Size = new System.Drawing.Size(88, 32);
            this.lblEnfant.TabIndex = 2;
            this.lblEnfant.Text = "Enfant";
            // 
            // lblAdulte
            // 
            this.lblAdulte.AutoSize = true;
            this.lblAdulte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdulte.Location = new System.Drawing.Point(592, 147);
            this.lblAdulte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdulte.Name = "lblAdulte";
            this.lblAdulte.Size = new System.Drawing.Size(90, 32);
            this.lblAdulte.TabIndex = 3;
            this.lblAdulte.Text = "Adulte";
            this.lblAdulte.Click += new System.EventHandler(this.lblAdulte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Classement par âge";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAdulte);
            this.Controls.Add(this.lblEnfant);
            this.Controls.Add(this.lstAdultes);
            this.Controls.Add(this.lstEnfants);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Classement des patients par âge";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEnfants;
        private System.Windows.Forms.ListBox lstAdultes;
        private System.Windows.Forms.Label lblEnfant;
        private System.Windows.Forms.Label lblAdulte;
        private System.Windows.Forms.Label label1;
    }
}
