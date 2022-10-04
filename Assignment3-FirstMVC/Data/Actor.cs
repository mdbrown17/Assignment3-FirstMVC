using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment3_FirstMVC.Data
{
    public class Actor
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public int? Age { get; set; }
        public string? ImdbHyperLink { get; set; }
        public string? Photo { get; set; }

        [ForeignKey("Movie")]
        public int? MovieID { get; set; }
        public Movie? Movie { get; set; }
    }
}
