using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WConFinServer.Models;

namespace WConFinServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        public static List<Estado> lista = new List<Estado>();

        [HttpGet]
        public List<Estado> GetEstado()
        {
            return lista;
        }

        [HttpPost]
        public string PostEstado(Estado estado)
        {
            lista.Add(estado);
            return "Estadoo cadastrado com sucesso!";
        }

        [HttpPut]
        public string PutEstado(Estado estado) //COM BASE NO ESTADO QUE FOI PASSADO, VAI SER PROCURADO NA LISTA
        {

            //VARIAVEL DO TIPO ESTADO      X - O OBEJETO QUE ESTIVER DENTRO DA LISTA, VAI SER CHAMADO DE X
            Estado estadoAux = lista.Where(x => x.Sigla == estado.Sigla).FirstOrDefault();
            estadoAux.Nome = estado.Nome;

            return "Estado alterado com sucesso!";
        }
        [HttpDelete]
        public string DeleteEstado(Estado estado)
        {
            Estado estadoAux = lista.Where(x => x.Sigla == estado.Sigla).FirstOrDefault();
            lista.Remove(estadoAux);
            return "Estado excluido com sucesso";
            
        }

         //Get - Listar
        //Put - Alterar
        //Post - Incluir
        //Delete - Excluir




    }
}
