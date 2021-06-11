using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using server_currencies.Models;
using server_currencies.Providers;
using System.Threading.Tasks;

namespace server_currencies.Repositories
{
	public class ListCurrencyRepository
	{
		public async Task<List<Currency>> get()
        {
            CurrencyProvider provider = new CurrencyProvider();

            return await provider.getList();
        }
    }
}