using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using VelocityCoders.Lottery.Models;
using VelocityCoders.Lottery.Models.Collections;
using VelocityCoders.Lottery.Models.Enums;

namespace VelocityCoders.Lottery.DAL
{
    public class GameDAL
    {
        public static GameCollection GetCollection()
        {
            GameCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetGame", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new GameCollection();
                            while (myReader.Read())
                            {
                                tempList.Add(FillDataRecord(myReader));
                            }
                        }
                        myReader.Close();
                    }
                }
            }
            return tempList;
        }

        public static Game GetItem(int gameId)
        {
            Game tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetGame", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@GameId", gameId);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.Read())
                        {
                            tempItem = FillDataRecord(myReader);
                        }
                        myReader.Close();
                    }
                }
            }
            return tempItem;
        }

        private static Game FillDataRecord(IDataRecord myDataRecord)
        {
            Game myObject = new Game();

            myObject.GameId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("GameName")))
                myObject.GameName = myDataRecord.GetString(myDataRecord.GetOrdinal("GameName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Description")))
                myObject.Description = myDataRecord.GetString(myDataRecord.GetOrdinal("Description"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("HowToPlay")))
                myObject.HowToPlay = myDataRecord.GetString(myDataRecord.GetOrdinal("HowToPlay"));

            return myObject;
        }
    }
}