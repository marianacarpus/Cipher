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
    public partial class Enigma : Form
    {
        public Enigma()
        {
            InitializeComponent();
        }
        public string TextBoxValue
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
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
        public string Encrypt_Enigma(string text, string reflector)
        {
            string rotor1 = "EKMFLGDQVZNTOWYHXUSPAIBRCJ",
                   rotor2 = "AJDKSIRUXBLHWTMCQGZNPYFVOE",
                   rotor3 = "BDFHJLCPRTXVZNYEIWGAKMUSQO",
                   reflector_B = "AYBRCUDHEQFSGLIPJXKNMOTZVW",
                   reflector_C = "AFBVCPDJEIGOHYKRLZMXNWTQSU",
                   alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string rez = "";
            string text1 = RemoveSpecialCharacters(text.ToUpper());
            int i;
            for (i = 0; i < text1.Length; i++)
            {
                string val1 = rotor3[alfabet.IndexOf(text1[i])].ToString();
                string val2 = rotor2[alfabet.IndexOf(val1)].ToString();
                string val3 = rotor1[alfabet.IndexOf(val2)].ToString();
                string val4 = "";
                if (reflector == "B")
                {
                    if (reflector_B.IndexOf(val3) % 2 == 0)
                        val4 = reflector_B[reflector_B.IndexOf(val3) + 1].ToString();
                    else
                        val4 = reflector_B[reflector_B.IndexOf(val3) - 1].ToString();
                }
                else if (reflector == "C"){
                    if (reflector_C.IndexOf(val3) % 2 == 0)
                        val4 = reflector_C[reflector_C.IndexOf(val3) + 1].ToString();
                    else
                        val4 = reflector_C[reflector_C.IndexOf(val3) - 1].ToString();
                }
                string val5 = alfabet[rotor1.IndexOf(val4)].ToString();
                string val6 = alfabet[rotor2.IndexOf(val5)].ToString();
                string val7 = alfabet[rotor3.IndexOf(val6)].ToString();
                rez += val7;

                string temp = rotor1.Substring(1);
                temp += rotor1[0];
                rotor1 = temp;
            }
            return rez;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string reflector="";
            if (radioButton1.Checked)
            {
                reflector = "B";
                textBox3.Text = Encrypt_Enigma(textBox1.Text, reflector);
            }
            else if (radioButton2.Checked)
            {
                reflector = "C";
                textBox3.Text = Encrypt_Enigma(textBox1.Text, reflector);
            }
          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
