using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public interface IDLAuto
    {
        IEnumerable<Auto> ListarAutos();
        IEnumerable<Auto> BuscarAutos(string marca);
    }
}
