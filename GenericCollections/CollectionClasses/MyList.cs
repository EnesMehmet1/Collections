using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericCollections.CollectionInterfaces;

namespace GenericCollections.CollectionClasses
{
    public class MyList : IGenericCollections
    {
        // List koleksiyon tipi IList arayüzünü implemente eder, dolayası ile Crud işlemleri ile birlikte İndexleme de vardır.

        List<string> myList = new List<string>() { "Enes", "Mehmet", "Yıldırım" };
        //IList<string> myList = new List<string>() { "Enes", "Mehmet", "Yıldırım" }; //Buradaki gibi List sınıfının implemente ettiği üst arayüzlerin tipini de alabilir.
        public void GetCollection()
        {
            IList<string> ilist = myList;
            ilist.Add("EMY");

            IEnumerable<string> enumerable = myList;
            IReadOnlyList<string> readOnlyList = myList;

            ilist.RemoveAt(0); //Listeler bir referans tutucudurlar, burada ilist'den 0.item'i silersek referansını verdiği readonlyList'den de silinir
            foreach (var item in readOnlyList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
