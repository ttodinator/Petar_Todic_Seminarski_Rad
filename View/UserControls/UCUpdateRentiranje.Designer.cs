
namespace View.UserControls
{
    partial class UCUpdateRentiranje
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBPrezime = new System.Windows.Forms.RadioButton();
            this.rBIme = new System.Windows.Forms.RadioButton();
            this.txtPretragaImePrezime = new System.Windows.Forms.TextBox();
            this.btnSearchImePrezime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchDatum = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPretraga = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblMusterija = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvStavkeRentiranja = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMusterija = new System.Windows.Forms.ComboBox();
            this.lblDatumShow = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRentiranja)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBPrezime);
            this.groupBox1.Controls.Add(this.rBIme);
            this.groupBox1.Controls.Add(this.txtPretragaImePrezime);
            this.groupBox1.Controls.Add(this.btnSearchImePrezime);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po imenu musterije";
            // 
            // rBPrezime
            // 
            this.rBPrezime.AutoSize = true;
            this.rBPrezime.Location = new System.Drawing.Point(16, 85);
            this.rBPrezime.Name = "rBPrezime";
            this.rBPrezime.Size = new System.Drawing.Size(80, 21);
            this.rBPrezime.TabIndex = 4;
            this.rBPrezime.TabStop = true;
            this.rBPrezime.Text = "Prezime";
            this.rBPrezime.UseVisualStyleBackColor = true;
            // 
            // rBIme
            // 
            this.rBIme.AutoSize = true;
            this.rBIme.Location = new System.Drawing.Point(16, 35);
            this.rBIme.Name = "rBIme";
            this.rBIme.Size = new System.Drawing.Size(51, 21);
            this.rBIme.TabIndex = 3;
            this.rBIme.TabStop = true;
            this.rBIme.Text = "Ime";
            this.rBIme.UseVisualStyleBackColor = true;
            // 
            // txtPretragaImePrezime
            // 
            this.txtPretragaImePrezime.Location = new System.Drawing.Point(148, 59);
            this.txtPretragaImePrezime.Name = "txtPretragaImePrezime";
            this.txtPretragaImePrezime.Size = new System.Drawing.Size(209, 22);
            this.txtPretragaImePrezime.TabIndex = 2;
            // 
            // btnSearchImePrezime
            // 
            this.btnSearchImePrezime.Location = new System.Drawing.Point(380, 49);
            this.btnSearchImePrezime.Name = "btnSearchImePrezime";
            this.btnSearchImePrezime.Size = new System.Drawing.Size(92, 43);
            this.btnSearchImePrezime.TabIndex = 1;
            this.btnSearchImePrezime.Text = "Pretrazi";
            this.btnSearchImePrezime.UseVisualStyleBackColor = true;
            this.btnSearchImePrezime.Click += new System.EventHandler(this.btnSearchImePrezime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpDatum);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSearchDatum);
            this.groupBox2.Location = new System.Drawing.Point(26, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po datumu";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(148, 46);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum:";
            // 
            // btnSearchDatum
            // 
            this.btnSearchDatum.Location = new System.Drawing.Point(380, 38);
            this.btnSearchDatum.Name = "btnSearchDatum";
            this.btnSearchDatum.Size = new System.Drawing.Size(92, 43);
            this.btnSearchDatum.TabIndex = 0;
            this.btnSearchDatum.Text = "Pretrazi";
            this.btnSearchDatum.UseVisualStyleBackColor = true;
            this.btnSearchDatum.Click += new System.EventHandler(this.btnSearchDatum_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPretraga);
            this.groupBox3.Location = new System.Drawing.Point(543, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga";
            // 
            // cbPretraga
            // 
            this.cbPretraga.FormattingEnabled = true;
            this.cbPretraga.Location = new System.Drawing.Point(48, 39);
            this.cbPretraga.Name = "cbPretraga";
            this.cbPretraga.Size = new System.Drawing.Size(399, 24);
            this.cbPretraga.TabIndex = 0;
            this.cbPretraga.SelectionChangeCommitted += new System.EventHandler(this.cbPretraga_SelectionChangeCommitted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDatumShow);
            this.groupBox4.Controls.Add(this.lblDatum);
            this.groupBox4.Controls.Add(this.lblMusterija);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.dgvStavkeRentiranja);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblUkupnaCena);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cbMusterija);
            this.groupBox4.Location = new System.Drawing.Point(26, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1042, 564);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.Red;
            this.lblDatum.Location = new System.Drawing.Point(405, 85);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 16;
            // 
            // lblMusterija
            // 
            this.lblMusterija.AutoSize = true;
            this.lblMusterija.ForeColor = System.Drawing.Color.Red;
            this.lblMusterija.Location = new System.Drawing.Point(30, 85);
            this.lblMusterija.Name = "lblMusterija";
            this.lblMusterija.Size = new System.Drawing.Size(0, 17);
            this.lblMusterija.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Izbaci stavku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Dodaj stavku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(933, 230);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 60);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Izmeni rentiranje";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvStavkeRentiranja
            // 
            this.dgvStavkeRentiranja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeRentiranja.Location = new System.Drawing.Point(33, 173);
            this.dgvStavkeRentiranja.Name = "dgvStavkeRentiranja";
            this.dgvStavkeRentiranja.RowHeadersWidth = 51;
            this.dgvStavkeRentiranja.RowTemplate.Height = 24;
            this.dgvStavkeRentiranja.Size = new System.Drawing.Size(894, 361);
            this.dgvStavkeRentiranja.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Musterija:";
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Location = new System.Drawing.Point(867, 47);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(0, 17);
            this.lblUkupnaCena.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(736, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ukupna cena:";
            // 
            // cbMusterija
            // 
            this.cbMusterija.FormattingEnabled = true;
            this.cbMusterija.Location = new System.Drawing.Point(105, 44);
            this.cbMusterija.Name = "cbMusterija";
            this.cbMusterija.Size = new System.Drawing.Size(243, 24);
            this.cbMusterija.TabIndex = 1;
            // 
            // lblDatumShow
            // 
            this.lblDatumShow.AutoSize = true;
            this.lblDatumShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDatumShow.Location = new System.Drawing.Point(472, 47);
            this.lblDatumShow.Name = "lblDatumShow";
            this.lblDatumShow.Size = new System.Drawing.Size(0, 17);
            this.lblDatumShow.TabIndex = 17;
            // 
            // UCUpdateRentiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCUpdateRentiranje";
            this.Size = new System.Drawing.Size(1149, 855);
            this.Load += new System.EventHandler(this.UCUpdateRentiranje_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeRentiranja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBPrezime;
        private System.Windows.Forms.RadioButton rBIme;
        private System.Windows.Forms.TextBox txtPretragaImePrezime;
        private System.Windows.Forms.Button btnSearchImePrezime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchDatum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPretraga;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvStavkeRentiranja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMusterija;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblMusterija;
        private System.Windows.Forms.Label lblDatumShow;
    }
}
