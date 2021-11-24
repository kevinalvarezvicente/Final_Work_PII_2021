using System;


namespace Library
{
    
    public class Entrepreneur_Qual : IQualification
    {
        string regulatoryEntity;
        DateTime creationDate;
        DateTime expirationDate;
       public Entrepreneur_Qual(string regulatoryEntity, DateTime creationDate, DateTime expirationDate)
        {
            this.creationDate = creationDate;
            this.regulatoryEntity = regulatoryEntity;
            this.expirationDate = expirationDate;
        }
        public void GetQualification(){

        }

    }
}