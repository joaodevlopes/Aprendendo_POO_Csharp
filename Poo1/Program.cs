using System;
namespace Poo1;

public class Program
{
    public static void Main()
    {
        //1. Criar instância(objeto) de uma classe Cake - "new"

        var cakeStrawberry = new Cake();

        //2. Setar as informações do nosso bolo de morango

        cakeStrawberry.Id = 472;
        cakeStrawberry.Name = "Bolo de morango Recheado";
        cakeStrawberry.Description = "Intolerantes a lactose, não consumir";
        cakeStrawberry.Value = 30;
        cakeStrawberry.IsFilling = true;

        //3. Mostrar ao usúario

        Console.WriteLine($"ID : {cakeStrawberry.Id}");
        Console.WriteLine($"Nome : {cakeStrawberry.Name}");
        Console.WriteLine($"Descrição : {cakeStrawberry.Description}");
        Console.WriteLine($"Valor : R$ {cakeStrawberry.Value}");
        Console.WriteLine($"É recheado? : {cakeStrawberry.IsFilling}");

        Console.WriteLine("------------------------");

        //4. Instancia de Bolo de Chocolate

        var cakeChocolate = new Cake();

        cakeChocolate.Id = 478;
        cakeChocolate.Name = "Bolo de Chocolate";
        cakeChocolate.Description = "Cacau meio amargo 30%";
        cakeChocolate.Value = 45;
        cakeChocolate.IsFilling = false;

        Console.WriteLine($"ID : {cakeChocolate.Id}");
        Console.WriteLine($"Nome : {cakeChocolate.Name}");
        Console.WriteLine($"Descrição : {cakeChocolate.Description}");
        Console.WriteLine($"Valor : R$ {cakeChocolate.Value}");
        Console.WriteLine($"É recheado? : {cakeChocolate.IsFilling}");

        Console.WriteLine("------------------------");

        //5. Listas de bolos


        Console.WriteLine("Listas de Bolos - Criação de Lista");

        List<Cake> cakeList = new List<Cake>();

        cakeList.Add( cakeStrawberry );
        cakeList.Add(cakeChocolate);

        Console.WriteLine();

        Console.WriteLine("------------------------");

        //6. Visualizar 

        foreach (Cake cake in cakeList)
        {
            Console.WriteLine($"ID : {cake.Id}");
            Console.WriteLine($"Nome : {cake.Name}");
            Console.WriteLine($"Descrição : {cake.Description}");
            Console.WriteLine($"Valor : R$ {cake.Value}");
            Console.WriteLine($"É recheado? : {cake.IsFilling}");
            Console.WriteLine("------------------------");
        }



    }
}
