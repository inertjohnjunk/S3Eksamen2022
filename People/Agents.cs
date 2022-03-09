using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    class Agents : Person
    {
        private int clearance;

        //Constructor
        public Agents(string newGivenName, string newFamilyName, int newAge, string newNationality, string newHairColor, string newEyeColor, double newHeight, int newClearance) : base (newGivenName, newFamilyName, newAge, newNationality, newHairColor, newEyeColor, newHeight)
        {
            SetClearance(newClearance);
        }

        //Accessors

        public void SetClearance(int newClearance) { clearance = newClearance; }


    }
}
