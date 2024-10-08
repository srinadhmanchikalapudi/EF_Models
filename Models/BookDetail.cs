using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetail_Id { get; set; }
        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }

        [ForeignKey("Book")] //We specify Navigation name here as below. but, it can be anything.

        public int BookID { get; set; }
        //Navigation Property
        //1 to Many relationship as Book is related to Bookdetail
        public Book Book { get; set; }

    }
}
