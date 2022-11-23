using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol_Binario arbol = new Arbol_Binario();
            L_Nodo raiz = arbol.New_nodo(6, null);
            arbol.New_nodo(2, raiz); arbol.New_nodo(8, raiz); arbol.New_nodo(1, raiz); arbol.New_nodo(4, raiz);
            arbol.New_nodo(3, raiz); arbol.New_nodo(5, raiz); arbol.New_nodo(7, raiz); arbol.New_nodo(11, raiz);
            

            arbol.Transversa(raiz);

            Console.WriteLine("----------------\n");
            L_Nodo Bus = arbol.Buscar(2, raiz);
            Console.WriteLine(Bus.Dato);
            Console.WriteLine("\n----------------\n");

            Console.WriteLine("\nInorder\n"); arbol.ordenar(Bus, "inorder");
            Console.WriteLine("\nPreorder\n"); arbol.ordenar(Bus, "preorder");
            Console.WriteLine("\nPostorder\n"); arbol.ordenar(Bus,"postorder");
        }
    }
}
