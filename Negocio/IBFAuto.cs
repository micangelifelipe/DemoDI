using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public interface IBFAuto
    {
        IEnumerable<Auto> ListarAutos();
        IEnumerable<Auto> BuscarAutos(string marca);
    }
}
