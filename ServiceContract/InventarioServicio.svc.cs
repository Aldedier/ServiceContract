namespace ServiceContract
{
    using System.Collections.Generic;
    using System.ServiceModel;

    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "InventarioServicio" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione InventarioServicio.svc o InventarioServicio.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class InventarioServicio : IInventarioServicio
    {
        #region Mock Inventario
        private readonly IList<Inventario> inventarios = new List<Inventario>()
        {
            new Inventario {Codigo = 1, Nombre = "Galleta 1", Cantidad = 50},
            new Inventario {Codigo = 2, Nombre = "Galleta 2", Cantidad = 55},
            new Inventario {Codigo = 3, Nombre = "Galleta 3", Cantidad = 56},
            new Inventario {Codigo = 4, Nombre = "Galleta 4", Cantidad = 57},
            new Inventario {Codigo = 5, Nombre = "Galleta 5", Cantidad = 58},
            new Inventario {Codigo = 6, Nombre = "Galleta 6", Cantidad = 59}
        };
        #endregion



        public void AgregarInventario(int codigo, string nombre, int cantidad)
        {
            if (codigo < 1)
                throw new FaultException<InventarioFault>(new InventarioFault("Codigo Invalido"));

            inventarios.Add(new Inventario
            {
                Codigo = codigo,
                Nombre = nombre,
                Cantidad = cantidad
            });
        }
        public IEnumerable<Inventario> ObtenerInventario() => inventarios;
    }
}
