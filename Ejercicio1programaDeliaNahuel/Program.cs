using System;

namespace ejercicio1parcialdelianahuel
{
	class program
	{

		static void Main(string[] args)
		{
			double distancia;
			double kilometro;
			double metro;
			double tiempo;
			double velocidad;
			Console.WriteLine("Calculemos la distancia recorrida, en base al tiempo y la velocidad.");
			Console.Write(" Ingrese velocidad en m/s:");
			velocidad = Double.Parse(Console.ReadLine());
			Console.Write("ingrese el tiempo en minutos");
			tiempo = Double.Parse(Console.ReadLine());
			distancia = velocidad * tiempo;
			Console.WriteLine("Su distancia recorrida es:" + distancia + "m");
			kilometro = distancia * 0.001;
			Console.WriteLine("la distancia recorrida es:" + kilometro + "km");
		}

	}

}

