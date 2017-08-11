using System.ComponentModel.DataAnnotations;
using System;

namespace restauranter.Models{
    
    public class Person{
        [Key]
        public int iduser {get;set;}

        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string UserName {get; set;}

        [Required]
        [MinLength(2)]
        [RegularExpression(@"^[a-zA-Z]+$")]
        public string RestauName {get; set;}


        [Required]
        public string Review { get; set; }
 
        [Required]
        
        public DateTime VisitDate {get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}
        public int Stars {get; set;}
        
      
        

        
    }
}