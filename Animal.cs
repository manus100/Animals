using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    enum Gender
    {
        Male,
        Female
    }
  abstract  class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal (string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || value < 0)              
                    throw new ArgumentException("Invalid input!");
                else
                    age = value;
            }
        }

        public string Gender
        {
            get => gender;
            set
            {
                if (string.IsNullOrEmpty(value.ToString()) || !Enum.IsDefined(typeof(Gender), value))
                    throw new ArgumentException("Invalid input!");
                else
                    gender = value;
            }
        }

        public abstract string ProduceSound();

    }
}
