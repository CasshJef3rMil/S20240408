using S20240408.AccesoADatos;
using S20240408.EntidadesDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S20240408.LogicaDeNegocio
{
    public class SpersonaBL
    {
        //EStamos accediendo al Imyector de dependencias
        readonly SpersonaDAL _spersonaDAL;
        public SpersonaBL(SpersonaDAL clienteDAL)
        {
            _spersonaDAL = clienteDAL;
        }


        //LLamamos al metodo crear
        public async Task<int> Crear(SPersona sPersona)
        {
            return await _spersonaDAL.Crear(sPersona);
        }
        //LLamamos al metodo Modificar
        public async Task<int> Modificar(SPersona sPersona)
        {
            return await _spersonaDAL.Modificar(sPersona);
        }
        //LLamamos al metodo eliminar
        public async Task<int> Eliminar(SPersona sPersona)
        {
            return await _spersonaDAL.Eliminar(sPersona);
        }
        //LLamamos al metodo Cliente
        public async Task<SPersona> ObtenerPorId(SPersona sPersona)
        {
            return await _spersonaDAL.ObtenerPorId(sPersona);
        }
        //LLamamos al metodo ObtenerTodos
        public async Task<List<SPersona>> ObtenerTodos()
        {
            return await _spersonaDAL.ObtenerTodos();
        }
        //LLamamos al metodo Buscar
        public async Task<List<SPersona>> Buscar(SPersona sPersona)
        {
            return await _spersonaDAL.Buscar(sPersona);
        }
    }
}
