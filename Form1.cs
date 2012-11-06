using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anagram
{
    public partial class Form1 : Form
    {
        // Determine if Word 2 is an anagram of Word 1.
        // Ignore spaces and capitalization.
        // Ex: mary is an anagram of army

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsAnagram_Click(object sender, EventArgs e)
        {
            var w1 = txtWord1.Text.Trim().Replace(" ", "").ToArray().OrderBy(a => a);
            var w2 = txtWord2.Text.Trim().Replace(" ", "").ToArray().OrderBy(a => a);
            string word1 = ArrayToString(w1.ToArray());
            string word2 = ArrayToString(w2.ToArray());

            if (word1 == word2)
                MessageBox.Show(txtWord2.Text + " is an anagram of " + txtWord1.Text);
            else
                MessageBox.Show(txtWord2.Text + " is NOT an anagram of " + txtWord1.Text);

        }

        private string ArrayToString(char[] Arr)
        {
            string s = "";
            foreach (char c in Arr)
                s += c;

            return s;
        }
    }
}
