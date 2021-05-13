
namespace kusanovicLenardSpremanjePrikazFiltriranjeXML
{
    partial class Pregled_podataka
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
            this.btnUcitaj = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnUcitaj
            // 
            this.btnUcitaj.Location = new System.Drawing.Point(22, 12);
            this.btnUcitaj.Name = "btnUcitaj";
            this.btnUcitaj.Size = new System.Drawing.Size(96, 23);
            this.btnUcitaj.TabIndex = 0;
            this.btnUcitaj.Text = "Ucitaj dokument";
            this.btnUcitaj.UseVisualStyleBackColor = true;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(213, 12);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 1;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(396, 12);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(459, 264);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // Pregled_podataka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnUcitaj);
            this.Name = "Pregled_podataka";
            this.Text = "Pregled_podataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcitaj;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}