using System;
using System.ComponentModel.DataAnnotations;

namespace Bicycles.Models
{
    public class FuncionarioModel
    {
        public Nullable<int> cpf_fun {get;set;}
        public string nome_fun {get;set;}
        public string telefone_fun {get;set;}
        public string email_fun {get;set;}
        [Display(Name = "Login")]
        [Required(ErrorMessage = "Informe o nome do usuário", AllowEmptyStrings = false)]
        public string login_fun {get;set;}
        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Informe a senha do usuário", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string senha_fun {get;set;}
        public Nullable<int> cep_end {get;set;}

        public FuncionarioModel(int cpf_fun,string nome_fun,string telefone_fun,string email_fun,string login_fun,string senha_fun,int cep_end)
        {
            this.cpf_fun = cpf_fun;
            this.nome_fun = nome_fun;
            this.telefone_fun = telefone_fun;
            this.email_fun = email_fun;
            this.login_fun = login_fun;
            this.senha_fun = senha_fun;
            this.cep_end = cep_end;
        }

        public FuncionarioModel()
        {
            this.cpf_fun = null;
            this.nome_fun = null;
            this.telefone_fun = null;
            this.email_fun = null;
            this.login_fun = null;
            this.senha_fun = null;
            this.cep_end = null;
        }

    }
}