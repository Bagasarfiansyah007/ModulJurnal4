using System;
using System.Collections.Generic;

namespace JurnalMod4
{
    class Program
    {
        static void Main(string[] args)
    {
        // memvalidasi generic class
        SimpleDataBase<double> db = new SimpleDataBase<double>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
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
