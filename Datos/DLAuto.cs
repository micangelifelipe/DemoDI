using System;
using System.Collections.Generic;
using System.Linq;


namespace Datos
{
    public class DLAuto : IDLAuto
    {
        private readonly List<Auto> autos;

        public DLAuto()
        {
            autos = new List<Auto>
            {
                new Auto() {  id = Guid.NewGuid(), marca = "Chevrolet" },
                new Auto() { id = Guid.NewGuid(), marca = "Audi"},
                new Auto() { id = Guid.NewGuid(), marca = "Ford"}

            };
        }

        public IEnumerable<Auto> ListarAutos()
        {
            return autos;
        }

        public IEnumerable<Auto> BuscarAutos(string marca)
        {
            return autos.Where(i => i.marca.Contains(marca)).ToList();
        }
        
    }

    public class DlAuto2 
    {
        private readonly List<Auto> autos;

        public DlAuto2()
        {
            autos = new List<Auto>
            {
                new Auto() {  id = Guid.NewGuid(), marca = "Chevrolet" },
                new Auto() { id = Guid.NewGuid(), marca = "Audi"}

            };
        }

        public IEnumerable<Auto> ListarAutos()
        {
            return autos;
        }

        public IEnumerable<Auto> BuscarAutos(string marca)
        {
            return autos.Where(i => i.marca.Contains(marca)).ToList();
        }

    }
}
