using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtNumber.Text = Properties.Settings.Default.word.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word="";
            try 
            {
                word = this.txtNumber.Text; 
            }
             catch (FormatException) {
                MessageBox.Show("Поле ввода пустое!!!");
                return;
            }
            Properties.Settings.Default.word = word;
            Properties.Settings.Default.Save();
            MessageBox.Show(Logic.Rearrangement(word));
        }
        public class Logic
        {
            public static string Rearrangement(string word)
            {
                var outPut = "";
                if (word.Length % 2 == 0)
                {
                    for (int i = 0; i < word.Length - 1; i += 2)
                    {
                        outPut = outPut + word[i + 1] + word[i];

                    }

                }
                else { outPut = "Введено неверное слово, перезапустите программу и повторите попытку"; }

                return outPut;
            }
        }

    }
}