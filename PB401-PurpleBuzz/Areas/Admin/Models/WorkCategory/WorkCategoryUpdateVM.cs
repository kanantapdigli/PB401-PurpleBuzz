using System.ComponentModel.DataAnnotations;

namespace PB401_PurpleBuzz.Areas.Admin.Models.WorkCategory
{
    public class WorkCategoryUpdateVM
    {
        [Required(ErrorMessage = "Ad daxil edilməlidir")]
        [MinLength(3, ErrorMessage = "Adın minimum uzunluğu 3 simvol olmalıdır")]
        [Display(Name = "Title")]
        public string Name { get; set; }
    }
}
