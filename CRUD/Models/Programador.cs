using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD.Models
{
    [Table("Programadores")]
    public class Programador
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Skype { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Linkdin { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string SalarioHora { get; set; }
        public string SalarioMes { get; set; }
        [DefaultValue(0)]
        public int CSharp { get; set; }
        [DefaultValue(0)]
        public int Asp { get; set; }
        [DefaultValue(0)]
        public int Angular { get; set; }
        [DefaultValue(0)]
        public int Jquery { get; set; }
        [DefaultValue(0)]
        public int Bootstrap { get; set; }
        [DefaultValue(0)]
        public int Wordpress { get; set; }
        [DefaultValue(0)]
        public int Php { get; set; }
        [DefaultValue(0)]
        public int Android { get; set; }
        [DefaultValue(0)]
        public int Ios { get; set; }
        [DefaultValue(0)]
        public int Ionic { get; set; }
        public string Portifolio { get; set; }
        public string Linguagens { get; set; }
        public string Trabalhos { get; set; }
        public string GerenciadorWeb { get; set; }
        public string EditorImagem { get; set; }
        public string Interesse { get; set; }
        public string Curso { get; set; }
        public string Horas { get; set; }
        public string Horario { get; set; }
        [DefaultValue(false)]
        public bool CLT { get; set; }
        [DefaultValue(false)]
        public bool Freelancer { get; set; }
        [DefaultValue(false)]
        public bool Estagio { get; set; }
        public string Banco { get; set; }
        public string Comentarios { get; set; }
    }
}