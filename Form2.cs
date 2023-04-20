using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Programme de calcul des lettres du diables ";
            label1.Text+="\r\npour le ghost and skull de COD Infinite warfare Zombie l'attaque de la chose radioactive";
            label1.Text += "\r\nEn ayant le mur en face de vous , entrez les lettres dans l'ordre de gauche a droite";
            label1.Text += "\r\npuis chaque lettre du mot a trouver dans la case en dessous(une par une)";
            label1.Text += "\r\npuis cliquez sur calculer , le resultat vous donnera une suite de chiffre";
            label1.Text += "\r\nqui correspondent au symbole a utiliser";
            label1.Text += "\r\nExemple : 214 , il faudra tirer sur le deuxieme puis le premier puis le quatrieme";
            label1.Text += "\r\n";
            label1.Text += "\r\nprogramme realisé sur la base de calcul du site https://www.psthc.fr/";
            label1.Text += "\r\nLien complet : https://www.psthc.fr/unjeu/callof-duty-infinite-warfare-ps4/guide-trophees-dlc3.htm?sid=62174e50a7af5e8b5f1c4d3d531cca1d#trophee1";





        }
    }
}
