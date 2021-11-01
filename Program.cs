using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                 if(i%2==1)
                 Console.Write(i);
            }
            int tekToplam=0;
            int cifttoplam=0;

            for (int i = 1; i < 1000; i++)
            {
                if(i%2==1)
                    tekToplam+=i;
                else
                cifttoplam +=i;
            }
            Console.WriteLine("Tek toplam"+tekToplam);
            Console.WriteLine("çift toplam"+cifttoplam);

            //break,continue
             for(int i = 0; i < 10; i++)
            {
            
            if(i==4)
              break;
            Console.Write(i);

            }
            for(int i = 0; i < 10; i++)
            {
            
            if(i==4)
              continue;
            Console.Write(i);

            }
       
     }

       
       
    
        
    }
}
