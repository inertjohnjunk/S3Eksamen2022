using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using S3Eksamen2022.Model;

namespace Metoder
{
    class Methods
    {
        S3Eksamen2022Entities db = new S3Eksamen2022Entities();


        //Establish connection and viewability of table-contents
        #region Collections
        public ObservableCollection<Agents> AgentList
        {
            get
            {
                ObservableCollection<Agents> agents = new ObservableCollection<Agents>(db.Agents.SqlQuery("SELECT * FROM Agents").ToList<Agents>());
                return agents;
            }
        }
        public ObservableCollection<Informants> InforList
        {
            get
            {
                ObservableCollection<Informants> informants = new ObservableCollection<Informants>(db.Informants.SqlQuery("SELECT * FROM Informants").ToList<Informants>());
                return informants;
            }
        }
        public ObservableCollection<Targets> TargetList
        {
            get
            {
                ObservableCollection<Targets> targets = new ObservableCollection<Targets>(db.Targets.SqlQuery("SELECT* FROM Targets").ToList<Targets>());
                return targets;
            }
        }
        #endregion

        #region CRUD (Create Read Update Delete)

        #region Persons
        #region Agents
        public void AddAgent(string givenName, string familyName, int age, string nationality, string hairColor, string eyeColor, float height, DateTime dateOfBirth)
        {
            Agents agent = new Agents()
            {
                GivenName = givenName,
                FamilyName = familyName,
                Age = age,
                Nationality = nationality,
                HairColor = hairColor,
                EyeColor = eyeColor,
                Height = height,
                DateOfBirth = dateOfBirth
            };
            db.Agents.Add(agent);
            db.SaveChanges();
        }

        public void UpdateAgent(Agents agent)
        {
            using (var db = new S3Eksamen2022Entities())
            {
                var result = db.Agents.SingleOrDefault(b => b.Id == agent.Id);
                if (result != null)
                {
                    result = agent;
                    db.SaveChanges();
                }
            }
        }
        public void DeleteAgent(Agents agent)
        {
            db.Agents.Remove(agent);
            db.SaveChanges();
        }
        #endregion

        #region Informants
        public void AddInformant(string givenName, string familyName, int age/*, etc...*/)
        {
            Informants informant = new Informants()
            {
                GivenName = givenName
                
            };
            db.Informants.Add(informant);
            db.SaveChanges();
        }
        public void DeleteInformant(Informants informant)
        {
            db.Informants.Remove(informant);
            db.SaveChanges();
        }

        public void UpdateInformant(Informants informant)
        {
            using (var db = new S3Eksamen2022Entities())
            {
                var result = db.Informants.SingleOrDefault(b => b.Id == informant.Id);
                if (result != null)
                {
                    result = informant;
                    db.SaveChanges();
                }
            }
        }
        #endregion

        #region Targets(Observants)
        public void AddTarget(string givenName, string familyName, int age, string nationality, string hairColor, string eyeColor, float height, DateTime dateOfBirth)
        {
            Targets target = new Targets()
            {
                GivenName = givenName,
                FamilyName = familyName,
                Age = age,
                Nationality = nationality,
                HairColor = hairColor,
                EyeColor = eyeColor,
                Height = height,
                DateOfBirth = dateOfBirth

            };
            db.Targets.Add(target);
            db.SaveChanges();
        }
        public void DeleteTargets(Targets target)
        {
            db.Targets.Remove(target);
            db.SaveChanges();
        }

        public void UpdateTargets(Targets target)
        {
            using (var db = new S3Eksamen2022Entities())
            {
                var result = db.Targets.SingleOrDefault(b => b.Id == target.Id);
                if (result != null)
                {
                    result = target;
                    db.SaveChanges();
                }
            }
        }
        #endregion
        #endregion

        #endregion
    }
}
