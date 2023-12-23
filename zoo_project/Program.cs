/*
Va a desarrollar una aplicación que coordina las visitas escolares al zoo de mascotas Contoso. El zoo es el hogar de 18 especies diferentes de animales. En el zoo, los alumnos visitantes se asignan a grupos y cada grupo tiene un conjunto de animales asignado. Después de visitar un conjunto de animales, los alumnos rotarán en los grupos hasta que hayan visto todos los animales del zoo de mascotas.

De forma predeterminada, los alumnos se dividen en 6 grupos. Sin embargo, hay algunas clases que tienen un número menor o mayor de alumnos, por lo que debe ajustarse el número de grupos en consecuencia. Los animales también deben asignarse aleatoriamente a cada grupo, con el fin de que la experiencia sea siempre única.

La especificación del diseño de la aplicación para el zoo de mascotas Contoso es la siguiente:

Actualmente hay tres colegios de visita:

El colegio A tiene seis grupos de visita (número predeterminado).
El colegio B tiene tres grupos de visita.
El colegio C tiene dos grupos de visita.
Para cada colegio de visita, realice las siguientes tareas:

Aleatorizar los animales.
Asignar los animales al número correcto de grupos.
Imprimir el nombre del colegio.
Imprimir los grupos de animales.*/

/*
- Habrá tres escuelas visitantes.
    - La escuela A tiene seis grupos de visitas (el número predeterminado)
    - La escuela B tiene tres grupos de visitas.
    - La escuela C tiene dos grupos de visitas.

- Para cada escuela visitante, realice las siguientes tareas
    - Aleatorizar los animales.
    - Asigna los animales al número correcto de grupos.
    - Imprima el nombre de la escuela
    - Imprimir los grupos de animales.*/

using System;

string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6)
{
   RandomizeAnimals();
   string[,] group = AssignGroup(groups);
   Console.WriteLine(schoolName);
   PrintGroup(group);
}

void RandomizeAnimals()
{
   Random random = new Random();
   for (int i = 0; i < pettingZoo.Length; i++)
   {
      int r = random.Next(i, pettingZoo.Length);

      string temp = pettingZoo[r];
      pettingZoo[r] = pettingZoo[i];
      pettingZoo[i] = temp;
   }

}

string[,] AssignGroup(int groups = 6)
{
   string[,] result = new string[groups, pettingZoo.Length / groups];

   int start = 0;
   for (int i = 0; i < groups; i++)
   {
      for (int j = 0; j < result.GetLength(1); j++)
      {
         result[i, j] = pettingZoo[start++];
      }
   }

   return result;
}

void PrintGroup(string[,] group)
{
   for (int i = 0; i < group.GetLength(0); i++)
   {
      Console.Write($"Group {i + 1}: ");
      for (int j = 0; j < group.GetLength(1); j++)
      {
         Console.Write($"{group[i, j]}  ");
      }
      Console.WriteLine();
   }
}