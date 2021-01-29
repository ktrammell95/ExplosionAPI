using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet]
        public string ConvertExplosion(string numbers)
        {
            var newNumber = "";

            foreach (char number in numbers)
            {
                switch (number)
                {
                    case '1':
                        newNumber += "1";
                        break;
                    case '2':
                        newNumber += "22";
                        break;
                    case '3':
                        newNumber += "333";
                        break;
                    case '4':
                        newNumber += "4444";
                        break;
                    case '5':
                        newNumber += "55555";
                        break;
                    case '6':
                        newNumber += "666666";
                        break;
                    case '7':
                        newNumber += "7777777";
                        break;
                    case '8':
                        newNumber += "88888888";
                        break;
                    case '9':
                        newNumber += "999999999";
                        break;
                }
            }
            return newNumber;
        }
    }
}