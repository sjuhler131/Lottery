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
    public class CostDAL
    {
        public static CostCollection GetCollection()
        {
            CostCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetCost", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new CostCollection();
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

        public static Cost GetItem(int costId)
        {
            Cost tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetCost", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@CostId", costId);

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

        private static Cost FillDataRecord(IDataRecord myDataRecord)
        {
            Cost myObject = new Cost();

            myObject.CostId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("CostId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("GameId")))
                myObject.GameId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("CostAmount")))
                myObject.CostAmount = myDataRecord.GetInt32(myDataRecord.GetOrdinal("CostAmount"));

            return myObject;
        }
    }
}