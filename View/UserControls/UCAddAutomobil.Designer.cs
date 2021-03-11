
namespace View.UserControls
{
    partial class UCAddAutomobil
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
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.cbGodiste = new System.Windows.Forms.ComboBox();
            this.txtCenaPoDanu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblBrojSasije = new System.Windows.Forms.Label();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.lblGodinaProizvodnje = new System.Windows.Forms.Label();
            this.lblCenaPoDanu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbMarka
            // 
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(193, 119);
            this.cbMarka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(239, 24);
            this.cbMarka.TabIndex = 0;
            this.cbMarka.SelectedIndexChanged += new System.EventHandler(this.cbMarka_SelectedIndexChanged);
            this.cbMarka.SelectionChangeCommitted += new System.EventHandler(this.cbMarka_SelectionChangeCommitted);
            // 
            // cbModel
            // 
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(193, 192);
            this.cbModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(239, 24);
            this.cbModel.TabIndex = 1;
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(193, 265);
            this.txtBrojSasije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(239, 22);
            this.txtBrojSasije.TabIndex = 2;
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(193, 330);
            this.txtRegistracija.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(239, 22);
            this.txtRegistracija.TabIndex = 3;
            // 
            // cbGodiste
            // 
            this.cbGodiste.FormattingEnabled = true;
            this.cbGodiste.Location = new System.Drawing.Point(193, 394);
            this.cbGodiste.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbGodiste.Name = "cbGodiste";
            this.cbGodiste.Size = new System.Drawing.Size(239, 24);
            this.cbGodiste.TabIndex = 4;
            // 
            // txtCenaPoDanu
            // 
            this.txtCenaPoDanu.Location = new System.Drawing.Point(193, 463);
            this.txtCenaPoDanu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCenaPoDanu.Name = "txtCenaPoDanu";
            this.txtCenaPoDanu.Size = new System.Drawing.Size(239, 22);
            this.txtCenaPoDanu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 195);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Broj sasije";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Registracija";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 397);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Godina proizvodnje";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 466);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cena po danu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(368, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dodavanje novog automobila";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.Location = new System.Drawing.Point(143, 525);
            this.btnSacuvaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(177, 52);
            this.btnSacuvaj.TabIndex = 13;
            this.btnSacuvaj.Text = "Sacuvaj automobil";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.ForeColor = System.Drawing.Color.Red;
            this.lblMarka.Location = new System.Drawing.Point(461, 119);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(0, 17);
            this.lblMarka.TabIndex = 14;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.ForeColor = System.Drawing.Color.Red;
            this.lblModel.Location = new System.Drawing.Point(461, 195);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(0, 17);
            this.lblModel.TabIndex = 15;
            // 
            // lblBrojSasije
            // 
            this.lblBrojSasije.AutoSize = true;
            this.lblBrojSasije.ForeColor = System.Drawing.Color.Red;
            this.lblBrojSasije.Location = new System.Drawing.Point(461, 268);
            this.lblBrojSasije.Name = "lblBrojSasije";
            this.lblBrojSasije.Size = new System.Drawing.Size(0, 17);
            this.lblBrojSasije.TabIndex = 16;
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.ForeColor = System.Drawing.Color.Red;
            this.lblRegistracija.Location = new System.Drawing.Point(461, 334);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(0, 17);
            this.lblRegistracija.TabIndex = 17;
            // 
            // lblGodinaProizvodnje
            // 
            this.lblGodinaProizvodnje.AutoSize = true;
            this.lblGodinaProizvodnje.ForeColor = System.Drawing.Color.Red;
            this.lblGodinaProizvodnje.Location = new System.Drawing.Point(461, 397);
            this.lblGodinaProizvodnje.Name = "lblGodinaProizvodnje";
            this.lblGodinaProizvodnje.Size = new System.Drawing.Size(0, 17);
            this.lblGodinaProizvodnje.TabIndex = 18;
            // 
            // lblCenaPoDanu
            // 
            this.lblCenaPoDanu.AutoSize = true;
            this.lblCenaPoDanu.ForeColor = System.Drawing.Color.Red;
            this.lblCenaPoDanu.Location = new System.Drawing.Point(461, 466);
            this.lblCenaPoDanu.Name = "lblCenaPoDanu";
            this.lblCenaPoDanu.Size = new System.Drawing.Size(0, 17);
            this.lblCenaPoDanu.TabIndex = 19;
            // 
            // UCAddAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCenaPoDanu);
            this.Controls.Add(this.lblGodinaProizvodnje);
            this.Controls.Add(this.lblRegistracija);
            this.Controls.Add(this.lblBrojSasije);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCenaPoDanu);
            this.Controls.Add(this.cbGodiste);
            this.Controls.Add(this.txtRegistracija);
            this.Controls.Add(this.txtBrojSasije);
            this.Controls.Add(this.cbModel);
            this.Controls.Add(this.cbMarka);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCAddAutomobil";
            this.Size = new System.Drawing.Size(809, 614);
            this.Load += new System.EventHandler(this.UCAddAutomobil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.ComboBox cbGodiste;
        private System.Windows.Forms.TextBox txtCenaPoDanu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblBrojSasije;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Label lblGodinaProizvodnje;
        private System.Windows.Forms.Label lblCenaPoDanu;
    }
}
