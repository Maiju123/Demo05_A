using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class PersonRegister
    {
        /// <summary>
        /// Persons list stores person objects....
        /// </summary>
        private List<Person> persons;

        /// <summary>
        ///Default constructor initializes a collection
        /// </summary>
        public PersonRegister()
        {
            persons = new List<Person>();
        }
        /// <summary>
        ///Adds a new person to collection
        /// </summary>
        /// <param name="person">person to add</param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        /// <summary>
        ///Returns a person to caller application 
        /// </summary>
        /// <param name="index">person index in collection</param>
        /// <returns> person object</returns> 

        public Person GetPerson(int index)
        {
            /*
             
            index = 0 1 2 3
            persons = p1 p2 p3 ?
            persons.Count = 3
            
            */

            if (index < persons.Count)
            {
                return persons.ElementAt(index);
            }
            else
            {
                return null;
            }
        }

        public Person FindPerson(string socialSecurityNumber)
        {
            foreach (Person person in persons)
            {
                // is sotus same....
                if (socialSecurityNumber.Equals(person.SocialSecurityNumber))
                {
                    return person; // person found with that sotu
                }
            }
            return null; // person with search sotu not found.... 
        }

        public void PrintData()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("* My awesome collection *");
            Console.WriteLine("*************************");
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
