using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Olympic_Project
{
    class Event
    {
        DataAccessLayer dl;
        private string  eventName, eventType, gender;// gender -F/M eventType - T/I
        int eventNo, disciplineNo;
        private decimal oR, wR;
        public Event()
        {

        }

        public Event(int eventNo, int disciplineNo, string eventName, string eventType, string gender, decimal or, decimal wr)
        {
            this.eventNo = eventNo;
            this.disciplineNo = disciplineNo;
            this.eventName = eventName;
            this.eventType = eventType;
            this.gender = gender;
            oR = or;
            wR = wr;
        }

        public int EventNo
        {
            get {return eventNo; }
        }
        public int DisciplineNo
        {
            get { return disciplineNo; }
        }
        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }
        public string EventType
        {
            get { return eventType; }
        }
        public string Gender
        {
            get { return gender; }
        }
        public decimal OR
        {
            get { return oR; }
            set { oR = value; }
        }
        public decimal WR
        {
            get { return wR; }
            set { wR = value; }
        }

        public int insertEvent(int disciplineNo, string eventName, string eventType, string gender, string or, string wr)
        {
            dl = new DataAccessLayer();
            return dl.insertEvent(disciplineNo, eventName, eventType, gender, or, wr);
        }

        public DataTable getAllEvents()
        {
            dl = new DataAccessLayer();
            return dl.getAllEvents();
        }

        public DataTable getEventsinDiscipline(int disciplineNo)
        {
            dl = new DataAccessLayer();
            return dl.getEventsinDiscipline(disciplineNo);
        }

        public int insertOlympicEvent(int eventNo, int year, string date, string time)
        {
            dl = new DataAccessLayer();
            return dl.insertOlympicEvent(eventNo, year, date, time);
        }

        public DataTable getOlympicEvents()
        {
            dl = new DataAccessLayer();
            return dl.getOlympicEvents();
        }

        public DataTable getOlympicEventsinDiscipline(int year, int disciplineNo)//gets the registered events in a discipline in a particular olympic games
        {
            dl = new DataAccessLayer();
            return dl.getOlympicEventsinDiscipline(year, disciplineNo);
        }

        public DataTable getEventTypeinDiscipline(int olympicID, int disciplineNo, string eventType)//gets the registered events in a discipline in a particular olympic games that is either a team or individual event
        {
            dl = new DataAccessLayer();
            return dl.getEventTypeinDiscipline(olympicID, disciplineNo, eventType);
        }

        public int deleteEvent(int eventNo)
        {
            dl = new DataAccessLayer();
            return dl.deleteEvent(eventNo);
        }

        public int updateEvent(int eventNo, string OR, string WR)
        {
            dl = new DataAccessLayer();
            return dl.updateEvent(eventNo, OR, WR);
        }

        public DataTable getEventbyDates(string startDate, string endDate)
        {
            dl = new DataAccessLayer();
            return dl.getEventbyDates(startDate, endDate);
        }

        public int deleteEventAthlete(int eventNo, int olympicID)
        {
            dl = new DataAccessLayer();
            return dl.deleteEventAthlete(eventNo, olympicID);
        }
    }
}
