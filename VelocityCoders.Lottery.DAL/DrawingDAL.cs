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
    public class DrawingDAL
    {
        public static DrawingCollection GetCollection()
        {
            DrawingCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetDrawing", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new DrawingCollection();
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

        public static Drawing GetItem(int drawingId)
        {
            Drawing tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetDrawing", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@DrawingId", drawingId);

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

        private static Drawing FillDataRecord(IDataRecord myDataRecord)
        {
            Drawing myObject = new Drawing();

            myObject.DrawingId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("DrawingId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("GameId")))
                myObject.GameId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("DrawingDate")))
                myObject.DrawingDate = myDataRecord.GetDateTime(myDataRecord.GetOrdinal("DrawingDate"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Jackpot")))
                myObject.Jackpot = myDataRecord.GetString(myDataRecord.GetOrdinal("Jackpot"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Multiplier")))
                myObject.Multiplier = myDataRecord.GetString(myDataRecord.GetOrdinal("Multiplier"));

            return myObject;
        }
    }
}