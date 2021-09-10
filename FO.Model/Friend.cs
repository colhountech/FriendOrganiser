using System.ComponentModel.DataAnnotations;

namespace FO.Model
{
    // For changes to Data Annotations
    // remember that the updates won't ahppen
    // unless you reapply the Add-Migration with -Force
    // Add-Migration -Force "Initial Seed"
    public class Friend
    {
        //[Key]  add by convention because Id
        public int Id { get; set; }        
        [Required]
        [MaxLength(50)] // used for strings and arrays
        public string Firstname { get; set; }
        [MaxLength(50)]
        public string Lastname { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }


    }
}
