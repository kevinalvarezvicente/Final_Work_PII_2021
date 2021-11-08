using System;

namespace Library
{
    public class Entrepreneur_Qual : IQualification
    {
        string place;
        string regulatoryEntity;
        DateTime creationDate;
        DateTime expirationDate;

        public int idQualification { get; private set; }

        public string nameQualification { get; private set; }

       public Entrepreneur_Qual(string place, string regulatoryEntity, DateTime creationDate, DateTime expirationDate)
        {
        }


    }
}