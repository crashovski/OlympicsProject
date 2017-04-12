using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Olympic_Project
{
    class Athlete
    {
        DataAccessLayer dl;
        private string name, surname, dob, gender;
        int athleteNo, countryID, disciplineNo;
        public Athlete()
        {

        }

        public Athlete(int athleteNo, int countryID, string name, string surname, string dob)
        {
            this.athleteNo = athleteNo;
            this.countryID = countryID;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
        }

        public Athlete(int athleteNo, int countryID, string name, string surname, string dob, int disciplineNo, string gender)
        {
            this.athleteNo = athleteNo;
            this.countryID = countryID;
            this.name = name;
            this.surname = surname;
            this.dob = dob;
            this.disciplineNo = disciplineNo;
            this.gender = gender;
        }
        
        public int AthleteNo
        {
            get { return athleteNo; }        
        }

        public string Gender
        {
            get { return gender; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public int CountryID
        {
            get { return countryID; }
            set { countryID = value; }
        }

        public string Dob
        {
            get { return dob; }
        }

        public int DisciplineNo
        {
            get { return disciplineNo; }
        }

        public Athlete getAAthlete(int athleteNo)
        {
            dl = new DataAccessLayer();
            return dl.getAAthlete(athleteNo);
        }      

        public int insertAthlete(int countryId, int disciplineNo, string name,
            string surname, string gender, string dob)
        {
            dl = new DataAccessLayer();
            return dl.insertAthlete(countryId, disciplineNo, name, surname, gender, dob);
        }

        public DataTable getAllAthletes()
        {
            dl = new DataAccessLayer();
            return dl.getAllAthletes();
        }
        
        public int updateAthlete(int athleteNo, int countryId, string name, string surname)
        {
            dl = new DataAccessLayer();
            return dl.updateAthlete(athleteNo, countryId, name, surname);
        }

       public Athlete searchAthlete(string name, string surname)
        {
            dl = new DataAccessLayer();
            return dl.searchAthlete(name, surname);
        }

        public int insertEventAthlete(int athleteNo, int eventNo, int year, string pb)
        {
            dl = new DataAccessLayer();
            return dl.insertEventAthlete(athleteNo, eventNo, year, pb);
        }

        public DataTable getEventAthletes(int olympicID, int eventID)
        {
            dl = new DataAccessLayer();
            return dl.getEventAthletes(olympicID, eventID);
        }

        public DataTable getIndividualEventAthletes(int olympicID, int eventNo)
        {
            dl = new DataAccessLayer();
            return dl.getIndividualEventAthletes(olympicID, eventNo);
        }

        public DataTable getTeamMembers(int olympicID, int eventNo, int countryID)
        {
            dl = new DataAccessLayer();
            return dl.getTeamMembers(olympicID, eventNo, countryID);
        }

        public int deleteAthlete(int athleteNo)
        {
            dl = new DataAccessLayer();
            return dl.deleteAthlete(athleteNo);
        }
     }
}
