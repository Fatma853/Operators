using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x = 3;
            Console.WriteLine("x: " + x);

            int y = 3;
            Console.WriteLine("y: " + y);
            
            y = y + 2;
            Console.WriteLine("y: " + y);
            
            y += 2;
            Console.WriteLine("y: " + y);
            
            y /= 1;
            Console.WriteLine("y: " + y);

            x *= 2;
            Console.WriteLine("x: " + x);

            // Mantıksal Operatörler
            // || (veya), && (ve), ! (değil)

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
                Console.WriteLine("Great!");

            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            // İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            Console.WriteLine("İlişkisel Operatörler");

            int a = 3;
            int b = 4;
            
            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);

            // Aritmetik Operatörler
            // /, *, +, -

            Console.WriteLine("\nAritmetik Operators");
            
            int sayi1 = 8;
            int sayi2 = 2;

            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
            Console.WriteLine(sonuc1);
            
            sonuc1 = sayi1 + sayi2;
            Console.WriteLine(sonuc1);
            
            sonuc1 = sayi1 - sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1++; // sayi1++ = sayi1 + 1
            Console.WriteLine(sonuc1);

            // % : Mod alınır.
            
            int sonuc2 = 20 % 3;
            sayi2 = 3;
            Console.WriteLine(sonuc2);
        }
    }
}

