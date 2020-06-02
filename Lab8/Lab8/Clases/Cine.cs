using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    class Cine : Local
    {
        string sala;
        Cine(string nombre, string identificador, string horario) : base(nombre, identificador, horario)
        {
            //
        }

        public void NumeroSalas(string sala)
        {
            this.sala = sala;
        }
    }
}
