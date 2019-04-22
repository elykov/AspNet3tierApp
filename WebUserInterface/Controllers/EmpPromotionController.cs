using BusinessLayerLibrary.Models;
using BusinessLayerLibrary.Services;
using DataAccessLibrary.DbLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUserInterface.Controllers
{
    public class EmpPromotionController : Controller
    {
        IGenericService<EmpPromotionDTO> empPromotionService;

        public EmpPromotionController(IGenericService<EmpPromotionDTO> empPromotionService)
        {
            this.empPromotionService = empPromotionService;
        }

        // GET: EmpPromotion
        public ActionResult Index()
        {
            return View(empPromotionService.GetAll());
        }


    }
}