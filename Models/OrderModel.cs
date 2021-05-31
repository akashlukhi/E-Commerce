using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce.Models
{
    public class OrderModel
    {
        [Key]
        [ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }
        public float Amount { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public DateTime date { get; set; }
    }
}
