namespace Restaurant_management_app
{
    partial class Statistikat
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
            this.lblProduktetMTPorositura = new System.Windows.Forms.Label();
            this.btnShfaq = new System.Windows.Forms.Button();
            this.txbStatistikat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProduktetMTPorositura
            // 
            this.lblProduktetMTPorositura.AutoSize = true;
            this.lblProduktetMTPorositura.Location = new System.Drawing.Point(163, 12);
            this.lblProduktetMTPorositura.Name = "lblProduktetMTPorositura";
            this.lblProduktetMTPorositura.Size = new System.Drawing.Size(131, 13);
            this.lblProduktetMTPorositura.TabIndex = 0;
            this.lblProduktetMTPorositura.Text = "Produktet me te porositura";
            // 
            // btnShfaq
            // 
            this.btnShfaq.Location = new System.Drawing.Point(193, 39);
            this.btnShfaq.Name = "btnShfaq";
            this.btnShfaq.Size = new System.Drawing.Size(75, 23);
            this.btnShfaq.TabIndex = 1;
            this.btnShfaq.Text = "Shfaq";
            this.btnShfaq.UseVisualStyleBackColor = true;
            this.btnShfaq.Click += new System.EventHandler(this.btnShfaq_Click);
            // 
            // txbStatistikat
            // 
            this.txbStatistikat.Location = new System.Drawing.Point(76, 68);
            this.txbStatistikat.Multiline = true;
            this.txbStatistikat.Name = "txbStatistikat";
            this.txbStatistikat.ReadOnly = true;
            this.txbStatistikat.Size = new System.Drawing.Size(309, 279);
            this.txbStatistikat.TabIndex = 2;
            // 
            // Statistikat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.Controls.Add(this.txbStatistikat);
            this.Controls.Add(this.btnShfaq);
            this.Controls.Add(this.lblProduktetMTPorositura);
            this.Name = "Statistikat";
            this.Text = "Statistikat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduktetMTPorositura;
        private System.Windows.Forms.Button btnShfaq;
        private System.Windows.Forms.TextBox txbStatistikat;
    }
}