using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Security.Models.ClassFiles;
using Security.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {

        [HttpGet]
        public string Get()
        {

            var services = this.HttpContext.RequestServices;

            var securityRepository = (ISecurityRepository)services.GetService(typeof(ISecurityRepository));

            IEnumerable<Security.Models.SecurityInfo> securityInfos = securityRepository.GetAllSecurities();

            return   JsonConvert.SerializeObject(securityInfos);

        }
    }
}
