//Definición de programa principal.

using Logistica; // using nos sirve para indicar que estamos haciendo uso de un espacio de nombres específico (Logistica)
				 // un espacio de nombres es una agrupación lógica de clases.


//Crear objeto de tipo Camion
// NombreClase nombreObjeto = new NombreClase(param1, param2...);
Camion camionV = new Camion(1, "Volvo",  2000, 6, true);

// declaración de variables
// tipoDato nombreVariable = valor    valor es el resultado de la llamada del método de instancia.
// método de instancia porque su ejecución depende de objeto mismo.
float costoViajeCamionV = camionV.CalcularCostoViaje(145f);

Camion camionF = new Camion(2, "Ford", "HY6789", 6000, 4, false);

float costoViajeCamionF = camionF.CalcularCostoViaje(320f);


Console.WriteLine("--Programa de logistica--"); // muestra en la consola el texto, textos entrecomillados...


Console.WriteLine($"Para el camion con id: {camionV.Id}, Marca {camionV.Marca} y  modelo {camionV.Modelo} el costo del viaje fue {costoViajeCamionV} ");

Console.WriteLine($"Para el camion con id: {camionF.Id}, Marca {camionF.Marca} y  modelo {camionF.Modelo} el costo del viaje fue {costoViajeCamionF} ");



