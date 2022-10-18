namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro c = new Cachorro();
            c.gravarNome("Bilu", "Preto", 0.45, "Vira-lata"); 
            c.mostarDado();
        }      
    } 
}
