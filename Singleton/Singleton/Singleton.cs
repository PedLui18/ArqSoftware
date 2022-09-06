using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        // 1. constructor privado
        private Singleton() { }
        // 2. propiedad estatica publica
        public static Singleton _instanciaSingleton = new Singleton();
        // 3. Campo estatico 
        public static Singleton Instancia()
        {
            return _instanciaSingleton;
        }

    }
}
