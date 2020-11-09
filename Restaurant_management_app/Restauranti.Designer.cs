namespace Restaurant_management_app
{
    partial class Restauranti
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
            this.RegjistroProdukte = new System.Windows.Forms.Button();
            this.btnRegjistroTavolinat = new System.Windows.Forms.Button();
            this.btnRegjistroPorosite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegjistroProdukte
            // 
            this.RegjistroProdukte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RegjistroProdukte.FlatAppearance.BorderSize = 2;
            this.RegjistroProdukte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegjistroProdukte.Location = new System.Drawing.Point(11, 11);
            this.RegjistroProdukte.Margin = new System.Windows.Forms.Padding(2);
            this.RegjistroProdukte.Name = "RegjistroProdukte";
            this.RegjistroProdukte.Size = new System.Drawing.Size(150, 130);
            this.RegjistroProdukte.TabIndex = 0;
            this.RegjistroProdukte.Text = "Regjistro Produkte";
            this.RegjistroProdukte.UseVisualStyleBackColor = true;
            this.RegjistroProdukte.Click += new System.EventHandler(this.RegjistroProdukte_Click);
            // 
            // btnRegjistroTavolinat
            // 
            this.btnRegjistroTavolinat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegjistroTavolinat.FlatAppearance.BorderSize = 2;
            this.btnRegjistroTavolinat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegjistroTavolinat.Location = new System.Drawing.Point(165, 11);
            this.btnRegjistroTavolinat.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegjistroTavolinat.Name = "btnRegjistroTavolinat";
            this.btnRegjistroTavolinat.Size = new System.Drawing.Size(150, 130);
            this.btnRegjistroTavolinat.TabIndex = 1;
            this.btnRegjistroTavolinat.Text = "Regjistro Tavolinat";
            this.btnRegjistroTavolinat.UseVisualStyleBackColor = true;
            this.btnRegjistroTavolinat.Click += new System.EventHandler(this.btnRegjistroTavolinat_Click);
            // 
            // btnRegjistroPorosite
            // 
            this.btnRegjistroPorosite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegjistroPorosite.FlatAppearance.BorderSize = 2;
            this.btnRegjistroPorosite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegjistroPorosite.Location = new System.Drawing.Point(319, 11);
            this.btnRegjistroPorosite.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegjistroPorosite.Name = "btnRegjistroPorosite";
            this.btnRegjistroPorosite.Size = new System.Drawing.Size(150, 130);
            this.btnRegjistroPorosite.TabIndex = 2;
            this.btnRegjistroPorosite.Text = "Regjistro Porosite";
            this.btnRegjistroPorosite.UseVisualStyleBackColor = true;
            this.btnRegjistroPorosite.Click += new System.EventHandler(this.btnRegjistroPorosite_Click);
            // 
            // Restauranti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 401);
            this.Controls.Add(this.btnRegjistroPorosite);
            this.Controls.Add(this.btnRegjistroTavolinat);
            this.Controls.Add(this.RegjistroProdukte);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Restauranti";
            this.Text = "Restauranti";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegjistroProdukte;
        private System.Windows.Forms.Button btnRegjistroTavolinat;
        private System.Windows.Forms.Button btnRegjistroPorosite;
    }
}

