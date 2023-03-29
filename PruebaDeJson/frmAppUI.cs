using System.Text.Json;

namespace PruebaDeJson
{
    public partial class frmAppUI : Form
    {
        List<Registro> datos = new List<Registro>();
        public frmAppUI()
        {
            InitializeComponent();
        }
        string ISBN = "";
        string Titulo = "";
        string Autor = "";
        string Editorial = "";
        int Paginas = 0;
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Da valores de los texbox a las variables
            ISBN = txtISBN.Text;
            Titulo = txtTitulo.Text;
            Autor = txtAutor.Text;
            Editorial = txtEditorial.Text;
            Paginas = int.Parse(txtPagina.Text);

            // guarda los valores en las variables de la clase registro
            datos.Add(new Registro { ISBN1 = ISBN, Titulo1 = Titulo, Autor1 = Autor, Editorial1 = Editorial, Pagina1 = Paginas });

            txtAutor.Clear();
            txtEditorial.Clear();
            txtISBN.Clear();
            txtPagina.Clear();
            txtTitulo.Clear();
            txtISBN.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            string json = JsonSerializer.Serialize(datos);
            File.WriteAllText("RegistroDeLIbros.json", json);
            MessageBox.Show(" SE A CREADO EL ARCHIVO JSON EXITOSAMENTE", " CREADO");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("RegistroDeLIbros.json"))
            {
                string cargar = File.ReadAllText("RegistroDeLIbros.json");
                datos = JsonSerializer.Deserialize<List<Registro>>(cargar);
            }
            

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmPrinter mostrar = new frmPrinter();
            mostrar.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Esta seguro que quiere salir?", "REGISTRO", MessageBoxButtons.YesNo, MessageBoxIcon.Question
              );

            if (d == DialogResult.Yes)
                this.Close();
        }
    }
}