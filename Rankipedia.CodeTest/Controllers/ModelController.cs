using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;
using Microsoft.AspNetCore.Mvc;


namespace Rankipedia.CodeTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelController : BaseController<Model, ModelDto>
    {
        public ModelController(IEntityService<ModelDto, Model> service) : base(service)
        {

        }
    }  
}
