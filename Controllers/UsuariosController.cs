using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API_MBProject.Models;
using API_MBProject.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using API_MBProject.Data;

namespace API_MBProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        //MÉTODOS GET
        [HttpGet("GetUsuarios")]
        public async Task<IActionResult> GetUsuarios()
        {
            try
            {
                List<Usuario> u = await _context.TB_USUARIOS.ToListAsync();
                return Ok(u);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetUserById/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            try
            {
                Usuario u = await _context.TB_USUARIOS.FirstOrDefaultAsync(u => u.id == id);
                return Ok(u);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet("GetByNomeAprox/{nome}")]
        public async Task<IActionResult> GetUsersByNomeAproximado(string nome)
        {
            try
            {
                List<Usuario> u = await _context.TB_USUARIOS.Where(u => u.nome.Contains(nome)).ToListAsync();
                return Ok(u);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        //MÉTODOS POST
        [HttpPost("PostUsuarios")]
        public async Task<IActionResult> PostUsuarios(Usuario NovoUsuario)
        {
            try
            {
                await _context.TB_USUARIOS.AddAsync(NovoUsuario);
                await _context.SaveChangesAsync();

                return Ok(NovoUsuario);
            }
            catch (System.Exception ex)
            {
                 return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }


        //MÉTODOS PUT

        [HttpPut("UpdateUsuario")]
        public async Task<IActionResult> UpdateUsuario(Usuario novoUser)
        {
            try
            {
                bool jaExiste = await _context.TB_USUARIOS.AnyAsync(user => user.id == novoUser.id);

                if (!jaExiste)
                {
                    throw new Exception("Você não pode alterar um usuário não existente");
                }

                _context.TB_USUARIOS.Update(novoUser);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //MÉTODOS DELETE
        [HttpDelete("DeleteUsuario/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Usuario uRemove = await _context.TB_USUARIOS.FirstOrDefaultAsync(user => user.id == id);
                _context.TB_USUARIOS.Remove(uRemove);
                int linhasAfetadas = await _context.SaveChangesAsync();

                return Ok(linhasAfetadas);
            }
            catch (System.Exception ex) {
                return BadRequest(ex.Message);
            }
        }


    }
}