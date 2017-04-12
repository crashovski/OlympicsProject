using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Olympic_Project
{
    class Olympics
    {
        DataAccessLayer dl = new DataAccessLayer();
        private int year, countryID;
        private string startDate, endDate, city;
        private string countryName, dates;
        private int noOfAthletes, noOfCountries, noOfEvents;
        public Olympics()
        {

        }

        public Olympics(int year, int countryID, string start, string end, string city)
        {
            this.year = year;
            this.countryID = countryID;
            startDate = start;
            endDate = end;
            this.city = city;
        }
        public Olympics(string dates, string country, int athlete, int countries, int events)
        {
            this.countryName = country;
            this.dates = dates;
            this.noOfAthletes = athlete;
            this.noOfCountries = countries;
            this.noOfEvents = events;
        }
        public Olympics getAOlympic(int year)
        {
            return dl.getAOlympic(year);
        }
        public Olympics getOlympicDetails(int olympicID)
        {
            return dl.GetOlympicDetails(olympicID);
        }
        public int Year
        {
            get { return year; }
        }
        public int CountryID
        {
            get { return countryID; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public string Dates
        {
            get { return dates; }
            set { dates = value; }
        }
        public string CountryName
        {
            get { return countryName; }
        }
        public int NoOfAthletes
        {
            get { return noOfAthletes; }
            set { noOfAthletes = value; }
        }
        public int NoOfCountries
        {
            get { return noOfCountries; }
            set { noOfCountries = value; }
        }
        public int NoOfEvents
        {
            get { return noOfEvents; }
            set { noOfEvents = value; }
        }
        public int insertOlympics(int year, int countryId, string start, string end, string city, string olympicName)
        {
            return dl.insertOlympics(year, countryId, start, end, city, olympicName);
        }
        public bool isProductOf4(int olympicId)
        {
            if (olympicId % 4 == 0)
            {
                return true;
            }
            else
                return false;
        }
        public DataTable getAllOlympics()
        {
            return dl.getAllOlympics();
        }
        public int deleteOlympic(int olympicID)
        {
            return dl.deleteOlympic(olympicID);
        }
        public int updateOlympic(int olympicID, string city)
        {
            string name = city + " " + olympicID;
            return dl.updateOlympics(olympicID, city, name);
        }
    }
}
