using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        public void GiveMask(Person person)
        {
            PersonManager personmanager = new PersonManager();

            if (personmanager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi.");
            }
        }
    }
}
