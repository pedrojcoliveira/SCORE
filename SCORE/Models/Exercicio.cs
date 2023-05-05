using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SCORE.Models;

[Table("Exercicio")]
public partial class Exercicio
{

    [Key]
    [Column("Id_Exercicio")]
    public int IdExercicio { get; set; }

    public string Titulo { get; set; }

    public string Descricao { get; set; }
    public string Tipo { get; set; } //Escolha múltipla, submissão de ficheiro ou resposta aberta


    public int Nota { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataEntrega { get; set; }

    [InverseProperty("IdExercicioNavigation")]
    public virtual ICollection<ExercicioUc> ExercicioUcs { get; } = new List<ExercicioUc>();
}
