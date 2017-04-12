using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Olympic_Project
{
    class Country
    {
        DataAccessLayer dl = new DataAccessLayer();
        private string name;
        private int id, noOfMedals;
        private string president, email;
        public Country()
        {

        }

        public Country(int id, string name, string president, string email)
        {
            this.name = name;
            this.id = id;
            this.president = president;
            this.email = email;
        }

        public Country(int medalCount)
        {
            noOfMedals = medalCount;
        }

        public Country getACountry(int id)
        {
            //call the DAL COuntry get ()                       
                dl = new DataAccessLayer();
                return dl.getACountry(id);         
        }

        public Country CountIndividualMedalCountry(int countryID, int olympicID, string medal)
        {
            dl = new DataAccessLayer();
            return dl.CountIndividualMedalCountry(countryID, olympicID, medal);
        }

        public Country CountTeamMedalCountry(int countryID, int olympicID, string medal)
        {
            dl = new DataAccessLayer();
            return dl.CountTeamMedalCountry(countryID, olympicID, medal);
        }

        public string President
        {
            get { return president; }
            set { president = value; }
        }//get set method

        public string Email
        {
            get { return email; }
            set { email = value; }
        }//get set method

        public string Name
        {
            get { return name; }
            set { name = value; }
        }//get set method

        public int Id
        {
            get { return id; }
            set { id = value; }
        }//get set method

        public int NoOfMedals
        {
            get { return noOfMedals; }
            set { noOfMedals = value; }
        }//get set method


        public DataTable getCountry(int id)
        {
            return dl.getCountry(id);
        }
        
        public DataTable getDeactiveCountries()
        {
            return dl.getDeactiveCountries();
        }

        public DataTable getActiveCountries()
        {
            return dl.getActiveCountries();
        }
        
        public DataTable getAllCountries()//gets all the countries and thier data except flag
        {
            return dl.getAllCountries();
        }

        public Byte[] getCountryFlag(int id)
        {
            return dl.getCountryFlag(id);
        }

        public int insertCountry(string name, string pres, string email, int active)
        {
            return dl.insertCountry(name, pres, email, active);
        }

        public int deleteCountry(int id)
        {
            return dl.deleteCountry(id);
        }

        public int updateCountryStatus(int id)
        {
            return dl.updateCountryStatus(id);
        }

        public bool isEmpty(string temp)
        {
            if (temp == null || temp == "")  //if the fields are empty or nulls it returns true
            {
                return true;
            }
            else
                return false;
        }

        public int updateCountry(int id, string name, string president, string email)
        {
            return dl.updateCountry(id, name, president, email);
        }

        public DataTable getCountryAthletesinDiscipline(int countryID, int disciplineNo)
        {
            return dl.getCountryAthletesinDiscipline(countryID, disciplineNo);
        }

        public DataTable getCountryAthletes(int countryID)
        {
            return dl.getCountryAthletes(countryID);
        }


    }
}
