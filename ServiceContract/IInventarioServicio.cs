using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceContract
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IInventarioServicio" en el código y en el archivo de configuración a la vez.
    [ServiceContract (Namespace = "http://demoswcf/inventario", Name = "Inventario")]
    public interface IInventarioServicio
    {
        [OperationContract(Action = "http://demoswcf/inventario/ObtenerInventario")]
        IEnumerable<Inventario> ObtenerInventario();

        [OperationContract(Action = "http://demoswcf/inventario/AgregarInventario")]
        [FaultContract(typeof(InventarioFault), Action = "http://demoswcf/inventario/FaultInventario")]
        void AgregarInventario(int codigo, string nombre, int cantidad);
    }

    [DataContract]
    public class InventarioFault
    {
        [DataMember]  
        public string Mensaje { get; set; }

        public InventarioFault(string mensaje)
        {
            this.Mensaje = mensaje;
        }

    }


    [DataContract]
    public class Inventario
    {
        [DataMember(IsRequired = true)]
        public int Codigo { get; set; }

        [DataMember(IsRequired = true)]
        public string Nombre { get; set; }

        [DataMember(IsRequired = true)]
        public int Cantidad { get; set; }
    }

}
