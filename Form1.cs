using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;
using System.Windows.Forms;


namespace WindowsFormsApp11
{
    

    public partial class Form1 : Form
    {
        public static int[] tabeau = new int[] {1,2,3,4,5 };
        public int[,] tableauVal =new int[4,4];
        public static string alpha = "abcdefghijklmnopqrstuvwxyz";
        //public int[] valeurs;
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int place;
            place = alpha.IndexOf(textBox1.Text.ToLower());
            tableauVal[0, 0] = place+1;
            place = alpha.IndexOf(textBox2.Text.ToLower());
            tableauVal[0, 1] = place+1;
            place = alpha.IndexOf(textBox3.Text.ToLower());
            tableauVal[0, 2] = place+1;
            place = alpha.IndexOf(textBox4.Text.ToLower());
            tableauVal[0, 3] = place+1;

            tableauVal[1, 0] = tableauVal[0, 0] + 3;
            tableauVal[1, 1] = tableauVal[0, 1] + 6;
            tableauVal[1, 2] = tableauVal[0, 2] + 9;
            tableauVal[1, 3] = tableauVal[0, 3] + 12;

            tableauVal[2, 0] = tableauVal[0, 0] + 6;
            tableauVal[2, 1] = tableauVal[0, 1] + 12;
            tableauVal[2, 2] = tableauVal[0, 2] + 18;
            tableauVal[2, 3] = tableauVal[0, 3] + 24;

            tableauVal[3, 0] = tableauVal[0, 0] + 9;
            tableauVal[3, 1] = tableauVal[0, 1] + 18;
            tableauVal[3, 2] = tableauVal[0, 2] + 27;
            tableauVal[3, 3] = tableauVal[0, 3] + 36;



            // calcul de la lettre du mot
            string lettre;
            lettre = textBox5.Text;
            place = alpha.IndexOf(lettre.ToLower() )+1;
            int[] valLettre = new int[5];
            valLettre[0] = place;
            for (int x=1; x<=4; x++)
            {
                valLettre[x] = valLettre[x-1]+26;
            }

            StringCollection valeurs = new StringCollection();
            StringCollection valeursnb = new StringCollection();


            // premier ligne
            for (int x=0;x<=3;x++)
            {
                valeurs.Add( tableauVal[0, x].ToString());
                valeursnb.Add((x+1).ToString());
                int ind = valeurs.Count;
                Console.WriteLine(valeursnb[ind - 1].ToString() + " : " + valeurs[ind - 1].ToString());

            }

            // premiere et deuxieme ligne
            for (int x = 0; x <= 3; x++)
            {
                int val = 0;
                val = tableauVal[0, x];
                for (int y=0;y<=3;y++)
                {
                    int val1 = 0;
                    val1 = tableauVal[1, y];
                    int valtot = val + val1;
                    valeurs.Add(valtot.ToString());
                    valeursnb.Add((x+1).ToString()+(y+1).ToString());
                    int ind = valeurs.Count;
                    Console.WriteLine(valeursnb[ind-1].ToString() + " : " + valeurs[ind - 1].ToString());
                }
                
            }

            // premiere et deuxieme et troisieme ligne
            for (int x = 0; x <= 3; x++)
            {
                int val = 0;
                val = tableauVal[0, x];
                for (int y = 0; y <= 3; y++)
                {


                    int val1 = 0;
                    val1 = tableauVal[1, y];
                    for (int z = 0; z <= 3; z++)
                    {
                        int val2 = 0;
                        val2 = tableauVal[2, z];
                        int valtot = val + val1+val2;
                        valeurs.Add(valtot.ToString());
                        valeursnb.Add((x + 1).ToString() + (y + 1).ToString() + (z + 1).ToString());
                        int ind = valeurs.Count;
                        Console.WriteLine(valeursnb[ind - 1].ToString() + " : " + valeurs[ind - 1].ToString());

                    }


                }

            }



            // premiere et deuxieme et troisieme et 4eme  ligne
            for (int x = 0; x <= 3; x++)
            {
                int val = 0;
                val = tableauVal[0, x];
                for (int y = 0; y <= 3; y++)
                {


                    int val1 = 0;
                    val1 = tableauVal[1, y];
                    for (int z = 0; z <= 3; z++)
                    {
                        int val2 = 0;
                        val2 = tableauVal[2, z];
                        for (int zz = 0; zz <= 3; zz++)
                        {
                            int val3 = 0;
                            val3 = tableauVal[3, zz];
                            int valtot = val + val1 + val2+val3;
                            valeurs.Add(valtot.ToString());
                            valeursnb.Add((x + 1).ToString() + (y + 1).ToString() + (z + 1).ToString()+(zz + 1).ToString());
                            int ind = valeurs.Count;
                            Console.WriteLine(valeursnb[ind - 1].ToString() + " : " + valeurs[ind - 1].ToString());

                        }


                    }


                }

            }


            //recherche un des codes de vallettre parmis  valeurs et retourne valeurnb
            label4.Text = "";
            for (int x=0;x<=4;x++)
            {
                int rech = valLettre[x];
                int inde = valeurs.IndexOf(rech.ToString());
                if (inde>-1)
                {
                    Console.Write("index : " + inde.ToString());
                    Console.Write("valeur : ");
                    Console.Write(valeurs[inde].ToString());
                    Console.Write(" -> symboles : ");
                    Console.Write(valeursnb[inde].ToString());
                    Console.WriteLine();
                    label4.Text = label4.Text + valeursnb[inde].ToString() + "\r\n";
                }
            }






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
        }
    }
}
