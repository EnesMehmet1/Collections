using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    public class MyArrayList
    {
        ArrayList arrayList = new ArrayList();
        public void Start()
        {
            arrayList.Add("123");
            arrayList.Add(123);
            arrayList.Add(new object() { });

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
