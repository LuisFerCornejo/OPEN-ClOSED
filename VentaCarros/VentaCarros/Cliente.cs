using System;
using System.Collections.Generic;
using System.Text;
//Tenemos esta clase "Cliente" donde se establecen los datos de los clientes que ya vayan hacer la compra del vehículo
namespace VentaCarros
{
    class Cliente
    {
        //Tenemos las 4 variables que nos va a ser de ayuda para ingresar los datos solicitados
        private string Apellido;
        private string Nombre;
        private int Cedula;
        private int Celular;
        
        public Cliente(string Apellido, string Nombre, int Cedula, int Celular)
        {
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.Celular = Celular;
           
        }

        public string getApellido()
        {
            return Apellido;
        }
        public void setApellido(string Apellido)
        {
            this.Apellido = Apellido;
        }


        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }


        public int getCedula()
        {
            return Cedula;
        }
        public void setCedula(int Cedula)
        {
            this.Cedula = Cedula;
        }



        public int getCelular()
        {
            return Celular;
        }
        public void setCelular(int Celular)
        {
            this.Celular = Celular;
        }


        //Aqui aplicamos polimorfismo por medio de (Virtual/Override)
        public virtual void ImprimirDatosCliente()
        {
            Console.WriteLine("**Datos del Cliente**");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Cédula: " + Cedula);
            Console.WriteLine("Celular: " + Celular);
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
