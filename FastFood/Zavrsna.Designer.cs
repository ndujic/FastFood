
namespace FastFood
{
    partial class Zavrsna
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.lblNacinPlacanja = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtUnosAdrese = new System.Windows.Forms.TextBox();
            this.cmbNacinPlacanja = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(44, 47);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(201, 305);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(183, 401);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(75, 23);
            this.btnNaruci.TabIndex = 1;
            this.btnNaruci.Text = "Naruči!";
            this.btnNaruci.UseVisualStyleBackColor = true;
            this.btnNaruci.Click += new System.EventHandler(this.btnNaruci_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(183, 448);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 2;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // lblNacinPlacanja
            // 
            this.lblNacinPlacanja.AutoSize = true;
            this.lblNacinPlacanja.Location = new System.Drawing.Point(31, 385);
            this.lblNacinPlacanja.Name = "lblNacinPlacanja";
            this.lblNacinPlacanja.Size = new System.Drawing.Size(128, 13);
            this.lblNacinPlacanja.TabIndex = 3;
            this.lblNacinPlacanja.Text = "Odaberite način plaćanja:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(31, 435);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(107, 13);
            this.lblAdresa.TabIndex = 4;
            this.lblAdresa.Text = "Unesite vašu adresu:";
            // 
            // txtUnosAdrese
            // 
            this.txtUnosAdrese.Location = new System.Drawing.Point(34, 451);
            this.txtUnosAdrese.Name = "txtUnosAdrese";
            this.txtUnosAdrese.Size = new System.Drawing.Size(121, 20);
            this.txtUnosAdrese.TabIndex = 5;
            // 
            // cmbNacinPlacanja
            // 
            this.cmbNacinPlacanja.FormattingEnabled = true;
            this.cmbNacinPlacanja.Items.AddRange(new object[] {
            "Gotovina",
            "Kartica"});
            this.cmbNacinPlacanja.Location = new System.Drawing.Point(34, 401);
            this.cmbNacinPlacanja.Name = "cmbNacinPlacanja";
            this.cmbNacinPlacanja.Size = new System.Drawing.Size(121, 21);
            this.cmbNacinPlacanja.TabIndex = 6;
            // 
            // Zavrsna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 532);
            this.Controls.Add(this.cmbNacinPlacanja);
            this.Controls.Add(this.txtUnosAdrese);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNacinPlacanja);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Zavrsna";
            this.Text = "Narudžba";
            this.Load += new System.EventHandler(this.Zavrsna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnNaruci;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label lblNacinPlacanja;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtUnosAdrese;
        private System.Windows.Forms.ComboBox cmbNacinPlacanja;
    }
}