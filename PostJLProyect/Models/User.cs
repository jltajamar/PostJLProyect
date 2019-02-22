using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PostJLProyect.Models
{
    public class User
    {

        [Key]
        [Column("idUser")]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id { get; set; }

        [Column("Name")]
        public String Name { get; set; }

        [Column("Surname")]
        public String Surname { get; set; }

        [Column("Password")]
        public String Password { get; set; }



    }
}