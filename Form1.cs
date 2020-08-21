using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetterChaos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char[] textArr = text.ToCharArray();
            Random rnd = new Random();
            for (int i = 0; i < textArr.Length; i++)
            {
                richTextBox1.SelectionFont = new Font(fontSwitch(rnd.Next(1, 9)), 12);
                richTextBox1.SelectedText = textArr[i].ToString();
            }
        }

        public string fontSwitch(int rnd)
        {
            switch (rnd)
            {
                case 1:
                    return "Palatino Linotype";
                case 2:
                    return "Lucida Console";
                case 3:
                    return "Arial Italic";
                case 4:
                    return "Calibri Bold";
                case 5:
                    return "Comic Sans MS";
                case 6:
                    return "Constantia";
                case 7:
                    return "Franklin Gothic Medium";
                case 8:
                    return "Impact";
                case 9:
                    return "Microsoft Himalaya";
                default:
                    return "Microsoft Sans Serif";
            }
        }
    }
}
