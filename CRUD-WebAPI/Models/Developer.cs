using System.Runtime.InteropServices;
using System.IO;
using System.Data.SqlTypes;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;
using static CRUD_WebAPI.Utils.Mensagens;

namespace CRUD_WebAPI.Models
{
    public class Developer
    {
        public Developer() { }
        public Developer(int id, string nome, char sexo, int idade, string hobby, string dataNascimento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Idade = idade;
            this.Hobby = hobby;
            this.DataNascimento = dataNascimento;
        }
        [Key]
        public int? Id { get; set; }

        [RegularExpression("^[a-z A-Z]*$", ErrorMessage = NomeInvalido)]
        [Required(ErrorMessage = CampoObrigatorio)]
        public string Nome { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [RegularExpression(@"^[f-fF-Fm-mM-M]*$", ErrorMessage = SexoInvalido)]
        public char Sexo { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        [Range(1, 99, ErrorMessage = IdadeInvalida)]
        public int Idade { get; set; }

        [Required(ErrorMessage = CampoObrigatorio)]
        public string Hobby { get; set; }

        [Display(Name = "Data de nascimento")]
         
        [Required(ErrorMessage = CampoObrigatorio)]
        [StringLength(10, ErrorMessage = FormatoDataInvalido, MinimumLength = 10)]
        [RegularExpression("[0-9]+\\/[0-9]+\\/[0-9]+", ErrorMessage = FormatoDataInvalido)]

        public string DataNascimento { get; set; }

    }
}