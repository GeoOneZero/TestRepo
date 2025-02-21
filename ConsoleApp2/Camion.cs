using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica
{
	//Herencia  ->    Clase : ClaseBase
	public class Camion : Vehiculo //Convenciones: Nombres clases comienzan con mayúscula.
	{
		public bool Refrigerado { get; set; } //bool (true, false)
		public int Ejes { get; set; }

		public Camion(int id, string marca, string modelo, float capacidadCarga, int ejes, bool refrigerado) 
			: base (id, marca, modelo, capacidadCarga)
		{
			Ejes = ejes;
			Refrigerado = refrigerado;
		}

		public Camion(int id, string marca, float capacidadCarga, int ejes, bool refrigerado)
			: base(id, marca, "", capacidadCarga)
		{
			Ejes = ejes;
			Refrigerado = refrigerado;
		}

		// Definición de método
		// modificadorAcceso características tipoDatoDevuelto NombreMétodo(tipoDato pararam1, tipoDato2 param2,...)
		//Override se indica para implementar método abstracto y sobre escribe ese método.
		//
		public override float CalcularCostoViaje(float distancia)
		{
			//Definición de variables
			// tipoDato nombreVariable;
			// tipoDato nombreVariable = valor;
			float costoBase = distancia * 2.5f;// f significa que este valor es float
			if (Refrigerado)
			{
				costoBase += 50;   //   costoBase = costoBase + 50;
			}

			return costoBase;
		}
	}
}
