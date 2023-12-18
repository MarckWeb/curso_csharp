using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

/*Console.WriteLine("asignacion de tipos enteros");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int  : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long  : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");*/
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

//El compilador de C# detecta un posible problema en el proceso. La variable second es de tipo string, por lo que podría establecerse en otro valor como "hello". Si el compilador de C# intentara convertir "hello" en un número, esto provocaría una excepción en tiempo de ejecución. Para evitar esta posibilidad, el compilador de C# no realiza implícitamente la conversión de string a int.

//Desde la perspectiva del compilador de C#, la operación más segura sería convertir int en un valor string y realizar una concatenación en su lugar.

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");


string value1 = "5";
string value2 = "7";
int results = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(results);

/*
Resumen
Hemos tratado varios conceptos importantes sobre la conversión y la coerción de datos:

Evitar un error en tiempo de ejecución al realizar una conversión de datos
Realización de una coerción explícita para indicar al compilador que comprende el riesgo de pérdida de datos
Confíe en que el compilador realizará una coerción implícita a la hora de llevar a cabo una conversión de ampliación.
Use el operador de coerción () y el tipo de datos para llevar a cabo una coerción (por ejemplo, (int)myDecimal).
Use la clase Convert cuando quiera llevar a cabo una conversión de restricción y redondear, pero que no se trunque la información.*/
Console.WriteLine("/////////////////////////////////////////////");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0m;
string message = "";

foreach (var value in values)
{
   decimal number; // stores the TryParse "out" value
   if (decimal.TryParse(value, out number))
   {
      total += number;
   }
   else
   {
      message += value;
   }
}

Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");

////
///
int val1 = 12;
decimal val2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {val1 / (int)val2}");

// Your code here to set resultado2
Console.WriteLine($"Divide value2 by value3, display the resultado as a decimal: {val2 / (decimal)value3}");

// Your code here to set resultado3
Console.WriteLine($"Divide value3 by value1, display the resultado as a float: {value3 / (float)val1}");

//otra solucion seria
/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// The Convert class is best for converting the fractional decimal numbers into whole integer numbers
// Convert.ToInt32() rounds up the way you would expect.
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");*/