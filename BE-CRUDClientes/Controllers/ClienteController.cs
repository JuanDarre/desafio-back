using BE_CRUDClientes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BE_CRUDClientes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly AplicationDbContext _context;
        public ClienteController(AplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var ListClientes = await _context.Clientes.ToListAsync();
                return Ok(ListClientes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var cliente = await _context.Clientes.FindAsync(id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return Ok(cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cliente = await _context.Clientes.FindAsync(id);

                if (cliente == null) {
                    return NotFound();
                }

                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Cliente cliente)
        {
            try
            {
                cliente.FechaCreacion = DateTime.Now;
                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return CreatedAtAction("Get", new { id = cliente.Id }, cliente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }




        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Cliente cliente)
        {

            try
            {
                if (id != cliente.Id)
                {
                    return BadRequest();
                }
                var clienteItem = await _context.Clientes.FindAsync(id);

                if(clienteItem == null)
                {
                    return NotFound();
                }

                    clienteItem.NombreCompleto = cliente.NombreCompleto;
                    clienteItem.Identificacion = cliente.Identificacion;
                    clienteItem.Edad = cliente.Edad;
                    clienteItem.Genero = cliente.Genero;
                    clienteItem.Estado = cliente.Estado;     
                    clienteItem.Maneja = cliente.Maneja;
                    clienteItem.Lentes = cliente.Lentes;
                    clienteItem.Diabetico = cliente.Diabetico;
                    clienteItem.OtraEnfermedad = cliente.OtraEnfermedad;

                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
