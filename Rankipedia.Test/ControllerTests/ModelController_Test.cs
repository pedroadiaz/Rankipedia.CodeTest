using System;
using System.Collections.Generic;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Services;
using Moq;
using Xunit;
using Rankipedia.CodeTest.Controllers;

namespace Rankipedia.Test.ControllerTests
{
    public class ModelController_Test : BaseController_Test<Model, ModelDto>
    {
        public ModelController_Test() : base()
        {
            _testTarget = new ModelController(_mockService.Object);
        }

        protected override void SetupTestData()
        {
            _testDtoList = new List<ModelDto>()
            {
                new ModelDto { id = 1, name = "Test", makeId = 2 },
                new ModelDto { id = 2, name = "Test2", makeId = 2 },
                new ModelDto { id = 3, name = "Test3", makeId = 3 }
            };

        }

    }
}
