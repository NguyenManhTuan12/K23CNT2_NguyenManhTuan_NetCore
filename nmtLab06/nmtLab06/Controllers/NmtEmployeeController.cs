using Microsoft.AspNetCore.Mvc;
using nmtLab06.Models;

namespace nmtLab06.Controllers
{
    public class NmtEmployeeController : Controller
    {
        public static List<NmtEmployee> NmtListEmployee = new List<NmtEmployee>
    {
        new NmtEmployee { NmtId = 1, NmtName = "Nong Van Hung", NmtBirthDay = new DateTime(2005, 8, 14), NmtEmail = "vanhung@example.com", NmtPhone = "0123456789", NmtSalary = 1000, NmtStatus = true },
        new NmtEmployee { NmtId = 2, NmtName = "Trần Thị B", NmtBirthDay = new DateTime(1998, 3, 10), NmtEmail = "thib@example.com", NmtPhone = "0987654321", NmtSalary = 1200, NmtStatus = true },
        new NmtEmployee { NmtId = 3, NmtName = "Lê Văn C", NmtBirthDay = new DateTime(2000, 8, 20), NmtEmail = "vanc@example.com", NmtPhone = "0909090909", NmtSalary = 900, NmtStatus = false },
        new NmtEmployee { NmtId = 4, NmtName = "Phạm Thị D", NmtBirthDay = new DateTime(1995, 1, 30), NmtEmail = "thid@example.com", NmtPhone = "0888888888", NmtSalary = 1100, NmtStatus = true },
        new NmtEmployee { NmtId = 5, NmtName = "Bạn Sinh Viên", NmtBirthDay = new DateTime(2002, 10, 1), NmtEmail = "sinhvien@example.com", NmtPhone = "0777777777", NmtSalary = 950, NmtStatus = true },
    };

        public IActionResult NmtIndex()
        {
            return View(NmtListEmployee);
        }

        public IActionResult NmtCreate()
        {
            return View();
        }

        public IActionResult NmtCreateSubmit(NmtEmployee nmtEmp)
        {
            nmtEmp.NmtId = NmtListEmployee.Max(e => e.NmtId) + 1;
            NmtListEmployee.Add(nmtEmp);
            return RedirectToAction("NmtIndex");
        }

        [HttpGet]
        public IActionResult NmtEdit(int id)
        {
            var nmtEmp = NmtListEmployee.FirstOrDefault(e => e.NmtId == id);
            if (nmtEmp == null)
                return NotFound();
            return View(nmtEmp);
        }

        public IActionResult NmtEditPUT(NmtEmployee nmtEmp)
        {
            var existing = NmtListEmployee.FirstOrDefault(e => e.NmtId == nmtEmp.NmtId);
            if (existing != null)
            {
                existing.NmtName = nmtEmp.NmtName;
                existing.NmtBirthDay = nmtEmp.NmtBirthDay;
                existing.NmtEmail = nmtEmp.NmtEmail;
                existing.NmtPhone = nmtEmp.NmtPhone;
                existing.NmtSalary = nmtEmp.NmtSalary;
                existing.NmtStatus = nmtEmp.NmtStatus;
            }
            return RedirectToAction("NmtIndex");
        }

        public IActionResult NmtDelete(int id)
        {
            var nmtEmp = NmtListEmployee.FirstOrDefault(e => e.NmtId == id);
            if (nmtEmp != null)
                NmtListEmployee.Remove(nmtEmp);
            return RedirectToAction("NmtIndex");
        }
    }
}
