﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Models.Models
{
    public class BookAuthorMap
    {
        //[Key] 
        //public int BookAuthor_Id;
        [ForeignKey("Book")]
        public int BookID { get; set; }
        [ForeignKey("Author")]
        public int Author_Id { get; set; }

        public Book Book { get; set; }
        public Author Author { get; set; }

    }
}
