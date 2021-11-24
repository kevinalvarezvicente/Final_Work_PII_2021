using System;
using System.Collections.Generic;

namespace Library
{
    public class Entrepreneur
    {
        public string EntrepreneurName { get; private set; }
        public string EntrepreneurSector { get; private set; }

        List<Agreement> listAgreement;
        List<Specialty> specialty;
        List<Entrepreneur_Qual> qualification;

        public Entrepreneur(string EntrepreneurName, string EntrepreneurSector, List<Entrepreneur_Qual> qualification, List<Specialty> specialty)
        {
            this.EntrepreneurName = EntrepreneurName;
            this.EntrepreneurSector = EntrepreneurSector;
            this.qualification = qualification;
            this.specialty = specialty;

        }
    }
}