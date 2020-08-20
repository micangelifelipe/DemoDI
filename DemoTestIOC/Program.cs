using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;
using Contenedor;

namespace DemoTestIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            //IDLAuto bfAuto = new BFAuto(new DLAuto());

            var contendor = new ContenedorHelper();
            contendor.RegistrarImplementacion<Datos.IDLAuto, Datos.DLAuto>();
            contendor.RegistrarImplementacion<Negocio.IBFAuto, Negocio.BFAuto>();

            //IBFAuto bFAuto = new BFAuto(contendor.Crear<Datos.IDLAuto>());

            IBFAuto bfAuto = contendor.Resolver<IBFAuto>();

            var autos = bfAuto.ListarAutos();

            foreach (var auto in autos)
            {
                Console.WriteLine(string.Format("{0} - {1}", auto.id.ToString(), auto.marca));
            }

            Console.ReadKey();
        }
    }
}
