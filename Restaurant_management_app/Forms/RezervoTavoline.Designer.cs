namespace Restaurant_management_app
{
    partial class RezervoTavoline
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
            this.cmbTavolinat = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNr = new System.Windows.Forms.TextBox();
            this.btnKerko = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tavolinat e lira";
            // 
            // cmbTavolinat
            // 
            this.cmbTavolinat.FormattingEnabled = true;
            this.cmbTavolinat.Location = new System.Drawing.Point(115, 153);
            this.cmbTavolinat.Name = "cmbTavolinat";
            this.cmbTavolinat.Size = new System.Drawing.Size(121, 21);
            this.cmbTavolinat.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data e rezervimit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numri i karrikave";
            // 
            // txbNr
            // 
            this.txbNr.Location = new System.Drawing.Point(115, 70);
            this.txbNr.Name = "txbNr";
            this.txbNr.Size = new System.Drawing.Size(121, 20);
            this.txbNr.TabIndex = 5;
            // 
            // btnKerko
            // 
            this.btnKerko.Location = new System.Drawing.Point(128, 99);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(88, 42);
            this.btnKerko.TabIndex = 7;
            this.btnKerko.Text = "button1";
            this.btnKerko.UseVisualStyleBackColor = true;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // RezervoTavoline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 304);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbTavolinat);
            this.Controls.Add(this.label1);
            this.Name = "RezervoTavoline";
            this.Text = "RezervoTavoline";
            this.Load += new System.EventHandler(this.RezervoTavoline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTavolinat;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNr;
        private System.Windows.Forms.Button btnKerko;
    }
}