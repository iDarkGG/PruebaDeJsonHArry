using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDeJson
{
    public class Registro
    {
        private string ISBN;
        private string Titulo;
        private string Autor;
        private string Editorial;
        private int Pagina;

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public string Editorial1 { get => Editorial; set => Editorial = value; }
        public int Pagina1 { get => Pagina; set => Pagina = value; }
    }
}
     