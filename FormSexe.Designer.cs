namespace CabinetMedicalApp.Classes
{
    partial class FormSexe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstFemme;
        private System.Windows.Forms.ListBox lstHomme;
        private System.Windows.Forms.Label labelFemmes;
        private System.Windows.Forms.Label labelHommes;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lstFemme = new System.Windows.Forms.ListBox();
            this.lstHomme = new System.Windows.Forms.ListBox();
            this.labelFemmes = new System.Windows.Forms.Label();
            this.labelHommes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstFemme
            // 
            this.lstFemme.FormattingEnabled = true;
            this.lstFemme.ItemHeight = 24;
            this.lstFemme.Location = new System.Drawing.Point(18, 136);
            this.lstFemme.Name = "lstFemme";
            this.lstFemme.Size = new System.Drawing.Size(237, 268);
            this.lstFemme.TabIndex = 1;
            // 
            // lstHomme
            // 
            this.lstHomme.FormattingEnabled = true;
            this.lstHomme.ItemHeight = 24;
            this.lstHomme.Location = new System.Drawing.Point(349, 136);
            this.lstHomme.Name = "lstHomme";
            this.lstHomme.Size = new System.Drawing.Size(283, 268);
            this.lstHomme.TabIndex = 3;
            // 
            // labelFemmes
            // 
            this.labelFemmes.AutoSize = true;
            this.labelFemmes.Location = new System.Drawing.Point(13, 118);
            this.labelFemmes.Name = "labelFemmes";
            this.labelFemmes.Size = new System.Drawing.Size(99, 25);
            this.labelFemmes.TabIndex = 0;
            this.labelFemmes.Text = "Femmes :";
            // 
            // labelHommes
            // 
            this.labelHommes.AutoSize = true;
            this.labelHommes.Location = new System.Drawing.Point(353, 119);
            this.labelHommes.Name = "labelHommes";
            this.labelHommes.Size = new System.Drawing.Size(101, 25);
            this.labelHommes.TabIndex = 2;
            this.labelHommes.Text = "Hommes :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Classement par sexe";
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(647, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFemmes);
            this.Controls.Add(this.lstFemme);
            this.Controls.Add(this.labelHommes);
            this.Controls.Add(this.lstHomme);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Classement par sexe";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
    }
}
