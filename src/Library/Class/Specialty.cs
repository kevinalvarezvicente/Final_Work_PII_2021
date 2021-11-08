using System;

namespace Library
{
    public class Specialty
    {
        public Specialty(string nameSpecialty, string place, DateTime obtainingDate, string university)
        {
            this.nameSpecialty = nameSpecialty;
            this.place = place;
            this.obtainingDate = obtainingDate;
            this.university = university;
        }

        public string nameSpecialty { get; private set; }
        public string place { get; private set; }
        public DateTime obtainingDate { get; private set; }
        public string university { get; private set; }
    }
}