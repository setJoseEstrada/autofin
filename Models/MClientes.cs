using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace autofin.Models
{
    public class MClientes
    {

        examen_Jose_Antonio_Estrada_ReyesEntities _DbContext = new examen_Jose_Antonio_Estrada_ReyesEntities();

        //List<t_clientes> _Clientes = new List<t_clientes>();

       // t_clientes objCliente = new t_clientes();
        public List<t_clientes> ConsultarTodos() => _DbContext.t_clientes.ToList();

        public t_clientes Consultaruno(int id) => _DbContext.t_clientes.Find(id);
       
        public void Agregar(t_clientes objClientes)
        {
              _DbContext.t_clientes.Add(objClientes);
            _DbContext.SaveChanges();

        }

        public void Modificar (t_clientes objClientes)
        {
            _DbContext.Entry(objClientes).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }
    }
}