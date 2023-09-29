using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Infrastructure.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public string PriceWithComma { get; set; }

    }
}
