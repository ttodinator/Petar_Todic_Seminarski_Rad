
namespace View.UserControls
{
    partial class UCSearchAutomobil
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
            this.btnSearchRegistracija = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRegistracija = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBrojSasije = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchBrSasije = new System.Windows.Forms.Button();
            this.dgvAutomobil = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchRegistracija
            // 
            this.btnSearchRegistracija.Location = new System.Drawing.Point(371, 22);
            this.btnSearchRegistracija.Name = "btnSearchRegistracija";
            this.btnSearchRegistracija.Size = new System.Drawing.Size(75, 49);
            this.btnSearchRegistracija.TabIndex = 0;
            this.btnSearchRegistracija.Text = "Pretrazi";
            this.btnSearchRegistracija.UseVisualStyleBackColor = true;
            this.btnSearchRegistracija.Click += new System.EventHandler(this.btnSearchRegistracija_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRegistracija);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearchRegistracija);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pretraga po registraciji";
            // 
            // txtRegistracija
            // 
            this.txtRegistracija.Location = new System.Drawing.Point(77, 37);
            this.txtRegistracija.Name = "txtRegistracija";
            this.txtRegistracija.Size = new System.Drawing.Size(267, 20);
            this.txtRegistracija.TabIndex = 2;
            //this.txtRegistracija.TextChanged += new System.EventHandler(this.txtRegistracija_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBrojSasije);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSearchBrSasije);
            this.groupBox2.Location = new System.Drawing.Point(26, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pretraga po broju sasije";
            // 
            // txtBrojSasije
            // 
            this.txtBrojSasije.Location = new System.Drawing.Point(77, 47);
            this.txtBrojSasije.Name = "txtBrojSasije";
            this.txtBrojSasije.Size = new System.Drawing.Size(267, 20);
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
            this.btnSearchBrSasije.Location = new System.Drawing.Point(371, 32);
            this.btnSearchBrSasije.Name = "btnSearchBrSasije";
            this.btnSearchBrSasije.Size = new System.Drawing.Size(75, 49);
            this.btnSearchBrSasije.TabIndex = 0;
            this.btnSearchBrSasije.Text = "Pretrazi";
            this.btnSearchBrSasije.UseVisualStyleBackColor = true;
            this.btnSearchBrSasije.Click += new System.EventHandler(this.btnSearchBrSasije_Click);
            // 
            // dgvAutomobil
            // 
            this.dgvAutomobil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutomobil.Location = new System.Drawing.Point(26, 272);
            this.dgvAutomobil.Name = "dgvAutomobil";
            this.dgvAutomobil.Size = new System.Drawing.Size(613, 196);
            this.dgvAutomobil.TabIndex = 4;
            // 
            // UCSearchAutomobil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAutomobil);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UCSearchAutomobil";
            this.Size = new System.Drawing.Size(659, 488);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutomobil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearchRegistracija;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchBrSasije;
        private System.Windows.Forms.TextBox txtRegistracija;
        private System.Windows.Forms.TextBox txtBrojSasije;
        private System.Windows.Forms.DataGridView dgvAutomobil;
    }
}
