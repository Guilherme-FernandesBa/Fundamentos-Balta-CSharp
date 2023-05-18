using System;

namespace Calculadora
{
    class Programa
    {
        static void Main(string[] args)
        {
            try
            {
                Menu.Mostrar();
            }
            catch
            {
                Menu.Padrao();
                
            }
        }
    }
}