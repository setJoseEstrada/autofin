using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace autofin.Models
{
    public class MProductos
    {

        examen_Jose_Antonio_Estrada_ReyesEntities _DbContext = new examen_Jose_Antonio_Estrada_ReyesEntities();

    
        public List<t_productos> ConsultarTodos() => _DbContext.t_productos.ToList();

        public t_productos Consultaruno(int id) => _DbContext.t_productos.Find(id);

        public void Agregar(t_productos objProductos)
        {
            _DbContext.t_productos.Add(objProductos);
            _DbContext.SaveChanges();

        }

        public void Modificar(t_productos objProductos)
        {
            _DbContext.Entry(objProductos).State = EntityState.Modified;
            _DbContext.SaveChanges();
        }
    }
}