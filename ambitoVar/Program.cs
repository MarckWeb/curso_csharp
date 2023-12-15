//variables lovales y globales
bool flag = true;

int value = 0;
if (flag)
{
   value = 10;
   Console.WriteLine($"Inside of code block:" + value);
}

Console.WriteLine($"Inside of code block: {value}");

//variables lovales y globales
int num = 5;
if (true)
{
   int num2 = 6;
   num += num2;
}
Console.WriteLine(num);


bool flags = true;
if (flags)
   Console.WriteLine(flags);

//formas de visualozar mejor
string name = "steve";

if (name == "bob")
   Console.WriteLine("Found Bob");
else if (name == "steve")
   Console.WriteLine("Found Steve");
else
   Console.WriteLine("Found Chuck");
//En este desafío usará lo que ha aprendido sobre los bloques de código y el ámbito de las variables para corregir el ejemplo de código mal escrito que se proporciona. Se pueden hacer muchas mejoras. Buena suerte.

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
foreach (int number in numbers)
{
   total += number;

   if (number == 42)
   {
      bool found = true;

      if (found)
         Console.WriteLine("Set contains 42");
   }
}
Console.WriteLine($"Total: {total}");

//switch cs

var fruit = "";
switch (fruit)
{
   case "apple":
      Console.WriteLine($"App will display information for apple.");
      break;

   case "banana":
      Console.WriteLine($"App will display information for banana.");
      break;

   case "cherry":
      Console.WriteLine($"App will display information for cherry.");
      break;
}

//exerscise switch

int employeeLevel = 100;
string employeeName = "Jhon Smith";

string title = "";

switch (employeeLevel)
{
   case 100:
   case 200:
      title = "Senior Associate";
      break;

   case 300:
      title = "Manager";
      break;

   case 400:
      title = "Senior Manager";
      break;

   default:
      title = " Associate";
      break;
}

Console.WriteLine($"{employeeName}, {title}");

//En este desafío reescribiremos una construcción if-elseif-else como instrucción switch. Este desafío nos ayudará a ver las ventajas y los inconvenientes de usar la instrucción switch en comparación con una construcción if-elseif-else. Buena suerte.

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
   type = "Sweat shirt";
}
else if (product[0] == "02")
{
   type = "T-Shirt";
}
else if (product[0] == "03")
{
   type = "Sweat pants";
}
else
{
   type = "Other";
}

if (product[1] == "BL")
{
   color = "Black";
}
else if (product[1] == "MN")
{
   color = "Maroon";
}
else
{
   color = "White";
}

if (product[2] == "S")
{
   size = "Small";
}
else if (product[2] == "M")
{
   size = "Medium";
}
else if (product[2] == "L")
{
   size = "Large";
}
else
{
   size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");

//convertir a switch

switch (product[0])
{
   case "01":
      type = "Sweat shirt";
      break;

   case "02":
      type = "T-Shirt";
      break;

   case "03":
      type = "Sweat pants";
      break;

   default:
      type = "Other";
      break;
}

switch (product[1])
{
   case "BL":
      color = "Black";
      break;

   case "MN":
      color = "Maroon";
      break;

   default:
      color = "White";
      break;
}

switch (product[2])
{
   case "S":
      size = "Small";
      break;

   case "M":
      size = "Medium";
      break;

   case "L":
      size = "Large";
      break;

   default:
      size = "One Size Fits All";
      break;
}

Console.WriteLine($"Product: {size} {color} {type}");


