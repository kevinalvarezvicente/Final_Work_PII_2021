using System;
using System.Collections.Generic;
using Date;

namespace Library
{
    public class Publication
    {
        public List<Publication> Publications = new List<Publication>();
        public int IdPublication { get; set; }

        public List<string> KeyWords = new List<string>();

        public Material Material { get; set; }

        public Company Company { get; set; }

        public DateTime PublicationDate { get; set; }

        public Publication(int idPublication, Material material, Company company, DateTime publicationDate){
            this.IdPublication = idPublication;
            this.Material = material;
            this.Company = company;
            this.PublicationDate = publicationDate;
        }

        public string generatePublication(int idPublication, Material material, Company company, DateTime publicationDate) {
            Publication publication = new Publication(idPublication, material, company, publicationDate);
            token1.idToken = id;
            token1.numberToken = token1.generateToken();
            this.ListToken.Add(token1);
            return token1;
        }
    }
}