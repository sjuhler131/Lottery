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
    public class StateDAL
    {
        public static StateCollection GetCollection()
        {
            StateCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetState", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new StateCollection();
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

        public static State GetItem(int stateId)
        {
            State tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetState", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@StateId", stateId);

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

        private static State FillDataRecord(IDataRecord myDataRecord)
        {
            State myObject = new State();

            myObject.StateId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("StateId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("StateName")))
                myObject.StateName = myDataRecord.GetString(myDataRecord.GetOrdinal("StateName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("StateAbbreviation")))
                myObject.StateAbbreviation = myDataRecord.GetString(myDataRecord.GetOrdinal("StateAbbreviation"));

            return myObject;
        }
    }
}