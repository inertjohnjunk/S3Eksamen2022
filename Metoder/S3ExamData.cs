using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Metoder
{
    class S3ExamData
    {
        /*S3Eksamen2022Entities db = new S3Eksamen2022Entities();
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

        #region CRUD
        #region Agents
        public void AddAgent(string givenName, string familyName, int age, Byte[] image)
        {
            Agents agent = new Agents()
            {
                Name = name
            };
            db.Teams.Add(team);
            db.SaveChanges();
        }
        public void DeleteTeam(Teams team)
        {
            db.Teams.Remove(team);
            db.SaveChanges();
        }

        public void UpdateTeam(Teams team)
        {
            using (var db = new FormelITDB1Entities())
            {
                var result = db.Teams.SingleOrDefault(b => b.Id == team.Id);
                if (result != null)
                {
                    result = team;
                    db.SaveChanges();
                }
            }
        }
        #endregion

        #endregion
        */
    }
}
