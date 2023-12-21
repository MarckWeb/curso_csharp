using System;
Console.WriteLine("Generacion de numeros aleatorios");
DisplayRandomNumbers();

void DisplayRandomNumbers()
{
   Random random = new Random();
   for (int i = 0; i < 5; i++)
   {
      Console.Write($"{random.Next(1, 20)} ");
   }

   Console.WriteLine();
}

Console.WriteLine("Generacion de numeros aleatorios");
DisplayRandomNumbers();

// Identificar el código duplicado


int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();
Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
   Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
   diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

   /* Adjust the times by adding the difference, keeping the value within 24 hours */
   AdjustTimes();
}
else
{
   diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

   /* Adjust the times by adding the difference, keeping the value within 24 hours */
   AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();


void DisplayTimes()
{
   foreach (int val in times)
   {
      string time = val.ToString();
      int len = time.Length;

      if (len >= 3)
      {
         time = time.Insert(len - 2, ":");
      }
      else if (len == 2)
      {
         time = time.Insert(0, "0:");
      }
      else
      {
         time = time.Insert(0, "0:0");
      }

      Console.Write($"{time} ");
   }

   Console.WriteLine();
}

void AdjustTimes()
{
   for (int i = 0; i < times.Length; i++)
   {
      times[i] = ((times[i] + diff)) % 2400;
   }
}

//Desglose del problema (PSEUDOCODIGO)

/*
si la dirección ip consta de 4 números
y
si cada número de dirección IP no tiene ceros a la izquierda
y
si cada número de dirección IP está en el rango 0 - 255

entonces la dirección IP es válida

de lo contrario, la dirección IP no es válida
*/
/*
string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

ValidateLength();
ValidateZeroes();
ValidateRange();

if (validLength && validZeroes && validRange)
{
   Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
   Console.WriteLine($"ip is an invalid IPv4 address");
}

void ValidateLength()
{
   string[] address = ipv4Input.Split(".");
   validLength = address.Length == 4;
}
void ValidateZeroes()
{
   string[] address = ipv4Input.Split(".");

   foreach (string number in address)
   {
      if (number.Length > 1 && number.StartsWith("0"))
      {
         validZeroes = false;
      }
   }

   validZeroes = true;
}
void ValidateRange() { }*/

string[] ipv4Input = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input)
{
   address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);//quita los espacios en blanco entre los puntos que colocara split sino encuentra un numero.

   ValidateLength();
   ValidateZeroes();
   ValidateRange();

   if (validLength && validZeroes && validRange)
   {
      Console.WriteLine($"{ip} is a valid IPv4 address");
   }
   else
   {
      Console.WriteLine($"{ip} is an invalid IPv4 address");
   }
}

void ValidateLength()
{
   validLength = address.Length == 4;
};

void ValidateZeroes()
{
   foreach (string number in address)
   {
      if (number.Length > 1 && number.StartsWith("0"))
      {
         validZeroes = false;
         return;
      }
   }

   validZeroes = true;
}

void ValidateRange()
{
   foreach (string number in address)
   {
      int value = int.Parse(number);
      if (value < 0 || value > 255)
      {
         validRange = false;
         return;
      }
   }
   validRange = true;
}

//exercise


Random random = new Random();
int luck = random.Next(100);

//"Tienes mucho que hacer", "Hoy es un día para", "Cualquier trabajo que hagas", "Este es un momento ideal para"
string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//"esperamos con ansias.", "¡probar cosas nuevas!", "es probable que tenga éxito.", "¡cumple tus sueños!"
string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//"miedo.", "evite decisiones importantes.", "puede tener resultados inesperados.", "reevalúa tu vida."
string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//"apreciar.", "disfrutar el tiempo con amigos.", "debe alinearse con sus valores.", "ponerse en sintonía con la naturaleza."
string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };


//"Un adivino susurra las siguientes palabras:"
void tellFortune()
{
   Console.WriteLine("A fortune teller whispers the following words:");
   string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
   for (int i = 0; i < 4; i++)
   {
      Console.Write($"{text[i]} {fortune[i]} ");
   }
}

tellFortune();





