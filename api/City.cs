using System.ComponentModel.DataAnnotations.Schema;

namespace api {
    [Table("city")]
    public class City
    {
        [Column("city_id")]
        public int Id { get; set; }
        [Column("city")]
        public string Name { get; set; }
        [Column("country_id")]
        public int Country_ID { get; set; }
    }
}
