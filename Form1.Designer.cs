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
            this.buttonGoToForm2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PreviousPageBtn = new System.Windows.Forms.Button();
            this.UnicodeConvertion = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 10);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(57, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input word";
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(75, 10);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(100, 20);
            this.txtInputWord.TabIndex = 1;
            // 
            // btnCheckPangram
            // 
            this.btnCheckPangram.Location = new System.Drawing.Point(15, 36);
            this.btnCheckPangram.Name = "btnCheckPangram";
            this.btnCheckPangram.Size = new System.Drawing.Size(105, 23);
            this.btnCheckPangram.TabIndex = 2;
            this.btnCheckPangram.Text = "PangramButton";
            this.btnCheckPangram.UseVisualStyleBackColor = true;
            this.btnCheckPangram.Click += new System.EventHandler(this.btnCheckPangram_Click);
            // 
            // btnCheckIsogram
            // 
            this.btnCheckIsogram.Location = new System.Drawing.Point(126, 36);
            this.btnCheckIsogram.Name = "btnCheckIsogram";
            this.btnCheckIsogram.Size = new System.Drawing.Size(107, 23);
            this.btnCheckIsogram.TabIndex = 3;
            this.btnCheckIsogram.Text = "IsogramButton";
            this.btnCheckIsogram.UseVisualStyleBackColor = true;
            this.btnCheckIsogram.Click += new System.EventHandler(this.btnCheckIsogram_Click);
            // 
            // btnGenerateAnagram
            // 
            this.btnGenerateAnagram.Location = new System.Drawing.Point(75, 65);
            this.btnGenerateAnagram.Name = "btnGenerateAnagram";
            this.btnGenerateAnagram.Size = new System.Drawing.Size(115, 23);
            this.btnGenerateAnagram.TabIndex = 4;
            this.btnGenerateAnagram.Text = "AnagramButton";
            this.btnGenerateAnagram.UseVisualStyleBackColor = true;
            this.btnGenerateAnagram.Click += new System.EventHandler(this.btnGenerateAnagram_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(75, 104);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(133, 56);
            this.txtOutput.TabIndex = 5;
            this.txtOutput.Text = "";
            // 
            // buttonGoToForm2
            // 
            this.buttonGoToForm2.Location = new System.Drawing.Point(722, 5);
            this.buttonGoToForm2.Name = "buttonGoToForm2";
            this.buttonGoToForm2.Size = new System.Drawing.Size(75, 23);
            this.buttonGoToForm2.TabIndex = 6;
            this.buttonGoToForm2.Text = "NextPage";
            this.buttonGoToForm2.UseVisualStyleBackColor = true;
            this.buttonGoToForm2.Click += new System.EventHandler(this.buttonGoToForm2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxInput);
            this.panel1.Controls.Add(this.richTextBoxOutput);
            this.panel1.Controls.Add(this.UnicodeConvertion);
            this.panel1.Controls.Add(this.PreviousPageBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblInput);
            this.panel2.Controls.Add(this.txtInputWord);
            this.panel2.Controls.Add(this.buttonGoToForm2);
            this.panel2.Controls.Add(this.btnCheckPangram);
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Controls.Add(this.btnCheckIsogram);
            this.panel2.Controls.Add(this.btnGenerateAnagram);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 8;
            // 
            // PreviousPageBtn
            // 
            this.PreviousPageBtn.Location = new System.Drawing.Point(3, 12);
            this.PreviousPageBtn.Name = "PreviousPageBtn";
            this.PreviousPageBtn.Size = new System.Drawing.Size(85, 23);
            this.PreviousPageBtn.TabIndex = 10;
            this.PreviousPageBtn.Text = "PreviousPage";
            this.PreviousPageBtn.UseVisualStyleBackColor = true;
            this.PreviousPageBtn.Click += new System.EventHandler(this.PreviousPageBtn_Click);
            // 
            // UnicodeConvertion
            // 
            this.UnicodeConvertion.Location = new System.Drawing.Point(251, 134);
            this.UnicodeConvertion.Name = "UnicodeConvertion";
            this.UnicodeConvertion.Size = new System.Drawing.Size(75, 23);
            this.UnicodeConvertion.TabIndex = 11;
            this.UnicodeConvertion.Text = "Convert";
            this.UnicodeConvertion.UseVisualStyleBackColor = true;
            this.UnicodeConvertion.Click += new System.EventHandler(this.UnicodeConvertion_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(251, 163);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(75, 45);
            this.richTextBoxOutput.TabIndex = 12;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(251, 108);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(93, 20);
            this.textBoxInput.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "UnicodeConversion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Button btnCheckPangram;
        private System.Windows.Forms.Button btnCheckIsogram;
        private System.Windows.Forms.Button btnGenerateAnagram;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Button buttonGoToForm2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button PreviousPageBtn;
        private System.Windows.Forms.Button UnicodeConvertion;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Label label1;
    }
}

