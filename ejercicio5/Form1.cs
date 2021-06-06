using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EJERCICIO 5!!!!!!!!!!!

namespace ejercicio5
{
    public partial class Form1 : Form
    {

        String titulo = "Ejercicio 5";
        int contadorTitulo, contadorTimer = 0;
        Icon icono1, icono2;
        public Form1()
        {
            InitializeComponent();
            Text = "";

            contadorTitulo = titulo.Length - 1;

            icono1 = new Icon(Directory.GetCurrentDirectory() + "\\listas.ico");
            icono2 = new Icon(Directory.GetCurrentDirectory() + "\\listas2.ico");

            Icon = icono1;
        }

        private void actualizar()
        {
            int[] array=new int[listBox1.SelectedIndices.Count];
            lblPrincipal.Text = "" + listBox1.Items.Count;
            lblSecundario.Text = "";
            for (int i=0; i < listBox1.SelectedIndices.Count; i++)
            {
                array[i] = listBox1.SelectedIndices[i];
            }
            for (int i=0; i < array.Length; i++)
            {
                lblSecundario.Text += "" + array[i] + " ";
            }
            toolTip1.SetToolTip(this.listBox2, "" + this.listBox2.Items.Count);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Marcos");
            listBox1.Items.Add("Juanjo");
            actualizar();
            timer1.Start();
        }

        private void BtnAnhadir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            actualizar();
        }

        private void BtnQuitar_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
                }

            }
            actualizar();
        }

        private void BtnTraspasar1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (int i=listBox1.SelectedIndices.Count-1; i>=0; i--)
                {
                    listBox2.Items.Insert(0, listBox1.SelectedItems[i]);
                    listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
                }
            }
            actualizar();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            contadorTimer++;

            if (contadorTitulo != -1)
            {
                Text = titulo[contadorTitulo] + Text;

                contadorTitulo--;
            }
            else
            {
                Text = "";
                contadorTitulo = titulo.Length - 1;
            }

            if (contadorTimer % 2 == 0)
            {
                if (Icon == icono1)
                {
                    Icon = icono2;
                }
                else
                {
                    Icon = icono1;
                }
            }
        }

        private void ListBox1_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        private void BtnTraspasar2_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                for(int i=listBox2.SelectedIndices.Count-1; i>=0; i--)
                {
                    listBox1.Items.Insert(0, listBox2.SelectedItems[i]);
                    listBox2.Items.RemoveAt(listBox2.SelectedIndices[i]);
                }
            }
            actualizar();
        }
    }
}
