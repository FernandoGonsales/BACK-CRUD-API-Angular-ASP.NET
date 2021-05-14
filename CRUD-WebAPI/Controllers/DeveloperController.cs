using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CRUD_WebAPI.Data;
using CRUD_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_WebAPI.Controllers
{
    [ApiController]
    [Route("api/developers")]
    public class DeveloperController : ControllerBase
    {
        private readonly IRepository _repository;

        public DeveloperController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var result = await _repository.GetAll();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {   
                Developer developer = await _repository.GetById(id);
                if (developer == null)
                {
                    return NotFound($"Desenvolvedor não encontrado.");
                }       
                return Ok(developer);
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create(Developer developer)
        {
            try
            {   
                developer.Id = null;
                _repository.Create(developer);
                if(await _repository.SaveChangesAsync())
                {
                    return Ok(developer);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Developer developer)
        {
            try
            {
                if (await _repository.GetById(id) == null)
                {
                    return NotFound();
                }

                developer.Id = id;
                _repository.Update(developer);
                if(await _repository.SaveChangesAsync())
                {
                    return Ok(developer);
                }                
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Developer developer = await _repository.GetById(id);
                if (developer == null)
                {
                    return NotFound();
                }

                _repository.Delete(developer);
                if(await _repository.SaveChangesAsync())
                {
                    return Ok(developer);
                }            
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro: {ex.Message}");
            }
            return BadRequest();
        }
    }
}