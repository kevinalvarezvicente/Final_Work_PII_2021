using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Library
{
    public class Publication : IJsonConvertible
    {
        [JsonConstructor]
        public Publication()
        {}
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
        public bool GeneratePublication(int idPublication, Material material, Company company, DateTime publicationDate) {
            Publication publication = new Publication(idPublication, material, company, publicationDate);
            
            
            this.ListPublications.Add(publication);
            return true;
        }
        public string ConvertToJson()
        {
            JsonSerializerOptions options = new()
            {
                ReferenceHandler = MyReferenceHandler.Instance,
                WriteIndented = true
            };

            return JsonSerializer.Serialize(this, options);
        }
    }
}