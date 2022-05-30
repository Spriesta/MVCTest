using Beta.Models;
using Beta.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Beta.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult MainLayout()
        {
            return View();
        }

        MainRepository rep = new MainRepository(); // repo bağlantısı

        [HttpPost]
        public JsonResult getList(int id)
        {
           
            MainRepository rep = new MainRepository();
            List<StudentReturnListModel> rList = rep.getList(id);

            return Json(rList, JsonRequestBehavior.AllowGet);
        }


    }
}








//------------------------------------------------------------------------
//[HttpPost] // test ile denedim çalıştı
//public JsonResult getList(int Id)
//{
//    List<Test> kisiler = new List<Test>
//            {
//                new Test { id = 1, sName = "Ahmet", sTC = "57328057877"}
//            };

//    Test ogrenci = kisiler.FirstOrDefault(x => x.id == Id);

//    return Json(ogrenci, JsonRequestBehavior.AllowGet);
//}
//------------------------------------------------------------------------



//Controller
/*
[Authorize]
public ActionResult EX01000081_GetDataGrid(string sSKU1, DateTime ACRDATE, DateTime ALUDATE)  // listeleme yaptık
{
    //ContentResult ret = null;
    DSResult dSResult = new DSResult();
    try
    {
        ShipResultRepository shipResulRep = new ShipResultRepository(Common.getConnStr());
        List<EX01000081_ReturnListModel> rList = shipResulRep.getList(sSKU1, ACRDATE, ALUDATE);

        response.data = rList;
        response.endRow = rList.Count - 1;
        response.totalRows = rList.Count;
        response.startRow = 0;
        response.status = 0;
        dSResult.Data = response;
    }
    catch (Exception ex)
    {
        response.data = ex.Message;
        response.status = -1;
        dSResult.Data = response;
    }
    return dSResult;
}
*/





