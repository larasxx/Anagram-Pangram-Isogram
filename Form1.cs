using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppForAnagrams.Analyzers;

namespace WindowsFormsAppForAnagrams
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }


        private void btnGenerateAnagram_Click(object sender, EventArgs e)
        {
            string inputWord = txtInputWord.Text;
            string anagram = AnagramGenerator.CreateAnagram(inputWord);
            txtOutput.Text = $"Anagram: {anagram}";
        }

        private void btnCheckIsogram_Click(object sender, EventArgs e)
        {
            string inputWord = txtInputWord.Text;
            bool isIsogram = Isogram.IsIsogram(inputWord);
            txtOutput.Text = $"Isogram: {isIsogram}";
        }

        private void btnCheckPangram_Click(object sender, EventArgs e)
        {
            string inputWord = txtInputWord.Text;
            bool isPangram = Pangram.IsPangram(inputWord);
            txtOutput.Text = $"Pangram: {isPangram}";
        }

        private void GnrtAcronym_Click(object sender, EventArgs e)
        {
            string inputWord = txtInputWord.Text;
            string acronym = Acronym.Abbreviate(inputWord);
            txtOutput.Text = $"Acronym: {acronym}";
        }

        private void ReverseString_Click(object sender, EventArgs e)
        {
            string inputWord = txtInputWord.Text;
            string revStr = ReversedString.Reverse(inputWord);
            txtOutput.Text = $"ReversedString: {revStr}";
        }

        private void buttonGoToForm2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true; 
            panel1.Dock = DockStyle.Fill;
        }

        private void buttonConvert__Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                output.AppendFormat("U+{0:X4} ", (int)c);
            }

            richTextBoxOutput.Text = output.ToString();
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible=false;
            panel2.Visible=true;
        }

        private void UnicodeConvertion_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;
            StringBuilder output = new StringBuilder();

            foreach (char c in input)
            {
                output.AppendFormat("U+{0:X4} ", (int)c);
            }

            richTextBoxOutput.Text = output.ToString();
        }

       
    }
}
