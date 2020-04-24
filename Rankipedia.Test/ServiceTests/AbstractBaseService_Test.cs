using System;
using System.Collections.Generic;
using Moq;
using Xunit;
using Rankipedia.CodeTest.Data;
using Rankipedia.CodeTest.Dto;
using Rankipedia.CodeTest.Models;
using Rankipedia.CodeTest.Services;
using AutoMapper;

namespace Rankipedia.Test
{
    public abstract class AbstractBaseService_Test<TDto, TEntity> where TDto : class, IDto where TEntity : class, IEntity
    {
        protected IEntityService<TDto, TEntity> _testTarget;
        protected List<TEntity> _testList = new List<TEntity>();
        protected List<TDto> _testDtoList = new List<TDto>();

        protected Mock<IEntityRepository<TEntity>> _mockRepo;
        protected Mock<IMapper> _mockMapper;

        public AbstractBaseService_Test()
        {
            _mockRepo = new Mock<IEntityRepository<TEntity>>();
            _mockMapper = new Mock<IMapper>();

            SetupTestData();
            SetupMocks();
        }

        protected virtual void SetupMocks()
        {
            _mockRepo.Setup(x => x.GetEntities()).Returns(_testList);
            _mockRepo.Setup(x => x.GetEntitiesByForeignKey(It.IsAny<int>())).Returns(_testList);
            _mockRepo.Setup(x => x.GetEntity(It.IsAny<int>())).Returns(_testList[0]);

            _mockMapper.Setup(x => x.Map<TDto>(It.IsAny<TEntity>())).Returns(_testDtoList[0]);
            _mockMapper.Setup(x => x.Map<List<TDto>>(It.IsAny<List<TEntity>>())).Returns(_testDtoList);
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

            _mockRepo.Verify(x => x.GetEntities(), Times.Once);
            _mockRepo.VerifyNoOtherCalls();
            _mockMapper.Verify(x => x.Map<List<TDto>>(It.IsAny<List<TEntity>>()), Times.Once);
            _mockMapper.VerifyNoOtherCalls();
        }

        [Fact]
        public void TestGetDto()
        {
            var dto = _testTarget.GetDto(12);

            Assert.NotNull(dto);
            Assert.Equal(_testDtoList[0], dto);

            _mockRepo.Verify(x => x.GetEntity(It.IsAny<int>()), Times.Once);
            _mockRepo.VerifyNoOtherCalls();
            _mockMapper.Verify(x => x.Map<TDto>(It.IsAny<TEntity>()), Times.Once);
            _mockMapper.VerifyNoOtherCalls();
        }

        [Fact]
        public void TestGetDtosByForeignKey()
        {
            var dtos = _testTarget.GetDtosByForeignKey(99);

            Assert.NotNull(dtos);
            Assert.Equal(_testDtoList, dtos);

            _mockRepo.Verify(x => x.GetEntitiesByForeignKey(It.IsAny<int>()), Times.Once);
            _mockRepo.VerifyNoOtherCalls();
            _mockMapper.Verify(x => x.Map<List<TDto>>(It.IsAny<List<TEntity>>()), Times.Once);
            _mockMapper.VerifyNoOtherCalls();
        }

    }
}
