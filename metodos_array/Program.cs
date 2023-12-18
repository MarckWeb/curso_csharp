string[] pallets = { "B14", "A11", "B12", "A13" };

//Metodo sort ordenar por a-z Use el método Sort() para manipular el orden según el tipo de datos especificado de la matriz.
Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
   Console.WriteLine($"-- {pallet}");
}


//Metodo reverse Use el método Reverse() para invertir el orden de los elementos de la matriz.
Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
   Console.WriteLine($"-- {pallet}");
}

//El método Array.Resize() agrega o quita elementos de la matriz.

Console.WriteLine($"Before: {pallets[0].ToLower()}");
Array.Clear(pallets, 0, 2);
//Console.WriteLine($"After: {pallets[0].ToLower()}");
if (pallets[0] != null)
   Console.WriteLine($"After: {pallets[0].ToLower()}");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
   Console.WriteLine($"-- {pallet}");
}

//Cambio de tamaño del array 

Console.WriteLine("aumentar elementos al array");
Array.Clear(pallets, 0, 2);
foreach (var pallet in pallets)
{
   Console.WriteLine($"-- {pallet}");
}

Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
   Console.WriteLine($"-- {pallet}");
}

//Quitar elementos e una matriz

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
   Console.WriteLine($"-- {pallet}");
}

//¿Se pueden quitar elementos nulos de una matriz?
//Si el método Array.Resize() no quita los elementos vacíos de una matriz, ¿existe otro método auxiliar que haga el trabajo automáticamente? No. La mejor forma de vaciar elementos de una matriz sería contar el número de elementos no nulos recorriendo en iteración cada elemento y aumentando una variable (un contador). Luego, habría que crear una segunda matriz que fuese del tamaño de la variable del contador. Por último, habría que recorrer cada elemento de la matriz original y copiar los valores no nulos en la nueva matriz.


Console.WriteLine("numeros en array");
int[] numeros = { 1, 2, 3, 10, 8 };

Array.Sort(numeros);
foreach (var num in numeros)
{
   Console.WriteLine($"numero: {num}");
}
Console.WriteLine("eliminando");
Array.Clear(numeros, 1, 3);
foreach (var num in numeros)
{

   if (num != 0)
   {
      Console.WriteLine($"numero: {num}");
   }
}

Array.Resize(ref numeros, 6);
numeros[5] = 9;
foreach (var num in numeros)
{
   if (num != 0)
   {
      Console.WriteLine($"numero con resize: {num}");
   }
}

Array.Sort(numeros);
foreach (var num in numeros)
{
   Console.WriteLine(num);
}

//Descubrimiento de Split() y Join()

//Uso de ToCharArray() para invertir un string

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray); //creando un string apartir de un array de caracteres
// Console.WriteLine(result);

//Metodo Join()
string result = String.Join(",", valueArray);//separa por comas cada caracter 
Console.WriteLine(result);

//Split() de la nueva cadena de valores separados por comas en una matriz de cadenas

string[] items = result.Split(',');
foreach (string item in items)
{
   Console.WriteLine(item);
}

//EJERCICIOS

// Step 1: Dividir la cadena en palabras
string pangram = "The quick brown fox jumps over the lazy dog";
string[] message = pangram.Split(' ');
foreach (var men in message)
{
   Console.WriteLine(men);
}

// Step 2: Crear un nuevo array para almacenar las palabras invertidas
string[] newMessage = new string[message.Length];

// Step 3: Invertir cada palabra y almacenarla en el nuevo array
for (int i = 0; i < message.Length; i++)
{
   // Obtener los caracteres de la palabra actual
   char[] letters = message[i].ToCharArray();

   // Invertir el array de caracteres
   Array.Reverse(letters);

   // Crear una nueva cadena a partir del array invertido y almacenarla en el nuevo array
   newMessage[i] = new string(letters);
}

// Step 4: Unir las palabras invertidas en una nueva cadena
string result2 = String.Join(" ", newMessage);

// Imprimir el resultado
Console.WriteLine(result2);

//Desafío para analizar una cadena de pedidos, ordenar los pedidos y etiquetar posibles errores


string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] arrayOrder = orderStream.Split(",");
Array.Sort(arrayOrder);
foreach (var text in arrayOrder)
{
   if (text.Length != 4)
   {
      Console.WriteLine(text + "\t- Error");
   }
   else
   {
      Console.WriteLine(text);
   }

}




