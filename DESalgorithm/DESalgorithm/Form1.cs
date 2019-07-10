using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESalgorithm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0123456789ABCDEF";
            textBox2.Text = "133457799BBCDFF1";
        }

        int[] rotateLeft = { 1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1 };

        public string binaryKey(string message)
        {
            return String.Join(String.Empty, message.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
        }
        private List<string> DES_Key_CreateSubKeys(string cheie)
        {
            List<string> Kn = new List<string>();

            try
            {

                // formarea cheii in binar
                string keyBin = binaryKey(cheie);
                // crearea cheii conform tabelului PC1
                string cheiePlus = DES_Key_Permut_PC1(keyBin);
                string C0, D0;
                DES_Key_Divide_C0_D0(cheiePlus, out C0, out D0);
                // crearea celor 16 blocuri Cn Dn
                List<string> Cn;
                List<string> Dn;
                DES_Key_Divide_Ci_Di(C0, D0, out Cn, out Dn);
                // calcularea subcheilor Kn 
                Kn = DES_Key_Permut_PC2(Cn, Dn);

                return Kn;
            }
            catch (Exception)
            {
            }
          
            return Kn;
        }

        private string DES_Key_Permut_PC1(string cheie)
        {
            // instantierea tabelului PC1 cu valori
            int[,] PC1 = new int[,] { {57, 49, 41, 33, 25, 17, 9},
                                           {1, 58, 50, 42, 34, 26, 18},
                                           {10, 2, 59, 51, 43, 35, 27},
                                           {19, 11, 3, 60, 52, 44, 36},
                                           {63, 55, 47, 39, 31, 23, 15},
                                           {7, 62, 54, 46, 38, 30, 22},
                                           {14, 6, 61, 53, 45, 37, 29},
                                           {21, 13, 5, 28, 20, 12, 4} };

            // crearea noii chei cu doar 56 biti
            string cheiePlus = "";
            for (int i = 0; i < PC1.GetLength(0); i++)
                for (int j = 0; j < PC1.GetLength(1); j++)
                    cheiePlus = cheiePlus + cheie[PC1[i, j] - 1];
            return cheiePlus;
        }

        public string constructNumber(int number)
        {
            string sirOut = "";
            byte[] b = new byte[4];
            int count;
            for (count = 3; count >= 0; count--)
            {
                if (number % 2 == 0)
                    b[count] = 0;
                else
                    b[count] = 1;
                number /= 2;
            }
            for (count = 0; count <= 3; count++)
                sirOut += b[count];
            return sirOut;
        }

        public void DES_Key_Divide_C0_D0(string cheie, out string c0, out string d0)
        {
            int i;
            c0 = ""; d0 = "";
            for (i = 0; i < cheie.Length / 2; i++)
                c0 += cheie[i];
            for (i = cheie.Length / 2; i < cheie.Length; i++)
                d0 += cheie[i];
        }

        public void DES_Key_Divide_Ci_Di(string C0, string D0, out List<string> Ci, out List<string> Di)
        {

            Ci = new List<string>();
            Di = new List<string>();
            int index = 0;
            // crearea primei rotatii care e in functie de D0 D0
            string c = C0.Substring(rotateLeft[0]) + C0.Substring(0, rotateLeft[0]);
            Ci.Add(c);
            string d = D0.Substring(rotateLeft[0]) + D0.Substring(0, rotateLeft[0]);
            Di.Add(d);

            // creare Ci Di prin rotatii la stanga in functie de valorile anterioare
            for (int i = 1; i < rotateLeft.Length; i++)
            {
                c = Ci[index].Substring(rotateLeft[i]) + Ci[index].Substring(0, rotateLeft[i]);
                Ci.Add(c);
                d = Di[index].Substring(rotateLeft[i]) + Di[index].Substring(0, rotateLeft[i]);
                Di.Add(d);
                index++;
            }
        }

        private List<string> DES_Key_Permut_PC2(List<string> Ci, List<string> Di)
        {
            List<string> Ki = new List<string>();
            int[,] PC2 = new int[,] { {14, 17, 11, 24, 1, 5},
                                           {3, 28, 15, 6, 21, 10},
                                           {23, 19, 12, 4, 26, 8},
                                           {16, 7, 27, 20, 13, 2},
                                           {41, 52, 31, 37, 47, 55},
                                           {30, 40, 51, 45, 33, 48},
                                           {44, 49, 39, 56, 34, 53},
                                           {46, 42, 50, 36, 29, 32} };
            // parcurgerea tuturor Ci si Di
            for (int i = 0; i < Ci.Count; i++)
            {
                // concatenarea lui Ci cu Di
                string k = Ci[i] + Di[i];

                // realizEZ permutarile
                string kPlus = "";
                for (int m = 0; m < PC2.GetLength(0); m++)
                    for (int n = 0; n < PC2.GetLength(1); n++)
                        kPlus = kPlus + k[PC2[m, n] - 1];
                Ki.Add(kPlus);
            }
            return Ki;
        }

        public string textHexa(string message)
        {
            StringBuilder rezultat = new StringBuilder(message.Length / 8 + 1);

            int mod4Len = message.Length % 8;
            // daca nu e multiplu de 8
            if (mod4Len != 0)
            {
                // adaugare de 0 pentru a ajunge la multiplu de 8
                message = message.PadLeft(((message.Length / 8) + 1) * 8, '0');
            }
            // conversie de cate 8 biti la hexa
            for (int i = 0; i < message.Length; i += 8)
            {
                string optBiti = message.Substring(i, 8);
                rezultat.AppendFormat("{0:X2}", Convert.ToByte(optBiti, 2));
            }
            return rezultat.ToString();
        }

        private string DES_Permut_IP(string message)
        {
            // instantierea tabelului IP cu valori
            int[,] tabelIP = new int[,] { {58, 50, 42, 34, 26, 18, 10, 2},
                                           {60, 52, 44, 36, 28, 20, 12, 4},
                                           {62, 54, 46, 38, 30, 22, 14, 6},
                                           {64, 56, 48, 40, 32, 24, 16, 8},
                                           {57, 49, 41, 33, 25, 17, 9, 1},
                                           {59, 51, 43, 35, 27, 19, 11, 3},
                                           {61, 53, 45, 37, 29, 21, 13, 5},
                                           {63, 55, 47, 39, 31, 23, 15, 7} };

            string IP = "";
            for (int i = 0; i < tabelIP.GetLength(0); i++)
                for (int j = 0; j < tabelIP.GetLength(1); j++)
                    IP = IP + message[tabelIP[i, j] - 1];
            return IP;
        }

        private void DES_Divide_L0_R0(string message, out string L0, out string R0)
        {
            L0 = ""; R0 = "";
            for (int i = 0; i < message.Length / 2; i++)
            {
                // prima jumatate
                L0 = L0 + message[i];
                // a doua jumatate
                R0 = R0 + message[message.Length / 2 + i];
            }
        }

        private string DES_Permut_E(string initial)
        {
            int[,] tabelE = new int[,] { {32, 1, 2, 3, 4, 5},
                                         {4, 5, 6, 7, 8, 9},
                                         {8, 9, 10, 11, 12, 13},
                                         {12, 13, 14, 15, 16, 17},
                                         {16, 17, 18, 19, 20, 21},
                                         {20, 21, 22, 23, 24, 25},
                                         {24, 25, 26, 27, 28, 29},
                                         {28, 29, 30, 31, 32, 1} };

            string valoare = "";
            for (int i = 0; i < tabelE.GetLength(0); i++)
                for (int j = 0; j < tabelE.GetLength(1); j++)
                    valoare = valoare + initial[tabelE[i, j] - 1];
            return valoare;
        }

        // realizarea operatiei de XOR
        private string opXOR(string message, string cheie)
        {
            string rezultat = "";
            for (int i = 0; i < message.Length; i++)
                if (message[i] == cheie[i])
                    rezultat = rezultat + "0";
                else
                    rezultat = rezultat + "1";
            return rezultat;
        }

        // realizarea tabelelor Si
        private List<int[,]> createSi()
        {
            List<int[,]> tabeleSi = new List<int[,]>();

            int[,] S1 = new int[,] { {14, 4, 13, 1, 2, 15, 11, 8, 3, 10, 6, 12, 5, 9, 0, 7},
                                     {0, 15, 7, 4, 14, 2, 13, 1, 10, 6, 12, 11, 9, 5, 3, 8},
                                     {4, 1, 14, 8, 13, 6, 2, 11, 15, 12, 9, 7, 3, 10, 5, 0},
                                     {15, 12, 8, 2, 4, 9, 1, 7, 5, 11, 3, 14, 10, 0, 6, 13} };
            tabeleSi.Add(S1);

            int[,] S2 = new int[,] { {15, 1, 8, 14, 6, 11, 3, 4, 9, 7, 2, 13, 12, 0, 5, 10},
                                     {3, 13, 4, 7, 15, 2, 8, 14, 12, 0, 1, 10, 6, 9, 11, 5},
                                     {0, 14, 7, 11, 10, 4, 13, 1, 5, 8, 12, 6, 9, 3, 2, 15},
                                     {13, 8, 10, 1, 3, 15, 4, 2, 11, 6, 7, 12, 0, 5, 14, 9} };
            tabeleSi.Add(S2);

            int[,] S3 = new int[,] { {10, 0, 9, 14, 6, 3, 15, 5, 1, 13, 12, 7, 11, 4, 2, 8},
                                     {13, 7, 0, 9, 3, 4, 6, 10, 2, 8, 5, 14, 12, 11, 15, 1},
                                     {13, 6, 4, 9, 8, 15, 3, 0, 11, 1, 2, 12, 5, 10, 14, 7},
                                     {1, 10, 13, 0, 6, 9, 8, 7, 4, 15, 14, 3, 11, 5, 2, 12} };
            tabeleSi.Add(S3);

            int[,] S4 = new int[,] { {7, 13, 14, 3, 0, 6, 9, 10, 1, 2, 8, 5, 11, 12, 4, 15},
                                     {13, 8, 11, 5, 6, 15, 0, 3, 4, 7, 2, 12, 1, 10, 14, 9},
                                     {10, 6, 9, 0, 12, 11, 7, 13, 15, 1, 3, 14, 5, 2, 8, 4},
                                     {3, 15, 0, 6, 10, 1, 13, 8, 9, 4, 5, 11, 12, 7, 2, 14} };
            tabeleSi.Add(S4);

            int[,] S5 = new int[,] { {2, 12, 4, 1, 7, 10, 11, 6, 8, 5, 3, 15, 13, 0, 14, 9},
                                     {14, 11, 2, 12, 4, 7, 13, 1, 5, 0, 15, 10, 3, 9, 8, 6},
                                     {4, 2, 1, 11, 10, 13, 7, 8, 15, 9, 12, 5, 6, 3, 0, 14},
                                     {11, 8, 12, 7, 1, 14, 2, 13, 6, 15, 0, 9, 10, 4, 5, 3} };
            tabeleSi.Add(S5);

            int[,] S6 = new int[,] { {12, 1, 10, 15, 9, 2, 6, 8, 0, 13, 3, 4, 14, 7, 5, 11},
                                     {10, 15, 4, 2, 7, 12, 9, 5, 6, 1, 13, 14, 0, 11, 3, 8},
                                     {9, 14, 15, 5, 2, 8, 12, 3, 7, 0, 4, 10, 1, 13, 11, 6},
                                     {4, 3, 2, 12, 9, 5, 15, 10, 11, 14, 1, 7, 6, 0, 8, 13} };
            tabeleSi.Add(S6);

            int[,] S7 = new int[,] { {4, 11, 2, 14, 15, 0, 8, 13, 3, 12, 9, 7, 5, 10, 6, 1},
                                     {13, 0, 11, 7, 4, 9, 1, 10, 14, 3, 5, 12, 2, 15, 8, 6},
                                     {1, 4, 11, 13, 12, 3, 7, 14, 10, 15, 6, 8, 0, 5, 9, 2},
                                     {6, 11, 13, 8, 1, 4, 10, 7, 9, 5, 0, 15, 14, 2, 3, 12} };
            tabeleSi.Add(S7);

            int[,] S8 = new int[,] { {13, 2, 8, 4, 6, 15, 11, 1, 10, 9, 3, 14, 5, 0, 12, 7},
                                     {1, 15, 13, 8, 10, 3, 7, 4, 12, 5, 6, 11, 0, 14, 9, 2},
                                     {7, 11, 4, 1, 9, 12, 14, 2, 0, 6, 10, 13, 15, 3, 5, 8},
                                     {2, 1, 14, 7, 4, 10, 8, 13, 15, 12, 9, 0, 3, 5, 6, 11} };
            tabeleSi.Add(S8);

            return tabeleSi;
        }

        // functia care realizeaza permutarea Si
        private string DES_Permut_Si(List<int[,]> tabeleSi, int indexSi, string Bi)
        {
            // primul si ultimul bit
            string I = Bi[0].ToString() + Bi[5].ToString();
            // bitii din mijloc
            string J = Bi.Substring(1, 4);

            int indexI = Convert.ToInt32(I, 2);
            int IndexJ = Convert.ToInt32(J, 2);

            // luarea valorii din tabelul Si respectiv
            int valoare = tabeleSi[indexSi][indexI, IndexJ];
            string rezultat = Convert.ToString(valoare, 2);

            // verificare daca valoarea este mai mica decat 8
            // daca e atunci se adauga un 0 in fata // 0111
            if (valoare < 8)
                rezultat = "0" + rezultat;
            // daca valoarea e mai mica decat 4
            // se mai adauga un 0 in fata // 0011
            if (valoare < 4)
                rezultat = "0" + rezultat;
            // daca e mai mic decat 2 // 0001
            if (valoare < 2)
                rezultat = "0" + rezultat;

            return rezultat;
        }

        
        private string DES_CreateSiBi(List<int[,]> tabeleSi, string text)
        {
            string rezultat = "";
            int index = 0;
            int iteratie = 0;

            while (index < text.Length)
            {
                string intermediar = text.Substring(index, 6);
                string rezFunctie = DES_Permut_Si(tabeleSi, iteratie, intermediar);
                rezultat = rezultat + rezFunctie;
                index = index + 6;
                iteratie++;
            }
            return rezultat;
        }


        private string DES_Permut_P(string msg)
        {
            int[,] tabelP = new int[,] { {16, 7, 20, 21},
                                         {29, 12, 28, 17},
                                         {1, 15, 23, 26},
                                         {5, 18, 31, 10},
                                         {2, 8, 24, 14},
                                         {32, 27, 3, 9},
                                         {19, 13, 30, 6},
                                         {22, 11, 4, 25} };

            string msgNou = "";
            for (int i = 0; i < tabelP.GetLength(0); i++)
                for (int j = 0; j < tabelP.GetLength(1); j++)
                    msgNou = msgNou + msg[tabelP[i, j] - 1];

            return msgNou;
        }

        public string DES_Compute_Li_Ri(string L, string R)
        {
            string rezultat = R + L;
            return rezultat;
        }

        public string DES_Compute_Inv_IP(string message)
        {
            int[,] tabelIPinv = new int[,] { {40, 8, 48, 16, 56, 24, 64, 32},
                                             {39, 7, 47, 15, 55, 23, 63, 31},
                                             {38, 6, 46, 14, 54, 22, 62, 30},
                                             {37, 5, 45, 13, 53, 21, 61, 29},
                                             {36, 4, 44, 12, 52, 20, 60, 28},
                                             {35, 3, 43, 11, 51, 19, 59, 27},
                                             {34, 2, 42, 10, 50, 18, 58, 26},
                                             {33, 1, 41, 9, 49, 17, 57, 25} };

            string IPinv = "";
            for (int i = 0; i < tabelIPinv.GetLength(0); i++)
                for (int j = 0; j < tabelIPinv.GetLength(1); j++)
                    IPinv = IPinv + message[tabelIPinv[i, j] - 1];

            return IPinv;
        }
        public string encrypt(string key, string msg)
        {
            // scrierea in binar a mesajului
            string msgBinary = binaryKey(msg);

            // realizarea permutatiei initiale
            string IP = DES_Permut_IP(msgBinary);

            // impartirea in doua jumatati a mesajului IP
            string L0, R0;
            DES_Divide_L0_R0(IP, out L0, out R0);

            // crearea subcheilor
            List<string> Kn = DES_Key_CreateSubKeys(key);

            // crearea tabelelor de permutare Si
            List<int[,]> Si = createSi();

            // calcularea celor 16 iteratii
            
            List<string> Ln = new List<string>();
            List<string> Rn = new List<string>();

            // prima iteratie
            int index = 0;
            string K = Kn[index];
            string L1 = R0;
            Ln.Add(L1);
            string XOR = opXOR(DES_Permut_E(R0), K);
            string sibi = DES_CreateSiBi(Si, XOR);
            string fctF = DES_Permut_P(sibi);
            string R1 = opXOR(L0, fctF);
            Rn.Add(R1);

            // urmatoarele 15 iteratii
            for (index = 1; index < 16; index++)
            {
                K = Kn[index];
                string Li = Rn[index - 1];
                Ln.Add(Li);
                XOR = opXOR(DES_Permut_E(Rn[index - 1]), K);
                sibi = DES_CreateSiBi(Si, XOR);
                fctF = DES_Permut_P(sibi);
                string Ri = opXOR(Ln[index - 1], fctF);
                Rn.Add(Ri);
            }

            // concatenarea celor 2 jumatati
            string message16 = DES_Compute_Li_Ri(Ln[15], Rn[15]);

            // permutarea inversa IP
            string messageFinal = DES_Compute_Inv_IP(message16);

            // transformare in hexazecimal
            string messageHexa = textHexa(messageFinal);
            return messageHexa;
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" && textBox2.Text == "")
            {
                MessageBox.Show("Enter the message and key!");

            }
            else
            {
                textBox3.Text = encrypt(textBox2.Text, textBox1.Text);
            }
        }
    }
}
