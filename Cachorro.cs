namespace Animal
{
    public class Cachorro : Animal
    {
        public double Tamanho { get; set; }

        public void gravarNome(String nome, String cor, Double tamanho, String especie){
            Tamanho = tamanho;
            Especies = especie;
            Nome = nome;
            Cor = cor;
        }

        public void mostarDados(){
            Console.WriteLine(Nome);
            Console.WriteLine(Cor);
            Console.WriteLine(Tamanho);
            Console.WriteLine(Especies);
        }
    }
}