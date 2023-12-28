### FUNCIONES -.

```csharp
<modificador_de_acceso> <tipo_de_retorno> <nombre_de_la_funcion>(<lista_de_parametros>)
{
    // Cuerpo de la función
    // Puedes realizar operaciones aquí
    return <valor_de_retorno>; // Opcional dependiendo del tipo de retorno
}
```

- _modificador_de_acceso:_ Puede ser public, private, protected, internal, entre otros. Indica desde dónde se puede acceder a la función.

- _tipo_de_retorno:_ Indica el tipo de dato que la función devolverá. Puede ser cualquier tipo de dato válido en C# (int, string, bool, etc.) o incluso un tipo personalizado.

- _nombre_de_la_funcion:_ Es el nombre que le das a tu función. Debe seguir las reglas de nomenclatura de C# y describir lo que hace la función.

- _lista_de_parametros:_ Es una lista de variables separadas por comas que la función aceptará como entrada. Cada parámetro debe tener un tipo y un nombre.

- _Cuerpo de la función:_ Aquí es donde escribes el código que realiza la tarea de la función.

- _return:_ Indica el valor que la función devuelve. No todas las funciones tienen que devolver un valor. El tipo de retorno de la función y el tipo del valor de retorno, si existe, deben coincidir.

```csharp
// Declaración de una función con parámetros y valor de retorno
    public int Sumar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }

```

ejemplo curso:

```csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ARRAYS

            //en este tipo de array lugeo es mas complejo agregar y eliminar elementos

            //tipo[] nombreArray = { valor1, valor2, valor3, ...};
            int[] numeros = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < numeros.Length; i++)
            {
                MessageBox.Show("el numero es: " + numeros[i]);
            }

            //es mejro segun el video
            List<int> listaDeNumeros = traerListado();

            //iteracion de array
            mostrarListado(listaDeNumeros);
        }

        //funcion que contiene valores de la lista
        private List<int> traerListado()
        {
            List<int> listaDeNumeros = new List<int>();
            listaDeNumeros.Add(0);
            listaDeNumeros.Add(1);
            listaDeNumeros.Add(2);
            listaDeNumeros.Add(3);
            return listaDeNumeros;
        }
        //funcion que itera los datos del array
        private void mostrarListado(List<int> listaDeNumeros)
        {
            for (int i = 0; i < listaDeNumeros.Count; i++)
            {
                MessageBox.Show("el numero es: " + listaDeNumeros[i]);
            }
        }
    }
}
```
