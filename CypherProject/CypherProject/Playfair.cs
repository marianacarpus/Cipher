using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CypherProject
{
    public partial class Playfair : Form
    {
        public Playfair()
        {
            InitializeComponent();
        }
        static string[] alfa = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        static string[,] matrice = new string[5, 5];
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string TextBox2Value
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string TextButtonValue
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
        public string TextLbl1Value
        {
            get { return lbl1.Text; }
            set { lbl1.Text = value; }
        }
        public string TextLbl2Value
        {
            get { return lbl3.Text; }
            set { lbl3.Text = value; }
        }
       
        public static string RemoveSpecialCharacters(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {

                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
        public static string RemoveDuplicates(string p)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < p.Length; i++)
            {
                if (sb.ToString().Contains(p[i]) == false)
                {
                    sb.Append(p[i]);
                }
            }
            return sb.ToString();
        }
        public static void matrix(string cheie)
        {
            cheie = cheie.ToUpper();
            cheie = cheie.Replace("J", "I");
            cheie = RemoveDuplicates(cheie);
            cheie = RemoveSpecialCharacters(cheie);
            StringBuilder sb = new StringBuilder();
            sb.Append(cheie);
            for (int i = 0; i < alfa.Length; i++)
            {
                if (sb.ToString().Contains(alfa[i]) == false)
                {
                    sb.Append(alfa[i]);
                }
            }
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrice[i, j] = sb[k].ToString();
                    k++;
                }
            }


        }
        public string Encrypt_Playfair(string textclar)
        {
            string textcriptat = "";
            textcriptat = RemoveSpecialCharacters(textclar.ToUpper());
            textcriptat = textcriptat.Replace("J", "I");

            for (int i = 0; i < textcriptat.Length - 1; i = i + 2)
            {
                if (textcriptat[i] == textcriptat[i + 1])
                {
                    textcriptat = textcriptat.Insert(i + 1, "X");
                }
            }

            if (textcriptat.Length % 2 != 0)
            {
                textcriptat = textcriptat.Insert(textcriptat.Length, "B");
            }
            matrix(textBox2.Text);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < textcriptat.Length - 1; i = i + 2)
            {

                char a = textcriptat[i];
                char b = textcriptat[i + 1];
                int a_i = 0;
                int a_j = 0;
                int b_i = 0;
                int b_j = 0;
                for (int n = 0; n < 5; n++)
                {
                    for (int m = 0; m < 5; m++)
                    {
                        if (matrice[n, m] == a.ToString())
                        {
                            a_i = n;
                            a_j = m;
                        }
                        if (matrice[n, m] == b.ToString())
                        {
                            b_i = n;
                            b_j = m;
                        }
                    }
                }
                if (a_i == b_i)
                {
                    if (a_j == 4)
                    {
                        sb.Append(matrice[a_i, 0]);
                        sb.Append(matrice[b_i, b_j + 1]);
                    }
                    else if (b_j == 4)
                    {
                        sb.Append(matrice[a_i, a_j + 1]);
                        sb.Append(matrice[b_i, 0]);
                    }
                    else
                    {
                        sb.Append(matrice[a_i, a_j + 1]);
                        sb.Append(matrice[b_i, b_j + 1]);
                    }
                }
                else if (a_j == b_j)
                {
                    if (a_i == 4)
                    {
                        sb.Append(matrice[0, a_j]);
                        sb.Append(matrice[b_i + 1, b_j]);
                    }
                    else if (b_i == 4)
                    {
                        sb.Append(matrice[a_i + 1, a_j]);
                        sb.Append(matrice[0, b_j]);
                    }
                    else
                    {
                        sb.Append(matrice[a_i + 1, a_j]);
                        sb.Append(matrice[b_i + 1, b_j]);
                    }
                }
                else
                {

                    sb.Append(matrice[a_i, b_j]);
                    sb.Append(matrice[b_i, a_j]);

                }

            }
            return sb.ToString();
        }
        public string Decrypt_Playfair(string textcriptat)
        {

            if (textcriptat.Length % 2 != 0)
            {
                textcriptat = textcriptat.Insert(textcriptat.Length, "B");
            }
            matrix(textBox2.Text);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < textcriptat.Length - 1; i = i + 2)
            {

                char a = textcriptat[i];
                char b = textcriptat[i + 1];
                int a_i = 0;
                int a_j = 0;
                int b_i = 0;
                int b_j = 0;
                for (int n = 0; n < 5; n++)
                {
                    for (int m = 0; m < 5; m++)
                    {
                        if (matrice[n, m] == a.ToString())
                        {
                            a_i = n;
                            a_j = m;
                        }
                        if (matrice[n, m] == b.ToString())
                        {
                            b_i = n;
                            b_j = m;
                        }
                    }
                }
                if (a_i == b_i)
                {
                    if (a_j == 0)
                    {
                        sb.Append(matrice[a_i, 4]);
                        sb.Append(matrice[b_i, b_j-1]);
                    }
                    else if (b_j == 0)
                    {
                        sb.Append(matrice[a_i, a_j - 1]);
                        sb.Append(matrice[b_i, 4]);
                    }
                    else
                    {
                        sb.Append(matrice[a_i, a_j - 1]);
                        sb.Append(matrice[b_i, b_j - 1]);
                    }
                }
                else if (a_j == b_j)
                {
                    if (a_i == 0)
                    {
                        sb.Append(matrice[4, a_j]);
                        sb.Append(matrice[b_i - 1, b_j]);
                    }
                    else if (b_i == 0)
                    {
                        sb.Append(matrice[a_i - 1, a_j]);
                        sb.Append(matrice[4, b_j]);
                    }
                    else
                    {
                        sb.Append(matrice[a_i - 1, a_j]);
                        sb.Append(matrice[b_i - 1, b_j]);
                    }
                }
                else
                {

                    sb.Append(matrice[a_i, b_j]);
                    sb.Append(matrice[b_i, a_j]);

                }

            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text =="Encrypt")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Introdu un text de criptat");
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Introdu o cheie");
                    textBox2.Focus();
                }
                else
                {
                    textBox3.Clear();
                    textBox3.Text = Encrypt_Playfair(textBox1.Text);
                }
            }
            else if (button1.Text =="Decrypt")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Introdu textul de decriptat");
                    textBox1.Focus();
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Introdu o cheie");
                    textBox2.Focus();
                }
                else
                {
                    textBox3.Clear();
                    textBox3.Text = Decrypt_Playfair(textBox1.Text);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
      
        }
    }
}
