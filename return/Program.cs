
using System.Reflection.Metadata;
using System.Runtime;

double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
   total += GetDiscountedPrice(i);
}

if (TotalMeetsMinimum())
{
   total -= 5.00;
}
Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
   // Calculate the discounted price of the item
   double result = items[itemIndex] * (1 - discounts[itemIndex]);
   return result;
}

bool TotalMeetsMinimum()
{
   // Check if the total meets the minimum
   return total >= minimumSpend;
}

string FormatDecimal(double input)
{
   // Format the double so only 2 decimal places are displayed
   return input.ToString().Substring(0, 5);
}


//Crear un método que devuelva un entero

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd)
{
   int rate = 23500;
   return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
   double rate = 23500;
   return vnd / rate;
}
//Creación de un método que devuelve una cadena
// string input = "snake";

// Console.WriteLine(input);
// Console.WriteLine(ReverseWord(input));
string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));
string ReverseWord(string word)
{
   string result = "";
   for (int i = word.Length - 1; i >= 0; i--)
   {
      result += word[i];
   }
   return result;
}
//Creación de un método para invertir palabras en una oración
string ReverseSentence(string input)
{
   string result = "";
   string[] words = input.Split(" ");

   foreach (string word in words)
   {
      result += ReverseWord(word) + " ";
   }

   return result.Trim();
}

//Creación de un método que devuelve un valor booleano

string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
   Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
   int start = 0;
   int end = word.Length - 1;

   while (start < end)
   {
      if (word[start] != word[end])
      {
         return false;
      }
      start++;
      end--;
   }

   return true;
}


//Encontrar monedas para dar el cambio
int target = 30;
int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
int[,] result = TwoCoins(coins, target);

if (result.Length == 0)
{
   Console.WriteLine("No two coins make change");
}
else
{
   Console.WriteLine("Change found at positions:");
   for (int i = 0; i < result.GetLength(0); i++)
   {
      if (result[i, 0] == -1)
      {
         break;
      }
      Console.WriteLine($"{result[i, 0]},{result[i, 1]}");
   }
}

int[,] TwoCoins(int[] coins, int target)
{
   int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
   int count = 0;

   for (int curr = 0; curr < coins.Length; curr++)
   {
      for (int next = curr + 1; next < coins.Length; next++)
      {
         if (coins[curr] + coins[next] == target)
         {
            result[count, 0] = curr;
            result[count, 1] = next;
            count++;
         }
         if (count == result.GetLength(0))
         {
            return result;
         }
      }
   }
   return (count == 0) ? new int[0, 0] : result;
}

//Desafío de código: adición de métodos para que el juego sea jugable

Random random = new Random();

Console.WriteLine("Would you like to play? (si/no)");
if (ShouldPlay())
{
   PlayGame();
}

void PlayGame()
{
   var play = true;

   while (play)
   {
      var target = 4;
      var roll = random.Next(1, 7);

      Console.WriteLine($"Roll a number greater than {target} to win!");
      Console.WriteLine($"You rolled a {roll}");
      Console.WriteLine(WinOrLose(target, roll));
      Console.WriteLine("\nPlay again? (si/no)");

      play = ShouldPlay();
   }
}

bool ShouldPlay()
{
   bool result = false;
   string playAgain = Console.ReadLine();
   if (playAgain != null)
   {
      if (playAgain.ToLower() == "si")
      {
         result = true;
         return result;
      }
      else if (playAgain.ToLower() == "no")
      {
         return result;
      }
   }


   return result;
}

string WinOrLose(int target, int roll)
{
   if (target > roll)
   {
      return "¡Tu Pierdes!";
   }
   else if (target < roll)
   {
      return "¡Tu ganas!";
   }
   else
   {
      // En caso de empate, puedes devolver un mensaje apropiado o cualquier valor deseado.
      return "¡Es un empate!";
   }
}


/*
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame() 
{
    var play = true;

    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}
¿Quisieras jugar? (sí/no)
Y
¡Saca un número mayor que 1 para ganar!
Sacas un 2
¡Tú ganas!

¿Juega de nuevo? (sí/no)
Y
¡Saca un número mayor que 4 para ganar!
Sacas un 6
¡Tú ganas!

¿Juega de nuevo? (sí/no)
Y
¡Saca un número mayor que 1 para ganar!
Sacas un 1
¡Tú pierdes!

¿Juega de nuevo? (sí/no)
norte
*/