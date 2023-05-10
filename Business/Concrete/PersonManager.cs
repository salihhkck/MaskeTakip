using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService
    {
        // ENCAPSULATİON : propertyleri yazıp bunları Person nesnesinin içinden çağırmaya denir.
        public void ApplyForMask(Person person) //metot tanımladık. Projede olan operasyonları birçok farklı noktada kullanabiliriz.
            //Sıklıkla kullanabileceğimiz operasyonları böyle metotlar içerisinde tanımlarız.
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            return true;
        }
    }


}
