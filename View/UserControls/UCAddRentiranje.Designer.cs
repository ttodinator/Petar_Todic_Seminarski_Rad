
namespace View.UserControls
{
    partial class UCAddRentiranje
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
            this.cbMusterija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUkupnaCena = new System.Windows.Forms.Label();
            this.dgvStavka = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveStavka = new System.Windows.Forms.Button();
            this.btnAddStavka = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMusterija = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.lblDatumShow = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavka)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMusterija
            // 
            this.cbMusterija.FormattingEnabled = true;
            this.cbMusterija.Location = new System.Drawing.Point(133, 71);
            this.cbMusterija.Margin = new System.Windows.Forms.Padding(4);
            this.cbMusterija.Name = "cbMusterija";
            this.cbMusterija.Size = new System.Drawing.Size(265, 24);
            this.cbMusterija.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Musterija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ukupna cena:";
            // 
            // lblUkupnaCena
            // 
            this.lblUkupnaCena.AutoSize = true;
            this.lblUkupnaCena.Location = new System.Drawing.Point(183, 201);
            this.lblUkupnaCena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUkupnaCena.Name = "lblUkupnaCena";
            this.lblUkupnaCena.Size = new System.Drawing.Size(0, 17);
            this.lblUkupnaCena.TabIndex = 5;
            // 
            // dgvStavka
            // 
            this.dgvStavka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavka.Location = new System.Drawing.Point(17, 98);
            this.dgvStavka.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStavka.Name = "dgvStavka";
            this.dgvStavka.RowHeadersWidth = 51;
            this.dgvStavka.Size = new System.Drawing.Size(818, 326);
            this.dgvStavka.TabIndex = 6;
            this.dgvStavka.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStavka_CellEndEdit);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveStavka);
            this.groupBox1.Controls.Add(this.btnAddStavka);
            this.groupBox1.Controls.Add(this.dgvStavka);
            this.groupBox1.Location = new System.Drawing.Point(51, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(855, 446);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stavke rentiranja";
            // 
            // btnRemoveStavka
            // 
            this.btnRemoveStavka.Location = new System.Drawing.Point(152, 39);
            this.btnRemoveStavka.Name = "btnRemoveStavka";
            this.btnRemoveStavka.Size = new System.Drawing.Size(98, 43);
            this.btnRemoveStavka.TabIndex = 8;
            this.btnRemoveStavka.Text = "Izbaci stavku";
            this.btnRemoveStavka.UseVisualStyleBackColor = true;
            this.btnRemoveStavka.Click += new System.EventHandler(this.btnRemoveStavka_Click);
            // 
            // btnAddStavka
            // 
            this.btnAddStavka.Location = new System.Drawing.Point(17, 39);
            this.btnAddStavka.Name = "btnAddStavka";
            this.btnAddStavka.Size = new System.Drawing.Size(115, 43);
            this.btnAddStavka.TabIndex = 7;
            this.btnAddStavka.Text = "Dodaj stavku";
            this.btnAddStavka.UseVisualStyleBackColor = true;
            this.btnAddStavka.Click += new System.EventHandler(this.btnAddStavka_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(748, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 64);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sacuvaj Rentiranje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMusterija
            // 
            this.lblMusterija.AutoSize = true;
            this.lblMusterija.ForeColor = System.Drawing.Color.Red;
            this.lblMusterija.Location = new System.Drawing.Point(419, 74);
            this.lblMusterija.Name = "lblMusterija";
            this.lblMusterija.Size = new System.Drawing.Size(0, 17);
            this.lblMusterija.TabIndex = 9;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.ForeColor = System.Drawing.Color.Red;
            this.lblDatum.Location = new System.Drawing.Point(419, 134);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(0, 17);
            this.lblDatum.TabIndex = 10;
            // 
            // lblDatumShow
            // 
            this.lblDatumShow.AutoSize = true;
            this.lblDatumShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDatumShow.Location = new System.Drawing.Point(130, 137);
            this.lblDatumShow.Name = "lblDatumShow";
            this.lblDatumShow.Size = new System.Drawing.Size(0, 17);
            this.lblDatumShow.TabIndex = 11;
            // 
            // UCAddRentiranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDatumShow);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblMusterija);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblUkupnaCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMusterija);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UCAddRentiranje";
            this.Size = new System.Drawing.Size(1036, 729);
            this.Load += new System.EventHandler(this.UCAddRentiranje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavka)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMusterija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUkupnaCena;
        private System.Windows.Forms.DataGridView dgvStavka;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveStavka;
        private System.Windows.Forms.Button btnAddStavka;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMusterija;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.Label lblDatumShow;
    }
}
