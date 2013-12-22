using System;

namespace cap03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cuentas
            /*
            CCuentaAhorro cuenta01 = new CCuentaAhorro("Un nombre 2", "Una cuenta 2", 6000, 3.5, 0.60);
            CCuenta cuenta02 = new CCuenta("Un nombre", "Una cuenta", 6000, 3.5);

            cuenta01.reintegro(cuenta01.obtenerCuotaMantenimiento());
            cuenta01.ingreso(6000);
            cuenta01.reintegro(10000);

            cuenta02.asignarNombre("Un nombre");
            cuenta02.asignarCuenta("Una cuenta");
            cuenta02.asignarTipoDeInteres(2.5);
            cuenta02.ingreso(12000);
            cuenta02.reintegro(3000);

            Console.WriteLine(cuenta01.obtenerNombre());
            Console.WriteLine(cuenta01.obtenerCuenta());
            Console.WriteLine(cuenta01.estado());
            Console.WriteLine(cuenta01.obtenerTipoDeInteres());
            */

            //Ordenador
            /*
            COrdenador ordenador01 = new COrdenador();
            ordenador01.Marca = "Toshiba";
            ordenador01.EncenderEquipo();
            ordenador01.Estado();
             */

            //Racionales
            CRacional racional = new CRacional();
            racional.AsignarDatos(2, 5);
            racional.VisualizarRacional();


            Console.Read();
        }
    }
}
