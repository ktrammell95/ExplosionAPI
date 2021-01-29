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
    public class MumblingController : ControllerBase
    {
        [HttpGet]
        public string ConvertMumbling(string letters)
        {
            string finalString = "";

            for (var index = 0; index < letters.Length; index++)
            {

                var currentLetter = letters[index];
                var letterUpper = char.ToUpper(currentLetter);
                var letterLower = char.ToLower(currentLetter);
                string lowerLettersRepeated = new String(letterLower, index);
                var newString = letterUpper + lowerLettersRepeated;

                finalString = finalString + newString;
                if (index != letters.Length - 1)
                {
                    finalString = finalString + "-";
                }
            }
            return finalString;
        }
    }
}