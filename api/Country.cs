using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace api {
    [Table("country")]
    public class Country
    {
        [Column("country_id")]
        public int Id { get; set; }
        [Column("country")]
        public string Name { get; set; }
    }
}
