using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class LongestNameVisitor : IVisitor
    {
        // Propiedad de solo lectura para obtener la persona con el nombre más largo entre los nodos visitados.
        public Person LongestNamePerson { get; private set; }

        // Propiedad privada para almacenar la longitud del nombre más largo encontrado.
        private int LongestNameLength { get; set; } = -1;

        // Método para visitar un nodo, verificar si tiene el nombre más largo y visitar recursivamente los nodos hijos.
        public void Visit(Node node)
        {
            if (node.Person.Name.Length > LongestNameLength)
            {
                LongestNamePerson = node.Person;
                LongestNameLength = node.Person.Name.Length;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}