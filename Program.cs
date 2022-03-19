using System;
using System.Collections.Generic;

namespace JurnalMod4
{
    class Program
    {
        static void Main(string[] args)
    {
        // memanggil generic method
        Console.WriteLine(Penjumlahan.JumlahTigaAngka<long>(12, 34, 56));

        
    }
}

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T input1, T input2, T input3)
    {
        dynamic a = input1;
        dynamic b = input2;
        dynamic c = input3;

        return a + b + c;

        // atau opsi lain tanpa variable temporary:
        //return (dynamic)input1 + (dynamic)input2 + (dynamic)input3;
    }
}


}
