using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class BFAuto : IBFAuto
    {
        public readonly IDLAuto dlAuto;

        public BFAuto(IDLAuto DiAuto)
        {
            dlAuto = DiAuto;
        }

        public IEnumerable<Auto> ListarAutos()
        {
            return dlAuto.ListarAutos();
        }

        public IEnumerable<Auto> BuscarAutos(string marca)
        {
            return dlAuto.BuscarAutos(marca);
        }
    }
}
