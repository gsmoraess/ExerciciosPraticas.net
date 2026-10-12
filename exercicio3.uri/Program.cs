/*using System;
using System.Globalization;

class Program
{
    static void Main(string[] agrs)
    {
        double a, b, c, d, DIFERENCA;

        a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        DIFERENCA = (a * b) - (c * d);

        Console.WriteLine("DIFERENCA = " + DIFERENCA.ToString(CultureInfo.InvariantCulture));

    }
}*/

/*using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        double salario, TotalVendas, TotalFinal;
        

        nome = Console.ReadLine();
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        TotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        
        TotalFinal = salario + (TotalVendas * 15 / 100);

        Console.WriteLine("Total = R$ " + TotalFinal.ToString("F2", CultureInfo.InvariantCulture));

    }
}*/




/*using System;

class Program
{
    // Constante: valor fixo de pi definido pelo enunciado (não usamos Math.PI
    // porque a questão pede especificamente 3.14159)
    const double pi = 3.14159;

    static void Main()
    {
        // Lê uma linha da entrada (string) e já converte pra double
        // Double.Parse transforma o texto lido em número de ponto flutuante
        double raio = Double.Parse(Console.ReadLine());

        // Fórmula do volume da esfera: (4/3) * pi * R³
        // 4.0/3 -> usamos 4.0 (não 4) pra forçar divisão de ponto flutuante,
        // senão o C# faria divisão inteira e o resultado daria 1 (errado!)
        // Math.Pow(raio, 3) -> eleva o raio ao cubo (R³), já que C# não tem operador ^
        double volume = (4.0 / 3) * pi * Math.Pow(raio, 3);

        // Formata a saída: "F3" garante exatamente 3 casas decimais
        // $"..." é interpolação de string, insere o valor de 'volume' formatado no texto
        Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
    }
}*/



/*using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
        string[] valores = Console.ReadLine().Split(' ');

        A = double.Parse(valores[0], CultureInfo.InvariantCulture);
        B = double.Parse(valores[1], CultureInfo.InvariantCulture);
        C = double.Parse(valores[2], CultureInfo.InvariantCulture);

        TRIANGULO = (A * C) / 2.0;
        CIRCULO = 3.14159 * Math.Pow(C, 2);
        TRAPEZIO = ((A + B) * C) / 2.0;
        QUADRADO = Math.Pow(B, 2);
        RETANGULO = A * B;

        Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3", CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3", CultureInfo.InvariantCulture));
    }

}*/


/*using System;

namespace beecrowd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            // Primeiro passo: acha o maior entre a e b
            int maiorAB = (a + b + Math.Abs(a - b)) / 2;

            // Segundo passo: acha o maior entre esse resultado e c
            int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}*/



/*using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
*/

/*using System;

namespace uri1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, nota100, nota50, nota20, nota10, nota5, nota2, nota1;

            N = int.Parse(Console.ReadLine());

            nota100 = N / 100;
            resto = N % 100;

            nota50 = resto / 50;
            resto = resto % 50;

            nota20 = resto / 20;
            resto = resto % 20;

            nota10 = resto / 10;
            resto = resto % 10;

            nota5 = resto / 5;
            resto = resto % 5;

            nota2 = resto / 2;
            resto = resto % 2;

            nota1 = resto / 1;

            Console.WriteLine(N);
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota1} nota(s) de R$ 1,00");
        }
    }
}*/



/*using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int horas;

        Console.WriteLine("Quantas horas? ");
        horas = int.Parse(Console.ReadLine());

        if (horas < 12)
        {
            Console.WriteLine("Bom dia!");

        }

        else
        {
            if (horas < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            
            }
           
        }
    }
}*/




using System;
using System.Globalization; 

namespace testes
    {
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA;
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);
            MEDIA = (A * 2 + B * 3 + C * 5) / 10;
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}