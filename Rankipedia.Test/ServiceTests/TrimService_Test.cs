using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rankipedia.Test
{
    public class TrimService_Test : AbstractBaseService_Test<TrimDto, Trim>
    {
        public TrimService_Test() : base()
        {
            _testTarget = new TrimService(_mockRepo.Object, _mockMapper.Object);
        }


        protected override void SetupTestData()
        {
            _testList = new List<Trim>()
            {
                new Trim { ID = 1, Name = "Test", ModelID = 1 },
                new Trim { ID = 2, Name = "Test2", ModelID = 1 },
                new Trim { ID = 3, Name = "Test3", ModelID = 2 }
            };

            _testDtoList = new List<TrimDto>()
            {
                new TrimDto { id = 1, name = "Test", modelId = 1 },
                new TrimDto { id = 2, name = "Test2", modelId = 1 },
                new TrimDto { id = 3, name = "Test3", modelId = 3 }
            };

        }
    }
}
