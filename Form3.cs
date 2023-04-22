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
    
    public partial class Form3 : Form
    {
        public int caseN;
        public int ReturnValue { get; set; }
      
        public  Form3(int CaseNumber)
        {
            InitializeComponent();
            caseN = CaseNumber;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Init_choices();
            label1.Text = caseN.ToString();
        }

        public void Init_choices()
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

            listView1.View = View.Tile;
            listView1.TileSize = new Size(84, 91);
            //imageList1.ImageSize = new Size(80, 80);
            //listView1.SmallImageList = imageList1;
            listView1.LargeImageList = imageList1;
            listView1.Items.Add("A", 0);
            listView1.Items.Add("B", 1);
            listView1.Items.Add("C", 2);
            listView1.Items.Add("D", 3);
            listView1.Items.Add("E", 4);
            listView1.Items.Add("F", 5);
            listView1.Items.Add("G", 6);
            listView1.Items.Add("H", 7);
            listView1.Items.Add("I", 8);
            listView1.Items.Add("J", 9);
            listView1.Items.Add("K", 10);
            listView1.Items.Add("L", 11);
            listView1.Items.Add("M", 12);
            listView1.Items.Add("N", 13);
            listView1.Items.Add("O", 14);
            listView1.Items.Add("P", 15);
            listView1.Items.Add("Q", 16);
            listView1.Items.Add("R", 17);
            listView1.Items.Add("S", 18);
            listView1.Items.Add("T", 19);
            listView1.Items.Add("U", 20);
            listView1.Items.Add("V", 21);
            listView1.Items.Add("W", 22);
            listView1.Items.Add("X", 23);
            listView1.Items.Add("Y", 24);
            listView1.Items.Add("Z", 25);
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
            this.Close();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            this.Close();
        }

       

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int i = listView1.FocusedItem.Index;
            this.ReturnValue = i;
           // MessageBox.Show("double " + i);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            int i = listView1.FocusedItem.Index;
           // MessageBox.Show("click " + i);
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
