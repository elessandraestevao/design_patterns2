﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap1
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection(){
            IDbConnection conexao = new SqlConnection();
            conexao.ConnectionString = "User Id=root;Password=teste;Server=localhost;Database=banco";
            conexao.Open();
            return conexao;
        }        
    }
}
