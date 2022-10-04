namespace Animais
{
	public class Cachorro : Animal
	{
		public double Tamanho { get; set; }

		public void GravarNome(string nome, string cor, double tamanho, string especie)
		{
			Tamanho = tamanho;
			Especies = especie;
			Nome = nome;
			Cor = cor;
		}

		public void MostarDados()
		{
			Console.WriteLine(Nome);
			Console.WriteLine(Cor);
			Console.WriteLine(Tamanho);
			Console.WriteLine(Especies);
		}
	}
}
