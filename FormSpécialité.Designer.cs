using System.Windows.Forms;

namespace CabinetMedicalApp.Classes
{
    partial class FormSpécialité
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitre;
        private Label lblGeneraliste;
        private Label lblDentiste;
        private Label lblCardiologue;
        private ListBox listBoxGeneraliste;
        private ListBox listBoxDentiste;
        private ListBox listBoxCardiologue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblGeneraliste = new System.Windows.Forms.Label();
            this.lblDentiste = new System.Windows.Forms.Label();
            this.lblCardiologue = new System.Windows.Forms.Label();
            this.listBoxGeneraliste = new System.Windows.Forms.ListBox();
            this.listBoxDentiste = new System.Windows.Forms.ListBox();
            this.listBoxCardiologue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Arial", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(154, 23);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(437, 44);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Affichage par spécialité";
            // 
            // lblGeneraliste
            // 
            this.lblGeneraliste.AutoSize = true;
            this.lblGeneraliste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneraliste.Location = new System.Drawing.Point(39, 108);
            this.lblGeneraliste.Name = "lblGeneraliste";
            this.lblGeneraliste.Size = new System.Drawing.Size(148, 29);
            this.lblGeneraliste.TabIndex = 1;
            this.lblGeneraliste.Text = "Généraliste";
            // 
            // lblDentiste
            // 
            this.lblDentiste.AutoSize = true;
            this.lblDentiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDentiste.Location = new System.Drawing.Point(316, 108);
            this.lblDentiste.Name = "lblDentiste";
            this.lblDentiste.Size = new System.Drawing.Size(109, 29);
            this.lblDentiste.TabIndex = 2;
            this.lblDentiste.Text = "Dentiste";
            // 
            // lblCardiologue
            // 
            this.lblCardiologue.AutoSize = true;
            this.lblCardiologue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Bold);
            this.lblCardiologue.Location = new System.Drawing.Point(603, 108);
            this.lblCardiologue.Name = "lblCardiologue";
            this.lblCardiologue.Size = new System.Drawing.Size(157, 29);
            this.lblCardiologue.TabIndex = 3;
            this.lblCardiologue.Text = "Cardiologue";
            // 
            // listBoxGeneraliste
            // 
            this.listBoxGeneraliste.ItemHeight = 24;
            this.listBoxGeneraliste.Location = new System.Drawing.Point(14, 128);
            this.listBoxGeneraliste.Name = "listBoxGeneraliste";
            this.listBoxGeneraliste.Size = new System.Drawing.Size(228, 316);
            this.listBoxGeneraliste.TabIndex = 4;
            // 
            // listBoxDentiste
            // 
            this.listBoxDentiste.ItemHeight = 24;
            this.listBoxDentiste.Location = new System.Drawing.Point(296, 128);
            this.listBoxDentiste.Name = "listBoxDentiste";
            this.listBoxDentiste.Size = new System.Drawing.Size(239, 316);
            this.listBoxDentiste.TabIndex = 5;
            // 
            // listBoxCardiologue
            // 
            this.listBoxCardiologue.ItemHeight = 24;
            this.listBoxCardiologue.Location = new System.Drawing.Point(593, 128);
            this.listBoxCardiologue.Name = "listBoxCardiologue";
            this.listBoxCardiologue.Size = new System.Drawing.Size(214, 316);
            this.listBoxCardiologue.TabIndex = 6;
            // 
            // FormSpecialites
            // 
            this.ClientSize = new System.Drawing.Size(829, 468);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblGeneraliste);
            this.Controls.Add(this.lblDentiste);
            this.Controls.Add(this.lblCardiologue);
            this.Controls.Add(this.listBoxGeneraliste);
            this.Controls.Add(this.listBoxDentiste);
            this.Controls.Add(this.listBoxCardiologue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormSpecialites";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Affichage par spécialité";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
