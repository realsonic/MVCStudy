using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson_02.Controllers
{
    public class CalcController : Controller
    {
        private void UpdateViewBag(int? op1, int? op2, Func<int, int, int> calcFunc)
        {
            ViewBag.op1 = op1;
            ViewBag.op2 = op2;
            if (op1 != null && op2 != null)
            {
                ViewBag.Result = calcFunc((int)op1, (int)op2);
            }
            else
            {
                ViewBag.Result = "Один из операндов не подходит!";
            }
        }

        public ActionResult Add(int? op1, int? op2)
        {
            UpdateViewBag(op1, op2, (o1, o2) => o1 + o2);

            return View("Result");
        }

        public ActionResult Mul(int? op1, int? op2)
        {
            UpdateViewBag(op1, op2, (o1, o2) => o1 * o2);

            return View("Result");
        }

        public ActionResult Sub(int? op1, int? op2)
        {
            UpdateViewBag(op1, op2, (o1, o2) => o1 - o2);

            return View("Result");
        }

        public ActionResult Div(int? op1, int? op2)
        {
            UpdateViewBag(op1, op2, (o1, o2) => o1 / o2);

            return View("Result");
        }
    }
}