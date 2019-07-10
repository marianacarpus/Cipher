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
    public partial class ADFGVX : Form
    {
        string[,] mat1 = new string[7, 7];
        string[,] mat2;
        public ADFGVX()
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
        public string TextBox3Value
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
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
        private void btnClear_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();

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

        public string crypt_ADFGVX(string texta)
        {
            string textcriptat = "";
            string cheie1 = RemoveDuplicates(textBox2.Text.ToUpper());
            string cheie2 = RemoveDuplicates(textBox3.Text.ToUpper());
            string[] alfa1 = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            StringBuilder sb = new StringBuilder();
            sb.Append(cheie1);
            for (int i = 0; i < alfa1.Length; i++)
            {
                if (!(sb.ToString().ToUpper().Contains(alfa1[i])))

                    sb.Append(alfa1[i]);

            }

            textcriptat = sb.ToString().ToUpper();
            int k = 0;

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    mat1[i, j] = textcriptat[k].ToString();
                    k++;
                }
            }

            mat1[0, 1] = "A";
            mat1[0, 2] = "D";
            mat1[0, 3] = "F";
            mat1[0, 4] = "G";
            mat1[0, 5] = "V";
            mat1[0, 6] = "X";
            mat1[1, 0] = "A";
            mat1[2, 0] = "D";
            mat1[3, 0] = "F";
            mat1[4, 0] = "G";
            mat1[5, 0] = "V";
            mat1[6, 0] = "X";
            StringBuilder sx = new StringBuilder();
            foreach (char caracter in texta)
            {

                for (int i = 1; i < 7; i++)
                {

                    for (int j = 1; j < 7; j++)
                    {
                        if (Convert.ToString(caracter).ToUpper() == mat1[i, j])
                        {
                            sx.Append(mat1[0, i]);
                            sx.Append(mat1[j, 0]);
                        }

                    }
                }
            }
            mat2 = new string[cheie2.Length, sx.Length];
            for (int i = 0; i < cheie2.Length; i++)
            {
                mat2[i, 0] = cheie2[i].ToString();
            }
            int col = 1;
            int k1 = 0;

            while (col <= (sx.Length / cheie2.Length) + 1)
            {
                for (int i = 0; i < cheie2.Length; i++)
                {

                    mat2[i, col] = sx[k1].ToString();
                    k1++;

                    if (k1 >= sx.Length)
                    {
                        k1 = sx.Length - 1;
                    }
                }
                col++;

            }
            string[] key2 = new string[cheie2.Length];
            for (int i = 0; i < cheie2.Length; i++)
            {
                key2[i] = cheie2[i].ToString();
            }
            Array.Sort(key2);
            StringBuilder sy = new StringBuilder();
            try
            {
                int r = 0;
                while (r < cheie2.Length)
                {
                    for (int i = 0; i < cheie2.Length; i++)
                    {
                        if (mat2[i, 0] == key2[r])
                        {
                            for (int j = 1; j <= (sx.Length / cheie2.Length) + 1; j++)
                            {
                                sy.Append(mat2[i, j]);
                            }
                            r++;
                        }

                    }
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
            }
            return sy.ToString();
        }
        public string decrypt_ADFGVX(string textc)
        {
            string cheie1 = RemoveDuplicates(textBox2.Text.ToUpper());
            string cheie2 = RemoveDuplicates(textBox3.Text.ToUpper());
            textc = textc.ToUpper();
            string[] alfa1 = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            string[] key2 = new string[cheie2.Length];
            for (int i = 0; i < cheie2.Length; i++)
            {
                key2[i] = cheie2[i].ToString();
            }
            Array.Sort(key2);
            mat2 = new string[cheie2.Length, (textc.Length / key2.Length) + 1];
            for (int i = 0; i < key2.GetLength(0); i++)
            {
                mat2[i, 0] = key2[i].ToString();
            }

            int k = 0;
            while (k < textc.Length)
            {
                for (int i = 0; i < key2.GetLength(0); i++)
                {
                    for (int j = 1; j < (textc.Length / key2.Length) + 1; j++)
                    {
                        mat2[i, j] = textc[k].ToString();
                        k++;

                    }
                }
            }
            StringBuilder xa = new StringBuilder();
            try
            {

                int r = 0;
                while (r < cheie2.Length)
                {
                    for (int i = 0; i < cheie2.Length; i++)
                    {
                        if (mat2[i, 0] == cheie2[r].ToString())
                        {
                            for (int j = 1; j < (textc.Length / key2.Length) + 1; j++)
                            {
                                xa.Append(mat2[i, j]);
                            }
                            r++;
                        }

                    }
                }
            }
            catch (System.IndexOutOfRangeException e)
            {
                System.Console.WriteLine(e.Message);
            }

            for (int i = 0; i < cheie2.Length; i++)
            {
                mat2[i, 0] = cheie2[i].ToString();
            }

            int k1 = 0;
            while (k1 < textc.Length)
            {
                for (int i = 0; i < key2.GetLength(0); i++)
                {
                    for (int j = 1; j < (textc.Length / key2.Length) + 1; j++)
                    {
                        mat2[i, j] = xa[k1].ToString();
                        k1++;

                    }
                }
            }

            StringBuilder sy = new StringBuilder();
            int col = 1;

            while (col <= (xa.Length / cheie2.Length))
            {
                for (int lin = 0; lin < cheie2.Length; lin++)
                {
                    sy.Append(mat2[lin, col]);

                }
                col++;

            }
            StringBuilder sb = new StringBuilder();
            sb.Append(cheie1);
            for (int i = 0; i < alfa1.Length; i++)
            {
                if (!(sb.ToString().ToUpper().Contains(alfa1[i])))

                    sb.Append(alfa1[i]);

            }


            int k2 = 0;

            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j < 7; j++)
                {
                    mat1[i, j] = sb[k2].ToString();
                    k2++;
                }
            }

            mat1[0, 1] = "A";
            mat1[0, 2] = "D";
            mat1[0, 3] = "F";
            mat1[0, 4] = "G";
            mat1[0, 5] = "V";
            mat1[0, 6] = "X";
            mat1[1, 0] = "A";
            mat1[2, 0] = "D";
            mat1[3, 0] = "F";
            mat1[4, 0] = "G";
            mat1[5, 0] = "V";
            mat1[6, 0] = "X";



            StringBuilder xl = new StringBuilder();
            for (int i = 0; i < sy.Length - 1; i = i + 2)
            {
                for (int j = 1; j < 7; j++)
                {
                    for (int l = 1; l < 7; l++)
                    {
                        if (mat1[j, 0] == sy[i].ToString() && mat1[0, l] == sy[i + 1].ToString())
                        {
                            xl.Append(mat1[j, l]);
                        }

                    }
                }

            }


            return xl.ToString();
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
                    MessageBox.Show("Introdu prima cheie");
                    textBox2.Focus();
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Introdu a doua cheie");
                    textBox3.Focus();
                }
                else
                {
                    textBox4.Clear();
                    textBox4.Text = crypt_ADFGVX(textBox1.Text);
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
                    MessageBox.Show("Introdu prima cheie");
                    textBox2.Focus();
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Introdu a doua cheie");
                    textBox3.Focus();
                }
                else
                {
                    textBox4.Clear();
                    textBox4.Text = decrypt_ADFGVX(textBox1.Text);
                }
            }

        }
    }
}
