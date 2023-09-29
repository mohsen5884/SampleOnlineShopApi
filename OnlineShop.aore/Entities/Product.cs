using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnlineShop.Core.Entities;
[Table("Products", Schema = "SLS")]
public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(128)]
    public string ProductName { get; set; }
    public long Price { get; set; }
}
