using Beta.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Beta.Repository
{
    public class aSqlConnect
    {
        //SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        //string sql = "";
        //void CUD(DynamicParameters dynamic = null) // insert delete update için kullanıyormuş
        //{
        //    if (connection.State == System.Data.ConnectionState.Closed) //bağlantı kapalıysa açıyoruz
        //    {
        //        connection.Open();
        //    }
        //    connection.Execute(sql, dynamic, commandType: CommandType.Text);
        //    connection.Close();

        //    connection.Query<StudentReturnListModel>(sql).ToList();
        //}


    }
}