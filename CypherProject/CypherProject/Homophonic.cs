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
    public partial class Homophonic : Form
    {
        private static Random random;
        private static object syncObj = new object();
        public Homophonic()
        {
            InitializeComponent();
        }
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
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
        public string Encrypt_Homophonic1(string textc)
        {
            string textd = "";
            textc = textc.ToUpper();
            textc = RemoveSpecialCharacters(textc);

            foreach (char caracter in textc)
            {

                switch (caracter.ToString().ToUpper())
                {
                    case "E":
                        {

                            string[] vect = { "00", "06", "13", "32", "52", "53", "71", "72", "83", "93" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "T":
                        {

                            string[] vect = { "14", "16", "30", "31", "43", "58", "73", "79" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "O":
                        {

                            string[] vect = { "11", "15", "25", "41", "42", "57", "78" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "I":
                        {

                            string[] vect = { "03", "10", "34", "35", "54", "56", "77" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "A":
                        {

                            string[] vect = { "18", "19", "20", "36", "55", "62", "76" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "N":
                        {

                            string[] vect = { "02", "37", "38", "59", "61", "69", "70" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "R":
                        {

                            string[] vect = { "09", "26", "39", "60", "75", "88" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "S":
                        {

                            string[] vect = { "94", "84", "85", "86", "87" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "H":
                        {

                            string[] vect = { "17", "28", "63", "74", "89" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "L":
                        {

                            string[] vect = { "04", "08", "27", "64" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "D":
                        {

                            string[] vect = { "05", "29", "66" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "U":
                        {

                            string[] vect = { "07", "22", "91" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "C":
                        {

                            string[] vect = { "23", "44", "92" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "M":
                        {

                            string[] vect = { "33", "51", "80" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "P":
                        {

                            string[] vect = { "12", "50" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "Y":
                        {

                            string[] vect = { "49", "68" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "F":
                        {

                            string[] vect = { "24", "45" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "G":
                        {

                            string[] vect = { "01", "96" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "W":
                        {

                            string[] vect = { "81", "98" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "B":
                        {

                            string[] vect = { "48", "97" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "V":
                        {

                            string[] vect = { "99" };

                            break;
                        }
                    case "K":
                        {

                            string[] vect = { "67" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "X":
                        {

                            string[] vect = { "47" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "J":
                        {

                            string[] vect = { "95" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "Q":
                        {

                            string[] vect = { "90" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }
                    case "Z":
                        {

                            string[] vect = { "46" };
                            textd += vect[GenerateRandomNumber(vect.Length)];
                            break;
                        }

                }
            }
            return textd;

        }
        public static string RemoveSpecialChar1(string str)
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
        public string Decrypt_Homophonic1(string textp)
        {
            string textd = "";
            textp = RemoveSpecialChar1(textp);
            string[,] matr = new string[26, 12];
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    matr[i, j] = "0";
                }
            }
            matr[0, 0] = "E"; matr[0, 1] = "00"; matr[0, 2] = "06"; matr[0, 3] = "13"; matr[0, 4] = "32"; matr[0, 5] = "52"; matr[0, 6] = "53"; matr[0, 7] = "71"; matr[0, 8] = "72"; matr[0, 9] = "83"; matr[0, 10] = "93";
            matr[1, 0] = "T"; matr[1, 1] = "14"; matr[1, 2] = "30"; matr[1, 3] = "31"; matr[1, 4] = "43"; matr[1, 5] = "58"; matr[1, 6] = "73"; matr[1, 7] = "79";
            matr[2, 0] = "O"; matr[2, 1] = "11"; matr[2, 2] = "15"; matr[2, 3] = "25"; matr[2, 4] = "41"; matr[2, 5] = "42"; matr[2, 6] = "57"; matr[2, 7] = "78";
            matr[3, 0] = "I"; matr[3, 1] = "03"; matr[3, 2] = "10"; matr[3, 3] = "34"; matr[3, 4] = "35"; matr[3, 5] = "54"; matr[3, 6] = "56"; matr[3, 7] = "77";
            matr[4, 0] = "A"; matr[4, 1] = "18"; matr[4, 2] = "19"; matr[4, 3] = "20"; matr[4, 4] = "36"; matr[4, 5] = "55"; matr[4, 6] = "62"; matr[4, 7] = "76";
            matr[5, 0] = "N"; matr[5, 1] = "02"; matr[5, 2] = "37"; matr[5, 3] = "38"; matr[5, 4] = "59"; matr[5, 5] = "61"; matr[5, 6] = "69"; matr[5, 7] = "70";
            matr[6, 0] = "R"; matr[6, 1] = "09"; matr[6, 2] = "26"; matr[6, 3] = "39"; matr[6, 4] = "60"; matr[6, 5] = "75"; matr[6, 6] = "88";
            matr[7, 0] = "S"; matr[7, 1] = "94"; matr[7, 2] = "84"; matr[7, 3] = "85"; matr[7, 4] = "86"; matr[7, 5] = "87";
            matr[8, 0] = "H"; matr[8, 1] = "17"; matr[8, 2] = "28"; matr[8, 3] = "63"; matr[8, 4] = "74"; matr[8, 5] = "89";
            matr[9, 0] = "L"; matr[9, 1] = "04"; matr[9, 2] = "08"; matr[9, 3] = "27"; matr[9, 4] = "64";
            matr[10, 0] = "D"; matr[10, 1] = "05"; matr[10, 2] = "29"; matr[10, 3] = "66";
            matr[11, 0] = "U"; matr[11, 1] = "07"; matr[11, 2] = "22"; matr[11, 3] = "91";
            matr[12, 0] = "C"; matr[12, 1] = "23"; matr[12, 2] = "44"; matr[12, 3] = "92";
            matr[13, 0] = "M"; matr[13, 1] = "33"; matr[13, 2] = "51"; matr[13, 3] = "80";
            matr[14, 0] = "P"; matr[14, 1] = "12"; matr[14, 2] = "50";
            matr[15, 0] = "Y"; matr[15, 1] = "49"; matr[15, 2] = "68";
            matr[16, 0] = "F"; matr[16, 1] = "24"; matr[16, 2] = "45";
            matr[17, 0] = "G"; matr[17, 1] = "01"; matr[17, 2] = "96";
            matr[18, 0] = "W"; matr[18, 1] = "81"; matr[18, 2] = "98";
            matr[19, 0] = "B"; matr[19, 1] = "48"; matr[19, 2] = "97";
            matr[20, 0] = "V"; matr[20, 1] = "99";
            matr[21, 0] = "K"; matr[21, 1] = "67";
            matr[22, 0] = "X"; matr[22, 1] = "47";
            matr[23, 0] = "J"; matr[23, 1] = "95";
            matr[24, 0] = "Q"; matr[24, 1] = "90";
            matr[25, 0] = "Z"; matr[25, 1] = "46";
            for (int i = 0; i < textp.Length - 1; i = i + 2)
            {
                string numar = string.Concat(textp[i], textp[i + 1]);
                for (int j = 0; j < 26; j++)
                {
                    for (int k = 0; k < 12; k++)
                    {
                        if (matr[j, k] == numar)
                        {
                            textd += matr[j, 0];
                        }
                    }
                }

            }
            return textd;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="Encrypt")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Introdu un text de criptat");
                    textBox1.Focus();
                }
                else
                {
                    textBox4.Clear();
                    textBox4.Text = Encrypt_Homophonic1(textBox1.Text);

                }

            }
            else if (button1.Text == "Decrypt")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Introdu un text de criptat");
                    textBox1.Focus();
                }
                else
                {
                    textBox4.Clear();
                    textBox4.Text = Decrypt_Homophonic1(textBox1.Text);

                }

            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
