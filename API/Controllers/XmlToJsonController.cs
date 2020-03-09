using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class XmlToJsonController : Controller
    {
      
        [HttpPost]
        public ActionResult Post([FromBody]string xml)
        {
            if(xml==null)
            {
                return Content ("Bad Xml format" );

            }
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.LoadXml(xml);
                doc.DocumentElement.RemoveAllAttributes();
            }
            catch(Exception ex)
            {
                return Content("Bad Xml format");

            }
            string jsonText = JsonConvert.SerializeXmlNode(doc.DocumentElement, Newtonsoft.Json.Formatting.Indented);

            return Content(  jsonText );
        }


        


    }
}