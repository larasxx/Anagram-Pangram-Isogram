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
            //string inputWord = txtInputWord.Text;
            //string anagram = AnagramGenerator.CreateAnagram(inputWord);
            //txtOutput.Text = $"Anagram: {anagram}";
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
    }
}
