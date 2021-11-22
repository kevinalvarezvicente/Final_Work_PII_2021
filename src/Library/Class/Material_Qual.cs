using System;

namespace Library
{
    public class Material_Qual : IQualification
    {
        string regulatoryEntity;
        DateTime creationDate;
        DateTime expirationDate;
       public Material_Qual(string regulatoryEntity, DateTime creationDate, DateTime expirationDate)
        {
            this.creationDate = creationDate;
            this.regulatoryEntity = regulatoryEntity;
            this.expirationDate = expirationDate;
        }
        public void GetQualification()
        {

        }
    }
}