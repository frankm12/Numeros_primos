using System;

namespace programa_principal
{
    class programa_principal
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este es un programa hecho por mi para saber si el numero que el usuario ingrese es primo o no\n");
            Console.WriteLine("Ingrese un numero");

            int numero_para_buscar_primo = int.Parse(Console.ReadLine());
            int divisor = 1, contador = 0;
            while(divisor <= numero_para_buscar_primo)
            {
                if(numero_para_buscar_primo % divisor == 0)
                {
                    contador++;
                }    
                divisor++;
            }
            if(contador == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero no es primo");
            }
        }
    }
}
