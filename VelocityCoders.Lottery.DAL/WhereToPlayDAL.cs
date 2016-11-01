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
    public class WhereToPlayDAL
    {
        public static WhereToPlayCollection GetCollection()
        {
            WhereToPlayCollection tempList = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetWhereToPlay", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetCollection);

                    myConnection.Open();
                    using (SqlDataReader myReader = myCommand.ExecuteReader())
                    {
                        if (myReader.HasRows)
                        {
                            tempList = new WhereToPlayCollection();
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

        public static WhereToPlay GetItem(int whereToPlayId)
        {
            WhereToPlay tempItem = null;

            using (SqlConnection myConnection = new SqlConnection(AppConfiguration.ConnectionString))
            {
                using (SqlCommand myCommand = new SqlCommand("usp_GetWhereToPlay", myConnection))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("@QueryId", SelectTypeEnum.GetItem);
                    myCommand.Parameters.AddWithValue("@WhereToPlayId", whereToPlayId);

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

        private static WhereToPlay FillDataRecord(IDataRecord myDataRecord)
        {
            WhereToPlay myObject = new WhereToPlay();

            myObject.WhereToPlayId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("WhereToPlayId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("GameId")))
                myObject.GameId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("GameId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("StateId")))
                myObject.StateId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("StateId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("CityId")))
                myObject.CityId = myDataRecord.GetInt32(myDataRecord.GetOrdinal("CityId"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("AddressName")))
                myObject.AddressName = myDataRecord.GetString(myDataRecord.GetOrdinal("AddressName"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("AddressNumber")))
                myObject.AddressNumber = myDataRecord.GetInt32(myDataRecord.GetOrdinal("AddressNumber"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Street01")))
                myObject.Street01 = myDataRecord.GetString(myDataRecord.GetOrdinal("Street01"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("Street02")))
                myObject.Street02 = myDataRecord.GetString(myDataRecord.GetOrdinal("Street02"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("ZipCode")))
                myObject.ZipCode = myDataRecord.GetInt32(myDataRecord.GetOrdinal("ZipCode"));

            if (!myDataRecord.IsDBNull(myDataRecord.GetOrdinal("ZipCodePlusFour")))
                myObject.ZipCodePlusFour = myDataRecord.GetInt32(myDataRecord.GetOrdinal("ZipCodePlusFour"));

            return myObject;
        }
    }
}