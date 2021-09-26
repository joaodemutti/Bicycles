using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace 
Bicycles
{
   
    public class Banco
    {
        List<String> list;
        public MySqlCommand cmd;
        public MySqlConnection connection;
        public MySqlDataReader dataReader;
        private bool connected = false;
        private string connectionString;

        public Banco()
        {
            connectionString = "SERVER=localhost;DATABASE=bicycles;UID=joaodemutti;PASSWORD=joao2003;";
            connection = new MySqlConnection(connectionString);
            cmd = new MySqlCommand();
            cmd.Connection = connection;
        }
        private bool Start()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
         
        }
        private bool End()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
        public bool TestConnection()
        {
            if(Start())
            {
                End();
                return true;
            }
            return false;
	}       
        
    public bool executeCommand(string command)
    {
    	if(Start()){
    		this.cmd.CommandText = command;
		try{this.cmd.ExecuteNonQuery();}
		catch(Exception e){End();return false;}
		End();
		return true;
    	} 
	return false;
    }
    
    }

}