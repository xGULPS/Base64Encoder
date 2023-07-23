using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncoderServices.Encoders
{
    public class Encoder
    {

        public Encoder() { }

        public string EncodeStringToBase64(string strToEncode)
        {
            var strToEncodeInBytes = System.Text.Encoding.UTF8.GetBytes(strToEncode);
            return System.Convert.ToBase64String(strToEncodeInBytes);
        }

        public string ReturnEncodedStringWithDelay(string strToEncode)
        {
            Random rnd = new Random();

            Thread.Sleep(rnd.Next(1000, 5000));

            return (EncodeStringToBase64(strToEncode)); 
        }
      

    }
}
