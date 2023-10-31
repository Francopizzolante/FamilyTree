using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class AgeSumVisitor : IVisitor
    {
        // Propiedad de solo lectura para obtener la suma total de las edades de las personas visitadas.
        public int AgeSum { get; private set; } = 0;

        // Método para visitar un nodo, sumar la edad de la persona asociada y visitar recursivamente los nodos hijos.
        public void Visit(Node node)
        {
            AgeSum += node.Person.Age;
            foreach (var child in node.Children)
            {
                child.Accept(this);
            }
        }
    }
}