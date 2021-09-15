//using System.Net.Mime;
using System;
//using System.Text;
using System.IO;
using System.Threading;
class Vuive
{
    public static void Main()
    {
        string a = "3/9/1998";
        Console.Write("Nhap ngay sinh di ban ey: ");
        string input = Console.ReadLine();
        if (input != a)
        {
            Console.WriteLine("Sai roi ban ey, ngay sinh cung d nho.");
            Console.Write("Nhap lai di ban ey: ");
            _ = Console.ReadLine();
        }
        for (int i = 0; i <= 100; i += 10)
        {
            Console.WriteLine("Dang xu ly {0}%", i);
            Thread.Sleep(100);
        }
        Console.WriteLine("\n");

        Console.WriteLine("Hoan thanh roi ey");
        Console.WriteLine("\n");

        string[] s = new string[1000];
        using (StreamReader sr = new StreamReader("/Funny Code/Funny/Funnyhung/bin/Debug/net5.0/hung.txt"))
        {
            string line;

            // doc va hien thi cac dong trong file cho toi
            // khi tien toi cuoi file. 
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
                Thread.Sleep(100);
            }
        }
        Console.WriteLine("\n");

        Console.WriteLine("Code tang ban cho ban co dong luc hoc :D hi");
        Console.ReadKey();


    }
}

