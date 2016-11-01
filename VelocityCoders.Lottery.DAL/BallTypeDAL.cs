using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VelocityCoders.Lottery.Models;
using VelocityCoders.Lottery.Models.Enums;
using VelocityCoders.Lottery.Models.Collections;
using Uhler.Common;

namespace VelocityCoders.Lottery.DAL
{
    public class BallTypeDAL
    {
        public static BallTypeCollection GetCollection()
        {
            BallTypeCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetBallType", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new BallTypeCollection();
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

        public static BallType GetItem(int ballTypeId)
        {
            BallType tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetBallType", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@BallTypeId", ballTypeId);

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

        private static BallType FillDataRecord(IDataRecord myDataRecord)
        {
            BallType myObject = new BallType();

            myObject.BallTypeId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("BallTypeId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("BallTypeName")))
                myObject.BallTypeName = myDataRecord.GetString(myDataRecord.GetOrdinal("BallTypeName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Sequence")))
                myObject.Sequence = myDataRecord.GetInt32(myDataRecord.GetOrdinal("Sequence"));

            return myObject;
        }
    }
}