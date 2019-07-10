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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cypherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playfair play = new Playfair();
            play.TextBoxValue = "Congress shall make no law respecting an establishment of religion, or prohibiting the free exercise thereof; or abridging the freedom of speech, or of the press; or the right of the people peaceably to assemble, and to petition the government for a redress of grievances.";
            play.TextBox2Value = "First Amendment";
            play.TextLbl1Value = "Plain Text:";
            play.TextLbl2Value = "Cipher Text: ";
            play.TextButtonValue = "Encrypt";
            play.Show();

        }

        private void decryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Playfair play = new Playfair();
            play.TextBoxValue = "GLEHEGNSNSNPMKVCBUNDPOEUEGNXMGFREHMDNRFDCKRTCNNDRQISMORCRLEPSOEWCSCFFREHSJAREGNWNWGELMRNSJGEGWRKFEGFTMCREHSJAREGNALEKRNXNWMGGPEWIFGNOSNRRPSFGNSRHJRQIFGNONPQOMONMBNMCKTDKENSRNACOMMDJDPQDRRFRLDSGNOWWMSEENDSRKFEEGETNRRPRBSRMWMDGMFH";
            play.TextBox2Value = "First Amendment";
            play.TextLbl2Value = "Plain Text:";
            play.TextLbl1Value = "Cipher Text: ";
            play.TextButtonValue = "Decrypt";
            play.Show();
        }

        private void cypherToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ADFGVX adf = new ADFGVX();
            adf.TextBoxValue = "cryptography";
            adf.TextBox2Value = "orange";
            adf.TextBox3Value = "water";
            adf.TextLbl1Value = "Plain Text:";
            adf.TextLbl2Value = "Cipher Text: ";
            adf.TextButtonValue = "Encrypt";
            adf.Show();
        }

        private void decryptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ADFGVX adf = new ADFGVX();
            adf.TextBoxValue = "DFAAVDGVFAVDAVAAVAFVDAADD";
            adf.TextBox2Value = "orange";
            adf.TextBox3Value = "water";
            adf.TextLbl2Value = "Plain Text:";
            adf.TextLbl1Value = "Cipher Text: ";
            adf.TextButtonValue = "Decrypt";
            adf.Show();
        }

        private void cypherToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Homophonic h1 = new Homophonic();
            h1.TextBoxValue = "cryptography";
            h1.TextLbl1Value = "Plain Text:";
            h1.TextLbl2Value = "Cipher Text: ";
            h1.TextButtonValue = "Encrypt";
            h1.Show();
        }

        private void decryptToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            Homophonic h1 = new Homophonic();
            h1.TextBoxValue = "442649501678018819507449";
            h1.TextLbl2Value = "Plain Text:";
            h1.TextLbl1Value = "Cipher Text: ";
            h1.TextButtonValue = "Decrypt";
            h1.Show();

        }

        private void cypherToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ACAHomophonic aca = new ACAHomophonic();
            aca.TextBoxValue = "Stenography";
            aca.TextBox2Value = "this";
            aca.TextLbl1Value = "Plain Text:";
            aca.TextLbl2Value = "Cipher Text: ";
            aca.TextButtonValue = "Encrypt";
            aca.Show();
        }

        private void decryptToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ACAHomophonic aca = new ACAHomophonic();
            aca.TextBoxValue = "3637723121900008332606";
            aca.TextBox2Value = "this";
            aca.TextLbl2Value = "Plain Text:";
            aca.TextLbl1Value = "Cipher Text: ";
            aca.TextButtonValue = "Decrypt";
            aca.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Cipher project!");
        }

        private void encryptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enigma eng = new Enigma();
            eng.TextBoxValue = "Prin Tratatul de pace de la Paris se prevedea intrarea Principatelor Romane sub garantia puterilor europene";
            eng.Show();
        }
    }
}
