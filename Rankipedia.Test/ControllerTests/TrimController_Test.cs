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
    public class TrimController_Test : BaseController_Test<Trim, TrimDto>
    {
        public TrimController_Test() : base()
        {
            _testTarget = new TrimController(_mockService.Object);
        }

        protected override void SetupTestData()
        {
            _testDtoList = new List<TrimDto>()
            {
                new TrimDto { id = 1, name = "Test", modelId = 5 },
                new TrimDto { id = 2, name = "Test2", modelId = 5 },
                new TrimDto { id = 3, name = "Test3", modelId = 5 }
            };

        }
    }
}
