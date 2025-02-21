//Directivas
//using... se asocie este archivo al espacio de nombres indicado abajo
using static Logistica.Enumeraciones;

namespace Logistica
{
	//Clase abstracta... 
	public abstract class Vehiculo
	{
		//Propiedad
		//ModificadorAccesso    TipoDato   NombrePropiedad   {get; set;  }

		//get indica que la propiedad es de lectura
		//set indica que la propiedad es de escritura

		//Tipos de datos C#
		//   int    entero,    string   cadenaTexto    float  númeroConDecimal

		//Propiedades de la clase (Encapsulamiento)
		public int Id { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public float CapacidadCarga { get; set; }
		public EstadoVehiculo Estado { get; set; }
		 
		//Constructor de la clase
		//Es un método que es llamado al crear una instancia de la clase

		public Vehiculo(int id, string marca, string modelo, float capacidadCarga )
		{ 
			//Asignación      Elemento1  =   Elemento2;      
			Id = id;
			Marca = marca;
			Modelo = modelo;
			CapacidadCarga = capacidadCarga;
			Estado = EstadoVehiculo.Disponible; //Asignar valor por defecto
		}
		//Método abstracto, no tiene implementación
		public abstract float CalcularCostoViaje( float distancia);

		public void CambiarEstado(EstadoVehiculo estado)
		{ 
			Estado = estado;
		}


	}
}
