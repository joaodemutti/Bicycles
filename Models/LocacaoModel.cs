using System;
using System.Linq;

namespace Bicycles.Models
{
    public class LocacaoModel
    {
        public int cod_locacao {get;set;}
        public string data_iniloc {get;set;}
        public string hora_iniloc {get;set;}
        public string data_fimloc {get;set;}
        public string hora_fimloc {get;set;}
        public int cod_bike {get;set;}
        public int cpf_cli {get;set;}

        public LocacaoModel(int cod_locacao,string data_iniloc,string hora_iniloc,string data_fimloc,string hora_fimloc,int cod_bike,int cpf_cli)
        {
            this.cod_locacao = cod_locacao; 
            this.data_iniloc = data_iniloc; 
            this.hora_iniloc = hora_iniloc; 
            this.data_fimloc = data_fimloc; 
            this.hora_fimloc = hora_fimloc; 
            this.cod_bike = cod_bike; 
            this.cpf_cli = cpf_cli; 
        }

        public LocacaoModel(string data_iniloc,string hora_iniloc,string data_fimloc,string hora_fimloc,int cod_bike,int cpf_cli)
        {
            this.cod_locacao = -1; 
            this.data_iniloc = data_iniloc; 
            this.hora_iniloc = hora_iniloc; 
            this.data_fimloc = data_fimloc; 
            this.hora_fimloc = hora_fimloc; 
            this.cod_bike = cod_bike; 
            this.cpf_cli = cpf_cli; 
        }
    }
}