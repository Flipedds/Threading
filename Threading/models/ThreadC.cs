namespace Threading.models;

public class ThreadC
{
    private string Nome;
    private int Inicio;
    private int Fim;
    
    public ThreadC(string nome, int inicio, int fim)
    {
        Nome = nome;
        Inicio = inicio;
        Fim = fim;
    }


    public void Run()
    {
        for (var i = Inicio; i < Fim; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine($"{Nome} - " + i);
            }
        }
    }
}