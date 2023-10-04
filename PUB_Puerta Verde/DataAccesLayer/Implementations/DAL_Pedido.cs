using DataAccesLayer.Interface;
using DataAccesLayer.Models;
using Domain.DT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Implementations
{
    public class DAL_Pedido : IDAL_Pedido
    {
        private readonly DataContext _db;
        public DAL_Pedido(DataContext db)
        {
            _db = db;
        }

        //Agregar
        public bool set_Cliente(DTPedido dtP)
        {
            Pedidos aux = Pedidos.SetPedido(dtP);
            Pedidos_Productos aux2 = null;
            try
            {
                _db.Pedidos.Add(aux);
                _db.SaveChanges();

                int idPedido = aux.id_Pedido;

                foreach (int i in dtP.list_IdProductos)
                {
                    aux2 = Pedidos_Productos.SetPedido_Producto(idPedido, i);
                    _db.Pedidos_Productos.Add(aux2);
                    _db.SaveChanges();
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Actualizar
        bool IDAL_Pedido.update_Pedido(DTPedido dtP)
        {
            Pedidos aux = null;
            aux = _db.Pedidos.FirstOrDefault(pe => pe.id_Pedido == dtP.id_Pedido);

            aux.valorPedido = dtP.valorPedido;
            aux.pago = dtP.pago;
            aux.username = dtP.username;
            aux.id_Cli_Preferencial = dtP.id_Cli_Preferencial;
            aux.estadoProceso = dtP.estadoProceso;
            aux.fecha_ingreso = dtP.fecha_ingreso;
            aux.hora_ingreso = dtP.hora_ingreso;
            aux.numero_movil = dtP.numero_movil;
            aux.observaciones = dtP.observaciones;
            Pedidos_Productos aux2 = null;

            try
            {
                _db.Update(aux);
                _db.SaveChanges();

                foreach(int x in dtP.list_IdProductos)
                {
                    aux2 = null; 
                    aux2 = _db.Pedidos_Productos.FirstOrDefault(ped => ped.id_Pedido == dtP.id_Pedido && ped.id_Producto == x);
                    if (aux2 == null)
                    {
                        aux2 = Pedidos_Productos.SetPedido_Producto(dtP.id_Pedido, x);
                        _db.Pedidos_Productos.Add(aux2);
                        _db.SaveChanges();
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        //Listar Activos 
        List<Pedidos> IDAL_Pedido.get_PedidosActivos()
        {
            return _db.Pedidos.Where(x => x.estadoProceso).Select(x => x.GetPedido()).ToList();
        }

        //Listar
        List<Pedidos> IDAL_Pedido.get_Pedidos()
        {
            return _db.Pedidos.Select(x => x.GetPedido()).ToList();
        }

        //Baja 
        bool IDAL_Pedido.baja_Pedido(int id)
        {
            Pedidos aux = null;
            aux = _db.Pedidos.FirstOrDefault(ped => ped.id_Pedido == id);

            aux.estadoProceso = false;

            try
            {
                _db.Update(aux);
                _db.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
