using AutoMapper;
using CRUDByAlexanderMartinezForExpressoAmericano.Dtos;
using CRUDByAlexanderMartinezForExpressoAmericano.Models;
using CRUDByAlexanderMartinezForExpressoAmericano.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDByAlexanderMartinezForExpressoAmericano.Controllers
{
    [Route("api/Producto")]
    [ApiController]
    public class ProductosController : Controller
    {
        private readonly IProductoRepository _ctRepo;
        private readonly IMapper _mapper;

        public ProductosController(IProductoRepository ctRepo, IMapper mapper)
        {
            _ctRepo = ctRepo;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetProductos()
        {
            var listaProductos = _ctRepo.GetProductos();
            return Ok(listaProductos);

            var listaProductoDto = new List<ProductoDto>();

            foreach (var lista in listaProductos)
            {
                listaProductoDto.Add(_mapper.Map<ProductoDto>(lista));
            }
            return Ok(listaProductoDto);

        }

        [HttpPost]
        public IActionResult CrearProducto([FromBody] ProductoDto productoDto)
        {
            if (productoDto == null)


            {
                return BadRequest(ModelState);
            }
            if (_ctRepo.ExisteProducto(productoDto.id_producto))
            {
                ModelState.AddModelError("", "Ya Existe el producto");
                return StatusCode(404, ModelState);
            }
            var producto = _mapper.Map<Producto>(productoDto);
            if (!_ctRepo.CrearProducto(producto))
            {
                ModelState.AddModelError("", $"Algo Salio mal guardando el registro{producto.id_producto}");
                return StatusCode(404, ModelState);
            }
            return Ok();
            
        }
        [HttpPatch("{productoId:int}", Name = "ActualizarProducto")]
        public IActionResult ActualizarProducto(int productoId, [FromBody] ProductoDto productoDto)
        {
           
            var producto = _mapper.Map<Producto>(productoDto);
            if (!_ctRepo.ActualizarProducto(producto))
            {
                ModelState.AddModelError("", $"Algo Salio mal actualizando el registro{producto.id_producto}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }

        [HttpDelete("{productoId:int}", Name = "BorrarProducto")]
        public IActionResult BorrarProducto(int productoId)
        {

           // var producto = _mapper.Map<Producto>(productoDto);
            if (!_ctRepo.ExisteProducto(productoId))
            {
                return NotFound();
            }
            var producto = _ctRepo.GetProducto(productoId);
            
            if (!_ctRepo.BorrarProducto(producto))
            {
                ModelState.AddModelError("", $"Algo Salio mal Borrando el registro{producto.id_producto}");
                return StatusCode(500, ModelState);
            }
            return NoContent();
        }
    }
}
