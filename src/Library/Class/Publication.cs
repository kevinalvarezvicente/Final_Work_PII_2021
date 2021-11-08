using System;

namespace Library
{
    public class Publication : IRecyclable
    {
        int idPublication;
        string [] keyWords;
        Material material;

        CompanyUser company;

        DateTime publicationDate;
        bool reciylable;

        public bool IsRecyclable(bool recyclable)
        {
            if (recyclable)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
    }


}