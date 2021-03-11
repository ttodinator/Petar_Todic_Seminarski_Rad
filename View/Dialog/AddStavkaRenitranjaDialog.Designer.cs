
namespace View.Dialog
{
    partial class AddStavkaRenitranjaDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.cbAutomobil = new System.Windows.Forms.ComboBox();
            this.cbPolisa = new System.Windows.Forms.ComboBox();
            this.btnAddStavka = new System.Windows.Forms.Button();
            this.lblAutomobil = new System.Windows.Forms.Label();
            this.lblPolisa = new System.Windows.Forms.Label();
            this.lblDatumDo = new System.Windows.Forms.Label();
            this.lblDatumOd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Redni broj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Automobil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Polisa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Datum od:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Datum do:";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(168, 226);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(228, 22);
            this.dtpDatumOd.TabIndex = 6;
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(168, 281);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(228, 22);
            this.dtpDatumDo.TabIndex = 7;
            // 
            // cbAutomobil
            // 
            this.cbAutomobil.FormattingEnabled = true;
            this.cbAutomobil.Location = new System.Drawing.Point(168, 105);
            this.cbAutomobil.Name = "cbAutomobil";
            this.cbAutomobil.Size = new System.Drawing.Size(228, 24);
            this.cbAutomobil.TabIndex = 8;
            // 
            // cbPolisa
            // 
            this.cbPolisa.FormattingEnabled = true;
            this.cbPolisa.Location = new System.Drawing.Point(168, 161);
            this.cbPolisa.Name = "cbPolisa";
            this.cbPolisa.Size = new System.Drawing.Size(228, 24);
            this.cbPolisa.TabIndex = 9;
            // 
            // btnAddStavka
            // 
            this.btnAddStavka.Location = new System.Drawing.Point(204, 353);
            this.btnAddStavka.Name = "btnAddStavka";
            this.btnAddStavka.Size = new System.Drawing.Size(99, 48);
            this.btnAddStavka.TabIndex = 10;
            this.btnAddStavka.Text = "Dodaj stavku";
            this.btnAddStavka.UseVisualStyleBackColor = true;
            this.btnAddStavka.Click += new System.EventHandler(this.btnAddStavka_Click);
            // 
            // lblAutomobil
            // 
            this.lblAutomobil.AutoSize = true;
            this.lblAutomobil.ForeColor = System.Drawing.Color.Red;
            this.lblAutomobil.Location = new System.Drawing.Point(415, 107);
            this.lblAutomobil.Name = "lblAutomobil";
            this.lblAutomobil.Size = new System.Drawing.Size(0, 17);
            this.lblAutomobil.TabIndex = 11;
            // 
            // lblPolisa
            // 
            this.lblPolisa.AutoSize = true;
            this.lblPolisa.ForeColor = System.Drawing.Color.Red;
            this.lblPolisa.Location = new System.Drawing.Point(415, 164);
            this.lblPolisa.Name = "lblPolisa";
            this.lblPolisa.Size = new System.Drawing.Size(0, 17);
            this.lblPolisa.TabIndex = 12;
            // 
            // lblDatumDo
            // 
            this.lblDatumDo.AutoSize = true;
            this.lblDatumDo.ForeColor = System.Drawing.Color.Red;
            this.lblDatumDo.Location = new System.Drawing.Point(415, 286);
            this.lblDatumDo.Name = "lblDatumDo";
            this.lblDatumDo.Size = new System.Drawing.Size(0, 17);
            this.lblDatumDo.TabIndex = 13;
            // 
            // lblDatumOd
            // 
            this.lblDatumOd.AutoSize = true;
            this.lblDatumOd.ForeColor = System.Drawing.Color.Red;
            this.lblDatumOd.Location = new System.Drawing.Point(415, 231);
            this.lblDatumOd.Name = "lblDatumOd";
            this.lblDatumOd.Size = new System.Drawing.Size(0, 17);
            this.lblDatumOd.TabIndex = 14;
            // 
            // AddStavkaRenitranjaDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.lblDatumOd);
            this.Controls.Add(this.lblDatumDo);
            this.Controls.Add(this.lblPolisa);
            this.Controls.Add(this.lblAutomobil);
            this.Controls.Add(this.btnAddStavka);
            this.Controls.Add(this.cbPolisa);
            this.Controls.Add(this.cbAutomobil);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStavkaRenitranjaDialog";
            this.Text = "Stavka rentiranja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.ComboBox cbAutomobil;
        private System.Windows.Forms.ComboBox cbPolisa;
        private System.Windows.Forms.Button btnAddStavka;
        private System.Windows.Forms.Label lblAutomobil;
        private System.Windows.Forms.Label lblPolisa;
        private System.Windows.Forms.Label lblDatumDo;
        private System.Windows.Forms.Label lblDatumOd;
    }
}