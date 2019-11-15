using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rocket.Libraries.AssemblyInformation
{
    [Route("api/about")]
    [ApiController]
    public class AboutController
    {
        [HttpGet]
        public InformationAboutAssembly Index()
        {
            return AssemblyInformationReader.Read();
        }
    }
}