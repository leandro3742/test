using BusinessLayer.Interfaces;
using Domain.DT;
using Domain.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_PUB_PV.Models;

namespace WebApi_PUB_PV.Controllers
{
    public class PedidoController : Controller
    {
        private IB_Pedido bl;
        public PedidoController(IB_Pedido _bl)
        {
            bl = _bl;
        }

        //Agregar
        [HttpPost("/api/agregarPedido")]
        public ActionResult<DTPedido> Post([FromBody] DTPedido value)
        {
            MensajeRetorno x = bl.agregar_Pedido(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        /*//Actualizar    
        [HttpPut("/api/actualizarCliente")]
        public ActionResult<DTCliente_Preferencial> Put([FromBody] DTCliente_Preferencial value)
        {
            MensajeRetorno x = bl.actualizar_ClientePreferencial(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Listar
        [HttpGet("/api/listarCliente")]
        public List<DTCliente_Preferencial> Get()
        {
            return bl.listar_ClientePreferencial();
        }

        ///Eliminar
        [HttpDelete("/api/bajaCliente/{id:int}")]
        public ActionResult<bool> BajaCategoria(int id)
        {
            MensajeRetorno x = bl.baja_ClientePreferencial(id);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }*/
    }
}
