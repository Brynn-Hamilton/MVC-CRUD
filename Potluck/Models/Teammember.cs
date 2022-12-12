using Dapper.Contrib.Extensions;

namespace Potluck.Models
{
    [Table("teammember")]
    public class Teammember
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AttendanceDate { get; set; }
        public string GuestName { get; set; }

    }
}
