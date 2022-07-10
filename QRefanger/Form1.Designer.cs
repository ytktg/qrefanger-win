namespace QRefanger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelQR = new System.Windows.Forms.Panel();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panelQR.Location = new System.Drawing.Point(3, 145);
            this.panelQR.Name = "panel1";
            this.panelQR.Size = new System.Drawing.Size(400, 200);
            this.panelQR.TabIndex = 0;
            this.panelQR.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox1
            // 
            this.textBoxUrl.Location = new System.Drawing.Point(3, 12);
            this.textBoxUrl.Name = "textBox1";
            this.textBoxUrl.Size = new System.Drawing.Size(797, 39);
            this.textBoxUrl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "QR表示";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(3, 106);
            this.labelUrl.Name = "label1";
            this.labelUrl.Size = new System.Drawing.Size(78, 32);
            this.labelUrl.TabIndex = 3;
            this.labelUrl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 441);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUrl);
            this.Controls.Add(this.panelQR);
            this.Name = "Form1";
            this.Text = "QRefanger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelQR;
        private TextBox textBoxUrl;
        private Button button1;
        private Label labelUrl;
    }
}