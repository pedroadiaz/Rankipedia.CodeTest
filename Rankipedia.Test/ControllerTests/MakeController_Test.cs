using System.Collections.Generic;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Services;
using Moq;
using Xunit;
using Rankipedia.CodeTest.Controllers;

using System;
using System.Collections.Generic;
using System.Text;

namespace Rankipedia.Test.ControllerTests
{
    public class MakeController_Test : BaseController_Test<Make, MakeDto>
    {
        public MakeController_Test() : base()
        {
            _testTarget = new MakeController(_mockService.Object);
        }

        protected override void SetupTestData()
        {
            _testDtoList = new List<MakeDto>()
            {
                new MakeDto { id = 1, name = "Test" },
                new MakeDto { id = 2, name = "Test2" },
                new MakeDto { id = 3, name = "Test3" }
            };

        }

    }
}
