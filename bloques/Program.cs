for (int i = 0; i < 10; i++)
{
   Console.WriteLine(i);
}

//recorrer hacia atras

for (int i = 10; i >= 0; i--)
{
   Console.WriteLine(i);
}

for (int i = 0; i < 10; i += 3)
{
   Console.WriteLine(i);
}

//break para interrumpir intrucciones for 
for (int i = 0; i < 10; i++)
{
   Console.WriteLine(i);
   if (i == 7) break;
}

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//    Console.WriteLine(names[i]);
// }

//actualizar array durante una iteracion 
//ERROR CON FOREACH

// string[] namess = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in namess)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
   if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);

//EAJERCICIO BIZZBUZZ
/*
for (int i = 1; i <= 100; i++)
{
   if (i % 3 == 0 && i % 5 == 0)
   {
      Console.WriteLine(i + "- fizzbuzz");
   }
   else if (i % 3 == 0)
   {
      Console.WriteLine(i + "- fizz");
   }
   else if (i % 5 == 0)
   {
      Console.WriteLine(i + "- buzz");
   }
   else
   {
      Console.WriteLine(i);
   }
}
*/
// DO- WHILE

Random random = new Random();
int current = 0;

do
{
   current = random.Next(1, 11);
   Console.WriteLine(current);
} while (current != 7);

//WHILE

while (current >= 3)
{
   current = random.Next(1, 11);
   Console.WriteLine(current);
}

Console.WriteLine($"Last number: {current}");

//Uso de la instrucción continue para ir directamente a la expresión booleana

do
{
   current = random.Next(1, 11);

   if (current >= 8) continue;

   Console.WriteLine(current);
} while (current != 7);

//Desafío de la batalla del juego de rol

int monstruo = 10;
int heroe = 10;
int salud = 0;

do
{

   salud = random.Next(1, 11);
   monstruo -= salud;
   Console.WriteLine($"el mostuo fue danañado y perdio {salud} de salud y ahora tiene {monstruo} de salud");
   if (monstruo <= 0)
   {
      Console.WriteLine("El heroe Gana!!!");
   }

   if (monstruo > 0)
   {
      salud = random.Next(1, 11);
      heroe -= salud;
      Console.WriteLine($"El heroe fue dañado y perdio {salud} de salud y ahora tiene {heroe} de salud");
      if (heroe <= 0)
      {
         Console.WriteLine("El Monstruo Gana!!!");
      }
   }
} while (heroe > 0 && monstruo > 0);

/*
El monstruo fue dañado y perdió 1 de salud y ahora tiene 9 de salud.
El héroe fue dañado y perdió 1 de salud y ahora tiene 9 de salud.
El monstruo fue dañado y perdió 7 puntos de salud y ahora tiene 2 puntos de salud.
El héroe fue dañado y perdió 6 de salud y ahora tiene 3 de salud.
El monstruo fue dañado y perdió 9 puntos de salud y ahora tiene -7 puntos de salud.
¡El héroe gana!
*/

//
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
   int roll = dice.Next(1, 11);
   monster -= roll;
   Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

   if (monster <= 0) continue;

   roll = dice.Next(1, 11);
   hero -= roll;
   Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

//Examinar la diferencia entre las iteraciones de instrucción do y while

// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//    readResult = Console.ReadLine();
// } while (readResult == null);

string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
   readResult = Console.ReadLine();
   if (readResult != null)
   {
      if (readResult.Length >= 3)
      {
         validEntry = true;
      }
      else
      {
         Console.WriteLine("Your input is invalid, please try again.");
      }
   }
} while (validEntry == false);


//
int numericValue = 0;
bool validNumber = false;
//El método int.TryParse() se puede usar para convertir un valor de cadena en un entero. El método usa dos parámetros, una cadena que se evaluará y el nombre de una variable de entero a la que se asignará un valor. Este método devuelve un valor booleano. El código de ejemplo siguiente muestra el uso de int.TryParse():
validNumber = int.TryParse(readResult, out numericValue);//se analizar el 1er parametro si es entero y si es lo guardara en la varibale que tiene como segundo parametro y su resultado sera true, caso conytario si no es entero no se agrega y es false


//Proyecto de código 1: escritura de código que valida la entrada de enteros

string? valueInsert;
int entero = 0;
bool validNumero = false;
do
{
   Console.WriteLine("Ingrese un numero valido entre el 5 y el 10");
   valueInsert = Console.ReadLine();
   validNumero = int.TryParse(valueInsert, out entero);
   if (validNumero == false)
   {
      Console.WriteLine("Lo sentimos, ingresaste un número no válido, inténtalo nuevamente.");
   }
   else
   {
      if (entero > 4)
      {
         if (entero < 11)
         {
            Console.WriteLine($"Su valor de entrada ({entero}) ha sido aceptado.");
         }
      }
      else
      {
         validNumero = false;
         Console.WriteLine($"Ingresaste {entero}. Ingresa un número entre 5 y 10.");
      }
   }

} while (validNumero == false);

/*

Introduzca un valor entero entre 5 y 10
dos
Lo sentimos, ingresaste un número no válido, inténtalo nuevamente.
2
Ingresaste 2. Ingresa un número entre 5 y 10.
7
Su valor de entrada (7) ha sido aceptado.
*/

//Proyecto de código 2: escritura de código que valida la entrada de cadena

string? input;
bool status = false;
do
{
   Console.WriteLine("INGRESA TU ROl");
   input = Console.ReadLine().Trim().ToLower();
   Console.WriteLine(input);

   switch (input)
   {
      case "admin":
         Console.WriteLine($"Su valor de entrada ({input}) ha sido aceptado.");
         status = true;
         break;

      case "manager":
         Console.WriteLine($"Su valor de entrada ({input}) ha sido aceptado.");
         status = true;
         break;

      case "user":
         Console.WriteLine($"Su valor de entrada ({input}) ha sido aceptado.");
         status = true;
         break;

      default:
         Console.WriteLine($"El nombre de función que ingresó, \"{input}\", no es válido. Ingrese el nombre de su función ");
         break;
   }

} while (status == false);


//Proyecto de código 3: escritura de código que procesa el contenido de una matriz de cadenas

/*string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
   string myString = myStrings[i];
   periodLocation = myString.IndexOf(".");
  
   string resulString;
   while (periodLocation != -1)
   {
      resulString = myString.Remove(periodLocation);

      myString = myString.Substring(periodLocation + 1);
      Console.WriteLine(myString);

      myString = myString.TrimStart();
      Console.WriteLine(myString);

      periodLocation = myString.IndexOf(".");

      Console.WriteLine(resulString);
   }

   resulString = myString.Trim();
   Console.WriteLine(resulString);


}*/


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

//string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
   string myString = myStrings[i];
   periodLocation = myString.IndexOf(".");

   string mySentence;

   // extract sentences from each string and display them one at a time
   while (periodLocation != -1)
   {

      // first sentence is the string value to the left of the period location
      mySentence = myString.Remove(periodLocation);

      // the remainder of myString is the string value to the right of the location
      myString = myString.Substring(periodLocation + 1);

      // remove any leading white-space from myString
      myString = myString.TrimStart();

      // update the comma location and increment the counter
      periodLocation = myString.IndexOf(".");

      Console.WriteLine(mySentence);
   }

   mySentence = myString.Trim();
   Console.WriteLine(mySentence);
}