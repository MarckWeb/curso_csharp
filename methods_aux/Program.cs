/*string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf("(");
int closingPosition = message.IndexOf(")");

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);

//Adición de código para recuperar el valor entre paréntesis
openingPosition += 1;

int lenght = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, lenght));
*/

//actualzar  indexOf, substring
/*string mensaje = "cual es el valor <span>entre las etiquetas</span>";
int abrirPosicion = mensaje.IndexOf("<span>");
int cerrarPosicion = mensaje.IndexOf("</span>");

abrirPosicion += 6;

int longitug = cerrarPosicion - abrirPosicion;
Console.WriteLine(mensaje.Substring(abrirPosicion, longitug));*/
/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/

//Uso de los métodos auxiliares IndexOfAny() y LastIndexOf() de la cadena
/*
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('(');

openingPosition += 1;
int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));*/
/*
string mensaje = "(¿Qué pasa si) hay (más de) un (conjunto de paréntesis)?";

while (true)
{
   int abrirPosicion = mensaje.IndexOf('(');
   if (abrirPosicion == -1) break; //en la ultima cadena no encuentra y fuera de la cadena

   abrirPosicion += 1;
   int cerrarPosicion = mensaje.IndexOf(')');
   int lenght = cerrarPosicion - abrirPosicion;
   Console.WriteLine(mensaje.Substring(abrirPosicion, lenght));

   // Tenga en cuenta la sobrecarga de la Subcadena para devolver solo el resto
   // mensaje sin procesar:

   mensaje = mensaje.Substring(cerrarPosicion + 1);
}
*/

//Trabajar con diferentes tipos de conjuntos de símbolos

/*string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Searching THIS Message: {message}");

char[] openSymbols = { '[', '{', '(' };
int startPosition = 6;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)}");*/
/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
   int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

   if (openingPosition == -1) break;

   string currentSymbol = message.Substring(openingPosition, 1);

   // Now  find the matching closing symbol
   char matchingSymbol = ' ';

   switch (currentSymbol)
   {
      case "[":
         matchingSymbol = ']';
         break;
      case "{":
         matchingSymbol = '}';
         break;
      case "(":
         matchingSymbol = ')';
         break;
   }

   // To find the closingPosition, use an overload of the IndexOf method to specify 
   // that the search for the matchingSymbol should start at the openingPosition in the string. 

   openingPosition += 1;
   closingPosition = message.IndexOf(matchingSymbol, openingPosition);

   // Finally, use the techniques you've already learned to display the sub-string:

   int length = closingPosition - openingPosition;
   Console.WriteLine(message.Substring(openingPosition, length));
}*/

using System.Threading.Tasks.Dataflow;

string mensaje = "(¿Qué pasa si) tengo [diferentes símbolos] pero cada {símbolo de apertura} necesita un [símbolo de cierre coincidente]?";

// El método auxiliar IndexOfAny() requiere una matriz de caracteres. 
// Quieres buscar:

char[] símbolosDeApertura = { '[', '{', '(' };

// Usarás una técnica ligeramente diferente para iterar a través 
// de los caracteres en la cadena. Esta vez, usa la posición de cierre 
// de la iteración anterior como índice de inicio para el 
// próximo símbolo de apertura. Entonces, necesitas inicializar la variable closingPosition 
// a cero:

int closingPosition = 0;

while (true)
{
   int openingPosition = mensaje.IndexOfAny(símbolosDeApertura, closingPosition);//busca un caracter que concida con el que te pase desde la posicion que te pase;

   if (openingPosition == -1) break;

   string símboloActual = mensaje.Substring(openingPosition, 1);

   // Ahora encuentra el símbolo de cierre coincidente
   char símboloCoincidente = ' ';

   switch (símboloActual)
   {
      case "[":
         símboloCoincidente = ']';
         break;
      case "{":
         símboloCoincidente = '}';
         break;
      case "(":
         símboloCoincidente = ')';
         break;
   }

   // Para encontrar closingPosition, usa una sobrecarga del método IndexOf para especificar 
   // que la búsqueda del símboloCoincidente debe comenzar en openingPosition en la cadena. 

   openingPosition += 1;

   closingPosition = mensaje.IndexOf(símboloCoincidente, openingPosition); //IndexOf(string value, int startIndex): Busca la posición de una subcadena específica dentro de la cadena, comenzando desde el índice especificado.

   // Finalmente, usa las técnicas que ya has aprendido para mostrar la subcadena:

   int longitud = closingPosition - openingPosition;
   Console.WriteLine(mensaje.Substring(openingPosition, longitud));
}


// uso de los métodos Remove() y Replace()


string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(5, 20);
Console.WriteLine(updatedData);

//Uso del método Replace()

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
message = message.Replace("This", "Esto");
Console.WriteLine(message);

//Realización de un desafío para extraer, reemplazar y quitar datos de una cadena de entrada
Console.WriteLine("/////////////////////////////////////////////");
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "Quantity: ";
string output = "Output: ";

// Your work here
const string startTag = "<div>";
const string startTagSpan = "<span>";

int cerrarPosicion = input.IndexOf("</div>");
int startTagLong = startTag.Length;

int length = cerrarPosicion - startTagLong;


//cadena sin div
output += input.Substring(startTagLong, length);
output = output.Replace("&trade", "&reg");

int abrirSpan = output.IndexOf("<span>");
Console.WriteLine(abrirSpan);
int cerrarPosicionSpan = output.IndexOf("</span>");
Console.WriteLine(cerrarPosicionSpan);

int startSpanLong = startTagSpan.Length + abrirSpan;
int lengthSpan = cerrarPosicionSpan - startSpanLong;
Console.WriteLine(lengthSpan);

quantity += output.Substring(startSpanLong, lengthSpan);


Console.WriteLine(quantity);
Console.WriteLine(output);


// otra solucion

// Your work here

// Extract the "quantity"
const string openSpan = "<span>";
const string closeSpan = "</span>";

int quantityStart = input.IndexOf(openSpan) + openSpan.Length; // + length of <span> so index at end of <span> tag
int quantityEnd = input.IndexOf(closeSpan);
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength);
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";
output = input.Replace(tradeSymbol, regSymbol);

// Remove the opening <div> tag
const string openDiv = "<div>";
int divStart = output.IndexOf(openDiv);
output = output.Remove(divStart, openDiv.Length);

// Remove the closing </div> tag and add "Output:" to the beginning
const string closeDiv = "</div>";
int divCloseStart = output.IndexOf(closeDiv);
output = "Output: " + output.Remove(divCloseStart, closeDiv.Length);

Console.WriteLine(quantity);
Console.WriteLine(output);


//indexOfAny = busca caracteres



