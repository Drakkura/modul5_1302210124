using modul5_1302210124;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302210124
{
    internal class SimpleDataBase_1302210124<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public void SimpleDataBase() { 
            this.storedData= new List<T>();
            this.inputDates= new List<DateTime>();
        }

        public void addNewData(T data) { 
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printAllData() {
            for (int i = 0; i < storedData.Count; i++) {
                Console.WriteLine("Data " + i+1 + " berisi: "+ Convert.ToString(storedData[i]+", yang disimpan pada waktu: " + inputDates[i]));
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            
            SimpleDataBase_1302210124<int> data = new SimpleDataBase_1302210124<int>();

            data.addNewData(13);
            data.addNewData(02); 
            data.addNewData(21);

            data.printAllData();
        }
    }
}