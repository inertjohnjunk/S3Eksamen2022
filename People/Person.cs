using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    /// <summary>
    /// Logic intended to facilitate interaction between tables.
    /// Massive fiasco, never managed to make inheritence or table relations work as I intended.
    /// </summary>
    public abstract class Person
    {
        private string givenName;
        private string familyName;
        private int age;
        private string nationality;
        private string hairColor;
        private string eyeColor;
        private double height;
        //Constructor
        public Person(string newGivenName, string newFamilyName, int newAge, string newNationality, string newHairColor, string newEyeColor, double newHeight)
        {

        }
        //Accessors
        public string GetGivenName() { return givenName; }
        public string GetFamilyName() { return familyName; }
        public int GetAge() { return age; }

        public void SetGivenName(string newGivenName) { givenName = newGivenName; }
        public void SetFamilyName(string newFamilyName) { familyName = newFamilyName; }
        public void CalcAge(DateTime newDateOfBirth)
        {
            var today = DateTime.Today;
            age = today.Year - newDateOfBirth.Year;
            if (newDateOfBirth.Date > today.AddYears(-age)) age--;
        }
        public void SetNationality(string newNationality) { nationality = newNationality; }
        


        //Abstract method intended to be used for inheritance when creating or updating child classes.

        /*
        public abstract void Draw();
        */
        
        //No such method was successfully used, and is likely not properly setup, fundamentally hampering any use outside this class.
    }
}
