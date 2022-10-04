using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace autofin.Models
{
    public class MDFactura
    {
        examen_Jose_Antonio_Estrada_ReyesEntities _DbContext = new examen_Jose_Antonio_Estrada_ReyesEntities();

        
        public List<t_detalleFactura> ConsultarTodos() => _DbContext.t_detalleFactura.ToList();

        public t_detalleFactura Consultaruno(int id) => _DbContext.t_detalleFactura.Find(id);

       

        public void Modificar(t_detalleFactura objfactura)
        {
            _DbContext.Entry(objfactura).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }
    }
}