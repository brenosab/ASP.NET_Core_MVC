using System;
using System.ComponentModel.DataAnnotations;

namespace ASPNET_Core_MVC.Models
{
    public class Info
    {
        public int Id { get; set; }
        public string Environment { get; set; }
        public string Application { get; set; }
        public string Version { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
