using System;
using System.Collections.Generic;
using System.Text;

namespace trabajoPractico
{
    class Rubros
    {
        int _idRubro;
        string _nombre;



        public Rubros(string N)
        {
            if (N != "")
            {
                _nombre = N;

            }
            else throw new ArgumentException("Verificar Datos");
         }

        public string Nombre
        {
            set { _nombre = value; }
            get { return _nombre; }
        }
        public int Rubro
        {
            set
            {
                _idRubro = value;
            }
            get { return _idRubro; }
        }



    }
}
