double P;
double M;
double C;
double H;
double media;
string resultado;
//-----------------------------------------------
Console.WriteLine("-Tirando media de notas-\n");

Console.Write("Digite o valor de 0 a 10 as nota nas aulas de:\n");

Console.Write("Português: ");
P = Convert.ToDouble(Console.ReadLine());

Console.Write("Matemática: ");
M = Convert.ToDouble(Console.ReadLine());

Console.Write("Ciencias: ");
C = Convert.ToDouble(Console.ReadLine());

Console.Write("História: ");
H = Convert.ToDouble(Console.ReadLine());
//------------------------------------------------
media = (P + M + C + H) / 4;

 if (media < 5)
    {
        resultado = "Você foi reprovado";
    }
    else if (media > 6)
    {
         resultado = "Você foi aprovado";
    }
        
     else 
    {
        resultado = "Você esta em recuparação"; 
    }

    Console.WriteLine($"Você ficou com média de {media:N1}. Resultado: {resultado}");