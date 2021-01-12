using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkDemo.Model
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] // pasakoma, kad Id yra primary key ir jis identity
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Deleted { get; set; } = false;

    }
}
