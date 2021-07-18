using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiThucHanh.Controllers
{
    public class NewnewController : Controller
    {
        // GET: Newnew
        public ActionResult Index()
        {

            return View();
        }
        public string CheckRadio(String soA, String soB, FormCollection frm)
        {
            double a = Convert.ToDouble(soA);
            double b = Convert.ToDouble(soB);
            double ketQua = 0;
            string phepTinh;
            phepTinh = frm["PhepTinh"].ToString();
            switch (phepTinh)
            {
                case "Cong":
                    ketQua = a + b;
                    break;
                case "Tru":
                    ketQua = a - b;
                    break;
                case "Nhan":
                    ketQua = a * b;
                    break;
                case "Chia":
                    ketQua = a % b;
                    break;
            }
            return "Ket Qua la:" + ketQua;
            //if (phepTinh == "Cong")
            //{
            //    ketQua = a + b;
            //    return "Ket Qua la:" + ketQua;
            //}

            //if (phepTinh == "Tru")
            //{
            //    ketQua = a - b;
            //    return "Ket Qua la:" + ketQua;
            //}

            //if (phepTinh == "Nhan")
            //{
            //    ketQua = a * b;
            //    return "Ket Qua la:" + ketQua;
            //}

            //if (phepTinh == "Chia")
            //{
            //    ketQua = a % b;
            //    return "Ket Qua la:" + ketQua;
            //}

            //ViewData["ketQua"] = ketQua;

        }
    }
}