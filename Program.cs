using System;

namespace operatorler
{
    class program
    {
        static void Main(string[] args)
        {
            //atama ve işlemli atama
            Console.WriteLine("---------------------------Atama İşlemli Atama---------------------------");
            int x=3;
            int y=3;
            y = y+2;
            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y /=1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);
            // mantıksa operatörler 
            // !, &&, ||
            Console.WriteLine("---------------------------Mantıksal Operatörler---------------------------");
            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");     
            
            //İlişkisel operatörler
            // >,<, <=, >=, ==, !=
            Console.WriteLine("---------------------------ilişkisel Operatörler---------------------------");
            int a=3;
            int b=4;
            bool sonuc= a<b;
            Console.WriteLine(sonuc);
            sonuc= a>b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc= a==b;
            Console.WriteLine(sonuc);

            Console.WriteLine("---------------------------Aritmetik Operatörler---------------------------");
            // /,*,+,-

            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            int sonuc2=sayi1*sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3=sayi1+sayi2;
            Console.WriteLine(sonuc3);
            int sonuc4=sayi1-sayi2;
            Console.WriteLine(sonuc4);

            // % mod alma - kalanı gösterir
            int sonuc5=sayi1%sayi2;
            Console.WriteLine(sonuc5);
            int sonuc6= 20%3;
            Console.WriteLine(sonuc6);



        }
    }
}   
