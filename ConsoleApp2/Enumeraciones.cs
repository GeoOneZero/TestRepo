using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica
{
	//Clase para definir enumeraciones
	// Sintaxis
	//  modificador_acceso     class    NombreClase     {  Definicion de la clase  }  
	//  Modificadores: public, private, internal... 
	public class Enumeraciones
	{
		//Convención utilizada:   Identificadores, Notación camel PrimerLetraMayuscula
		public enum EstadoVehiculo { 
			Disponible,
			EnRuta,
			EnMantenimiento
		}

		public enum TipoLicencia { 
			A, B, C, D
		}

		public enum EstadoEntrega { Pendiente, EnTransito, Entregado, Cancelado }

	}
}
