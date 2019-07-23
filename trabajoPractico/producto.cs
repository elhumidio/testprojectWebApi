using System;
using System.Collections.Generic;
using System.Text;

namespace trabajoPractico
{
    class producto
    {
        int _codigoProducto;
        string _nombre;
        Int16 _idRubro;
        int _stockActual;
        
        
        public  producto (int C, string N, int SA,Int16 IDR)
        {
            if (C > 0 && N != "" && SA > -1 && IDR >-1)
            {
                _codigoProducto = C;
                _nombre = N;
                _stockActual = SA;
                _idRubro = IDR;
            }
            else throw new ArgumentException("Verificar datos", "Error");


        }

        public int codigoProducto
        {
            set { _codigoProducto = value; }
            get { return _codigoProducto; }
        }

        public string Nombre
        {
            set { _nombre= value; }
            get { return _nombre; }
        }
        public int stockActual
        {
            set {_stockActual = value; }
            get { return _stockActual; }
        }
        public Int16 idRubro
        {
            set { _idRubro = value; }
            get { return _idRubro; }
        }


    }
}
