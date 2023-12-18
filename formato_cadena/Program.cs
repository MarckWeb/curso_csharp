//¿Qué es el formato compuesto?
//El formato compuesto usa marcadores de posición numerados dentro de una cadena. En tiempo de ejecución, todo lo que hay dentro de las llaves se resolverá en un valor que también se pasa en función de su posición.

string text1 = "hola";
string text2 = "mundo!";
string result = string.Format("{0} {1}!", text1, text2);
Console.WriteLine(result);

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

//¿Qué es la interpolación de cadenas?
//La interpolación de cadenas es una técnica que simplifica el formato compuesto.

string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!");
Console.WriteLine($"{second} {first}!");
Console.WriteLine($"{first} {first} {first}!");

//Aplicación de formato a valores de moneda

decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");//:c muestra moneda segun el pais del usuario final

//Aplicación de formato a números

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units"); n= separa en mil antes del punto y muestra solo dos decimales

decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N4} units"); //n4= muestra mas presicion en mmostrar mas decimales

//Aplicación de formato a porcentajes

decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");//se agrega el numero para mostrra dos decimales como sepracion

//Combinación de enfoques de formato

decimal prices = 67.55m;
decimal salePrice = 59.99m;

string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (prices - salePrice), prices);


yourDiscount += $"A discount of {(price - salePrice) / price:P2}!";
Console.WriteLine(yourDiscount);

//Representación del número de factura mediante la interpolación de cadenas

int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");

//Métodos que agregan espacios en blanco para fines de formato (PadLeft(), PadRight())
// Métodos que comparan dos cadenas o facilitan la comparación (Trim(), TrimStart(), TrimEnd(), GetHashcode(), la propiedad Length)
// Métodos que ayudan a determinar lo que está dentro de una cadena, o incluso a recuperar solo una parte de la cadena (Contains(), StartsWith(), EndsWith(), Substring())
// Métodos que cambian el contenido de la cadena mediante el reemplazo, la inserción o la eliminación de elementos (Replace(), Insert(), Remove())
// Métodos que convierten una cadena en una matriz de cadenas o caracteres (Split(), ToCharArray())

//El método PadLeft() agrega espacios en blanco al lado izquierdo de la cadena para que el número total de caracteres sea igual al argumento que se envía. En este caso, el objetivo es que la longitud total de la cadena sea de 12 caracteres.

string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadRight(12));

//¿Qué es un método sobrecargado?
// En C#, un método sobrecargado es otra versión de un método con argumentos distintos o adicionales que modifican ligeramente la funcionalidad del método, como sucede con la versión sobrecargada del método PadLeft().

Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));

//Uso de cadenas con relleno
string paymentId = "769C";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";


//PadRight(6): paymentId se rellena a la derecha con espacios para que tenga una longitud total de 6 caracteres.
var formattedLine = paymentId.PadRight(6);

//PadRight(24): payeeName se rellena a la derecha con espacios para que tenga una longitud total de 24 caracteres. Aquí, la cadena resultante ocupará un total de 24 caracteres, comenzando desde el extremo izquierdo de la cadena original payeeName.
formattedLine += payeeName.PadRight(24); ///empiesa por la izquierda

//PadLeft(10): paymentAmount se rellena a la izquierda con espacios para que tenga una longitud total de 10 caracteres. En este caso, la cadena resultante ocupará un total de 10 caracteres, comenzando desde el extremo derecho de la cadena original paymentAmount.
formattedLine += paymentAmount.PadLeft(10);//en un expacio de 10rellena el texto y si hay espacio respeta
Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);

//Completar el desafío de aplicar la interpolación de cadenas a una carta de formulario


string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
//cash
string currentProfit1 = $"{currentProfit:C2}";
string newProfit1 = $"{newProfit:C2}";
//porcentaje
string currentReturn1 = $"{currentReturn:P2}";
string newReturn1 = $"{newReturn:P2}";

string result3 = currentProduct.PadRight(20);
result3 += currentReturn1.PadRight(10); //empieza desde el 20 hasta el 30 por la derecha
result3 += currentProfit1.PadLeft(15); //empieza por la izquierda hasta el 45

string result4 = newProduct.PadRight(20);
result4 += newReturn1.PadRight(10);
result4 += newProfit1.PadLeft(15);

string comparisonMessage = $"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn1}\n\nOur new product, {newProduct} offers a return of {newReturn1}.  Given your current volume, your potential profit would be {newProfit1}\n\nHere's a quick comparison:\n\n{result3}\n{result4}";

// Your logic here

Console.WriteLine(comparisonMessage);

Console.WriteLine("12345678901234567890123456789012345678901234567890123456789012345678901234567890");
/*
Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75 %.

Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75 %   $55,000,000.00      
Glorious Future     13.13 %   $63,000,000.00  
*/