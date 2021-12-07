using System;
using System.Collections.Generic;
using System.Text;
//Esta interface va es creada en base a una nueva necesidad que adquiere la empresa
//donde la persona que adquirio nuestro programa nos informa que ya no solo se va a dedicar a la venta de vehículos
//nuevos si no que tambien de vehículos de segunda mano y para eso creamos esta interface para mostrar por pantalla si el vehiculo adquirido
// es nuevo o usado
namespace VentaCarros
{
    interface NuevoUsado
    {
        int Kilometraje();
        string Estado();
    }
}
