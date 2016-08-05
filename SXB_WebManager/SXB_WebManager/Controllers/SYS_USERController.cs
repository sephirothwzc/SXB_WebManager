using System.Web.Mvc;
using DAO;
using Entity;

namespace SXB_WebManager.Controllers
{
    public class SYS_USERController : Controller
    {
        // GET: SYS_USER
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult GetSYS_USER()
        {
            SYS_USER_DAO dao = new SYS_USER_DAO();
            var rest = dao.Query();
            return Json(rest, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// 新增对象
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveSYS_USER(SYS_USER user)
        {
            user.LASTDATE = System.DateTime.Now;
            var rest = 0;
            if (string.IsNullOrEmpty(user.ROW_ID))
                rest = new DAO.SYS_USER_DAO().Insert(user);
            else
                rest = new DAO.SYS_USER_DAO().Update(user);
            return Json(user);
        }
    }
}