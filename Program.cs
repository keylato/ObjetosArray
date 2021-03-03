using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadplanner 
{
    class program
    {
        static void Main(string[] args)
        {
         Objeto Objeto1 = new Objeto ("Barril","B", 2, 70f);
         Objeto Objeto2 = new Objeto ("Bolsa Chatarra","BC",1, 20f);
         Objeto Objeto3 = new Objeto ("Bolsa con plantas","BP", 2, 3f);
         Objeto Objeto4 = new Objeto ("Caja ligera","C1", 1, 5f);
         Objeto Objeto5 = new Objeto ("Caja pesada","C2", 1, 15f);
         Objeto Objeto6 = new Objeto ("Caja vacia","C3", 1, .2f);
         Objeto Objeto7 = new Objeto ("Silla","S", 2, 4f);
         Objeto vacio1 = new Objeto ("/","/", 0, 0f);
         Objeto vacio2 = new Objeto ("/","/", 0, 0f);

         Objeto [,] objetos = new Objeto [3,4]; 
         objetos [0,0] = vacio1;
         objetos [0,1] = Objeto4;
         objetos [0,2] = Objeto7;
         objetos [0,3] = vacio2;
         objetos [1,0] = Objeto3;
         objetos [1,1] = Objeto1;
         objetos [1,2] = Objeto7;
         objetos [1,3] = Objeto6;
         objetos [2,0] = Objeto3;
         objetos [2,1] = Objeto1;
         objetos [2,2] = Objeto2;
         objetos [2,3] = Objeto5;
         
        for( int i =0; i < 3; i++)
        {
        for (int j = 0; j < 4; j++)
            {
                Console.Write(objetos[i,j].ShortName + " ");
            }
        Console.WriteLine();
        }
        if ( objetos[2,1].Weights < objetos[0,1].Weights )
        {
            Console.WriteLine("Se esta aplastando" + Objeto4.Name);
        }
        else if (objetos [0,1].Weights < objetos [2,1].Weights)
        {
            Console.WriteLine("No se esta aplastando nada");
        }
        else if ( objetos [2,2].Weights > objetos [1,2].Weights)
        {
            Console.WriteLine("Se esta aplastando" + Objeto7.Name);
        }
        else if (objetos [1,2].Weights > objetos [2,2].Weights)
        {
            Console.WriteLine("No se esta aplastando nada");
        }
        else if (objetos [2,3].Weights > objetos[1,3].Weights)
        {
            Console.WriteLine("Se esta aplastando" + Objeto6.Name);
        }
        Console.ReadKey();
        }
        



          
        


            

        }
    
        
    }


