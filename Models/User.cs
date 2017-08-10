using System.ComponentModel.DataAnnotations;
using System;

namespace restauranter.Models{
    
    public class Person{
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
        
        public DateTime Visit {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public int Stars {get; set;}
        
      
        

        
    }
}