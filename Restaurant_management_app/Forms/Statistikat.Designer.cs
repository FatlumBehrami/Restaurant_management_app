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
            this.components = new System.ComponentModel.Container();
            this.lblProduktetMTPorositura = new System.Windows.Forms.Label();
            this.btnShfaqProduktin = new System.Windows.Forms.Button();
            this.txbStatistikat = new System.Windows.Forms.TextBox();
            this.porosiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaEPorosiveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.porosiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEPorosiveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).BeginInit();
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
            // btnShfaqProduktin
            // 
            this.btnShfaqProduktin.Location = new System.Drawing.Point(193, 39);
            this.btnShfaqProduktin.Name = "btnShfaqProduktin";
            this.btnShfaqProduktin.Size = new System.Drawing.Size(75, 23);
            this.btnShfaqProduktin.TabIndex = 1;
            this.btnShfaqProduktin.Text = "Shfaq";
            this.btnShfaqProduktin.UseVisualStyleBackColor = true;
            this.btnShfaqProduktin.Click += new System.EventHandler(this.btnShfaqProduktin_Click);
            // 
            // txbStatistikat
            // 
            this.txbStatistikat.Location = new System.Drawing.Point(39, 68);
            this.txbStatistikat.Multiline = true;
            this.txbStatistikat.Name = "txbStatistikat";
            this.txbStatistikat.ReadOnly = true;
            this.txbStatistikat.Size = new System.Drawing.Size(373, 24);
            this.txbStatistikat.TabIndex = 2;
            // 
            // porosiaBindingSource
            // 
            this.porosiaBindingSource.DataSource = typeof(Restaurant_management_app.Porosia);
            // 
            // listaEPorosiveBindingSource
            // 
            this.listaEPorosiveBindingSource.DataSource = typeof(Restaurant_management_app.ListaEPorosive);
            // 
            // klientiBindingSource
            // 
            // 
            // Statistikat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 365);
            this.Controls.Add(this.txbStatistikat);
            this.Controls.Add(this.btnShfaqProduktin);
            this.Controls.Add(this.lblProduktetMTPorositura);
            this.Name = "Statistikat";
            this.Text = "Statistikat";
            ((System.ComponentModel.ISupportInitialize)(this.porosiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaEPorosiveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klientiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduktetMTPorositura;
        private System.Windows.Forms.Button btnShfaqProduktin;
        private System.Windows.Forms.TextBox txbStatistikat;
        private System.Windows.Forms.BindingSource listaEPorosiveBindingSource;
        private System.Windows.Forms.BindingSource klientiBindingSource;
        private System.Windows.Forms.BindingSource porosiaBindingSource;
    }
}