using System;
using System.Collections.Generic;

namespace Library
{
    public class Publication
    {
        public List<Publication> ListPublications = new List<Publication>();
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

        public bool generatePublication(int idPublication, Material material, Company company, DateTime publicationDate) {
            Publication publication = new Publication(idPublication, material, company, publicationDate);
            this.ListPublications.Add(publication);
            return true;
        }
    }
}