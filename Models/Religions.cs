using System.ComponentModel.DataAnnotations;

namespace StudentData.Models
{
    public class Religions
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ReligionId { get; set;}
    }
}
