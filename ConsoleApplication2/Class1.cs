using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Employee
    {

        private string empName;
        private int empID;
        private float currPay;

        public Employee() { }
        public Employee(string name, int id, float pay)
        {
            Name = name;
            ID = id;
            Pay = pay;

        }

        public Employee (int id , float pay)
        {
            Name = "unknown";
            ID = id;
            Pay = pay; 
        }

        public Employee (string name, float pay)
        {
            Name = name;
            ID = newID();
            Pay = pay;
        }
        public Employee (string name, int id)
        {
            Name = name;
            ID = id;
            Pay = 1800;
        }
        public string Name
        {
            get
            {
                return empName;
            }

            set
            {
                empName = value;
            }

        }
        public int ID
        {
            get
            {
                return empID;
            }

            set
            {
                empID = value;
            }
        }
        public float Pay
        {
            get
            {
                return currPay;
            }
            set
            {
                currPay = value;
            }
        }

        //funkcja 
        public int newID()
        {
        Random x = new Random();

        int id = x.Next(1, 1000);
            return id;
        } 
        public void ShowStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID:{0}", ID);
            Console.WriteLine("Payment: {0}", Pay);
        }
    }

}


