using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concreate;
using MernisServiceReference;

namespace Business.Concreate
{
    public class PersonManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;

        }

        public bool CheckPerson (Person person)
        {
            //mernis kontrolü 
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, Ad: person.FirstName, Soyad: person.LastName, DogumYili: person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
        



    }
}
