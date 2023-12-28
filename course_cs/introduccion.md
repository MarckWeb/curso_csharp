# INTRODUCCION

es un lenguaje fuertemente tipado

#### VARIABLES -.

```csharp
string nombreVariable = "valor variable";
int numeroEntero = 10;
double numeroDecimal = 500.52

//concatenacion

string resultado = numeroEntero +  numeroDecimal + nombreVariable //510.52valor variable

string resultado = nombreVariable + numeroEntero +  numeroDecimal //valor variable500.5210
```

##### TABLA DE IMC CODIGO EN C#

```csharp
//guardamos el valor el input en la variable
string textPeso = txtPeso.Text;

//convertir string a numero
double numPeso = Double.Parse(textPeso); //peso en kilogramos

string textAltura = txtAltura.Text;
double numAltura = Double.Parse(textAltura); //peso en metros


double resultadoIMC = numPeso / (numAltura * numAltura);

//para mostrar una alerta

MessageBox.Show("El IMC es: " + resultadoIMC);
```

#### ARRAYS -.

En C#, la elección entre Count y Length depende del tipo de colección o array que estás utilizando.

- _Length_ -. se utiliza con arrays. Es una propiedad que devuelve el número total de elementos en el array.

```csharp
 //ARRAYS

 //en este tipo de array lugeo es mas complejo agregar y eliminar elementos

 //tipo[] nombreArray = { valor1, valor2, valor3, ...};
 int[] numeros = { 1, 2, 3, 4, 5 };

 for (int i = 0; i < numeros.Length; i++)
 {
     MessageBox.Show("el numero es: " + numeros[i]);
 }
```

- _Count_ -. se utiliza con colecciones que implementan la interfaz ICollection `<T>` o ICollection. Es una propiedad que devuelve el número de elementos en la colección.

```csharp
 //es mejor segun el video
 List<int> listaDeNumeros = new List<int>();
 listaDeNumeros.Add(0);
 listaDeNumeros.Add(1);
 listaDeNumeros.Add(2);
 listaDeNumeros.Add(3);

 //iteracion de array

 for(int i = 0; i < listaDeNumeros.Count; i++)
 {
     MessageBox.Show("el numero es: " + listaDeNumeros[i]);
 }
```
