using System;
using DDDServicesLayers.Domain.Entities;
using DDDServicesLayers.Domain.Services;
using DDDServicesLayers.Infra.Messages.MessageServices;

namespace DDDServicesLayers.Application.AppServices
{
    public class PersonAppService
    {
        private readonly Person _person; 
        public PersonAppService(string name)
        {
            _person = new Person(Guid.NewGuid(), name);
        }

        public void Save()
        {
            var personServiceSave = new PersonService(_person);
            personServiceSave.Save();

            if (personServiceSave.Success)
            {
                var emailService = new EmailService("test@mail.com", "Confirm", "Register saved.");
                emailService.Send();
            }
        }
    }
}