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
    public partial class ACAHomophonic : Form
    {
        private static Random random;
        private static object syncObj = new object();
        string[,] matrix = new string[5, 25];
        public ACAHomophonic()
        {
            InitializeComponent();
        }
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
        private static int GenerateRandomNumber(int max)
        {
            lock (syncObj)
            {
                if (random == null)
                    random = new Random();
                return random.Next(max);
            }
        }
        rotire[] rotate<rotire>(rotire[] a, int index)
        {
            rotire[] result = new rotire[a.Length];
            Array.Copy(a, 0, result, index, a.Length - index);
            Array.Copy(a, a.Length - index, result, 0, index);
            return result;
        }
        public void generarematrix(string cheie)
        {
            string[] alfa25 = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] a1 = new string[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" };
            string[] a2 = new string[] { "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50" };
            string[] a3 = new string[] { "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75" };
            string[] a4 = new string[] { "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "00" };
            List<string[]> x = new List<string[]>();
            x.Add(a1);
            x.Add(a2);
            x.Add(a3);
            x.Add(a4);
            cheie = cheie.ToUpper();

            for (int i = 0; i < 25; i++)
            {
                matrix[0, i] = alfa25[i];
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (cheie[i].ToString() == alfa25[j].ToString())
                    {

                        x[i] = rotate(x[i], j);
                        for (int k = 0; k < 25; k++)
                        {
                            matrix[i + 1, k] = x[i][k];

                        }

                    }
                }
            }
        }
        public string Encrypt_ACAHomophonic(string textc)
        {
            string textd = "";
            textc = RemoveSpecialCharacters(textc);
            textc = textc.ToUpper();
            generarematrix(textBox2.Text);
            foreach (char car in textc)
            {
                for (int j = 0; j < 25; j++)
                {
                    string[] v = new string[4];
                    if (car.ToString() == matrix[0, j])
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            v[i - 1] = matrix[i, j];
                        }
                        textd += v[GenerateRandomNumber(v.Length)];
                    }
                }

            }
            return textd;
        }
        public static string RemoveSpecialChar(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in str)
            {
                if ((c >= '0' && c <= '9'))
                {

                    sb.Append(c);
                }
            }

            return sb.ToString();
        }
        public string Decrypt_ACAHomophonic(string textd)
        {
            string textc = "";
            textd = RemoveSpecialChar(textd);
            generarematrix(textBox2.Text);
            for (int i = 0; i < textd.Length - 1; i = i + 2)
            {
                string numar = string.Concat(textd[i], textd[i + 1]);
                for (int j = 1; j < 5; j++)
                {
                    for (int k = 0; k < 25; k++)
                    {
                        if (matrix[j, k] == numar)
                        {
                            textc += matrix[0, k];
                        }
                    }
                }
            }
            return textc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Encrypt")
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
                    textBox3.Text = Encrypt_ACAHomophonic(textBox1.Text);

                }

            }
            else if (button1.Text == "Decrypt")
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
                    textBox3.Text = Decrypt_ACAHomophonic(textBox1.Text);

                }

            }

        }
    

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }
    }
}
