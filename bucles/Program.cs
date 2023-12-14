Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
Console.WriteLine("a" == "a ");

//modificar valores y mejorar posibles errores 

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Uso del operador de desigualdad
Console.WriteLine("ejecutando desigualdad");

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue1 = "a";
Console.WriteLine(myValue1 != "a");

//Uso de los operadores de comparación
Console.WriteLine("ejecutando comparacion");
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);


//verificar si un contenido tiene un caracter en especial
Console.WriteLine("verificando caracter");
string caracter = "En este texto encontraremos un caracter";
Console.WriteLine(caracter.Contains("este"));
Console.WriteLine(caracter.Contains("estos"));
Console.WriteLine(caracter.StartsWith("En"));
Console.WriteLine(caracter.EndsWith("caracter"));

//logica de neagcion
Console.WriteLine("verificando la negacion");
Console.WriteLine(caracter.Contains("este") == false);
Console.WriteLine(!caracter.Contains("este"));

//exercise
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

//Uso del operador condicional insertado
saleAmount = 900;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


Random random = new Random();
int posibility = random.Next(20);
Console.WriteLine($"El resultado es {posibility}: {(posibility > 10 ? "heads" : "tails")}");

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

//Ejercicio: Realización de una actividad de desafío con expresiones booleanas

string permission = "Admin|Manager";
int lever = 56;

if (permission.Contains("Admin"))
{
   Console.WriteLine($"{(lever > 55 ? "Welcome, Super Admin user" : "Welcome, Admin user.")}");
}
else if (permission.Contains("Manager"))
{
   Console.WriteLine($"{(lever > 20 ? "Contact an Admin for access." : "You do not have sufficient privileges.")}");
}
else
{
   Console.WriteLine("You do not have sufficient privileges.");
}



