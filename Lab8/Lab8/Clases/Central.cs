using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    class Central
    {
        List<Tienda> listaTiendas = new List<Tienda>();
        List<Restaurante> listaRestaurantes = new List<Restaurante>();

        public Tienda CreacionTienda(string nombre, string numero, string horario)
        {
            Tienda tienda = new Tienda(nombre, numero, horario);
            AgregarTienda(tienda);
            return tienda;
        }

        public void AgregarTienda(Tienda tienda)
        {
            listaTiendas.Add(tienda);
        }

        public Restaurante CreacionRestaurante(string nombre, string numero, string horario)
        {
            Restaurante Restaurante = new Restaurante(nombre, numero, horario);
            AgregarRestaurante(Restaurante);
            return Restaurante;
        }

        public void AgregarRestaurante(Restaurante Restaurante)
        {
            listaRestaurantes.Add(Restaurante);
        }
    }
}
