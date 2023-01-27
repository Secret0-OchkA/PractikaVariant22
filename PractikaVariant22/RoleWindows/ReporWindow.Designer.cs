namespace PractikaVariant22.RoleWindows
{
    partial class ReporWindow
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
            this.button_CreatePdf = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button_CreatePdf
            // 
            this.button_CreatePdf.Location = new System.Drawing.Point(22, 12);
            this.button_CreatePdf.Name = "button_CreatePdf";
            this.button_CreatePdf.Size = new System.Drawing.Size(75, 23);
            this.button_CreatePdf.TabIndex = 0;
            this.button_CreatePdf.Text = "CreatePdf";
            this.button_CreatePdf.UseVisualStyleBackColor = true;
            this.button_CreatePdf.Click += new System.EventHandler(this.button_CreatePdf_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(22, 80);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // ReporWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 115);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_CreatePdf);
            this.Name = "ReporWindow";
            this.Text = "ReporWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_CreatePdf;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}