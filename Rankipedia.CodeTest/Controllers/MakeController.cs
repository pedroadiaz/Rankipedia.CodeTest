using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;
using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakeController : BaseController<Make, MakeDto>
    {
        public MakeController(IEntityService<MakeDto, Make> service) : base(service)
        {

        }
    }
}
