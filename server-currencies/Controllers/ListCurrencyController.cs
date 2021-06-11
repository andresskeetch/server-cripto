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
    public class ListCurrencyController : ApiController
    {
        // GET api/<controller>
        public async Task<List<Currency>> Get()
        {
            ListCurrencyRepository repository = new ListCurrencyRepository();
            return await repository.get();
        }
    }
}