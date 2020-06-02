using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Clases
{
    class Restaurante : Local
    {
        bool mesasExclusivas;
        public Restaurante(string nombre, string identificador, string horario) : base(nombre, identificador, horario)
        {
            //
        }

        public void Exclusividad(string booleano)
        {
            if(booleano == "NO")
            {
                mesasExclusivas = false;
            }

            else if (booleano == "SI")
            {
                mesasExclusivas = true;
            }
        }
    }
}
