﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concreate;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        List<Person> GetList();

        bool CheckPerson(Person person);
        

    }
}
