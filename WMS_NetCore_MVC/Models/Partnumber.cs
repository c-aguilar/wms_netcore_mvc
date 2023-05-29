using System.ComponentModel.DataAnnotations;

namespace WMS_NetCore_MVC.Models
{
    public class Partnumber
    {
        [Key]
        public string Id { get; set; }
        public string Description { get; set; }
    }
}
