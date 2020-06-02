using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    class Tienda : Local
    {
        List<string> categorias = new List<string>();
        public Tienda(string nombre, string identificador, string horario) : base(nombre, identificador, horario)
        {
            //
        }

        public void AgregarCategoria(string categoria)
        {
            categorias.Add(categoria);
        }
    }
}
