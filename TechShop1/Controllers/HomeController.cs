using System.Linq;
using TechShop1.Models;
using System.Web.Mvc;


namespace TechShop1.Controllers
{
    namespace Techshop1.Controllers
    {
        public class HomeController : Controller
        {
            register db = new register();
            public ActionResult Index()
            {
                return View();
            }
            //Get
            [HttpGet]
            public ActionResult DangKy()
            {
                return View();
            }
            [HttpPost]
            public ActionResult DangKy(register_data Register)
            {
                db.register_datas.Add(Register);
                int id = db.SaveChanges();
                if (id > 0) 
                {
                    return RedirectToAction("DangNhap");
                }
                else
                {
                    return RedirectToAction("Error", "Home");
                }
            }
            public ActionResult DangNhap()
            {
                return View();
            }
            [HttpPost]
            public ActionResult DangNhap(register_data Register)
            {
                var usernameForm = Register.username;
                var passwordForm = Register.password;
                var userCheck = db.register_datas.SingleOrDefault(x => x.username.Equals(usernameForm) && x.password.Equals(passwordForm));
                if (userCheck != null)
                {
                    Session["reigster_data"] = userCheck;
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    ViewBag.LoginFail = "Đăng nhập thất bại, vui lòng kiểm tra thông tin";
                }
                return View("DangNhap");
            }
            public ActionResult DangXuat(register_data register)
            {
                Session["register_data"] = null;
                return RedirectToAction("DangNhap");

            }
            public ActionResult CuaHang()
            {
                return RedirectToAction("CuaHang", "Products");
            }
        }

        }
}