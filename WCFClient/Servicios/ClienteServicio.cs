namespace WCFClient.Servicios
{
    using ServiceContract;
    using System;
    using System.ServiceModel;

    public class ClienteServicio
    {
        public async void TestFaultService()
        {
            InventarioClient cliente = new InventarioClient();
            try
            {
                Console.WriteLine("Agregado al inventario");
                await cliente.AgregarInventarioAsync(0, "" , 0);
                cliente.Close();
            }
            catch (FaultException<InventarioFault> inventFault)
            {
                Console.WriteLine($"{inventFault.Detail.Mensaje}");
                cliente.Abort();
            }
        }
    }
}
