using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {

        public string Get()
        {
            return "call api in 'api/data/<input>' format";
        }
        // GET: api/Data/5
        [HttpGet("{id}", Name = "Get")]
        public DataResult Get(int id)
        {
            var result = new DataResult { Success = true, Message = null };
            if (id == 0)
            {
                result.Message = "input is zero!";
                result.Result = id.ToString();
            }
            var resultText = "";
            if (id % 7 == 0)
            {
                resultText = "C";
            }
            if (id % 9 == 0)
            {
                resultText += "N";
            }
           
            if (resultText == "")
            {
                result.Message = "input is not a multiple of 7 or 9!";
                resultText = id.ToString();
            }

            result.Result = resultText;

            return result;
        }

        
    }
}
