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

        public Employee() { };
        public Employee(string name, int ID, float pay )
        {
            
        }


        public string name
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

}
