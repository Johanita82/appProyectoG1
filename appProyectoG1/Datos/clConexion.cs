﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace appProyectoG1.Datos
{
    public class clConexion
    {

        SqlConnection conexion;
        public clConexion()
        {
            conexion = new SqlConnection("Data Source=LAPTOP-0DVIKOLF\\SQLEXPRESS01;Initial Catalog=dbProyectog1;Integrated Security=True");
            conexion.Open();
        }

        public DataTable mtdDesconectado(string sql) //select
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }

        public int mtdConectar(string sql) //Insert, Update, Delete
        {
            SqlCommand comando = new SqlCommand(sql, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;

        }
    }
}