using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rankipedia.Test
{
    public class ModelService_Test : AbstractBaseService_Test<ModelDto, Model>
    {
        public ModelService_Test() : base()
        {
            _testTarget = new ModelService(_mockRepo.Object, _mockMapper.Object);
        }


        protected override void SetupTestData()
        {
            _testList = new List<Model>()
            {
                new Model { ID = 1, Name = "Test", MakeID = 1 },
                new Model { ID = 2, Name = "Test2", MakeID = 1 },
                new Model { ID = 3, Name = "Test3", MakeID = 2 }
            };

            _testDtoList = new List<ModelDto>()
            {
                new ModelDto { id = 1, name = "Test", makeId = 1 },
                new ModelDto { id = 2, name = "Test2", makeId = 1 },
                new ModelDto { id = 3, name = "Test3", makeId = 3 }
            };

        }
    }
}
