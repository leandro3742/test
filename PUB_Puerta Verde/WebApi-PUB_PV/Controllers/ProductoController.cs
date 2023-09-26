using BusinessLayer.Interfaces;
using Domain.DT;
using Domain.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_PUB_PV.Models;

namespace WebApi_PUB_PV.Controllers
{
    public class ProductoController : Controller
    {

        private IB_Producto bl;
        public ProductoController(IB_Producto _bl)
        {
            bl = _bl;
        }

        //Agregar
        [HttpPost("/api/agregarCategoria")]
        public ActionResult<DTCategoria> Post([FromBody] DTCategoria value)
        {
            MensajeRetorno x = bl.agregar_Categoria(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Listar
        [HttpGet("/api/listarCategorias")]
        public List<DTCategoria> Get()
        {
            return bl.listar_Categoria();
        }

        //Eliminar
        [HttpDelete("/api/bajaCategoria/{id:int}")]
        public ActionResult<bool> BajaCategoria(int id)
        {
            MensajeRetorno x = bl.baja_Categoria(id);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }
    }
}
