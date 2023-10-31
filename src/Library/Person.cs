using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Person
    {
        // Propiedad para obtener o establecer el nombre de la persona.
        public string Name { get; set; }

        // Propiedad para obtener o establecer la edad de la persona.
        public int Age { get; set; }

        // Constructor para inicializar una nueva instancia de la clase Person con un nombre y una edad específicos.
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}