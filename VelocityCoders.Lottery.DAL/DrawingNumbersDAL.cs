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
    public class DrawingNumbersDAL
    {
        public static DrawingNumbersCollection GetCollection()
        {
            DrawingNumbersCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetDrawingNumbers", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new DrawingNumbersCollection();
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

        public static DrawingNumbers GetItem(int drawingNumbersId)
        {
            DrawingNumbers tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetDrawingNumbers", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@DrawingNumbersId", drawingNumbersId);

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

        private static DrawingNumbers FillDataRecord(IDataRecord myDataRecord)
        {
            DrawingNumbers myObject = new DrawingNumbers();

            myObject.DrawingNumbersId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("DrawingNumbersId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("BallTypeId")))
                myObject.BallTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("BallTypeId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("DrawingId")))
                myObject.DrawingId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("DrawingId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Number")))
                myObject.Number = myDataRecord.GetInt32(myDataRecord.GetOrdinal("Number"));

            return myObject;
        }
    }
}