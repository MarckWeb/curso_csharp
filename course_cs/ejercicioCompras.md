```csharp
 //tenemso los soguientes productos
 /*
  -pantalon; 20$
 -camisa: 35$
 -zapatos: 24$
 Armar un nprograma que permita agregar estos productos a un listado
 Mostrar el precio final
 Aplicar un 10% de descuento si ingresa el codigo de promocion NAVIDAD
  */

  public partial class Form1 : Form
 {
     public Form1()
     {
         InitializeComponent();
     }

     private void Form1_Load(object sender, EventArgs e)
     {
         cboProductos.Items.Add("Pantalon");
         cboProductos.Items.Add("Camisa");
         cboProductos.Items.Add("Zapato");
     }

     private void btnAgregar_Click(object sender, EventArgs e)
     {
         //agregamos la opcion seleccionada de combobox
         string productoSeleccionado = cboProductos.SelectedItem.ToString();
         listCompra.Items.Add(productoSeleccionado);
     }

     private void btnComprar_Click(object sender, EventArgs e)
     {
         double precioFinal = 0;

         //Capturamos los items de listbox
         int totalProductosSeleccionados = listCompra.Items.Count;

         for(int i = 0; i < totalProductosSeleccionados; i++)
         {
             string productoElegido = listCompra.Items[i].ToString();
             if(productoElegido == "Pantalon")
             {
                 precioFinal += 20;
             }else if(productoElegido == "Camisa")
             {
                 precioFinal += 35;
             }if(productoElegido == "Zapato")
             {
                 precioFinal += 24;
             }

         }

         if(txtCuponDescuento.Text == "NAVIDAD")
         {
             precioFinal = precioFinal * 0.9;
         }


         MessageBox.Show("el precio total es: " + precioFinal);
     }
 }
```

ejercicio mostrar los 100 primeros numeros primos

```csharp
 private void btnMostrar_Click(object sender, EventArgs e)
 {
     string resultado = "";
     double numero = 2;
     int contador = 0;
      while (contador < 100) {
         if (esNumeroPrimo(numero))
         {
             resultado = resultado + " , " + numero;
             contador++;
         }
         numero++;
     }

     MessageBox.Show(resultado);
 }

 private bool esNumeroPrimo(double numero)
 {
     bool esPrimo = true;

     for (int i = 2; i < numero; i++)
     {

         if (numero % i == 0) {
             esPrimo = false;
         }

     }
     return esPrimo;
 }
```
