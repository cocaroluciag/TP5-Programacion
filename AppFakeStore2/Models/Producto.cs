using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFakeStore2.Models;

public class Producto
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public decimal price { get; set; }
    public string category { get; set; }
    public string image { get; set; }
    public Rating rating { get; set; }
}
