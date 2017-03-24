using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiSwaggerDemo.Controllers
{
    public class OrderController : ApiController
    {
        [HttpPost, Route("order/UpdateOrder")]
        public OutPutResult UpdateOrder(string input)
        {
            return new OutPutResult() { Success = false, Message = input };
        }
    }
    public class OutPutResult
    {
       public bool Success { get; set; }
       public string Message { get; set; }
    }
}
