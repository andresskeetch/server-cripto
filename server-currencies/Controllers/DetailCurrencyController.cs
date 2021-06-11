using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;
using server_currencies.Models;
using server_currencies.Repositories;

namespace server_currencies.Controllers
{

    public class DetailCurrencyController : ApiController
    {

        // GET api/<controller>/5
        public async Task<Currency> Get(string id)
        {
            DetailCurrencyRepository repository = new DetailCurrencyRepository();
            return await repository.get(id);
        }
    }
}