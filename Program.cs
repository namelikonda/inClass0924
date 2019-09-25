using System;

namespace inClass0924
{
    class Person

    {

        string lastName;
        string firstName;
        string getName()
        {
            return firstName + " " + lastName;
        }

        public Person()
        {
            firstName = "Niranjan";
            lastName = "Kumar";
        }
        public Person(string lname)
        {
            lastName = lname;
        }

    }

}






