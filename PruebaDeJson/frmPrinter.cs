using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace PruebaDeJson
{
    public partial class frmPrinter : Form
    {
        public frmPrinter()
        {
            InitializeComponent();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
             string json = File.ReadAllText("RegistroDeLIbros.json");
            List<Registro> datos = JsonSerializer.Deserialize<List<Registro>>(json);

            foreach (Registro valores in datos)
            {
                ListViewItem imprimir = new ListViewItem(valores.ISBN1);
                imprimir.SubItems.Add(valores.Titulo1);
                imprimir.SubItems.Add(valores.Autor1);
                imprimir.SubItems.Add(valores.Editorial1);
                imprimir.SubItems.Add(valores.Pagina1.ToString());
                lvImprimir.Items.Add(imprimir);
            }


        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLibros1 devolver = new frmLibros1();
            devolver.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Esta seguro que quiere salir?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question
              );

            if (d == DialogResult.Yes)
                this.Close();
            frmLibros1 cerrar = new frmLibros1();
            cerrar.Close();
        }
    }
}
