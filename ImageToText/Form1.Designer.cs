namespace ImageToText
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
            this.pictarget = new System.Windows.Forms.PictureBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCamera = new System.Windows.Forms.Button();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).BeginInit();
            this.SuspendLayout();
            // 
            // pictarget
            // 
            this.pictarget.Location = new System.Drawing.Point(75, 63);
            this.pictarget.Name = "pictarget";
            this.pictarget.Size = new System.Drawing.Size(547, 191);
            this.pictarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictarget.TabIndex = 0;
            this.pictarget.TabStop = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(225, 260);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(237, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(225, 308);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(237, 130);
            this.txtOutput.TabIndex = 2;
            // 
            // btnCamera
            // 
            this.btnCamera.Location = new System.Drawing.Point(497, 260);
            this.btnCamera.Name = "btnCamera";
            this.btnCamera.Size = new System.Drawing.Size(237, 23);
            this.btnCamera.TabIndex = 3;
            this.btnCamera.Text = "Take Picture";
            this.btnCamera.UseVisualStyleBackColor = true;
            this.btnCamera.Click += new System.EventHandler(this.btnCamera_Click);
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(75, 24);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(320, 21);
            this.cboCamera.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.btnCamera);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.pictarget);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictarget;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCamera;
        private System.Windows.Forms.ComboBox cboCamera;
    }
}

