using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node abuelo = new Node(new Person("Pepe", 70));
            Node padre = new Node(new Person("Mario", 45));
            Node madre = new Node(new Person("Leticia", 43));
            Node hijo = new Node(new Person("Ernesto", 20));
            Node hija = new Node(new Person("Luisa", 18));
            Node tio = new Node(new Person("Osbaldo", 40));
            Node primo = new Node(new Person("Marcos", 15));
            Node prima = new Node(new Person("Patricia", 17));

            abuelo.AddChildren(padre);
            abuelo.AddChildren(madre);
            abuelo.AddChildren(tio);
            padre.AddChildren(hijo);
            padre.AddChildren(hija);
            tio.AddChildren(primo);
            tio.AddChildren(prima);

            AgeSumVisitor ageSumVisitor = new AgeSumVisitor();
            abuelo.Accept(ageSumVisitor);
            Console.WriteLine($"La suma de las edades es: {ageSumVisitor.AgeSum}");

            OldestChildVisitor oldestChildVisitor = new OldestChildVisitor();
            abuelo.Accept(oldestChildVisitor);
            Console.WriteLine($"El hijo más grande es: {oldestChildVisitor.OldestChild.Name}");

            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            abuelo.Accept(longestNameVisitor);
            Console.WriteLine($"La persona con el nombre más largo es: {longestNameVisitor.LongestNamePerson.Name}");

        }
    }
}
