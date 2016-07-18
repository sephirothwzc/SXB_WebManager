using System.Web.Mvc;
using DAO;

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
    }
}