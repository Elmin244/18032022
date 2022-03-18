using System;
using System.Collections.Generic;
using System.Text;

namespace _18032022
{
    class Employee:Deparment
    {
        
        private string _name;
        private string _surname;
        private int _salary;
        public Employee[] employes = new Employee[0];
        public int Salary
        {
            get => this._salary;
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
            }
        }
        public string Name
        {
            get => this._name;
            set
            {
                if (CheckMethod(value))
                {
                    _name = value;
                }
            }
        }
        public string Surname
        {
            get => this._surname;
            set
            {
                if (CheckMethod(value))
                {
                    _surname = value;
                }
            }
        }
        public bool CheckMethod(string str)
        {
            if (!string.IsNullOrWhiteSpace(str) && char.IsUpper(str[0]))
            {
                for (int i = 1; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                        return false;

                }
                return true;
            }
            return false; 
        }
        public void AddStudent(Employee employee)
        {
            if (this.employes.Length<this.EmployeeLimit)
            {
                Array.Resize(ref this.employes, this.employes.Length + 1);
                this.employes[this.employes.Length - 1] = employee;
            }
            else
            {
                throw new Exception("Limiti heddini kecdinizz!!!");
            }
        }
                
    }
}
