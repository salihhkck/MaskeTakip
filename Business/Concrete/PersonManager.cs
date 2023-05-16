using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager:IApplicantService
    {
        // ENCAPSULATİON : propertyleri yazıp bunları Person nesnesinin içinden çağırmaya denir.
        public void ApplyForMask(Person person) //metot tanımladık. Projede olan operasyonları birçok farklı noktada kullanabiliriz.
            //Sıklıkla kullanabileceğimiz operasyonları böyle metotlar içerisinde tanımlarız.
        {

        }

        public List<Person> GetList() // List<Person> : Person türünde liste döndürecektir.
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear).Result.Body.TCKimlikNoDogrulaResult;
        }
    }


}
