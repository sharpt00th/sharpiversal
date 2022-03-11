using System.ComponentModel.DataAnnotations;

namespace SimpleDotNetFourEightWebApi.Models
{
    public class TestConnectionRequest
    {
        [Required]
        public string InstanceUrl { get; set; }

        [Required]
        public string ClientId { get; set; }

        [Required]
        public string ClientSecret { get; set; }
    }
}