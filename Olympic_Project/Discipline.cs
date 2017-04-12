using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Olympic_Project
{
    class Discipline
    {
        DataAccessLayer dl;
        private string  name;
        private int active, disciplineNo;
        private Byte[] logo;
        public Discipline()
        {

        }

        public Discipline(int disciplineNo, string name, Byte[] logo, int active) 
        {
            this.disciplineNo = disciplineNo;
            this.name = name;
            this.active = active;
            this.logo = logo;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int DisciplineNo
        {
            get { return disciplineNo; }
            set { disciplineNo = value; }
        }

        public Byte[] Logo
        {
            get { return logo; }
            set { logo = value; }
        }

        public int Active
        {
            get { return active; }
            set { active = value; }
        }
        
        public Discipline getADiscipline(int no)
        {
            dl = new DataAccessLayer();
            return dl.getADiscipline(no);
        }

        public int insertDiscipline(string disciplineName, Byte[] logo, int active)
        {
            dl = new DataAccessLayer();
            return dl.insertDiscipline(disciplineName, logo, active);
        }

        public DataTable getAllDisciplines()
        {
            dl = new DataAccessLayer();
            return dl.getAllDisciplines();
        }

        public int updateDiscipline(int no, string name, Byte[] logo, int active)
        {
            dl = new DataAccessLayer();
            return dl.updateDiscipline(no, name, logo, active);
        }

        public DataTable getCountryDiscipline(int countryID)
        {
            dl = new DataAccessLayer();
            return dl.getCountryDiscipline(countryID);
        }

        public DataTable getGenderOlympicEventsinDiscipline(int disciplineNo, int year, string gender)
        {
            dl = new DataAccessLayer();
            return dl.getGenderOlympicEventsinDiscipline(disciplineNo, year, gender);
        }

        public DataTable getDeactiveDisciplines()
        {
            dl = new DataAccessLayer();
            return dl.getDeactiveDisciplines();
        }

        public int updateDisciplineStatus(int disciplineNo)
        {
            dl = new DataAccessLayer();
            return dl.updateDisciplineStatus(disciplineNo);
        }

        public DataTable getDisciplineAthletes(int disciplineNo)
        {
            dl = new DataAccessLayer();
            return dl.getDisciplineAthletes(disciplineNo);
        }

        public int deleteDiscipline(int disciplineNo)
        {
            dl = new DataAccessLayer();
            return dl.deleteDiscipline(disciplineNo);
        }
    }
}
