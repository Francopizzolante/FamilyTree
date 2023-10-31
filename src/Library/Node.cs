using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        // Propiedad de solo lectura para obtener la persona asociada a este nodo.
        public Person Person { get; private set; }

        // Lista interna para almacenar los nodos hijos de este nodo.
        private List<Node> children = new List<Node>();

        // Propiedad de solo lectura para obtener la lista de nodos hijos como una colección de solo lectura.
        public ReadOnlyCollection<Node> Children
        {
            get { return children.AsReadOnly(); }
        }

        // Constructor para inicializar una nueva instancia de la clase Node con una persona específica.
        public Node(Person person)
        {
            this.Person = person;
        }

        // Método para agregar un nodo hijo a la lista de nodos hijos.
        public void AddChildren(Node n)
        {
            children.Add(n);
        }

        // Método para aceptar un visitador y aplicar la operación de visita a este nodo.
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
