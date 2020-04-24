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
    public class TrimService : AbstractBaseService<TrimDto, Trim>
    {
        public TrimService(IEntityRepository<Trim> repository, IMapper mapper) : base(repository, mapper)
        {

        }
    }
}
