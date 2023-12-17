using System;
using System.Reflection.Metadata;

// El array ourAnimals almacenará la siguiente información:
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// Variables que admiten la entrada de datos
int maxPets = 8;
string? readResult;
string menuSelection = "";

// Array utilizado para almacenar datos en tiempo de ejecución, no hay datos persistentes
string[,] ourAnimals = new string[maxPets, 6];

// Crear algunas entradas iniciales en el array ourAnimals
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "perro";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "tamaño mediano, hembra de color crema, golden retriever que pesa alrededor de 65 libras. Adiestrada para ir al baño.";
            animalPersonalityDescription = "le encanta que le acaricien la barriga y le gusta perseguir su cola. Da muchos besos.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "perro";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "grande, macho de color marrón rojizo, golden retriever que pesa alrededor de 85 libras. Adiestrado para ir al baño.";
            animalPersonalityDescription = "le encanta que le acaricien las orejas cuando te saluda en la puerta, ¡o en cualquier momento! Le encanta inclinarse y dar abrazos de perro.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "gato";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "pequeña hembra blanca que pesa alrededor de 8 libras. Entrenada para usar la caja de arena.";
            animalPersonalityDescription = "amigable";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "gato";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Especie: " + animalSpecies;
    ourAnimals[i, 2] = "Edad: " + animalAge;
    ourAnimals[i, 3] = "Apodo: " + animalNickname;
    ourAnimals[i, 4] = "Descripción física: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personalidad: " + animalPersonalityDescription;
}

do
{
    // Mostrar las opciones del menú principal

    Console.Clear();

    /*
    Enumere toda la información de mascotas de la que disponemos actualmente.
    Asigne valores a los campos de la matriz ourAnimals.
    Asegúrese de que las edades y las descripciones físicas de los animales estén completas.
    Asegúrese de que los apodos y las descripciones de personalidad de los animales estén completos.
    Edite la edad de un animal.
    Edite la descripción de personalidad de un animal.
    Muestre todos los gatos con una característica especificada.
    Muestre todos los perros con una característica especificada.
    */

    Console.WriteLine("Bienvenido a la aplicación Contoso PetFriends. Sus opciones principales del menú son:");
    Console.WriteLine(" 1. Listar toda nuestra información actual de mascotas");
    Console.WriteLine(" 2. Agregar una nueva mascota a la matriz ourAnimals");
    Console.WriteLine(" 3. Asegurarse de que las edades y descripciones físicas de los animales estén completas");
    Console.WriteLine(" 4. Asegurarse de que los apodos y descripciones de personalidad de los animales estén completos");
    Console.WriteLine(" 5. Editar la edad de una mascota");
    Console.WriteLine(" 6. Editar la descripción de personalidad de una mascota");
    Console.WriteLine(" 7. Mostrar todos los gatos con una característica especificada");
    Console.WriteLine(" 8. Mostrar todos los perros con una característica especificada");
    Console.WriteLine();
    Console.WriteLine("Ingrese el número de su selección (o escriba Salir para salir del programa)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
        // NOTA: podríamos poner una declaración do alrededor de la entrada de menuSelection para garantizar una entrada válida, pero
        // usamos una declaración condicional abajo que solo procesa los valores de entrada válidos, así que la declaración do
        // no es necesaria aquí.
    }

    // Utilizar switch-case para procesar la opción de menú seleccionada
    switch (menuSelection)
    {
        case "1":
            // Listar toda nuestra información actual de mascotas
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPresione la tecla Enter para continuar");
            readResult = Console.ReadLine();

            break;

        case "2":
            // Agregar una nueva mascota a la matriz ourAnimals
            string anotherPet = "s";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"Actualmente tenemos {petCount} mascotas que necesitan hogar. Podemos manejar {(maxPets - petCount)} más.");
            }

            while (anotherPet == "s" && petCount < maxPets)
            {
                bool validEntry = false;

                // Obtener la especie (perro o gato) - la cadena animalSpecies es un campo obligatorio
                do
                {
                    Console.WriteLine("\n\rIngrese 'perro' o 'gato' para comenzar una nueva entrada");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "perro" && animalSpecies != "gato")
                        {
                            //Console.WriteLine($"Ingresaste: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // Construir el número de identificación del animal - por ejemplo, C1, C2, D3 (para Gato 1, Gato 2, Perro 3)
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                // Obtener la edad de la mascota. Puede ser ? en la entrada inicial.
                do
                {
                    int petAge;
                    Console.WriteLine("Ingrese la edad de la mascota o ingrese ? si es desconocida");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // Obtener una descripción de la apariencia/condición física de la mascota - animalPhysicalDescription puede estar en blanco.
                do
                {
                    Console.WriteLine("Ingrese una descripción física de la mascota (tamaño, color, género, peso, entrenamiento para ir al baño)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "a determinar";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // Obtener una descripción de la personalidad de la mascota - animalPersonalityDescription puede estar en blanco.
                do
                {
                    Console.WriteLine("Ingrese una descripción de la personalidad de la mascota (gustos o disgustos, trucos, nivel de energía)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "a determinar";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // Obtener el apodo de la mascota. animalNickname puede estar en blanco.
                do
                {
                    Console.WriteLine("Ingrese un apodo para la mascota");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "a determinar";
                        }
                    }
                } while (animalNickname == "");

                // Almacenar la información de la mascota en la matriz ourAnimals (basado en cero)
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Especie: " + animalSpecies;
                ourAnimals[petCount, 2] = "Edad: " + animalAge;
                ourAnimals[petCount, 3] = "Apodo: " + animalNickname;
                ourAnimals[petCount, 4] = "Descripción física: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personalidad: " + animalPersonalityDescription;

                // Incrementar petCount (la matriz es de base cero, así que incrementamos el contador después de agregar a la matriz)
                petCount = petCount + 1;

                // Comprobar el límite de maxPets
                if (petCount < maxPets)
                {
                    // ¿Otra mascota?
                    Console.WriteLine("¿Quieres ingresar información para otra mascota (s/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "s" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("Hemos alcanzado nuestro límite en la cantidad de mascotas que podemos manejar.");
                Console.WriteLine("Presione la tecla Enter para continuar.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Asegurarse de que las edades y descripciones físicas de los animales estén completas
            Console.WriteLine("Asegurándose de que las edades y descripciones físicas de los animales estén completas:");

            int edadInt = 0;

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        if (j == 0 || j == 2) // Verificar las propiedades "ID #" y "Edad"
                        {
                            Console.WriteLine(ourAnimals[i, j]);
                        }
                    }

                    // Validar y actualizar la edad
                    string edadString = ourAnimals[i, 2].Split(' ')[1];
                    if (!int.TryParse(edadString, out edadInt))
                    {
                        // La conversión no fue exitosa, solicitar un nuevo valor
                        Console.WriteLine($"La edad de la mascota {ourAnimals[i, 0].Split(' ')[1]} es inválida. Ingrese una nueva edad:");
                        while (!int.TryParse(Console.ReadLine(), out edadInt))
                        {
                            Console.WriteLine("Por favor, ingrese un valor numérico válido para la edad:");
                        }
                    }

                    // Validar y actualizar la descripción física
                    string descripcionFisica = ourAnimals[i, 4].Split(':')[1].Trim();
                    if (descripcionFisica == "")
                    {
                        // La descripción física está incompleta, solicitar un nuevo valor
                        Console.WriteLine($"La descripción física de la mascota {ourAnimals[i, 0].Split(' ')[1]} está incompleta. Ingrese una nueva descripción física:");
                        while (string.IsNullOrWhiteSpace(readResult = Console.ReadLine()))
                        {
                            Console.WriteLine("Por favor, ingrese una descripción física válida:");
                        }
                        descripcionFisica = readResult;
                    }

                    // Asignar los valores actualizados
                    ourAnimals[i, 2] = "Edad: " + edadInt;
                    ourAnimals[i, 4] = "Descripción física: " + descripcionFisica;
                }
            }

            // Mostrar mensaje y pausar la aplicación
            Console.WriteLine("Se han asegurado las edades y descripciones físicas de las mascotas.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            Console.ReadLine();
            break;


        case "4":
            // Asegurarse de que los apodos y descripciones de personalidad de los animales estén completos
            Console.WriteLine("Asegurándose de que los apodos y descripciones de personalidad de los animales estén completos:");

            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        if (j == 0 || j == 3) // Verificar las propiedades "ID #" y "Apodo"
                        {
                            Console.WriteLine(ourAnimals[i, j]);
                        }
                    }

                    // Validar y actualizar el apodo
                    string apodo = ourAnimals[i, 3].Split(':')[1].Trim();
                    if (apodo == null || apodo.Length == 0 || apodo.Trim() == "")
                    {
                        // El apodo está incompleto, solicitar un nuevo valor
                        Console.WriteLine($"El apodo de la mascota {ourAnimals[i, 0].Split(' ')[1]} está incompleto. Ingrese un nuevo apodo:");
                        readResult = Console.ReadLine();
                        while (readResult == null || readResult.Trim() == "")
                        {
                            Console.WriteLine("Por favor, ingrese un apodo válido:");
                            readResult = Console.ReadLine();
                        }
                        apodo = readResult;
                    }

                    // Validar y actualizar la descripción de personalidad
                    string descripcionPersonalidad = ourAnimals[i, 5].Split(':')[1].Trim();
                    if (descripcionPersonalidad == null || descripcionPersonalidad.Length == 0 || descripcionPersonalidad.Trim() == "")
                    {
                        // La descripción de personalidad está incompleta, solicitar un nuevo valor
                        Console.WriteLine($"La descripción de personalidad de la mascota {ourAnimals[i, 0].Split(' ')[1]} está incompleta. Ingrese una nueva descripción de personalidad:");
                        readResult = Console.ReadLine();
                        while (readResult == null || readResult.Trim() == "")
                        {
                            Console.WriteLine("Por favor, ingrese una descripción de personalidad válida:");
                            readResult = Console.ReadLine();
                        }
                        descripcionPersonalidad = readResult;
                    }

                    // Asignar los valores actualizados
                    ourAnimals[i, 3] = "Apodo: " + apodo;
                    ourAnimals[i, 5] = "Personalidad: " + descripcionPersonalidad;
                }
            }

            // Mostrar mensaje y pausar la aplicación
            Console.WriteLine("Se han asegurado los apodos y descripciones de personalidad de las mascotas.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            Console.ReadLine();
            break;

        case "5":
            // Editar la edad de una mascota
            Console.WriteLine("EN CONSTRUCCIÓN - por favor, vuelva el próximo mes para ver el progreso.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Editar la descripción de personalidad de una mascota
            Console.WriteLine("EN CONSTRUCCIÓN - por favor, vuelva el próximo mes para ver el progreso.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Mostrar todos los gatos con una característica especificada
            Console.WriteLine("EN CONSTRUCCIÓN: vuelva a consultar el próximo mes para ver el progreso.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Mostrar todos los gatos con una característica especificada
            Console.WriteLine("EN CONSTRUCCIÓN: vuelva a consultar el próximo mes para ver el progreso.");
            Console.WriteLine("Presione la tecla Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "salir");