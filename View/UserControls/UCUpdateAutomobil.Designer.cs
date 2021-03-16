
namespace View.UserControls
{
    partial class UCUpdateAutomobil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchBrSasije = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchRegistracija = new System.Windows.Forms.Button();
            this.cbAutomobili = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMarkaUpdate = new System.Windows.Forms.ComboBox();
            this.cbModelUpdate = new System.Windows.Forms.ComboBox();
            this.txtRegistracijaUpdate = new System.Windows.Forms.TextBox();
            this.txtCenaUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGodisteUpdate = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.lblGodiste = new System.Windows.Forms.Label();
            this.lblCenaPoDanu = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBrojSasije);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSearchBrSasije);
            this.groupBox2.Location = new System.Drawing.Point(3, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 97);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po broju sasije";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(77, 47);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(164, 20);
            this.txtBrojSasije.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj sasije:";
            // 
            // btnSearchBrSasije
            // 
            this.btnSearchBrSasije.Location = new System.Drawing.Point(254, 32);
            this.btnSearchBrSasije.Name = "btnSearchBrSasije";
            this.btnSearchBrSasije.Size = new System.Drawing.Size(75, 49);
            this.btnSearchBrSasije.TabIndex = 0;
            this.btnSearchBrSasije.Text = "Pretrazi";
            this.btnSearchBrSasije.UseVisualStyleBackColor = true;
            this.btnSearchBrSasije.Click += new System.EventHandler(this.btnSearchBrSasije_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegistracija);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchRegistracija);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po registraciji";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(77, 37);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(164, 20);
            this.txtRegistracija.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registracija:";
            // 
            // btnSearchRegistracija
            // 
            this.btnSearchRegistracija.Location = new System.Drawing.Point(254, 22);
            this.btnSearchRegistracija.Name = "btnSearchRegistracija";
            this.btnSearchRegistracija.Size = new System.Drawing.Size(75, 49);
            this.btnSearchRegistracija.TabIndex = 0;
            this.btnSearchRegistracija.Text = "Pretrazi";
            this.btnSearchRegistracija.UseVisualStyleBackColor = true;
            this.btnSearchRegistracija.Click += new System.EventHandler(this.btnSearchRegistracija_Click);
            // 
            // cbAutomobili
            // 
            this.cbAutomobili.FormattingEnabled = true;
            this.cbAutomobili.Location = new System.Drawing.Point(4, 30);
            this.cbAutomobili.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutomobili.Name = "cbAutomobili";
            this.cbAutomobili.Size = new System.Drawing.Size(214, 21);
            this.cbAutomobili.TabIndex = 6;
            this.cbAutomobili.SelectionChangeCommitted += new System.EventHandler(this.cbAutomobili_SelectionChangeCommitted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAutomobili);
            this.groupBox3.Location = new System.Drawing.Point(361, 11);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(222, 173);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Automobil";
            // 
            // cbMarkaUpdate
            // 
            this.cbMarkaUpdate.FormattingEnabled = true;
            this.cbMarkaUpdate.Location = new System.Drawing.Point(100, 227);
            this.cbMarkaUpdate.Name = "cbMarkaUpdate";
            this.cbMarkaUpdate.Size = new System.Drawing.Size(144, 21);
            this.cbMarkaUpdate.TabIndex = 8;
            this.cbMarkaUpdate.SelectionChangeCommitted += new System.EventHandler(this.cbMarkaUpdate_SelectionChangeCommitted);
            // 
            // cbModelUpdate
            // 
            this.cbModelUpdate.FormattingEnabled = true;
            this.cbModelUpdate.Location = new System.Drawing.Point(100, 272);
            this.cbModelUpdate.Name = "cbModelUpdate";
            this.cbModelUpdate.Size = new System.Drawing.Size(144, 21);
            this.cbModelUpdate.TabIndex = 9;
            // 
            // txtRegistracijaUpdate
            // 
            this.txtRegistracijaUpdate.Location = new System.Drawing.Point(100, 313);
            this.txtRegistracijaUpdate.Name = "txtRegistracijaUpdate";
            this.txtRegistracijaUpdate.Size = new System.Drawing.Size(144, 20);
            this.txtRegistracijaUpdate.TabIndex = 11;
            // 
            // txtCenaUpdate
            // 
            this.txtCenaUpdate.Location = new System.Drawing.Point(100, 389);
            this.txtCenaUpdate.Name = "txtCenaUpdate";
            this.txtCenaUpdate.Size = new System.Drawing.Size(144, 20);
            this.txtCenaUpdate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Marka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Registracija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Godiste:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 392);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cena po danu";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(491, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 49);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Izmeni automobil";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Model:";
            // 
            // cbGodisteUpdate
            // 
            this.cbGodisteUpdate.FormattingEnabled = true;
            this.cbGodisteUpdate.Location = new System.Drawing.Point(100, 354);
            this.cbGodisteUpdate.Name = "cbGodisteUpdate";
            this.cbGodisteUpdate.Size = new System.Drawing.Size(144, 21);
            this.cbGodisteUpdate.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(491, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 49);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Obrisi automobil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.BackColor = System.Drawing.SystemColors.Control;
            this.lblMarka.ForeColor = System.Drawing.Color.Red;
            this.lblMarka.Location = new System.Drawing.Point(271, 232);
            this.lblMarka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(0, 13);
            this.lblMarka.TabIndex = 22;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.SystemColors.Control;
            this.lblModel.ForeColor = System.Drawing.Color.Red;
            this.lblModel.Location = new System.Drawing.Point(271, 275);
            this.lblModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 13);
            this.lblModel.TabIndex = 23;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.BackColor = System.Drawing.SystemColors.Control;
            this.lblRegistracija.ForeColor = System.Drawing.Color.Red;
            this.lblRegistracija.Location = new System.Drawing.Point(271, 315);
            this.lblRegistracija.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(0, 13);
            this.lblRegistracija.TabIndex = 24;
            // 
            // lblGodiste
            // 
            this.lblGodiste.AutoSize = true;
            this.lblGodiste.BackColor = System.Drawing.SystemColors.Control;
            this.lblGodiste.ForeColor = System.Drawing.Color.Red;
            this.lblGodiste.Location = new System.Drawing.Point(271, 357);
            this.lblGodiste.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGodiste.Name = "lblGodiste";
            this.lblGodiste.Size = new System.Drawing.Size(0, 13);
            this.lblGodiste.TabIndex = 25;
            // 
            // lblCenaPoDanu
            // 
            this.lblCenaPoDanu.AutoSize = true;
            this.lblCenaPoDanu.BackColor = System.Drawing.SystemColors.Control;
            this.lblCenaPoDanu.ForeColor = System.Drawing.Color.Red;
            this.lblCenaPoDanu.Location = new System.Drawing.Point(271, 392);
            this.lblCenaPoDanu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCenaPoDanu.Name = "lblCenaPoDanu";
            this.lblCenaPoDanu.Size = new System.Drawing.Size(0, 13);
            this.lblCenaPoDanu.TabIndex = 26;
            // 
            // UCUpdateAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCenaPoDanu);
            this.Controls.Add(this.lblGodiste);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbGodisteUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCenaUpdate);
            this.Controls.Add(this.txtRegistracijaUpdate);
            this.Controls.Add(this.cbModelUpdate);
            this.Controls.Add(this.cbMarkaUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UCUpdateAutomobil";
            this.Size = new System.Drawing.Size(599, 505);
            this.Load += new System.EventHandler(this.UCUpdateAutomobil_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchBrSasije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchRegistracija;
        private System.Windows.Forms.ComboBox cbAutomobili;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbMarkaUpdate;
        private System.Windows.Forms.ComboBox cbModelUpdate;
        private System.Windows.Forms.TextBox txtRegistracijaUpdate;
        private System.Windows.Forms.TextBox txtCenaUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGodisteUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Label lblGodiste;
        private System.Windows.Forms.Label lblCenaPoDanu;
    }
}
