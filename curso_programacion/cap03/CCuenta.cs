using System;

namespace cap03
{
    class CCuenta
    {
        private string nombre;
        private string cuenta;
        private double saldo;
        private double tipoDeInteres;

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length == 0)
                {
                    Console.WriteLine("Error: cadena vacía");
                    return;
                }
                nombre = value;
            }
        }


        public double Saldo
        {
            get
            {
                return saldo;
            }
        }


        public void asignarNombre(string nom)
        {
            if (nom.Length == 0)
            {
                Console.WriteLine("Error: cadena vacía");
                return;
            }
            nombre = nom;
        }


        public string obtenerNombre()
        {
            return nombre;
        }


        public void asignarCuenta(string cue)
        {
            if (cue.Length == 0)
            {
                Console.WriteLine("Error: cuenta no válida");
                return;
            }
            cuenta = cue;
        }


        public string obtenerCuenta()
        {
            return cuenta;
        }


        public void ingreso(double cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("Error: cantidad negativa");
                return;
            }
            saldo += cantidad;
        }


        public void reintegro(double cantidad)
        {
            if (saldo - cantidad < 0)
            {
                Console.WriteLine("Error: no dispone de saldo");
                return;
            }
            saldo -= cantidad;
        }


        public void asignarTipoDeInteres(double tipo)
        {
            if (tipo < 0)
            {
                Console.WriteLine("Error: tipo no válido");
                return;
            }
            tipoDeInteres = tipo;
        }


        public double obtenerTipoDeInteres()
        {
            return tipoDeInteres;
        }


        public double estado()
        {
            return saldo;
        }
        #endregion

        #region Constructor
        public CCuenta()
        {
        }

        public CCuenta(string _nom, string _cue, double _sal, double _tipo)
        {
            asignarNombre(_nom);
            asignarCuenta(_cue);
            ingreso(_sal);
            asignarTipoDeInteres(_tipo);
        }
        #endregion
    }
}
