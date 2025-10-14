// File: SalaryEmployee.cs

using System;

namespace employee_demo
{
    public class SalaryEmployee : Employee
    {
        private float _salary = 0;

        public float GetSalary()
        {
            return _salary;
        }

        public void SetSalary(float salary)
        {
            _salary = salary;
        }

        // Override the abstract method from the base class
        public override float GetPay()
        {
            return _salary / 12;
        }
    }
}