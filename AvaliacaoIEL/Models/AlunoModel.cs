using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AvaliacaoIEL.Models
{
    public class AlunoModel
    {
        #region propiedades
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O Nome é obrigatório."),
            StringLength(100, MinimumLength = 10,
                          ErrorMessage = "Intervalo permitido de 10 a 100 caracteres.")]

        public string? Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório."),
            StringLength(11, MinimumLength = 11,
                          ErrorMessage = "O CPF precisa ter 11 digitos.")]
        public string? CPF { get; set; }

        [Required(ErrorMessage = "O Endereço é obrigatório."),
            StringLength(200, MinimumLength = 5,
                          ErrorMessage = "Intervalo permitido de 3 a 200 caracteres.")]
        public string? Endereco { get; set; }

        [Required(ErrorMessage = "O Cidade é obrigatório.")]
        public int CidadeID { get; set; }

      

        [Required(ErrorMessage = "A Instituição é obrigatória.")]
        public int InstituicaoID { get; set; }

      

        [Required(ErrorMessage = "O Nome do curso é obrigatório."),
            StringLength(100, MinimumLength = 5,
                          ErrorMessage = "Intervalo permitido de 5 a 100 caracteres.")]
        public string? NomeCurso { get; set; }

        [Required(ErrorMessage = "A Data de conclusão é obrigatória.")]
        public DateTime DataConclusao { get; set; }
        #endregion

       
    }
}
