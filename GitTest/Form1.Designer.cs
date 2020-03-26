namespace GitTest
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
            this.txtEnteredText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblResultText = new System.Windows.Forms.Label();
            this.btnDoSomething = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEnteredText
            // 
            this.txtEnteredText.Location = new System.Drawing.Point(96, 30);
            this.txtEnteredText.Name = "txtEnteredText";
            this.txtEnteredText.Size = new System.Drawing.Size(100, 20);
            this.txtEnteredText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Test";
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Location = new System.Drawing.Point(34, 116);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(0, 13);
            this.lblResultText.TabIndex = 2;
            // 
            // btnDoSomething
            // 
            this.btnDoSomething.Location = new System.Drawing.Point(213, 30);
            this.btnDoSomething.Name = "btnDoSomething";
            this.btnDoSomething.Size = new System.Drawing.Size(75, 23);
            this.btnDoSomething.TabIndex = 3;
            this.btnDoSomething.Text = "Press Me";
            this.btnDoSomething.UseVisualStyleBackColor = true;
            this.btnDoSomething.Click += new System.EventHandler(this.btnDoSomething_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoSomething);
            this.Controls.Add(this.lblResultText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEnteredText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEnteredText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.Button btnDoSomething;
    }
}

