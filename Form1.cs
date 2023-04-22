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

            


            imageList1.Images.Add(Properties.Resource1.a);
            imageList1.Images.Add(Properties.Resource1.b);
            imageList1.Images.Add(Properties.Resource1.c);
            imageList1.Images.Add(Properties.Resource1.d);
            imageList1.Images.Add(Properties.Resource1.e);
            imageList1.Images.Add(Properties.Resource1.f);
            imageList1.Images.Add(Properties.Resource1.g);
            imageList1.Images.Add(Properties.Resource1.h);
            imageList1.Images.Add(Properties.Resource1.i);
            imageList1.Images.Add(Properties.Resource1.j);
            imageList1.Images.Add(Properties.Resource1.k);
            imageList1.Images.Add(Properties.Resource1.l);
            imageList1.Images.Add(Properties.Resource1.m);
            imageList1.Images.Add(Properties.Resource1.n);
            imageList1.Images.Add(Properties.Resource1.o);
            imageList1.Images.Add(Properties.Resource1.p);
            imageList1.Images.Add(Properties.Resource1.q);
            imageList1.Images.Add(Properties.Resource1.r);
            imageList1.Images.Add(Properties.Resource1.s);
            imageList1.Images.Add(Properties.Resource1.t);
            imageList1.Images.Add(Properties.Resource1.u);
            imageList1.Images.Add(Properties.Resource1.v);
            imageList1.Images.Add(Properties.Resource1.w);
            imageList1.Images.Add(Properties.Resource1.x);
            imageList1.Images.Add(Properties.Resource1.y);
            imageList1.Images.Add(Properties.Resource1.z);



            pictureBox1.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;

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
            int numeroLigne = 0;
            label4.Text = "";
            bool h=groupBox1.HasChildren;
            if (h==true)
            {
                groupBox1.Controls.Clear();
            }
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
                    numeroLigne += 1;
                    dessine_pic(valeursnb[inde],numeroLigne);
                    //creer les images
                    
                }
                
            }






        }

        public void dessine_pic(string valeurs,int ligne)
        {
            Point imLoc;
            imLoc = new Point(90, (ligne*70)-60);
            Label indik = new Label();
            indik.Text = "Combinaison " + ligne.ToString() + " :";
            indik.AutoSize = true;
            indik.Parent = groupBox1;
            indik.Location = new Point(2, (ligne*70)-50);
            // ex : valeurs = "221"
            int x = valeurs.Length;
            for (int y=0;y<=x-1;y++)
            {
                int chiffre = 0;
                bool isok=int.TryParse( valeurs.Substring(y, 1), out chiffre);
               if (isok)
                {
                    PictureBox ik = new PictureBox();
                    ik.SizeMode = PictureBoxSizeMode.StretchImage;
                    ik.BackColor = Color.Black;
                    ik.Image = imageList1.Images[chiffre - 1];
                    ik.Width = 50;
                    ik.Height = 50;
                    ik.Parent = groupBox1;
                    ik.Location = imLoc;
                    imLoc.X += 60;
                }
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fo = new Form2();
            fo.Show();
        }

        
        
        private void textBox1_Click(object sender, EventArgs e)
        {

            using (var choices = new Form3(1))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox1.Text = alpha[val].ToString();
                    pictureBox1.Image = imageList1.Images[val];
                    
                }
            }

            //Form3 choices = new Form3(1);
            //choices.Show();
            //string g = choices.ReturnValue1;

        }

        

        private void textBox2_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(2))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox2.Text = alpha[val].ToString();
                    pictureBox2.Image = imageList1.Images[val];

                }
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(3))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox3.Text = alpha[val].ToString();
                    pictureBox3.Image = imageList1.Images[val];

                }
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(4))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox4.Text = alpha[val].ToString();
                    pictureBox4.Image = imageList1.Images[val];

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(1))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox1.Text = alpha[val].ToString();
                    pictureBox1.Image = imageList1.Images[val];

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(2))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox2.Text = alpha[val].ToString();
                    pictureBox2.Image = imageList1.Images[val];

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(3))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox3.Text = alpha[val].ToString();
                    pictureBox3.Image = imageList1.Images[val];

                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (var choices = new Form3(4))
            {
                var result = choices.ShowDialog();
                if (result == DialogResult.OK)
                {
                    int val = choices.ReturnValue;            //values preserved after close
                    textBox4.Text = alpha[val].ToString();
                    pictureBox4.Image = imageList1.Images[val];

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
