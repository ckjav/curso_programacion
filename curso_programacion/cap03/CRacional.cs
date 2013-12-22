using System;

namespace cap03
{
    class CRacional
    {
        private int Numerador;
        private int Denominador;

        public void AsignarDatos(int num, int den)
        {
            Numerador = num;
            if (den == 0)
                Denominador = 1;
            Denominador = den;
        }

        public void VisualizarRacional()
        {
            Console.WriteLine(Numerador + "/" + Denominador);
        }
    }
}
