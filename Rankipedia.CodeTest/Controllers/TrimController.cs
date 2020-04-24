using Microsoft.AspNetCore.Mvc;

using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;

namespace Rankipedia.CodeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrimController : BaseController<Trim, TrimDto>
    {
        public TrimController(IEntityService<TrimDto, Trim> service) : base(service)
        {

        }
    }
}
