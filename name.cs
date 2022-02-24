using System;
using System.Collections.Generic;
using System.Text;

namespace store
{
    class Name
    {
        private string firstName;
        private string lastName;
        private Name() { }
        public Name (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public void printName() {
            Console.WriteLine("my name is " + firstName + " " + lastName);
        }
        public int howLongIsName()
        {
            return firstName.Length + lastName.Length;
        }
    }

}
