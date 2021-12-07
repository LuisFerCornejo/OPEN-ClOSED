using System;
using System.Collections.Generic;
using System.Text;
//En esta clase es donde se procede con los datos del cliente y el vehículo que desea comprar
namespace VentaCarros
{
    class Carro:Cliente,NuevoUsado
    {
        string Modelo;
        string Marca;
        string Color;
        int Año;
        int Precio;

        public Carro(string Apellido, string Nombre, int Cedula, int Celular, string Modelo, string Marca, string Color, int Año, int Precio): base (Apellido, Nombre, Cedula, Celular)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
            this.Color = Color;
            this.Año = Año;
            this.Precio = Precio;            
        }

        //Aqui aplicamos polimorfismo por medio de (Virtual/Override)
        public override void ImprimirDatosCliente()
        {
            base.ImprimirDatosCliente();
            Console.WriteLine("**Datos del carro adquirido**");
            Console.WriteLine("Modelo: "+Modelo);
            Console.WriteLine("Marca: "+Marca);
            Console.WriteLine("Color: "+Color);
            Console.WriteLine("Año: "+Año);
            Console.WriteLine("Precio: "+Precio);
        }
        //Aqui vuelta se vuelve a aplicar polimorfismo por medio de interface
        public int Kilometraje()
        {
            return 1500;
            

        }

        public string Estado()
        {
            return "USADO";
        }
    }
}
