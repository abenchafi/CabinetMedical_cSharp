namespace CabinetMedicalApp.Classes
{
    partial class FormPrioritaire
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
            this.textname = new System.Windows.Forms.TextBox();
            this.textlabel = new System.Windows.Forms.Label();
            this.Prénomlabel = new System.Windows.Forms.Label();
            this.Sexelabel = new System.Windows.Forms.Label();
            this.spelabel = new System.Windows.Forms.Label();
            this.textprenom = new System.Windows.Forms.TextBox();
            this.textsexe = new System.Windows.Forms.TextBox();
            this.textspec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(261, 96);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(376, 29);
            this.textname.TabIndex = 0;
            // 
            // textlabel
            // 
            this.textlabel.AutoSize = true;
            this.textlabel.Location = new System.Drawing.Point(95, 96);
            this.textlabel.Name = "textlabel";
            this.textlabel.Size = new System.Drawing.Size(53, 25);
            this.textlabel.TabIndex = 1;
            this.textlabel.Text = "Nom";
            // 
            // Prénomlabel
            // 
            this.Prénomlabel.AutoSize = true;
            this.Prénomlabel.Location = new System.Drawing.Point(90, 186);
            this.Prénomlabel.Name = "Prénomlabel";
            this.Prénomlabel.Size = new System.Drawing.Size(80, 25);
            this.Prénomlabel.TabIndex = 2;
            this.Prénomlabel.Text = "Prénom";
            // 
            // Sexelabel
            // 
            this.Sexelabel.AutoSize = true;
            this.Sexelabel.Location = new System.Drawing.Point(95, 279);
            this.Sexelabel.Name = "Sexelabel";
            this.Sexelabel.Size = new System.Drawing.Size(58, 25);
            this.Sexelabel.TabIndex = 3;
            this.Sexelabel.Text = "Sexe";
            // 
            // spelabel
            // 
            this.spelabel.AutoSize = true;
            this.spelabel.Location = new System.Drawing.Point(90, 371);
            this.spelabel.Name = "spelabel";
            this.spelabel.Size = new System.Drawing.Size(107, 25);
            this.spelabel.TabIndex = 4;
            this.spelabel.Text = "Spécialiste";
            // 
            // textprenom
            // 
            this.textprenom.Location = new System.Drawing.Point(261, 186);
            this.textprenom.Name = "textprenom";
            this.textprenom.Size = new System.Drawing.Size(376, 29);
            this.textprenom.TabIndex = 5;
            // 
            // textsexe
            // 
            this.textsexe.Location = new System.Drawing.Point(261, 279);
            this.textsexe.Name = "textsexe";
            this.textsexe.Size = new System.Drawing.Size(272, 29);
            this.textsexe.TabIndex = 6;
            // 
            // textspec
            // 
            this.textspec.Location = new System.Drawing.Point(261, 371);
            this.textspec.Name = "textspec";
            this.textspec.Size = new System.Drawing.Size(272, 29);
            this.textspec.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient Prioritaire";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textspec);
            this.Controls.Add(this.textsexe);
            this.Controls.Add(this.textprenom);
            this.Controls.Add(this.spelabel);
            this.Controls.Add(this.Sexelabel);
            this.Controls.Add(this.Prénomlabel);
            this.Controls.Add(this.textlabel);
            this.Controls.Add(this.textname);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Patient Prioritaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label textlabel;
        private System.Windows.Forms.Label Prénomlabel;
        private System.Windows.Forms.Label Sexelabel;
        private System.Windows.Forms.Label spelabel;
        private System.Windows.Forms.TextBox textprenom;
        private System.Windows.Forms.TextBox textsexe;
        private System.Windows.Forms.TextBox textspec;
        private System.Windows.Forms.Label label1;
    }
}