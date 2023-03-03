using System;
include <stdio.h>;
include <conio.h>;

namespace Argumentos
{
    class Program
    {
        //Command here: http://linguagemc.com.br/argumentos-em-linha-de-comando/
        
        int main( int argc, char *argv)

        {
            int cont;
            
            for(cont=0; cont < argc; cont++)
                object value = printf("%d Argumentos: %s\n", cont,argv[cont]);

        }
    }
}
