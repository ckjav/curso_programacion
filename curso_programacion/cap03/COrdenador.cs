using System;

namespace cap03
{
    class COrdenador
    {
        #region Variables
        private string vMarca;
        #endregion

        #region Propiedades
        public string Marca
        {
            get
            {
                return vMarca; 
            }
            set
            {
                vMarca = value;
            }
        }

        public string Procesador;
        public short Peso;
        public bool Encendido;
        public bool PantallaEncendida;
        #endregion

        #region Metodos
        public void EncenderEquipo()
        {
            if (Encendido == true)
            {
                Console.WriteLine("El equipo ya está encendido.");
            }
            else
            {
                Encendido = true;
                PantallaEncendida = true;
                Console.WriteLine("El equipo ha sido encendido.");
            }
        }

        public void Estado()
        {
            Console.WriteLine("El estado del equipo es el siguiente: ");
            Console.WriteLine("Marca: " + Marca);
            Console.WriteLine("Procesador: " + Procesador);
            Console.WriteLine("Peso: " + Peso + " kg.");

            if (Encendido == true)
            {
                Console.WriteLine("El equipo esta encendido");
            }
            else
            {
                Console.WriteLine("el equipo esta apagado.");
            }

            if (PantallaEncendida == true)
            {
                Console.WriteLine("La pantalla esta encendida");
            }
            else
            {
                Console.WriteLine("La pantalla esta apagada");
            }

            Console.WriteLine("");
        }

        public void ApagarEquipo()
        {

        }

        public void DesactivarPresentacionPantalla()
        {

        }

        public void ActivarPresentacionPantalla()
        {

        }

        public void CargarAplicacion()
        {

        }
        #endregion
    }
}
