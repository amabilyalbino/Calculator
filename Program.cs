
Operacao(metodo:"soma");

static void Operacao(string metodo) {

    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    if (metodo == "subtracao")
    {
        float resultado = v1-v2;
        Console.WriteLine($"O resultado da subtracao é {resultado}");
    }
    if (metodo == "soma"){

        float resultado = v1+v2;
        Console.WriteLine($"O resultado da soma é {resultado}");
    }
    if (metodo == "multiplicacao") {

         float resultado = v1*v2;
        Console.WriteLine($"O resultado da multipicacao  é {resultado}");
    }



// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Primeiro valor: ");
// float v1 = float.Parse(Console.ReadLine());

// Console.WriteLine("Segundo valor: ");
// float v2 = float.Parse(Console.ReadLine());

// Console.WriteLine("");

// float resultado = v1 + v2;
// Console.WriteLine("O resultado da soma é " + resultado);
// //Poderia fazer tbm: Console.WriteLine($"O resultado da soma é {resultado}");
// //Poderia fazer tbm: Console.WriteLine($"O resultado da soma é {v1 + v2}");
// Console.WriteLine(v1);

// Multiplicacao();
// static void Soma() {
//     Console.WriteLine("Primeiro valor: ");
//     float v1 = float.Parse(Console.ReadLine());
    
//     Console.WriteLine("Segundo valor: ");
//     float v2 = float.Parse(Console.ReadLine());
//     Console.WriteLine("");
//     float resultado = v1 + v2;
//     Console.WriteLine("O resultado da soma é " + resultado);
//     //Poderia fazer tbm: Console.WriteLine($"O resultado da soma é {resultado}");
//     //Poderia fazer tbm: Console.WriteLine($"O resultado da soma é {v1 + v2}");
//     Console.WriteLine(v1);
// }

// static void Subtracao() {
//     Console.Clear();

//     Console.WriteLine("Primeiro valor: ");
//     float v1 = float.Parse(Console.ReadLine());

//     Console.WriteLine("Segundo valor: ");
//     float v2 = float.Parse(Console.ReadLine());

//     Console.WriteLine("");

//     float resultado = v1-v2;
//     Console.WriteLine($"O resultado da subtração é {resultado}");

//     Console.ReadKey();

// }
// static void Multiplicacao() {

//     Console.Clear();

//     Console.WriteLine("Primeiro valor: ");
//     float v1 = float.Parse(Console.ReadLine());

//     Console.WriteLine("Segundo valor: ");
//     float v2 = float.Parse(Console.ReadLine());

//     Console.WriteLine("");

//     float resultado = v1*v2;
//     Console.WriteLine($"O resultado da multiplicacao é {resultado}");

//     Console.ReadKey();

// } 

      

    
       
    
    


}
