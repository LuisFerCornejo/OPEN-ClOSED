using System;
using System.Collections.Generic;
using System.Text;
//Tenemos esta clase "Vendedor" donde se establecen los datos de los Vendedores
namespace VentaCarros
{
    class Vendedor
    {
        //Tenemos las 4 variables que nos va a ser de ayuda para ingresar los datos solicitados
        string NombreV;
        string ApellidoV;
        int CedulaV;
        int CelularV;

        public Vendedor (string ApellidoV, string NombreV, int CedulaV, int CelularV)
        {
            this.ApellidoV = ApellidoV;
            this.NombreV = NombreV;
            this.CedulaV = CedulaV;
            this.CelularV = CelularV;
        }
        //Aqui aplicamos polimorfismo por medio de (Virtual/Override)
        public virtual void ImprimirDatosVendedor()
        {
            
            Console.WriteLine("**Datos del Vendedor**");
            Console.WriteLine("Nombre: " + NombreV);
            Console.WriteLine("Apellido: " + ApellidoV);
            Console.WriteLine("Cedula: " + CedulaV);
            Console.WriteLine("Celular: " + CelularV);
            
        }
    }
}
