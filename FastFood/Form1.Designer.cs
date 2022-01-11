
namespace FastFood
{
    partial class Form1
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
            this.btnRes1 = new System.Windows.Forms.Button();
            this.btnRes2 = new System.Windows.Forms.Button();
            this.btnRes3 = new System.Windows.Forms.Button();
            this.btnRes4 = new System.Windows.Forms.Button();
            this.btnNaruci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRes1
            // 
            this.btnRes1.Location = new System.Drawing.Point(81, 60);
            this.btnRes1.Name = "btnRes1";
            this.btnRes1.Size = new System.Drawing.Size(151, 45);
            this.btnRes1.TabIndex = 0;
            this.btnRes1.Text = "Restoran 1";
            this.btnRes1.UseVisualStyleBackColor = true;
            this.btnRes1.Click += new System.EventHandler(this.btnRes1_Click);
            // 
            // btnRes2
            // 
            this.btnRes2.Location = new System.Drawing.Point(81, 133);
            this.btnRes2.Name = "btnRes2";
            this.btnRes2.Size = new System.Drawing.Size(151, 45);
            this.btnRes2.TabIndex = 1;
            this.btnRes2.Text = "Restoran 2";
            this.btnRes2.UseVisualStyleBackColor = true;
            this.btnRes2.Click += new System.EventHandler(this.btnRes2_Click);
            // 
            // btnRes3
            // 
            this.btnRes3.Location = new System.Drawing.Point(81, 210);
            this.btnRes3.Name = "btnRes3";
            this.btnRes3.Size = new System.Drawing.Size(151, 45);
            this.btnRes3.TabIndex = 2;
            this.btnRes3.Text = "Restoran 3";
            this.btnRes3.UseVisualStyleBackColor = true;
            this.btnRes3.Click += new System.EventHandler(this.btnRes3_Click);
            // 
            // btnRes4
            // 
            this.btnRes4.Location = new System.Drawing.Point(81, 291);
            this.btnRes4.Name = "btnRes4";
            this.btnRes4.Size = new System.Drawing.Size(151, 45);
            this.btnRes4.TabIndex = 3;
            this.btnRes4.Text = "Restoran 4";
            this.btnRes4.UseVisualStyleBackColor = true;
            this.btnRes4.Click += new System.EventHandler(this.btnRes4_Click);
            // 
            // btnNaruci
            // 
            this.btnNaruci.Location = new System.Drawing.Point(576, 173);
            this.btnNaruci.Name = "btnNaruci";
            this.btnNaruci.Size = new System.Drawing.Size(114, 40);
            this.btnNaruci.TabIndex = 5;
            this.btnNaruci.Text = "Naruči!";
            this.btnNaruci.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNaruci);
            this.Controls.Add(this.btnRes4);
            this.Controls.Add(this.btnRes3);
            this.Controls.Add(this.btnRes2);
            this.Controls.Add(this.btnRes1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRes1;
        private System.Windows.Forms.Button btnRes2;
        private System.Windows.Forms.Button btnRes3;
        private System.Windows.Forms.Button btnRes4;
        private System.Windows.Forms.Button btnNaruci;
    }
}

