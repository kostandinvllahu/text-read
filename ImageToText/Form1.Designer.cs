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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictarget)).BeginInit();
            this.SuspendLayout();
            // 
            // pictarget
            // 
            this.pictarget.Location = new System.Drawing.Point(75, 63);
            this.pictarget.Name = "pictarget";
            this.pictarget.Size = new System.Drawing.Size(376, 176);
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
            this.txtOutput.ReadOnly = true;
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
            this.cboCamera.SelectedIndexChanged += new System.EventHandler(this.cboCamera_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Flip Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(695, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

