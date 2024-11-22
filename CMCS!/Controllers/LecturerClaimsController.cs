using CMCS_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CMCS_.Controllers
{

    public class LecturerClaimsController : Controller
    {
        private static List<LecturerClaim> Claims = new List<LecturerClaim>
    {
        new LecturerClaim { Id = 1, LecturerName = "John Doe", HoursWorked = 30, HourlyRate = 25.00M, FinalPayment = 600.00M, Status = "Pending" }
    };

        public IActionResult Index()
        {
            return View(Claims);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LecturerClaim claim)
        {
            if (ModelState.IsValid)
            {
                claim.FinalPayment = claim.HoursWorked * claim.HourlyRate;
                claim.Id = Claims.Count + 1; // Simulating auto-increment ID
                Claims.Add(claim);
                return RedirectToAction("Index");
            }
            return View(claim);
        }

        public IActionResult Approve(int id)
        {
            var claim = Claims.FirstOrDefault(c => c.Id == id);
            if (claim != null && claim.Status == "Pending")
            {
                claim.Status = "Approved";
            }
            return RedirectToAction("Index");
        }
    }
}
