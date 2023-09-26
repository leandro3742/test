using BusinessLayer.Interfaces;
using DataAccesLayer.Interface;
using Domain.DT;
using Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Implementations
{
    public class B_ClientePreferencial: IB_ClientePreferencial
    {
        private IDAL_ClientePreferencial _dal;
        private IDAL_Casteo _cas;
        private IDAL_FuncionesExtras _fu;

        public B_ClientePreferencial(IDAL_ClientePreferencial dal, IDAL_Casteo cas, IDAL_FuncionesExtras fu)
        {
            _dal = dal;
            _cas = cas;
            _fu = fu;
        }

        MensajeRetorno IB_ClientePreferencial.agregar_ClientePreferencial(DTCliente_Preferencial dtCP)
        {
            MensajeRetorno men = new MensajeRetorno();
            if (dtCP != null)
            {
                if (!_fu.existeCliente(dtCP.telefono))
                {
                    if (_dal.set_Cliente(dtCP) == true)
                    {
                        men.El_Cliente_se_guardo_Correctamente();
                        return men;
                    }
                    else
                    {
                        men.Exepcion_no_Controlada();
                        return men;
                    }
                }
                else
                {
                    men.Ya_existe_un_Cliente_con_los_datos_ingresado();
                    return men;
                }
            }
            else
            {
                men.Objeto_Nulo();
                return men;
            }
        }
    }
}
