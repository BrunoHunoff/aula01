namespace aula01_ex;

class Program
{
    static void Main(string[] args)
    {
       ex020();
    }

    static void ex001() {
        Console.WriteLine("Digite um numero: ");

        var n = Convert.ToInt32(Console.ReadLine());

        if (n > 10) {
            Console.WriteLine("O numero eh maior que 10");
            return;
        }

        Console.WriteLine("O numero eh menor ou igual a 10");
    }

    static void ex020() {
        const int kmPorL = 12;

        Console.WriteLine("Quanto tempo durou a viagem?");
        var travelTime = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Qual foi a velocidade media?");
        var travelSpeed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Litros gastos: {(travelTime * travelSpeed)/kmPorL}");

    }

    
}
