namespace WindowsFormsAppForAnagrams
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
            this.lblInput = new System.Windows.Forms.Label();
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.btnCheckPangram = new System.Windows.Forms.Button();
            this.btnCheckIsogram = new System.Windows.Forms.Button();
            this.btnGenerateAnagram = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(373, 166);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(57, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input word";
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(376, 182);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(100, 20);
            this.txtInputWord.TabIndex = 1;
            // 
            // btnCheckPangram
            // 
            this.btnCheckPangram.Location = new System.Drawing.Point(255, 235);
            this.btnCheckPangram.Name = "btnCheckPangram";
            this.btnCheckPangram.Size = new System.Drawing.Size(105, 23);
            this.btnCheckPangram.TabIndex = 2;
            this.btnCheckPangram.Text = "PangramButton";
            this.btnCheckPangram.UseVisualStyleBackColor = true;
            this.btnCheckPangram.Click += new System.EventHandler(this.btnCheckPangram_Click);
            // 
            // btnCheckIsogram
            // 
            this.btnCheckIsogram.Location = new System.Drawing.Point(376, 235);
            this.btnCheckIsogram.Name = "btnCheckIsogram";
            this.btnCheckIsogram.Size = new System.Drawing.Size(107, 23);
            this.btnCheckIsogram.TabIndex = 3;
            this.btnCheckIsogram.Text = "IsogramButton";
            this.btnCheckIsogram.UseVisualStyleBackColor = true;
            this.btnCheckIsogram.Click += new System.EventHandler(this.btnCheckIsogram_Click);
            // 
            // btnGenerateAnagram
            // 
            this.btnGenerateAnagram.Location = new System.Drawing.Point(519, 235);
            this.btnGenerateAnagram.Name = "btnGenerateAnagram";
            this.btnGenerateAnagram.Size = new System.Drawing.Size(115, 23);
            this.btnGenerateAnagram.TabIndex = 4;
            this.btnGenerateAnagram.Text = "AnagramButton";
            this.btnGenerateAnagram.UseVisualStyleBackColor = true;
            this.btnGenerateAnagram.Click += new System.EventHandler(this.btnGenerateAnagram_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(376, 302);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(133, 56);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnGenerateAnagram);
            this.Controls.Add(this.btnCheckIsogram);
            this.Controls.Add(this.btnCheckPangram);
            this.Controls.Add(this.txtInputWord);
            this.Controls.Add(this.lblInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Button btnCheckPangram;
        private System.Windows.Forms.Button btnCheckIsogram;
        private System.Windows.Forms.Button btnGenerateAnagram;
        private System.Windows.Forms.RichTextBox txtOutput;
    }
}

