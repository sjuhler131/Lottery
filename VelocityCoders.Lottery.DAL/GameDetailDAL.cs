using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VelocityCoders.Lottery.Models;
using VelocityCoders.Lottery.Models.Collections;
using VelocityCoders.Lottery.Models.Enums;

namespace VelocityCoders.Lottery.DAL
{
    public class GameDetailDAL
    {
        public static GameDetailCollection GetCollection()
        {
            GameDetailCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetGameDetail", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new GameDetailCollection();
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

        public static GameDetail GetItem(int gameDetailId)
        {
            GameDetail tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetGameDetail", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@GameDetailId", gameDetailId);

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

        private static GameDetail FillDataRecord(IDataRecord myDataRecord)
        {
            GameDetail myObject = new GameDetail();

            myObject.GameDetailId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameDetailId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("GameId")))
                myObject.GameId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Match")))
                myObject.Match = myDataRecord.GetString(myDataRecord.GetOrdinal("Match"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Odds")))
                myObject.Odds = myDataRecord.GetString(myDataRecord.GetOrdinal("Odds"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Prize")))
                myObject.Prize = myDataRecord.GetString(myDataRecord.GetOrdinal("Prize"));

            return myObject;
        }
    }
}