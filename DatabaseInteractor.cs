using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using IO_Project.Core;
using IO_Project.ParticipantInteraction;
using IO_Project.JourneyInteraction;
using IO_Project.StageInteraction;
using System.Linq;

namespace IO_Project
{
    class DatabaseInteractor
    {
        private SqlConnection connection;

        public DatabaseInteractor(SqlConnection connection)
        {
            this.connection = connection;
        }

        public Journal LoadJournal()
        {
            Journal journal = new Journal(getJourneys(), getParticipants());

            return journal;
        }



        public List<Participant> getParticipants()
        {
            List<Participant> participantsList = new List<Participant>();
            connection.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT firstName, surname FROM Participant", connection);
            SqlDataReader myreader;

            myreader = SelectCommand.ExecuteReader();

            while (myreader.Read())
            {
                Participant p = new Participant(myreader["firstName"].ToString() + " " + myreader["surname"].ToString());
                participantsList.Add(p);
            }
            connection.Close();
            return participantsList;
        }

        public List<Journey> getJourneys()
        {
            
            Dictionary<string, Journey> journeysList = new Dictionary<string, Journey>();
            connection.Open();
            SqlCommand SelectCommand = new SqlCommand("SELECT * FROM Trip", connection);
            SqlDataReader myreader;

            myreader = SelectCommand.ExecuteReader();


            while (myreader.Read())
            {
                Journey j = new Journey(myreader["name"].ToString(), myreader["description"].ToString(), myreader["startDate"].ToString());
                journeysList.Add(myreader["Id"].ToString(), j);
            }
            myreader.Close();

            foreach (var element in journeysList)
            {
                element.Value.AddStages(StagesByJourneyId(element.Key));
                element.Value.AssignParticipants(ParticipantsByJoerneyId(element.Key));
            }

            connection.Close();
            return journeysList.Values.ToList();
        }
        private List<Participant> ParticipantsByJoerneyId(string journeyId)
        {
            List<Participant> paricipantList = new List<Participant>();
            SqlCommand SelectCommand = new SqlCommand(
                "SELECT * FROM Participant " +
                "WHERE Trip = '" + journeyId + "'", connection);

            SqlDataReader myreader;
            myreader = SelectCommand.ExecuteReader();
            while (myreader.Read())
            {
                Participant p = new Participant(myreader["firstName"].ToString() + " " + myreader["surname"].ToString());
                paricipantList.Add(p);
            }
            myreader.Close();
            return paricipantList;
        }
        private List<Stage> StagesByJourneyId(string journeyId)
        {
            List<Stage> journeysList = new List<Stage>();
            SqlCommand SelectCommand = new SqlCommand(
                "SELECT * FROM Stage " +
                "WHERE Trip = '" + journeyId + "'", connection);

            SqlDataReader myreader;
            myreader = SelectCommand.ExecuteReader();
            while (myreader.Read())
            {
                Stage j = new Stage(myreader["Title"].ToString(), myreader["description"].ToString(), myreader["iconPath"].ToString());
                journeysList.Add(j);
            }
            myreader.Close();
            return journeysList;


        }
    }
}
