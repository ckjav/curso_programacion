using System;

namespace cap03
{
    class CCuentaAhorro:CCuenta
    {
        #region Atributos
        private double cuotaMantenimineto;
        #endregion


        #region Constructores
        public CCuentaAhorro()
        {
        }

        public CCuentaAhorro(string _nom, string _cue, double _sal, double _tipo, double _mant) :
            base(_nom, _cue, _sal, _tipo)
        {
            asignarCuotaMantenimiento(_mant);
        }
        #endregion


        #region Metodos
        public void asignarCuotaMantenimiento(double _cantidad)
        {
            if (_cantidad < 0)
            {
                System.Console.WriteLine("Error: cantidad negativa");
                return;
            }
            cuotaMantenimineto = _cantidad;
        }

        public double obtenerCuotaMantenimiento()
        {
            return cuotaMantenimineto;
        }

        public void reintegro(double _cantidad)
        {
            double saldo = estado();
            double tipoDeInteres = obtenerTipoDeInteres();

            if (tipoDeInteres >= 3.5)
            {
                if (saldo - _cantidad < 1500)
                {
                    System.Console.WriteLine("Error: no dispone de esa cantidad");
                    return;
                }
            }

            base.reintegro(_cantidad);//método reintegro de la clase base, también llamada superclase
        }
        #endregion
    }
}
