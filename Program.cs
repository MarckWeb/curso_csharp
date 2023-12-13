//Escritura de código que genera tres números aleatorios y los muestre en la salida
/*Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");


//"Si dos dados cualesquiera muestran el mismo valor, se obtendrán dos puntos extra por obtener dobles"

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
   //"Si los tres dados que tire muestran el mismo valor, obtendrá seis puntos extra por obtener un triple"

   if ((roll1 == roll2) && (roll2 == roll3))
   {
      Console.WriteLine("Obtuviste triples! +6 bonos extra total");
      total += 6;
   }
   else
   {
      Console.WriteLine("Obtuviste dobles! Bono +2 al total!");
      total += 2;
   }

}


if (total >= 16)
{
   Console.WriteLine("Ganaste un coche nuevo");
}
else if (total >= 10)
{
   Console.WriteLine("Ganaste un protatil nuevo");
}
else if (total == 7)
{
   Console.WriteLine("Ganaste un viaje");
}
else
{
   Console.WriteLine("Ganaste un gatito");
}



//ejemplo, a continuación, se muestra un ejemplo de código sencillo que usa el método string.Contains() para evaluar si una cadena contiene otra.

string message = "existe la palabra max o jose.";
bool result = message.Contains("max");
Console.WriteLine(result);

if (message.Contains("jose"))
{
   Console.WriteLine("Quien es jose?");
}

*/