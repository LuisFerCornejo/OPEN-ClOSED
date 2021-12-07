using System;

namespace VentaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine("**Datos de la compra**");
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");

            Console.WriteLine("");
            Vendedor Vendedor = new Vendedor("Lucas", "Angie", 1305252487, 0985874544);
            Vendedor.ImprimirDatosVendedor();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("");
            Carro Carro = new Carro("Cornejo", "Luis", 1313839555, 0962930821, "Silverado", "Chevrolet", "Blanco", 2020, 98000);
            Carro.ImprimirDatosCliente();
        
            NuevoUsado[] NU = {Carro};
            foreach (NuevoUsado item in NU)
            {
                Console.WriteLine("El kilometraje es: " +item.Kilometraje());
                Console.WriteLine("El estado del vehiculo es: "+item.Estado());
            }
        }
    }
}
