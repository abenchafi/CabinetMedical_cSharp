using System;

namespace CabinetMedicalApp.Classes
{
    partial class FormAccueil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnReinitialiser;
        private System.Windows.Forms.ListBox lstPatients;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblAdresse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnReinitialiser = new System.Windows.Forms.Button();
            this.lstPatients = new System.Windows.Forms.ListBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.btnresetform = new System.Windows.Forms.Button();
            this.btnprio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSexe = new System.Windows.Forms.ComboBox();
            this.comboSpe = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnquite = new System.Windows.Forms.Button();
            this.btnfunction = new System.Windows.Forms.Button();
            this.btnage = new System.Windows.Forms.Button();
            this.btnsexe = new System.Windows.Forms.Button();
            this.grpInfosPatient = new System.Windows.Forms.GroupBox();
            this.textAdresse = new System.Windows.Forms.TextBox();
            this.grpactions = new System.Windows.Forms.GroupBox();
            this.grplistepatient = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1.SuspendLayout();
            this.grpInfosPatient.SuspendLayout();
            this.grpactions.SuspendLayout();
            this.grplistepatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(235, 79);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(266, 39);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(235, 148);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(266, 39);
            this.txtPrenom.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(41, 61);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(333, 90);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter à la liste d\'attente";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(41, 168);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(333, 85);
            this.btnSupprimer.TabIndex = 7;
            this.btnSupprimer.Text = "Retirer un patient";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnReinitialiser
            // 
            this.btnReinitialiser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReinitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiser.Location = new System.Drawing.Point(41, 271);
            this.btnReinitialiser.Name = "btnReinitialiser";
            this.btnReinitialiser.Size = new System.Drawing.Size(333, 92);
            this.btnReinitialiser.TabIndex = 8;
            this.btnReinitialiser.Text = "Réinitialiser la liste";
            this.btnReinitialiser.UseVisualStyleBackColor = false;
            this.btnReinitialiser.Click += new System.EventHandler(this.btnReinitialiser_Click);
            // 
            // lstPatients
            // 
            this.lstPatients.FormattingEnabled = true;
            this.lstPatients.ItemHeight = 32;
            this.lstPatients.Location = new System.Drawing.Point(21, 99);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(347, 452);
            this.lstPatients.TabIndex = 9;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(29, 83);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(56, 25);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.lblPrenom.Location = new System.Drawing.Point(29, 152);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(86, 25);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.lblAdresse.Location = new System.Drawing.Point(29, 236);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(92, 25);
            this.lblAdresse.TabIndex = 4;
            this.lblAdresse.Text = "Adresse";
            // 
            // btnresetform
            // 
            this.btnresetform.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnresetform.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetform.Location = new System.Drawing.Point(41, 379);
            this.btnresetform.Name = "btnresetform";
            this.btnresetform.Size = new System.Drawing.Size(333, 92);
            this.btnresetform.TabIndex = 10;
            this.btnresetform.Text = "Réinitialiser formulaire";
            this.btnresetform.UseVisualStyleBackColor = false;
            this.btnresetform.Click += new System.EventHandler(this.btnresetform_Click);
            // 
            // btnprio
            // 
            this.btnprio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprio.Location = new System.Drawing.Point(41, 486);
            this.btnprio.Name = "btnprio";
            this.btnprio.Size = new System.Drawing.Size(333, 92);
            this.btnprio.TabIndex = 11;
            this.btnprio.Text = "Prioritaire";
            this.btnprio.UseVisualStyleBackColor = false;
            this.btnprio.Click += new System.EventHandler(this.btnprio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date de naissance";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(235, 316);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(266, 39);
            this.date.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sexe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Spésialité demandé";
            // 
            // comboSexe
            // 
            this.comboSexe.FormattingEnabled = true;
            this.comboSexe.Location = new System.Drawing.Point(235, 405);
            this.comboSexe.Name = "comboSexe";
            this.comboSexe.Size = new System.Drawing.Size(266, 40);
            this.comboSexe.TabIndex = 16;
            // 
            // comboSpe
            // 
            this.comboSpe.FormattingEnabled = true;
            this.comboSpe.Location = new System.Drawing.Point(235, 486);
            this.comboSpe.Name = "comboSpe";
            this.comboSpe.Size = new System.Drawing.Size(266, 40);
            this.comboSpe.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 43);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 35);
            // 
            // btnquite
            // 
            this.btnquite.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnquite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquite.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquite.Location = new System.Drawing.Point(26, 648);
            this.btnquite.Name = "btnquite";
            this.btnquite.Size = new System.Drawing.Size(199, 56);
            this.btnquite.TabIndex = 22;
            this.btnquite.Text = "Quitter l\'application";
            this.btnquite.UseVisualStyleBackColor = false;
            this.btnquite.Click += new System.EventHandler(this.btnquite_Click);
            // 
            // btnfunction
            // 
            this.btnfunction.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfunction.Location = new System.Drawing.Point(275, 645);
            this.btnfunction.Name = "btnfunction";
            this.btnfunction.Size = new System.Drawing.Size(251, 56);
            this.btnfunction.TabIndex = 23;
            this.btnfunction.Text = "Afficher par spésialité";
            this.btnfunction.UseVisualStyleBackColor = false;
            this.btnfunction.Click += new System.EventHandler(this.btnfunction_Click);
            // 
            // btnage
            // 
            this.btnage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnage.Location = new System.Drawing.Point(563, 645);
            this.btnage.Name = "btnage";
            this.btnage.Size = new System.Drawing.Size(406, 56);
            this.btnage.TabIndex = 24;
            this.btnage.Text = "Classer par âge";
            this.btnage.UseVisualStyleBackColor = false;
            this.btnage.Click += new System.EventHandler(this.btnage_Click);
            // 
            // btnsexe
            // 
            this.btnsexe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsexe.Location = new System.Drawing.Point(1005, 645);
            this.btnsexe.Name = "btnsexe";
            this.btnsexe.Size = new System.Drawing.Size(375, 56);
            this.btnsexe.TabIndex = 25;
            this.btnsexe.Text = "Classer par sexe";
            this.btnsexe.UseVisualStyleBackColor = false;
            this.btnsexe.Click += new System.EventHandler(this.btnsexe_click);
            // 
            // grpInfosPatient
            // 
            this.grpInfosPatient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpInfosPatient.Controls.Add(this.textAdresse);
            this.grpInfosPatient.Controls.Add(this.date);
            this.grpInfosPatient.Controls.Add(this.lblNom);
            this.grpInfosPatient.Controls.Add(this.txtNom);
            this.grpInfosPatient.Controls.Add(this.lblPrenom);
            this.grpInfosPatient.Controls.Add(this.txtPrenom);
            this.grpInfosPatient.Controls.Add(this.lblAdresse);
            this.grpInfosPatient.Controls.Add(this.label1);
            this.grpInfosPatient.Controls.Add(this.label2);
            this.grpInfosPatient.Controls.Add(this.comboSpe);
            this.grpInfosPatient.Controls.Add(this.label3);
            this.grpInfosPatient.Controls.Add(this.comboSexe);
            this.grpInfosPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfosPatient.Location = new System.Drawing.Point(12, 12);
            this.grpInfosPatient.Name = "grpInfosPatient";
            this.grpInfosPatient.Size = new System.Drawing.Size(521, 594);
            this.grpInfosPatient.TabIndex = 26;
            this.grpInfosPatient.TabStop = false;
            this.grpInfosPatient.Text = "Informations sur le patient";
            // 
            // textAdresse
            // 
            this.textAdresse.Location = new System.Drawing.Point(235, 222);
            this.textAdresse.Name = "textAdresse";
            this.textAdresse.Size = new System.Drawing.Size(266, 39);
            this.textAdresse.TabIndex = 18;
            // 
            // grpactions
            // 
            this.grpactions.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpactions.Controls.Add(this.btnprio);
            this.grpactions.Controls.Add(this.btnAjouter);
            this.grpactions.Controls.Add(this.btnSupprimer);
            this.grpactions.Controls.Add(this.btnReinitialiser);
            this.grpactions.Controls.Add(this.btnresetform);
            this.grpactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpactions.Location = new System.Drawing.Point(553, 12);
            this.grpactions.Name = "grpactions";
            this.grpactions.Size = new System.Drawing.Size(427, 594);
            this.grpactions.TabIndex = 27;
            this.grpactions.TabStop = false;
            this.grpactions.Text = "Liste des Actions";
            // 
            // grplistepatient
            // 
            this.grplistepatient.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grplistepatient.Controls.Add(this.lstPatients);
            this.grplistepatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grplistepatient.Location = new System.Drawing.Point(1005, 12);
            this.grplistepatient.Name = "grplistepatient";
            this.grplistepatient.Size = new System.Drawing.Size(396, 594);
            this.grplistepatient.TabIndex = 28;
            this.grplistepatient.TabStop = false;
            this.grplistepatient.Text = "Liste d\'attente";
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1423, 738);
            this.Controls.Add(this.grplistepatient);
            this.Controls.Add(this.grpactions);
            this.Controls.Add(this.grpInfosPatient);
            this.Controls.Add(this.btnsexe);
            this.Controls.Add(this.btnage);
            this.Controls.Add(this.btnfunction);
            this.Controls.Add(this.btnquite);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cabinet Médical - Gestion des patients";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.grpInfosPatient.ResumeLayout(false);
            this.grpInfosPatient.PerformLayout();
            this.grpactions.ResumeLayout(false);
            this.grplistepatient.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnresetform;
        private System.Windows.Forms.Button btnprio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSexe;
        private System.Windows.Forms.ComboBox comboSpe;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Button btnquite;
        private System.Windows.Forms.Button btnfunction;
        private System.Windows.Forms.Button btnage;
        private System.Windows.Forms.Button btnsexe;
        private System.Windows.Forms.GroupBox grpInfosPatient;
        private System.Windows.Forms.GroupBox grpactions;
        private System.Windows.Forms.GroupBox grplistepatient;
        private System.Windows.Forms.TextBox textAdresse;
    }
}