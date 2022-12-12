using Dapper.Contrib.Extensions;

namespace Potluck.Models
{
    [Table("dish")]
    public class Dish
    {
        [Key]
        public int Id { get; set; }
        public string TMName { get; set; }
        public string PhoneNumber { get; set; }
        public string DishName { get; set; }
        public string DishDescription {get; set; }
        public string Category { get; set; }

    }
}
