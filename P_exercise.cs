//Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.
/*
using System.Threading.Tasks.Dataflow;

Random random = new Random();
//dias hasta el vencimiento
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine(daysUntilExpiration);
if (daysUntilExpiration > 10)
{
   Console.WriteLine("");
}
else
{
   if (daysUntilExpiration == 0)
   {
      Console.WriteLine("Tu suscripcion a experido!");
   }
   else if (daysUntilExpiration == 1)
   {

      discountPercentage = 20;
      Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%!");
   }
   else if (daysUntilExpiration <= 5)
   {
      discountPercentage = 10;
      Console.WriteLine($"Su suscripción vence en {daysUntilExpiration} días.\n¡Renueva ahora y ahorra un {discountPercentage}%!");

   }

   else if (daysUntilExpiration <= 10)
   {
      Console.WriteLine("Su suscripción caducará pronto. ¡Renovar ahora!");
   }
}


//declaracion de una matriz
/*string[] fraudulentOrderIDs = new string[3];
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
//fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
Console.WriteLine($"second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"third: {fraudulentOrderIDs[2]}");

//Reasignación del valor de una matriz

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reasing first: {fraudulentOrderIDs[0]}");*/

//Inicialización de una matriz
/*
string[] fraudulentOrderIDs = { "A123", "C456", "C789" };
Console.WriteLine($"first: {fraudulentOrderIDs[0]}");
Console.WriteLine($"second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reasing first: {fraudulentOrderIDs[0]}");

//Uso de la propiedad Length de una matriz

Console.WriteLine($"encontramos {fraudulentOrderIDs.Length} fraudes en proceso");

//Recorrido en bucle de una matriz con "foreach"

string[] names = { "Robin", "Clarck", "Vin" };
foreach (string name in names)
{
   Console.WriteLine(name);
}

//Crear e inicializar una matriz de números enteros (int).
int sum = 0;
//Crear una variable que contenga el número del contenedor actual y que muestre la suma acumulativa
int bin = 0;

int[] inventory = { 200, 450, 700, 175, 250 };
foreach (int items in inventory)
{
   bin++;
   sum += items;
   Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

//El equipo ha encontrado un patrón. Los pedidos que comienzan por la letra "B" presentan un fraude con una frecuencia 25 veces superior a la normal. Deberá escribir otro código que genere el identificador de pedido para los nuevos pedidos que empiecen por la letra "B". El equipo antifraude lo usará para investigar más en profundidad.

string[] idsFraudulent = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
foreach (string ids in idsFraudulent)
{
   if (ids.StartsWith("B"))
   {
      Console.WriteLine(ids);
   }
}*/

//Creación y uso de comentarios de código
/*
string firstName = "Bob";
int widgetsPurchased = 7;
// Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

Random randomm = new Random();
string[] orderIds = new string[5];
//Recorre cada ID de pedido en blanco
// Loop through each blank orderID

for (int i = 0; i < orderIds.Length; i++)
{
   //Obtenga un valor aleatorio que equivale a las letras ASCII de la A a la E
   // Get a random value that equates to ASCII letters A through E
   int prefixValue = randomm.Next(65, 70);

   // Convierte el valor aleatorio en un carácter y luego en una cadena
   // Convert the random value into a char, then a string
   string prefix = Convert.ToChar(prefixValue).ToString();

   // Create a random number, pad with zeroes
   // Crea un número aleatorio, rellena con ceros

   string suffix = randomm.Next(1, 1000).ToString("000");
   // Combina el prefijo y el sufijo, luego asigna al ID de pedido actual
   // Combine the prefix and suffix together, then assign to current OrderID

   orderIds[i] = prefix + suffix;
}
// Imprime cada ID de pedido
// Print out each orderID

foreach (var orderID in orderIds)
{
   Console.WriteLine(orderID);
}
*/
//mejorar comentarios de forma correcta

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
  El siguiente código crea cinco OrderID aleatorios
  para probar el proceso de detección de fraude. ID de pedido
  constan de una letra de la A a la E, y tres
  dígito. Ex. A123.
*/
/*
Random randomm = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
   int prefixValue = randomm.Next(65, 70);
   string prefix = Convert.ToChar(prefixValue).ToString();
   string suffix = randomm.Next(1, 1000).ToString("000");

   orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
   Console.WriteLine(orderID);
}

//mejoramiento de la legibilidad de codigo 

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

/*string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
   if (letter == 'o')
   {
      letterCount++;
   }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

*/