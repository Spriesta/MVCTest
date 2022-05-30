using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using Beta.Models;
using System.Configuration;
using Dapper;

namespace Beta.Repository 
{ 
    public class MainRepository
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString);
        //bağlantı açık kapalı kontrolü yap        
        public List<StudentReturnListModel> getList(int id)
        {
            string sql = $@"
                         SELECT * FROM student WHERE id = '{id}'
                            ";
            List<StudentReturnListModel> res = connection.Query<StudentReturnListModel>(sql).ToList();
                        
            return res;
        }
         
        

    }
}


//    Repo

//      public List<EX01000081_ReturnListModel> getList(string sSKU1, DateTime ACRDATE, DateTime ALUDATE)  // listeleme yaptık
//{                               // QUERY EKSİK CANER ABİYE SOR
//    string sql = $@"
//                EXEC csp_RPT_EX01000081 '1=1', 'TRK', 1 
//                ";
//    List<EX01000081_ReturnListModel> res = QueryGeneric<EX01000081_ReturnListModel>(sql).ToList();
//    return res;
//}