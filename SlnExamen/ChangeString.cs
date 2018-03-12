using System;
using System.Text.RegularExpressions;

namespace SlnExamen
{
    public class ChangeString
    {

        public string   build( Char  cadena)
        {
            int cont = 0;

            if (cadena != Convert.ToChar(cadena.ToString().ToLower()))
                {
                cadena = Convert.ToChar(cadena.ToString().ToLower());
                cont = 1;
            }

            
            string cad = string.Empty;
            switch (cadena)
            {
                case 'a':
                    cadena = 'b' ;
                    break;
                case 'b':
                    cadena = 'c';
                    break;
                case 'c':
                    cadena = 'd';
                    break;
                case 'd':
                    cadena = 'e';
                    break;
                case 'e':
                    cadena = 'f';
                    break;
                case 'f':
                    cadena = 'g';
                    break;
                case 'g':
                    cadena = 'h';
                    break;
                case 'h':
                    cadena = 'i';
                    break;
                case 'i':
                    cadena = 'j';
                    break;
                case 'j':
                    cadena = 'k';
                    break;
                case 'k':
                    cadena = 'l';
                    break;
                case 'l':
                    cadena = 'm';
                    break;
                case 'm':
                    cadena = 'n';
                    break;
                case 'n':
                    cadena = 'ñ';
                    break;
                case 'ñ':
                    cadena = 'o';
                    break;
                case 'o':
                    cadena = 'p';
                    break;
                case 'p':
                    cadena = 'q';
                    break;
                case 'q':
                    cadena = 'r';
                    break;
                case 'r':
                    cadena = 's';
                    break;
                case 's':
                    cadena = 't';
                    break;
                case 't':
                    cadena = 'u';
                    break;
                case 'u':
                    cadena = 'v';
                    break;
                case 'v':
                    cadena = 'w';
                    break;
                case 'w':
                    cadena = 'x';
                    break;
                case 'x':
                    cadena = 'y';
                    break;
                case 'y':
                    cadena = 'z';
                    break;
                case 'z':
                    cadena = 'a';
                    break;
            }

            if (cont  == 1)
            {
                cadena = Convert.ToChar(cadena.ToString().ToUpper());
            }

            cad = Convert.ToString(cadena); 


            return cad;
            }

        }
}