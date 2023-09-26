using BusinessLayer.Interfaces;
using Domain.DT;
using Domain.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_PUB_PV.Models;

namespace WebApi_PUB_PV.Controllers
{
    public class ClientePreferencialController : Controller
    {
        private IB_ClientePreferencial bl;
        public ClientePreferencialController(IB_ClientePreferencial _bl)
        {
            bl = _bl;
        }

        //Agregar
        [HttpPost("/api/agregarCliente")]
        public ActionResult<DTCliente_Preferencial> Post([FromBody] DTCliente_Preferencial value)
        {
            MensajeRetorno x = bl.agregar_ClientePreferencial(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        /*//Actualizar    
        [HttpPut("/api/actualizarEvento")]
        public ActionResult<Evento> Put([FromBody] DTEvento value)
        {
            MensajesEnum x = bl.actualizar_Evento(value);
            return Ok(new StatusResponse { StatusOk = x.status, StatusMessage = x.mensaje });
        }

        //Listar
        [HttpGet("/api/listarEventos")]
        public List<DTEvento> Get()
        {
            return bl.listar_Eventos();
        }

        //Eliminar
        [HttpDelete("/api/agregarEvento/{id:int}")]
        public ActionResult<bool> Delete(int id)
        {
            return Ok(bl.eliminar_Evento(id));
        }*/
    }
}
