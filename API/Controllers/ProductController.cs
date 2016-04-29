using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    public class ProductController : ApiController
    {

        List<Product> listadeProdutos = new List<Product>();


        // GET: api/Product
        public IHttpActionResult Get()
        {
            var produto1 = new Product();
            produto1.Id = 1;
            produto1.Name = "Placa de Rede";
            produto1.Category = "Hadware";
            produto1.price = 120m;

            var produto2 = new Product { Id = 2, Name = "Placa Mãe", Category = "Hadware", price = 480m };
            var produto3 = new Product { Id = 3, Name = "Antivirus", Category = "Software", price = 80m };

            listadeProdutos.Add(produto1);
            listadeProdutos.Add(produto2);
            listadeProdutos.Add(produto3);


            return Ok(listadeProdutos) ;
               
        }

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
