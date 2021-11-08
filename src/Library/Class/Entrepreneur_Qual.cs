using System;


namespace Library
{
    
    public class Entrepreneur_Qual : IQualification
    {
        string place;
        string regulatoryEntity;
        DateTime creationDate;

        DateTime expirationDate;
       public Entrepreneur_Qual(string place, string regulatoryEntity, DateTime creationDate, DateTime expirationDate)
        {
        }

    }
}