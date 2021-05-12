using CRUD_WebAPI.Controllers;
using CRUD_WebAPI.Data;
using Xunit;
using Moq;
using CRUD_WebAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.WebAPI.Tests.Controllers
{
    public class DeveloperControllerTest
    {
        private DeveloperController _developerController;
         private readonly Mock<IRepository> _developerRepository = new Mock<IRepository>();

        public DeveloperControllerTest()
        {
            _developerController = new DeveloperController(_developerRepository.Object) {};
        }

        [Fact]
        public async void DadoRequestCadastroDesenvolvedorValidoEntaoDeveRetornarResponseDeSucessoComDesenvolvedorCadastrado() 
        {
            _developerRepository
                .Setup(repository => repository.Create(It.IsAny<Developer>()))
                .Returns(DeveloperCadastrado());
        }

                

        private Developer DeveloperCadastrado()
        {
            return new Developer()
            {
                Id = 1,
                Nome = "Pessoa Fisica Test",
                Sexo = 'M',
                Idade = 20,
                Hobby = "Jogar Games",
                DataNascimento = "02/04/2001"
            };
        }
















    }
}