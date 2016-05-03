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

         static List<Product> listadeProdutos = new List<Product>();

        public ProductController()
        {
            var produto1 = new Product
            {
                Id = 1,
                Name = "Placa de Rede",
                Category = "Hadware",
                price = 120m,
            };

            var produto2 = new Product 
            { 
                Id = 2,
                Name = "Placa Mãe", 
                Category = "Hadware", 
                price = 480m 
            };
            var produto3 = new Product 
            { 
                Id = 3, 
                Name = "Antivirus", 
                Category = "Software", 
                price = 80m 
            };

            listadeProdutos.Add(produto1);
            listadeProdutos.Add(produto2);
            listadeProdutos.Add(produto3);

        }


        // GET: api/Product
        public IHttpActionResult Get()
        {
           
            return Ok(listadeProdutos) ;
               
        }

        // GET: api/Product/5
       public IHttpActionResult Get(int id)
        {

            var produto = listadeProdutos.Find(x => x.Id == id);
            return Ok(produto);
        }

        // POST: api/Product
        public IHttpActionResult Post([FromBody]Product produto)
        {
            listadeProdutos.Add(produto);
            return Ok();

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
