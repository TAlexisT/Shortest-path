using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Arbol_Binario
    {
        private L_Nodo raiz;
        
        private int i = 0;

        public Arbol_Binario()
        {
            raiz = null;
        }
        internal L_Nodo Raiz { get => raiz; set => raiz = value; }

        public L_Nodo New_nodo (int I_Dato, L_Nodo M_Nodo)
        {
            L_Nodo temp = null;

            // Si no hay quien inserte entonces creamos el nodo
            if (M_Nodo == null)
            {
                temp = new L_Nodo();
                temp.Dato = I_Dato;

                return temp;
            }

            if (I_Dato < M_Nodo.Dato)
            {
                M_Nodo.Left = New_nodo(I_Dato, M_Nodo.Left);
            }

            if (I_Dato > M_Nodo.Dato)
            {
                M_Nodo.Right = New_nodo(I_Dato, M_Nodo.Right);
            }

            return M_Nodo;

        }

        // Transversa

        public void Transversa (L_Nodo M_Nodo)
        {

            if (M_Nodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write(" ");
            Console.WriteLine(M_Nodo.Dato);
            
            // Si hay izquierda meto la izquierda
            if (M_Nodo.Left != null)
            {
                i++;
                Console.Write("I  ");
                Transversa(M_Nodo.Left);
                i--;
            }

            // Si hay derecha meto la derecha
            if (M_Nodo.Right != null)
            {
                i++;
                Console.Write("D  ");
                Transversa(M_Nodo.Right);
                i--;
            }
        }

        public L_Nodo Buscar(int I_Dato, L_Nodo M_Nodo)
        {
            L_Nodo encontrado = null;
            if (M_Nodo == null)
                return null;

            if (M_Nodo.Left != null)
                if (M_Nodo.Left.Dato == I_Dato)
                    return M_Nodo;

            if (M_Nodo.Right != null)
                if (M_Nodo.Right.Dato == I_Dato)
                    return M_Nodo;

            // Si hay izquierdo se va para la izquierda
            if(M_Nodo.Left != null && I_Dato < M_Nodo.Dato)
            {
                encontrado = Buscar(I_Dato, M_Nodo.Left);
            }

            // Si hay derecho se va para la derecha
            if (M_Nodo.Right != null && I_Dato > M_Nodo.Dato)
            {
                encontrado = Buscar(I_Dato, M_Nodo.Right);
            }

            return encontrado;
        }

        public void ordenar(L_Nodo nodo, string torder)
        {
            if (torder == "inorder")
            {
                if (nodo.Left != null)
                {
                    ordenar(nodo.Left, torder);
                }
                Console.WriteLine(nodo.Dato);
                if(nodo.Right != null)
                {
                    ordenar(nodo.Right, torder);
                }
           
            }
            else if (torder == "preorder")
            {
                Console.WriteLine(nodo.Dato);
                if (nodo.Left != null)
                {
                    ordenar(nodo.Left, torder);
                }
                if (nodo.Right != null)
                {
                    ordenar(nodo.Right, torder);
                }
            }
            else if (torder == "postorder")
            {
                
                if (nodo.Left != null)
                {
                    ordenar(nodo.Left, torder);
                }
                if (nodo.Right != null)
                {
                    ordenar(nodo.Right, torder);
                }
                Console.WriteLine(nodo.Dato);
            }
        }

    }
}
