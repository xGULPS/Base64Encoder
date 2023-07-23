
using Microsoft.AspNetCore.Mvc;
using EncoderServices.Encoders;

namespace Base64EncoderAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EncoderController : Controller
    {

        private readonly Encoder _encoderServices;
        public EncoderController(Encoder encoderServices)
        {
            _encoderServices = encoderServices;
        }

        [HttpGet("encodestringtobase64")]
        public IActionResult EncodeStringToBase64(string strToEncode)
        {                  
            return Ok(_encoderServices.EncodeStringToBase64(strToEncode));
        }

        [HttpGet("encodestringtobase64Length")]
        public IActionResult EncodeStringToBase64Length(string strToEncode)
        {
            return Ok(_encoderServices.EncodeStringToBase64(strToEncode).Length);
        }
        [HttpGet("encodestringtobase64byindex")]
        public IActionResult EncodeStringToBase64ByIndex(string strToEncode,int Index)
        {
            return Ok(_encoderServices.ReturnEncodedStringWithDelay(strToEncode).Substring(Index,1));
        }
    }
}
