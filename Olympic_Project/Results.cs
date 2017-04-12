using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Olympic_Project
{
    class Results
    {
        DataAccessLayer dl = new DataAccessLayer();
        private string firstName, surname, medal, countryName;
        private string result; //time or number
        private int position;
        public Results()
        {

        }

        public Results(string rank, string firstname, string surname, string countryName, string result, int position)
        {
            this.firstName = firstname;
            this.surname = surname;
            this.countryName = countryName;
            this.medal = rank;
            this.position = position;
            this.result = result;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public string Medal
        {
            get { return medal; }
            set { medal = value; }
        }

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        public string Result
        {
            get { return result; }
            set { result = value; }
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Name
        {
            get { return firstName + " " + surname; }
        }

        public string DisplayAthlete()
        {
            string ranks = "";
            if (medal == "N")
                ranks = position.ToString();
            else
                ranks = medal;
            return ranks.PadRight(5)  + Name.PadRight(12) + "\t" + countryName.PadRight(5) + "\t" + result.PadRight(4);
        }
        public int updateResults(int athleteNo, int olympicID, int eventNo, string medal, int position, string PB)
        {
            return dl.updateResults(athleteNo, olympicID, eventNo, medal, position, PB);
        }
        public SqlDataReader getReaderforWinners(int eventNo, int olympicID)
        {
            return dl.getReaderforWinners(eventNo, olympicID);
        }
        public int deleteMedal(int athleteNo)
        {
            return dl.deleteMedal(athleteNo);
        }
    }
}
