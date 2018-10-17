using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationjson.Models;

namespace WebApplicationjson.Controllers
{
    public class TestdataController : Controller
    {
        // GET: Testdata
        JsonController _contrller = new JsonController();
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                id = "3f2b12b8-2a06-45b4-b057-45949279b4e5";
            }
            //string _id = id.ToString();
            
            JsonModel model = _contrller.Get(id);
            return View(model);
        }
        public ActionResult Listdata()
        {
            List<JsonModel> _lst = _contrller.GetAll();
            return View(_lst);
        }
        public ActionResult Edit(JsonModel Model)
        {
            JsonModel _model= _contrller.EditData(Model);
            return View(_model);
        }
        public ActionResult Delete(string Id)
        {
            
            JsonModel model = _contrller.Deletejson(Id);
            return View();
        }

        public ActionResult Create(JsonModel data)
        {
            _contrller.Postdata(data);
            return View();
        }

        public ActionResult Details(string id)
        {
            JsonModel model = _contrller.Get(id);
            return View(model);
        }
    }
}