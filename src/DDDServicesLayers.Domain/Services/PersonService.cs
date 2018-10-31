using System;
using DDDServicesLayers.Domain.Entities;

namespace DDDServicesLayers.Domain.Services
{
    public class PersonService
    {
        public PersonService(Person person)
        {
            Person = person;
        }

        public Person Person { get; private set; }
        public bool Success { get; private set; }

        public void Save()
        {
            // Save person logic
            Success = true;
        }
    }
}