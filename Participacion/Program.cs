using System;

namespace Participacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que simule un banco que tiene 
            //3 clientes que pueden hacer depósitos y retiros. 
            //También el banco requiere que al final del día calcule 
            //la cantidad de dinero que hay depositado.

            int a, b, c, d, dj, dp, dm, rj, rp, rm, j=20000, p=16000, m=60500;
            do
            {
                Console.Clear();
                Console.WriteLine("Elija su usuario");
                Console.WriteLine("(1) Juan");
                Console.WriteLine("(2) Pedro");
                Console.WriteLine("(3) Maria");
                Console.WriteLine("(4) Salir");
                a=int.Parse(Console.ReadLine());           
                if (a==1)
                {               
                    do
                    {
                        Console.Clear();  
                        Console.WriteLine("Usuario: Juan");                
                        Console.WriteLine("Elija una opción");
                        Console.WriteLine("(1) Depositar");
                        Console.WriteLine("(2) Retirar");
                        Console.WriteLine("(3) Salir");
                        b=int.Parse(Console.ReadLine()); 
                        if (b==1)
                        {
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",j);
                            Console.WriteLine("Digite cantidad a depositar");
                            dj=int.Parse(Console.ReadLine());
                            j+=dj;
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",j);
                            Console.ReadLine();
                        }   
                        if (b==2)  
                        {
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",j);
                            Console.WriteLine("Digite cantidad a retirar");
                            rj=int.Parse(Console.ReadLine());
                            if (rj<=j)
                            {
                                j-=rj;
                            }
                            else
                            {
                                Console.WriteLine("No tiene balance suficiente para este reiro");
                                Console.ReadLine();
                            }
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",j);
                            Console.ReadLine();
                        }             
                    } while (b!=3);
                }
                if (a==2)
                {
                    do
                    {
                        Console.Clear();  
                        Console.WriteLine("Usuario: Pedro");                
                        Console.WriteLine("Elija una opción");
                        Console.WriteLine("(1) Depositar");
                        Console.WriteLine("(2) Retirar");
                        Console.WriteLine("(3) Salir");
                        c=int.Parse(Console.ReadLine()); 
                        if (c==1)
                        {
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",p);
                            Console.WriteLine("Digite cantidad a depositar");
                            dp=int.Parse(Console.ReadLine());
                            p+=dp;
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",p);
                            Console.ReadLine();
                        }   
                        if (c==2)  
                        {
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",p);
                            Console.WriteLine("Digite cantidad a retirar");
                            rp=int.Parse(Console.ReadLine());
                            if (rp<=p)
                            {
                                p-=rp;
                            }
                            else
                            {
                                Console.WriteLine("No tiene balance suficiente para este reiro");
                                Console.ReadLine();
                            }
                        
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",p);
                            Console.ReadLine();
                        }             
                    } while (c!=3);
                }
                if (a==3)
                {
                    do
                    {
                        Console.Clear();  
                        Console.WriteLine("Usuario: Maria");                
                        Console.WriteLine("Elija una opción");
                        Console.WriteLine("(1) Depositar");
                        Console.WriteLine("(2) Retirar");
                        Console.WriteLine("(3) Salir");
                        d=int.Parse(Console.ReadLine()); 
                        if (d==1)
                        {
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",m);
                            Console.WriteLine("Digite cantidad a depositar");
                            dm=int.Parse(Console.ReadLine());
                            m+=dm;
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",m);
                            Console.ReadLine();
                        }   
                        if (d==2)  
                        {
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",m);
                            Console.WriteLine("Digite cantidad a retirar");
                            rm=int.Parse(Console.ReadLine());
                            if (rm<=m)
                            {
                               m-=rm;
                            }
                            else
                            {
                                Console.WriteLine("No tiene balance suficiente para este reiro");
                                Console.ReadLine();
                            }
                        
                            Console.Clear();
                            Console.WriteLine("Su balance es de {0} pesos",m);
                            Console.ReadLine();
                        }             
                    } while (d!=3); 
                } 
            }while (a!=4);
        }
    }
}
