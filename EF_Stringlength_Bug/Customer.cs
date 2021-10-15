using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EF_Stringlength_Bug
{
    [Index(nameof(CustomerRecord.Name), IsUnique = true)]
    public record CustomerRecord(
        int Id,
        [MaxLength(50)]
        //[StringLength(50)]
        string Name
    );

    [Index(nameof(CustomerRecord.Name), IsUnique = true)]
    public class CustomerClass
    {
        public int Id { get; init; }

        [MaxLength(50)]
        //[StringLength(50)]
        public string Name { get; init; }
    }
}
