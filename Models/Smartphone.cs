using System.Reflection;

namespace DesafioPOO.Models
{
	public abstract class Smartphone
	{
		public string Numero { get; set; }
		public string Modelo { get; set; }
		public string IMEI { get; set; }
		public int Memoria { get; set; }

		public Smartphone(string numero, string modelo, string imei, int memoria)
		{
			Numero = numero;
			Modelo = modelo;
			IMEI = imei;
			Memoria = memoria;
		}

		public void Ligar()
		{
			Console.WriteLine("Ligando...");
		}

		public void ReceberLigacao()
		{
			Console.WriteLine("Recebendo ligação...");
		}

		public void MostrarModelo(string marca, string modelo, int memoria)
		{
			Console.WriteLine($"{marca} {modelo}, com {memoria} de memória.");
		}

		public abstract void InstalarAplicativo(string nomeApp);
	}
}