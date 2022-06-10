using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Netmoveis.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Netmoveis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        
            private static List<GuestModel> guests = new()
            {
                new GuestModel { ID = 1, TIPO_DO_MOVEL = "ALUGUEL", VALOR_VENDA = 10000, VALOR_LOCACAO = 10000, ENDERECO = "AV VISCONDE DE SOUZA", NUMERO = 10, COMPLEMENTO = "MODELO1", BAIRRO = "COQUEIRO", CIDADE = "IMBITUBA", ESTADO = "SC", CEP = "878800" },
                new GuestModel { ID = 2, TIPO_DO_MOVEL = "VENDA", VALOR_VENDA = 10000, VALOR_LOCACAO = 10000, ENDERECO = "AV VISCONDE DE SOUZA", NUMERO = 10, COMPLEMENTO = "MODELO2", BAIRRO = "COQUEIRO", CIDADE = "IMBITUBA", ESTADO = "SC", CEP = "878800" },
                new GuestModel { ID = 3, TIPO_DO_MOVEL = "ALUGUEL", VALOR_VENDA = 10000, VALOR_LOCACAO = 10000, ENDERECO = "AV VISCONDE DE SOUZA", NUMERO = 10, COMPLEMENTO = "MODELO", BAIRRO = "COQUEIRO", CIDADE = "LAGONA", ESTADO = "SC", CEP = "878800" },
                new GuestModel { ID = 4, TIPO_DO_MOVEL = "VENDA", VALOR_VENDA = 10000, VALOR_LOCACAO = 10000, ENDERECO = "AV VISCONDE DE SOUZA", NUMERO = 10, COMPLEMENTO = "MODELO", BAIRRO = "COQUEIRO", CIDADE = "IMBITUBA", ESTADO = "SC", CEP = "878800" }
            };
       

        [HttpGet]
        public  IEnumerable <GuestModel> Get()
        {
            return guests;
        }

        // GET: GuestController
        [HttpGet("{id}")]
        public GuestModel Get(int id)
        {
            return guests.Where(g=> g.ID == id).FirstOrDefault();
        }

        [HttpPost]
        public void Post([FromBody]GuestModel value)
        {
            guests.Add(value);
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] GuestModel value)
        {

            guests.Remove(guests.Where(g => g.ID == id).FirstOrDefault());
            guests.Add(value);

        }

        // GET: GuestController/Delete/5

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            guests.Remove(guests.Where(g => g.ID == id).FirstOrDefault());
        }
               

        
    }
}
