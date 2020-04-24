using AutoMapper;
using Rankipedia.CodeTest.Data;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rankipedia.CodeTest.Services
{
    public class MakeService : AbstractBaseService<MakeDto, Make>
    {
        public MakeService(IEntityRepository<Make> repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
