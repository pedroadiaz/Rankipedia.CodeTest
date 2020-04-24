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
    public abstract class BaseController_Test<TEntity, TDto> where TEntity : class, IEntity where TDto : class, IDto
    {
        protected BaseController<TEntity, TDto> _testTarget;
        protected List<TDto> _testDtoList = new List<TDto>();

        protected Mock<IEntityService<TDto, TEntity>> _mockService;

        public BaseController_Test()
        {
            _mockService = new Mock<IEntityService<TDto, TEntity>>();

            SetupTestData();
            SetupMocks();
        }

        protected virtual void SetupMocks()
        {
            _mockService.Setup(x => x.GetDtos()).Returns(_testDtoList);
            _mockService.Setup(x => x.GetDtosByForeignKey(It.IsAny<int>())).Returns(_testDtoList);
            _mockService.Setup(x => x.GetDto(It.IsAny<int>())).Returns(_testDtoList[0]);
        }

        protected virtual void SetupTestData()
        {

        }

        [Fact]
        public void TestGetDtos()
        {
            var dtos = _testTarget.GetDtos();

            Assert.NotNull(dtos);
            Assert.Equal(_testDtoList, dtos);

            _mockService.Verify(x => x.GetDtos(), Times.Once);
            _mockService.VerifyNoOtherCalls();
        }

        [Fact]
        public void TestGetDto()
        {
            var dto = _testTarget.GetDto(12);

            Assert.NotNull(dto);
            Assert.Equal(_testDtoList[0], dto);

            _mockService.Verify(x => x.GetDto(It.IsAny<int>()), Times.Once);
            _mockService.VerifyNoOtherCalls();
        }

        [Fact]
        public void TestGetDtosByForeignKey()
        {
            var dtos = _testTarget.GetDtosByKey(99);

            Assert.NotNull(dtos);
            Assert.Equal(_testDtoList, dtos);

            _mockService.Verify(x => x.GetDtosByForeignKey(It.IsAny<int>()), Times.Once);
            _mockService.VerifyNoOtherCalls();
        }
    }
}
