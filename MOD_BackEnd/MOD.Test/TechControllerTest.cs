using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using MOD.TechnologyService.Controllers;
using MOD.TechnologyService.Models;
using MOD.TechnologyService.Repositories;
using Moq;
using Xunit;

namespace MOD.Test
{
   public class TechControllerTest
    {
        private readonly Mock<ISkillRepository> _repo;
        private readonly SkillController _controller;

        public TechControllerTest()
        {
            _repo = new Mock<ISkillRepository>();
            _controller = new SkillController(_repo.Object);
        }
        

        private List<Skill> GetSkills()
        {
            return new List<Skill>()
            {
                new Skill(){SId="1",SName="Java"},
                new Skill(){SId="2",SName="C"},
                new Skill(){SId="3",SName="Python"},
            };
        }
        [Fact]
        public void Get()
        {
            _repo.Setup(m => m.GetAll()).Returns(GetSkills());
            var result = _controller.Get() as List<Skill>;
                Assert.Equal(3, result.Count);
        }
        [Fact]
        public void GetByID()
        {
            _repo.Setup(m => m.GetName("Java")).Returns(GetSkills()[0]);
            var result = _controller.GetByname("Java") as Skill;

            Assert.NotNull(result);
            Assert.Equal("Java", result.SName);
        }
        [Fact]

        public void Post()
        {
            var item = GetSkills()[0];
            var result = _controller.Post(item) as OkResult;
            Assert.NotNull(result);
        }
        [Fact]
        public void Put()
        {
            var item = GetSkills()[0];
            var result = _controller.Put(item) as OkResult;
            Assert.NotNull(result);
        }

        [Fact]
        public void Delete()
        {
            _repo.Setup(m => m.Delete(It.IsAny<string>()));
            var result = _controller.Delete("S2345") as OkResult;
            Assert.NotNull(result);
        }
    }
}
