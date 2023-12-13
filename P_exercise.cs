//Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.

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
      Console.WriteLine("Your subscription expires within a day!\nRenew now and save 20%!");
      discountPercentage = 20;
   }
   else if (daysUntilExpiration <= 5)
   {
      Console.WriteLine($"Su suscripción vence en {daysUntilExpiration} días.\n¡Renueva ahora y ahorra un 10%!");
      discountPercentage = 10;
   }

   else if (daysUntilExpiration <= 10)
   {
      Console.WriteLine("Su suscripción caducará pronto. ¡Renovar ahora!");
   }
}

