using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class L_Nodo
    {
        private int dato;
        private L_Nodo left;
        private L_Nodo right;

        public int Dato { get => dato; set => dato = value; }
        internal L_Nodo Left { get => left; set => left = value; }
        internal L_Nodo Right { get => right; set => right = value; }

        public L_Nodo()
        {
            dato = 0;
            left = null;
            right = null;
        }
    }
}
