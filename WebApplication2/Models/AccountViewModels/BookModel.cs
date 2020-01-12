using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.AccountViewModels
{
    [Table("Books")]
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public virtual ICollection<ReviewModel> Reviews { get; set; }

    }

    [Table("Reviews")]
    public class ReviewModel
    {
        [Key]
        public int ReviewId { get; set; }
        [ForeignKey("Books")]
        public int BookId { get; set; }
        public string Comment { get; set; }

    }
}
