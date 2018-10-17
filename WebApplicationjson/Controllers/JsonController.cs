using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplicationjson.Models;

namespace WebApplicationjson.Controllers
{
    public class JsonController : ApiController
    {
        // GET api/<controller>
        //public IEnumerable<string> Get()
        //{
        //    //return new string[] { "value1", "value2" };
        //    return "Helloooo";
        //}
        List<JsonModel> _lstModel = new List<JsonModel>() {
            new JsonModel()
            {
                Id = "3f2b12b8-2a06-45b4-b057-45949279b4e5",
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 58.26,
                PostingDate = "2016 - 07 - 01T00:00:00",
                IsCleared = true,
                ClearedDate = "2016-07-02T00:00:00"
            },
        new JsonModel()
        {
            Id = "d2032222-47a6-4048-9894-11ab8ebb9f69",
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 50.09,
                PostingDate = "2016-08-01T00:00:00",
                IsCleared = true,
                ClearedDate = "2016-08-02T00:00:00"
            },
            new JsonModel()
        {
            Id = "d8f156f3-bd57-49c3-9dcb-fcaaa52308f5",
                ApplicationId = 197104,
                Type = "Debit",
                Summary = "Payment",
                Amount = 58.26,
                PostingDate = "2016 - 09 - 01T00:00:00",
                IsCleared = true,
                ClearedDate = "2016 - 09 - 02T00:00:00"
            }
            };
        
        public List<JsonModel> GetAll()
        {
            return _lstModel;
        }
        public JsonModel EditData(JsonModel model)
        {
            JsonModel _tempmodel = _lstModel.Where(s => s.Id ==model.Id).FirstOrDefault<JsonModel>();
            if (_tempmodel != null)
            {
                _lstModel.Remove(_tempmodel);
                _lstModel.Add(model);
                
                
            }
            return _tempmodel;
           
        }
        public JsonModel Get(string id)
        {
            
           
            
            //JsonModel _model = new JsonModel();
            //return new string[] { "value1", "value2" };
            
           JsonModel model= _lstModel.Where(s => s.Id == id).FirstOrDefault<JsonModel>();
            
            return model;
        }

        // GET api/<controller>/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<controller>
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/<controller>/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        public void Postdata(JsonModel model)
        {
            //bool _val = false;
            try {
                if (model != null)
                {
                    _lstModel.Add(model);
                    //_val = true;
                }
                //return _val;
            }
            catch(Exception ex)
            {
                //return _val;
            }  
        }
        // DELETE api/<controller>/5
        [HttpDelete]
       
        public JsonModel Deletejson(string appId)
        {
            JsonModel model = new JsonModel();
            if (appId != null)
            {
                model= _lstModel.Where(s => s.Id == appId).FirstOrDefault<JsonModel>();
                _lstModel.Remove(model);
            }
            return model;
        }

      
    }
}