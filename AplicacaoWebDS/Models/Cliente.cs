using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;



namespace AplicacaoWebDS.Models
{
    public class Cliente
    {
        private int CodCliente { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Por favor preencha o campo Nome do Cliente")]
        [StringLength(50, MinimumLength = 3)]
        public string Nome { get; set; }


        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Por favor preencha o campo Endereço")]
        // [StringLength(50, MinimumLength = 4)]
        public string Endereco { get; set; }


        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Por favor preencha o campo Telefone")]
        [StringLength(12)]
        public string Telefone { get; set; }


        [Display(Name = "Email")]
        [Required(ErrorMessage = "Por favor preencha o campo Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string Email { get; set; }


        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Por favor preencha o campo CPF")]
        [StringLength(11)]
        public string CPF { get; set; }


        [Display(Name = "Data Nascimento")]
        [Required(ErrorMessage = "Por favor preencha o campo Data Nascimento")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNasc { get; set; }

    }
}