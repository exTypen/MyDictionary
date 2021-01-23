using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> notlar = new MyDictionary<string, int>();
            notlar.Add("Ahmet", 90);
            notlar.Add("Mehmet", 80);
            notlar.Add("Yasir", 100);
            notlar.Add("Furkan", 70);
            notlar.Add("Yusuf", 40);

            notlar.Print();

            notlar.Clear();

            notlar.Add("DENEME", 10);

            notlar.Print();
        }
    }
}
