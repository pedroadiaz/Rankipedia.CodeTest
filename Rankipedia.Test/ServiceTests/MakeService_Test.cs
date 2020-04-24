using System;
using System.Collections.Generic;
using Moq;
using Xunit;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;

namespace Rankipedia.Test
{
    public class MakeService_Test : AbstractBaseService_Test<MakeDto, Make>
    {
        public MakeService_Test() : base()
        {
            _testTarget = new MakeService(_mockRepo.Object, _mockMapper.Object);
        }

        protected override void SetupTestData()
        {
            _testList = new List<Make>()
            {
                new Make { ID = 1, Name = "Test" },
                new Make { ID = 2, Name = "Test2" },
                new Make { ID = 3, Name = "Test3" }
            };

            _testDtoList = new List<MakeDto>()
            {
                new MakeDto { id = 1, name = "Test" },
                new MakeDto { id = 2, name = "Test2" },
                new MakeDto { id = 3, name = "Test3" }
            };

        }
    }
}
