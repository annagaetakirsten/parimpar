int numeroDigitado;
Console.Write ("digite um numero ");
numeroDigitado = Convert.ToInt32(Console.ReadLine());

bool numeroEhPar = (numeroDigitado % 2) == 0;

if (numeroEhPar)

{
  Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"{numeroDigitado} é par ");
}

 else
 {
     Console.ForegroundColor = ConsoleColor.Blue;
     Console.WriteLine ($"{numeroDigitado} é ímpar");
 }

 Console.ResetColor();