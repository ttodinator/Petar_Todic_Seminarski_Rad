
namespace View.UserControls
{
    partial class UCUpdateMusterija
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnIme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPretraga = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPrezime = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblBrojTelefona = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.dtpDatumUpdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBrojUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrezimeUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImeUpdate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.btnIme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(432, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po imenu";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(80, 37);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(203, 22);
            this.txtIme.TabIndex = 3;
            // 
            // btnIme
            // 
            this.btnIme.Location = new System.Drawing.Point(292, 34);
            this.btnIme.Margin = new System.Windows.Forms.Padding(4);
            this.btnIme.Name = "btnIme";
            this.btnIme.Size = new System.Drawing.Size(100, 28);
            this.btnIme.TabIndex = 2;
            this.btnIme.Text = "Pretrazi";
            this.btnIme.UseVisualStyleBackColor = true;
            this.btnIme.Click += new System.EventHandler(this.btnIme_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime:";
            // 
            // cbPretraga
            // 
            this.cbPretraga.FormattingEnabled = true;
            this.cbPretraga.Location = new System.Drawing.Point(516, 60);
            this.cbPretraga.Margin = new System.Windows.Forms.Padding(4);
            this.cbPretraga.Name = "cbPretraga";
            this.cbPretraga.Size = new System.Drawing.Size(313, 24);
            this.cbPretraga.TabIndex = 2;
            this.cbPretraga.SelectionChangeCommitted += new System.EventHandler(this.cbPretraga_SelectionChangeCommitted);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrezime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPrezime);
            this.groupBox2.Location = new System.Drawing.Point(20, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(432, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po prezimenu";
            // 
            // btnPrezime
            // 
            this.btnPrezime.Location = new System.Drawing.Point(292, 36);
            this.btnPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrezime.Name = "btnPrezime";
            this.btnPrezime.Size = new System.Drawing.Size(100, 27);
            this.btnPrezime.TabIndex = 3;
            this.btnPrezime.Text = "Pretrazi";
            this.btnPrezime.UseVisualStyleBackColor = true;
            this.btnPrezime.Click += new System.EventHandler(this.btnPrezime_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(80, 38);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(203, 22);
            this.txtPrezime.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(512, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Musterije:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblDatum);
            this.groupBox3.Controls.Add(this.lblBrojTelefona);
            this.groupBox3.Controls.Add(this.lblPrezime);
            this.groupBox3.Controls.Add(this.lblIme);
            this.groupBox3.Controls.Add(this.dtpDatumUpdate);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBrojUpdate);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtPrezimeUpdate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtImeUpdate);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(20, 261);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(927, 378);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pretraga po imenu";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.Red;
            this.lblDatum.Location = new System.Drawing.Point(362, 185);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 13;
            // 
            // lblBrojTelefona
            // 
            this.lblBrojTelefona.AutoSize = true;
            this.lblBrojTelefona.ForeColor = System.Drawing.Color.Red;
            this.lblBrojTelefona.Location = new System.Drawing.Point(362, 140);
            this.lblBrojTelefona.Name = "lblBrojTelefona";
            this.lblBrojTelefona.Size = new System.Drawing.Size(0, 17);
            this.lblBrojTelefona.TabIndex = 12;
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.ForeColor = System.Drawing.Color.Red;
            this.lblPrezime.Location = new System.Drawing.Point(362, 90);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(0, 17);
            this.lblPrezime.TabIndex = 11;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.Red;
            this.lblIme.Location = new System.Drawing.Point(362, 40);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(0, 17);
            this.lblIme.TabIndex = 10;
            // 
            // dtpDatumUpdate
            // 
            this.dtpDatumUpdate.Location = new System.Drawing.Point(152, 180);
            this.dtpDatumUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDatumUpdate.Name = "dtpDatumUpdate";
            this.dtpDatumUpdate.Size = new System.Drawing.Size(203, 22);
            this.dtpDatumUpdate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 187);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Datum rodjenja";
            // 
            // txtBrojUpdate
            // 
            this.txtBrojUpdate.Location = new System.Drawing.Point(152, 137);
            this.txtBrojUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrojUpdate.Name = "txtBrojUpdate";
            this.txtBrojUpdate.Size = new System.Drawing.Size(203, 22);
            this.txtBrojUpdate.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Broj telefona";
            // 
            // txtPrezimeUpdate
            // 
            this.txtPrezimeUpdate.Location = new System.Drawing.Point(152, 87);
            this.txtPrezimeUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezimeUpdate.Name = "txtPrezimeUpdate";
            this.txtPrezimeUpdate.Size = new System.Drawing.Size(203, 22);
            this.txtPrezimeUpdate.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 91);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prezime:";
            // 
            // txtImeUpdate
            // 
            this.txtImeUpdate.Location = new System.Drawing.Point(152, 37);
            this.txtImeUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.txtImeUpdate.Name = "txtImeUpdate";
            this.txtImeUpdate.Size = new System.Drawing.Size(203, 22);
            this.txtImeUpdate.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 243);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Izmeni musteriju";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ime:";
            // 
            // UCUpdateMusterija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbPretraga);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCUpdateMusterija";
            this.Size = new System.Drawing.Size(976, 831);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbPretraga;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnIme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPrezime;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtImeUpdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBrojUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrezimeUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblBrojTelefona;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
    }
}
