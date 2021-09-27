using System;

namespace Bicycles.Models
{
    public class ClienteModel
    {
        public Nullable<int> cpf_cli {get;set;}
        public string nome_cli {get;set;}
        public string telefone_cli {get;set;}
        public string email_cli {get;set;}
        public Nullable<int> cep_end {get;set;}

        public ClienteModel(int cpf_cli,string nome_cli,string telefone_cli,string email_cli,int cep_end)
        {
            this.cpf_cli = cpf_cli;
            this.nome_cli = nome_cli;
            this.telefone_cli = telefone_cli;
            this.email_cli = email_cli;
            this.cep_end = cep_end;            
        }

        public ClienteModel()
        {
            this.cpf_cli = null;
            this.nome_cli = null;
            this.telefone_cli = null;
            this.email_cli = null;
            this.cep_end = null;            
        }
        
    }
}