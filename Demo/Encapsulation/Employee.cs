using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Attributes
        public int Id;
        private string? EmpName;
        private decimal salary;
        #endregion
        #region Applying Encapsulation using getter setter
        public string? GetName()
        {
            return EmpName;
        }
        public void setName(string? Name)
        {
            EmpName = Name;
        }
        #endregion
        #region Applying Encapsulation using new approach property
        //full property
        public decimal Salary
        {
            get
            {
                return salary;
            } set
            {
                salary = value;
            }
        }
        //Automatic property
        public int Age { get; set; }
        public decimal Deduction
        {
            get
            {
                return salary * 0.1M;
            }
        }
        //Code snippets
        //prop
        public int MyProperty { get; set; }
        //propfull
        private int myVar;

        public int MyVar
        {
            get { return myVar; }
            set { myVar = value; }
        }

        #endregion

        #region Constructor
        public Employee(int id, string? empName, decimal salary)
        {
            Id = id;
            EmpName = empName;
            this.salary = salary;
        }
        #endregion
        #region Method
        public override string ToString()
        {
            return $"Id={Id}\nName={EmpName}\nSalary={salary:c}";
        }
        #endregion
    }
}
