using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using System.Net.Http.Formatting;
using DevExtremeMvcApp1.Models;

namespace DevExtremeMvcAppGridTest.Controllers {
    public class OrdersController : ApiController {
        [HttpGet]
        public HttpResponseMessage Get(DataSourceLoadOptions loadOptions) {
            var list = SampleData.Orders;
            return Request.CreateResponse(DataSourceLoader.Load(list, loadOptions));
        }
        [HttpPut]
        public object Put(FormDataCollection form) {
            //add your code to modify database here
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpPost]
        public object Post(FormDataCollection form) {
            //add your code to modify database here
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [HttpDelete]
        public object Delete(FormDataCollection form) {
            //add your code to modify database here
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}