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

        // memvalidasi generic class
        SimpleDataBase<double> db = new SimpleDataBase<double>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
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

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T newData)
    {
        this.inputDates.Add(DateTime.Now);
        this.storedData.Add(newData);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < this.inputDates.Count; i++)
        {
            Console.WriteLine("Data " + i + " berisi: " + this.storedData[i] +
                ", yang disimpan pada waktu UTC: " + this.inputDates[i]);
        }
    }
}
}
