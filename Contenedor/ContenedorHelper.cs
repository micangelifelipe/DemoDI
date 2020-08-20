using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contenedor
{
    /// <summary>
    /// Registra el mapeo entre la interfaz y a implementación concreta de la interfaz
    /// Crea objetos y resuelve dependencias
    /// dispose
    /// </summary>
    public class ContenedorHelper
    {
        private readonly Hashtable registros;

        public ContenedorHelper()
        {
            registros = new Hashtable();
        }

        public void RegistrarImplementacion<TInterface, TImplementacion>()
        {
            registros.Add(typeof(TInterface), typeof(TImplementacion));
        }

        public TInterface Crear<TInterface>()
        {
            var typeofImple = (Type)registros[typeof(TInterface)];
            if (typeofImple == null)
            {
                throw new ApplicationException($"Error al resolver {typeof(TInterface).Name}");
            }
            return (TInterface)Activator.CreateInstance(typeofImple);
        }

        public T Resolver<T>()
        {
            var ctor = ((Type)registros[typeof(T)]).GetConstructors()[0];
            var dep = ctor.GetParameters()[0].ParameterType;
            var mi = typeof(ContenedorHelper).GetMethod("Crear");
            var gm = mi.MakeGenericMethod(dep);
            return (T)ctor.Invoke(new object[] { gm.Invoke(this, null) });

        }
    }
}
