using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Olympic_Project
{
    class DataAccessLayer
    {
        private string sConn;
        private SqlConnection dbConn;
        private SqlCommand dbCmd;
        private SqlDataAdapter dbAdapter;
        private SqlDataReader dbReader;
        private DataTable dt;
        private DataSet ds;
        private string sql;
        public DataAccessLayer()
        {
            sConn = "Data Source = localhost; Initial Catalog = Olympics;Integrated Security = SSPI";
            dbConn = new SqlConnection(sConn);
            dbConn.Open();
        }

        public Country getACountry(int id) //returns data to the country.cs but it calls the 
        {                             //used to fill textboxes
            string name = "", president = "", email = "";
            int countryId = id;
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetCountry";
            dbCmd.Parameters.AddWithValue("@ID", id);
            dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                name = dbReader["countryName"].ToString();
                president = dbReader["president"].ToString();
                email = dbReader["email"].ToString();
            }
            dbReader.Close();
            Country country = new Country(countryId, name, president, email);
            return country;
        }

        public DataTable getCountry(int id)  //gets name and id of active countries
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Connection = dbConn;
            dbCmd.CommandText = "dbo.usp_GetCountry";
            dbCmd.Parameters.AddWithValue("@ID", id);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getAllCountries()//gets everything about all countries
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.Connection = dbConn;
            dbCmd.CommandText = "Dbo.usp_GetAllCountries";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int insertCountry(string name, string pres, string email, int active)//adds a new country to the database
        {
            if (dbConn.State == ConnectionState.Closed)
                dbConn.Open();

            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "Dbo.usp_InsertCountry";
            dbCmd.Parameters.AddWithValue("@name", name);
            dbCmd.Parameters.AddWithValue("@pres", pres);
            dbCmd.Parameters.AddWithValue("@email", email);
            dbCmd.Parameters.AddWithValue("@active", active);

            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int deleteCountry(int id)//changes the value of active to 0
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "Dbo.usp_DeleteCountry";
            dbCmd.Parameters.AddWithValue("@id", id);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public Byte[] getCountryFlag(int id)  //gets the countries flag
        {                                        //need to cater for null values
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "Dbo.usp_GetCountry";
            dbCmd.Parameters.AddWithValue("@ID", id);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(ds, "Country");
            int c = ds.Tables["Country"].Rows.Count;
            if (c > 0)
            {
                Byte[] byteBLOBData = new Byte[0];
                try
                {
                    byteBLOBData = (Byte[])(ds.Tables["Country"].Rows[c - 1]["flag"]);
                    return byteBLOBData;
                }
                catch (Exception)
                {
                    return null;
                }
                
            }
            else
                return null;
        }

        public DataTable getDeactiveCountries()  //returns country name and surname if the are not active
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetDeactiveCountries";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getActiveCountries()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetActiveCountries";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int updateCountryStatus(int id) //updates the active field to 1
        {
            dt = new DataTable();
            sql = "UPDATE Country SET active = " + 1 + "WHERE countryID = '" + id + "'";
            dbCmd = new SqlCommand(sql, dbConn);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public int updateCountry(int id, string name, string president, string email)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_UpdateCountry";
            dbCmd.Parameters.AddWithValue("@id", id);
            dbCmd.Parameters.AddWithValue("@name", name);
            dbCmd.Parameters.AddWithValue("@president", president);
            dbCmd.Parameters.AddWithValue("@email", email);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable getCountryAthletesinDiscipline(int countryID, int disciplineNo)
        {
            try
            {
                dt = new DataTable();
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_GetCountryAthletesinDiscipline";
                dbCmd.Parameters.AddWithValue("@countryID", countryID);
                dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
                dbAdapter = new SqlDataAdapter(dbCmd);
                dbAdapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable getCountryAthletes(int countryID)
        {
            try
            {
                dt = new DataTable();
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_GetCountryAthletes";
                dbCmd.Parameters.AddWithValue("@countryID", countryID);
                dbAdapter = new SqlDataAdapter(dbCmd);
                dbAdapter.Fill(dt);
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
  
        public Country CountIndividualMedalCountry(int countryID, int olympicID, string medal)
        {
            //asks for countryID, olympicID and medal G, S, B and returns how many particular medals were won
            Int32 count = 0;
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_CountIndividualMedalinCountry";
            dbCmd.Parameters.AddWithValue("@countryID", countryID);
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            dbCmd.Parameters.AddWithValue("@medal", medal);
            count = (Int32)dbCmd.ExecuteScalar();//returns the noOfMedals that were counted in the sql
            Country country = new Country(count);
            return country;
        }
        public Country CountTeamMedalCountry(int countryID, int olympicID, string medal)
        {
            //asks for countryID, olympicID and medal G, S, B and returns how many particular medals were won
            int count = 0, noOfMedals = 0;
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_CountTeamMedalinCountry";
            dbCmd.Parameters.AddWithValue("@countryID", countryID);
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            dbCmd.Parameters.AddWithValue("@medal", medal);
            dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                noOfMedals = int.Parse(dbReader["noOfMedals"].ToString());
                count++;
            }
            dbReader.Close();
            Country country = new Country(count);
            return country;
        }

        //things to do with Discipline Table and form
        public int insertDiscipline(string disciplineName, Byte[] logo, int active)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_insertDiscipline";
            dbCmd.Parameters.AddWithValue("@disciplineName", disciplineName);
            dbCmd.Parameters.AddWithValue("@active", active);
            dbCmd.Parameters.AddWithValue("@logo", logo);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable getAllDisciplines()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_getAllDisciplines";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public Discipline getADiscipline(int no) 
        {
            string name = "";
            int active = 0;
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_getDiscipline";
            dbCmd.Parameters.AddWithValue("@disciplineNo", no);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(ds, "Discipline");
            int d = ds.Tables["Discipline"].Rows.Count;
            if (d > 0)                                                  //problem is when the value is null for logo
            {
                name = (ds.Tables["Discipline"].Rows[d - 1]["disciplineName"]).ToString();
                active = int.Parse((ds.Tables["Discipline"].Rows[d - 1]["disciplineActive"]).ToString());
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])(ds.Tables["Discipline"].Rows[d - 1]["Disciplinelogo"]);
                Discipline discipline = new Discipline(no, name, byteBLOBData, active);
                return discipline;
            }
            else
                return null;
        }

        public int updateDiscipline(int no, string name, Byte[] logo, int active)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_UpdateDiscipline";
            dbCmd.Parameters.AddWithValue("@disciplineNo", no);
            dbCmd.Parameters.AddWithValue("@disciplineName", name);
            dbCmd.Parameters.AddWithValue("@logo", logo);
            dbCmd.Parameters.AddWithValue("@active", active);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable getCountryDiscipline(int countryID)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetCountryDiscipline";
            dbCmd.Parameters.AddWithValue("@countryID", countryID);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getGenderOlympicEventsinDiscipline(int disciplineNo, int year, string gender)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetGenderOlympicEventsinDiscipline";
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbCmd.Parameters.AddWithValue("@year", year);
            dbCmd.Parameters.AddWithValue("@gender", gender);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getDeactiveDisciplines()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetDeactiveDisciplines";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int updateDisciplineStatus(int disciplineNo)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_UpdateDisciplineStatus";
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable getDisciplineAthletes(int disciplineNo)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetDisciplineAthletes";
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int deleteDiscipline(int disciplineNo)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_DeleteDiscipline";
                dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (SqlException)
            {
                return -1;
            }
        }

        //Athlete forms
        public int insertAthlete(int countryId, int disciplineNo, string name,
            string surname, string gender, string dob)//include date and maybe avatar
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_InsertAthlete";
            dbCmd.Parameters.AddWithValue("@countryID", countryId);
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbCmd.Parameters.AddWithValue("@firstName", name);
            dbCmd.Parameters.AddWithValue("@surname", surname);
            dbCmd.Parameters.AddWithValue("@gender", gender);
            dbCmd.Parameters.AddWithValue("@dob", dob);
            // dbCmd.Parameters.AddWithValue("@avatar", null);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable getAllAthletes()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_getAllAthletes";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public Athlete getAAthlete(int athleteNo)
        {
            string name = "", surname = "", dob = "";
            int country = 0;
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_getAthlete";
            dbCmd.Parameters.AddWithValue("@no", athleteNo);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(ds, "Athlete");
            int a = ds.Tables["Athlete"].Rows.Count;
            if (a > 0)
            {
                name = (ds.Tables["Athlete"].Rows[a - 1]["firstName"]).ToString();
                surname = (ds.Tables["Athlete"].Rows[a - 1]["surname"]).ToString();
                country = int.Parse((ds.Tables["Athlete"].Rows[a - 1]["countryID"]).ToString());
                dob = (ds.Tables["Athlete"].Rows[a - 1]["DOB"]).ToString();
                Athlete athlete = new Athlete(athleteNo, country, name, surname, dob);
                return athlete;
            }
            else
                return null;

        }

        public int updateAthlete(int athleteNo, int countryId, string name, string surname)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_updateAthlete";
            dbCmd.Parameters.AddWithValue("@athleteNo", athleteNo);
            dbCmd.Parameters.AddWithValue("@countryID", countryId);
            dbCmd.Parameters.AddWithValue("@firstName", name);
            dbCmd.Parameters.AddWithValue("@surname", surname);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public Athlete searchAthlete(string name, string surname)
        {
            string dob = "", gender = " ";
            int country = 0, athleteNo = 0, disciplineNo = 0;
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_SearchAthlete";
            dbCmd.Parameters.AddWithValue("@firstName", name);
            dbCmd.Parameters.AddWithValue("@lastName", surname);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(ds, "Athlete");
            int a = ds.Tables["Athlete"].Rows.Count;
            if (a > 0)
            {
                athleteNo = int.Parse((ds.Tables["Athlete"].Rows[a - 1]["athleteNo"]).ToString());
                name = (ds.Tables["Athlete"].Rows[a - 1]["firstName"]).ToString();
                surname = (ds.Tables["Athlete"].Rows[a - 1]["surname"]).ToString();
                country = int.Parse((ds.Tables["Athlete"].Rows[a - 1]["countryID"]).ToString());
                disciplineNo = int.Parse((ds.Tables["Athlete"].Rows[a - 1]["disciplineNo"]).ToString());
                dob = (ds.Tables["Athlete"].Rows[a - 1]["DOB"]).ToString();
                gender = (ds.Tables["Athlete"].Rows[a - 1]["gender"]).ToString();
                Athlete athlete = new Athlete(athleteNo, country, name, surname, dob, disciplineNo, gender);
                return athlete;
            }
            else
                return null;
        }

        public int insertEventAthlete(int athleteNo, int eventNo, int year, string pb)
        {
            try
            {
                dbCmd = new SqlCommand(); //must cater for if the ahtlete is already registered
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_InsertEventAthlete";
                dbCmd.Parameters.AddWithValue("@athleteNo", athleteNo);
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbCmd.Parameters.AddWithValue("@year", year);
                dbCmd.Parameters.AddWithValue("@personalBest", pb);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return -1;
            }
        }

        public DataTable getEventAthletes(int olympicID, int eventID)
        {
                dt = new DataTable();
                dbCmd = new SqlCommand(); 
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_GetEventAthletes";
                dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
                dbCmd.Parameters.AddWithValue("@eventID", eventID);
                dbAdapter = new SqlDataAdapter(dbCmd);
                dbAdapter.Fill(dt);
                return dt; 
        }
        public DataTable getIndividualEventAthletes(int olympicID, int eventNo)
        {
            try
            {
                dt = new DataTable();
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_GetIndividualEventAthletes";
                dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbAdapter = new SqlDataAdapter(dbCmd);
                dbAdapter.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public DataTable getTeamMembers(int olympicID, int eventNo, int countryID)
        {
            try
            {
                dt = new DataTable();
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_GetTeamMembers";
                dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbCmd.Parameters.AddWithValue("@countryID", countryID);
                dbAdapter = new SqlDataAdapter(dbCmd);
                dbAdapter.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                return null;
            }
        }

        public int deleteAthlete(int athleteNo)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_DeleteAthlete";
            dbCmd.Parameters.AddWithValue("@athleteNo", athleteNo);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        //Event form
        public int insertEvent(int disciplineNo, string eventName, string eventType, string gender, string or, string wr)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_InsertEvent";
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbCmd.Parameters.AddWithValue("@eventName", eventName);
            dbCmd.Parameters.AddWithValue("@eventType", eventType);
            dbCmd.Parameters.AddWithValue("@gender", gender);
            dbCmd.Parameters.AddWithValue("@OR", or);
            dbCmd.Parameters.AddWithValue("@WR", wr);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

        public DataTable getAllEvents()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetAllEvents";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getEventsinDiscipline(int disciplineNo)//gets all events in dicipline
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetEventsinDiscipline";
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int insertOlympicEvent(int eventNo, int year, string date, string time)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_InsertOlympicEvent";
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbCmd.Parameters.AddWithValue("@year", year);
                dbCmd.Parameters.AddWithValue("@date", date);
                dbCmd.Parameters.AddWithValue("@time", time);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return -1;
            }
        }

        public DataTable getOlympicEvents()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetOlympicEvents";
            dbCmd.Parameters.AddWithValue("@olympicID", 2016);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getOlympicEventsinDiscipline(int year, int disciplineNo)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetOlympicEventsinDiscipline";
            dbCmd.Parameters.AddWithValue("@olympicID", year);
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public DataTable getEventTypeinDiscipline(int olympicID, int disciplineNo, string eventType)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetEventTypeinDiscipline";
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            dbCmd.Parameters.AddWithValue("@disciplineNo", disciplineNo);
            dbCmd.Parameters.AddWithValue("@eventType", eventType);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int deleteEvent(int eventNo)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_DeleteEvent";
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public int updateEvent(int eventNo, string OR, string WR)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_UpdateEvent";
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbCmd.Parameters.AddWithValue("@OR", OR);
                dbCmd.Parameters.AddWithValue("@WR", WR);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public DataTable getEventbyDates(string startDate, string endDate)
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetEventDates";
            dbCmd.Parameters.AddWithValue("@startDate", startDate);
            dbCmd.Parameters.AddWithValue("@endDate", endDate);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public int deleteEventAthlete(int eventNo, int olympicID)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_DeleteEvent_Athlete";
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        //Olympics form
        public int insertOlympics(int year, int countryId, string start, string end, string city, string olympicName)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_InsertOlympics";
                dbCmd.Parameters.AddWithValue("@countryId", countryId);
                dbCmd.Parameters.AddWithValue("@olympicID", year);
                dbCmd.Parameters.AddWithValue("@startDate", start);
                dbCmd.Parameters.AddWithValue("@endDate", end);
                dbCmd.Parameters.AddWithValue("@city", city);
                dbCmd.Parameters.AddWithValue("@olympicName", olympicName);
                int x = dbCmd.ExecuteNonQuery();
                insertOlympicCountry(year, countryId);
                return x;           
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return -1;
            } 
        }

        public void insertOlympicCountry(int year, int countryID)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_InsertOlympicCountry";
                dbCmd.Parameters.AddWithValue("@countryId", countryID);
                dbCmd.Parameters.AddWithValue("@olympicID", year);
                int x = dbCmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                
            }
        }

        public DataTable getAllOlympics()
        {
            dt = new DataTable();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetAllOlympics";
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(dt);
            return dt;
        }

        public Olympics getAOlympic(int year)
        {
            int countryID;
            string city, start, end;
            DataSet ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetOlympic";
            dbCmd.Parameters.AddWithValue("@year", year);
            dbAdapter = new SqlDataAdapter(dbCmd);
            dbAdapter.Fill(ds, "Olympic");
            int o = ds.Tables["Olympic"].Rows.Count;
            if (o > 0)
            {
                countryID = int.Parse((ds.Tables["Olympic"].Rows[o - 1]["countryID"]).ToString());
                city = (ds.Tables["Olympic"].Rows[o - 1]["city"]).ToString();
                start = (ds.Tables["Olympic"].Rows[o - 1]["startDate"]).ToString();
                end = (ds.Tables["Olympic"].Rows[o - 1]["endDate"]).ToString();
                Olympics olym = new Olympics(year, countryID, start, end, city);
                return olym;
            }
            else
                return null;
        }

        public int deleteOlympic(int olympicID)
        {
           try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_DeleteOlympic";
                dbCmd.Parameters.AddWithValue("@year", olympicID);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                return -1;
            }
        }

        public Olympics GetOlympicDetails(int olympicID)
        {
            int athlete = CountAthletes(olympicID);
            int countries = CountCountries();
            int events = CountEvents(olympicID);
            string name = getHostCountry(olympicID);
            Olympics olympic = new Olympics("2016", name, athlete, countries, events);
            return olympic;
        }
        public int CountAthletes(int olympicID)//returns the number of athletes in one olympic games and returns it to method
        {
            Int32 count = 0;
            ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_CountAthletesinOlympics";
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            count = (Int32)dbCmd.ExecuteScalar();
            return count;
        }
        public int CountCountries()//returns the number of countries in one olympic games and returns it to method
        {
            Int32 count = 0;
            ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_CountCountriesinOlympics";
            count = (Int32)dbCmd.ExecuteScalar();
            return count;
        }
        public int CountEvents(int olympicID)//returns the number of countries in one olympic games and returns it to method
        {
            Int32 count = 0;
            ds = new DataSet();
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_CountEventsinOlympics";
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            count = (Int32)dbCmd.ExecuteScalar();
            return count;
        }
        public string getHostCountry(int olympicID)//gets the name of the hosting country
        {
            string name = "ERROR";
            sql = "SELECT countryName FROM Country, Olympic_Country WHERE Olympic_Country.olympicID =" + olympicID + " AND Country.countryID = Olympic_Country.countryID";
            dbCmd = new SqlCommand(sql, dbConn);
            dbReader = dbCmd.ExecuteReader();
            while (dbReader.Read())
            {
                name = dbReader["countryName"].ToString();
            }
            return name;
        }
        public int updateOlympics(int olympicID, string city, string name)
        {           
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_UpdateOlympics";
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            dbCmd.Parameters.AddWithValue("@city", city);
            dbCmd.Parameters.AddWithValue("@olympicName", name);
            int x = dbCmd.ExecuteNonQuery();
            return x;        
        }//updates the olympics

        //Result Form for Medals
        public int updateResults(int athleteNo, int olympicID, int eventNo, string medal, int position, string PB)
        {
            try
            {
                dbCmd = new SqlCommand();
                dbCmd.Connection = dbConn;
                dbCmd.CommandType = CommandType.StoredProcedure;
                dbCmd.CommandText = "dbo.usp_updateResults";
                dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
                dbCmd.Parameters.AddWithValue("@athleteNo", athleteNo);
                dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
                dbCmd.Parameters.AddWithValue("@medal", medal);
                dbCmd.Parameters.AddWithValue("@position", position);
                dbCmd.Parameters.AddWithValue("@PB", PB);
                int x = dbCmd.ExecuteNonQuery();
                return x;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public SqlDataReader getReaderforWinners(int eventNo, int olympicID)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_GetAthletesResultsinEvent";
            dbCmd.Parameters.AddWithValue("@eventNo", eventNo);
            dbCmd.Parameters.AddWithValue("@olympicID", olympicID);
            dbReader = dbCmd.ExecuteReader();
            return dbReader;
        }

        public int deleteMedal(int athleteNo)
        {
            dbCmd = new SqlCommand();
            dbCmd.Connection = dbConn;
            dbCmd.CommandType = CommandType.StoredProcedure;
            dbCmd.CommandText = "dbo.usp_DeleteMedal";
            dbCmd.Parameters.AddWithValue("@athleteNo", athleteNo);
            int x = dbCmd.ExecuteNonQuery();
            return x;
        }

    }

}
