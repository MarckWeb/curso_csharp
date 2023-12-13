//Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.

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
int[] inventory = { 200, 450, 700, 175, 250 };
foreach (int items in inventory)
{
   sum += items;
}

Console.WriteLine($"tienen {sum} de inventario");