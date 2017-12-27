namespace Fractals_Summative
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
            this.mandelBrotPictureBox = new System.Windows.Forms.PictureBox();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mandelBrotPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mandelBrotPictureBox
            // 
            this.mandelBrotPictureBox.Location = new System.Drawing.Point(12, 12);
            this.mandelBrotPictureBox.Name = "mandelBrotPictureBox";
            this.mandelBrotPictureBox.Size = new System.Drawing.Size(800, 600);
            this.mandelBrotPictureBox.TabIndex = 0;
            this.mandelBrotPictureBox.TabStop = false;
            this.mandelBrotPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.mandelBrotPictureBox_Paint);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(819, 166);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(145, 60);
            this.generateButton.TabIndex = 1;
            this.generateButton.Text = "button1";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 645);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.mandelBrotPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mandelBrotPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox mandelBrotPictureBox;
        private System.Windows.Forms.Button generateButton;
    }
}

