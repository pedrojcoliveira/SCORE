using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SCORE.Models
{
    public class FileViewModel
    {
        [Key]
        [Required]

        //Colocar aqui o Nome do aluno como Required
       
        public string Name { get; set; }

        [Display(Name = "Size in Bytes")]
        public long Size { get; set; }
    }
}
