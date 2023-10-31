using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class OldestChildVisitor : IVisitor
    {
        // Propiedad de solo lectura para obtener la persona más grande entre los nodos hoja visitados.
        public Person OldestChild { get; private set; }

        // Propiedad privada para almacenar la edad de la persona más grande encontrada.
        private int OldestAge { get; set; } = 0;

        // Método para visitar un nodo, verificar si es una hoja y si es la persona más grande encontrada, y visitar recursivamente los nodos hijos.
        public void Visit(Node node)
        {
            if (node.Children.Count == 0 && node.Person.Age > OldestAge)
            {
                OldestChild = node.Person;
                OldestAge = node.Person.Age;
            }

            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}