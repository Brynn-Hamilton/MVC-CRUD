using Microsoft.AspNetCore.Mvc;
using Potluck.Models;

namespace Potluck.Controllers
{
    public class TeammemberController : Controller
    {
        public IActionResult Index()
        {
            List <Teammember> teammembers = DAL.GetAllTeammembers();
            return View(teammembers);
        }
        public IActionResult RSVP()
        {
            return View();
        }
        public IActionResult Registered(Teammember teammember)
        {
            bool isvalid = true;
            if (teammember.LastName == null || teammember.LastName.Length < 1)
            {
                TempData["LastNameError"] = "*Last name must contain at least one character.";
                isvalid = false;
            }
            if (teammember.EmailAddress == null || !teammember.EmailAddress.Contains("@"))
            {
                TempData["EmailError"] = "*Email must contain the @ symbol.";
                isvalid = false;
            }
            if (isvalid == true)
            {
                DAL.InsertTeammember(teammember);
                return View(teammember);
            }
            else
            {
                return Redirect("/teammember/rsvp");
            }
        }
        public IActionResult Detail(int id)
        {
            Teammember teammember = DAL.GetOneTeammember(id);
            return View(teammember);
        }

        public IActionResult Delete(int id)
        {
            DAL.DeleteTeammember(id);
            return Redirect("/teammember");
        }

        public IActionResult EditForm(int id)
        {
            Teammember teammember = DAL.GetOneTeammember(id);
            return View(teammember);
        }

        public IActionResult SaveChanges(Teammember teammember)
        {
            DAL.UpdateTeammember(teammember);
            return Redirect("/teammember");
        }
    }
}
