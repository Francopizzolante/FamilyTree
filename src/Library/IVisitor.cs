using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IVisitor
    {
        // Método para visitar un nodo y realizar operaciones sobre él.
        void Visit(Node node);
    }

}