using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class Book
    {
        

        public int BookID { get; set; }  // We can end a property with ID and it will take it as a primary key. or else, we can create with [Key] attribute.
        public string Title { get; set; } //question mark after string makes it a nullable column
        [MaxLength(20)]
        [Required]
        public string ISBN { get; set; }
        public double Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        /*//Foreign Key
        [ForeignKey("BookDetail")] //We specify Navigation name here as below. but, it can be anything.
        public int BookDetail_Id { get; set; }
        //Navigation Property
        //1 to Many relationship as Book is related to Bookdetail*/
        public BookDetail BookDetail { get; set; } //EF will see this and think there needs to be some kind of relationship.

        [ForeignKey("Publisher")]  
        public int Publisher_Id { get; set; }
        public Publisher Publisher { get; set; }

        public List <BookAuthorMap> BookAuthor { get; set; } //To create a list of authors for a specific book

    }
}
