using Microsoft.EntityFrameworkCore;
using S20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S20240408.AccesoADatos
{
    public class SpersonaDAL
    {
        readonly AppDbContext _appDbContext;
        public SpersonaDAL(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }


        //Metodo Crear
        public async Task<int> Crear(SPersona sPersona)
        {
            _appDbContext.Add(sPersona);
            return await _appDbContext.SaveChangesAsync();
        }

        // Método Modificar
        public async Task<int> Modificar(SPersona sPersona)
        {
            var clienteData = await _appDbContext.Spersonas.FirstOrDefaultAsync(s => s.Id == sPersona.Id);
            if (clienteData != null)
            {
                clienteData.Nombre = sPersona.Nombre;
                clienteData.Apellido = sPersona.Apellido;
                clienteData.FechaNacimiento = sPersona.FechaNacimiento;
                clienteData.Sueldo = sPersona.Sueldo; // Corregir esta línea
                clienteData.Estatus = sPersona.Estatus; // Corregir esta línea
                _appDbContext.Update(clienteData);
            }
            return await _appDbContext.SaveChangesAsync();
        }


        //Metodo Eliminar
        public async Task<int> Eliminar(SPersona sPersona)
        {
            var clienteData = await _appDbContext.Spersonas.FirstOrDefaultAsync(s => s.Id == sPersona.Id);
            if (clienteData != null)
                _appDbContext.Remove(clienteData);
            return await _appDbContext.SaveChangesAsync();
        }


        //Metodo ObtenerPorID
        public async Task<SPersona> ObtenerPorId(SPersona sPersona)
        {
            var clienteData = await _appDbContext.Spersonas.FirstOrDefaultAsync(s => s.Id == sPersona.Id);
            if (clienteData != null)
                return clienteData;
            else
                return new SPersona();
        }

        //Metodo ObtenerTodos
        public async Task<List<SPersona>> ObtenerTodos()
        {
            return await _appDbContext.Spersonas.ToListAsync();
        }

        //Metodos Buscar
        public async Task<List<SPersona>> Buscar(SPersona sPersona)
        {

            var query = _appDbContext.Spersonas.AsQueryable();
            if (!string.IsNullOrWhiteSpace(sPersona.Nombre))
            {
                query = query.Where(s => s.Nombre.Contains(sPersona.Nombre));
            }
            if (!string.IsNullOrWhiteSpace(sPersona.Apellido))
            {
                query = query.Where(s => s.Apellido.Contains(sPersona.Apellido));
            }
            return await query.ToListAsync();
        }
    }
}
