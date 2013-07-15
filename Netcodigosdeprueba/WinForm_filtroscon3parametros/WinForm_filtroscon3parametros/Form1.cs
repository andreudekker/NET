using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WinForm_filtroscon3parametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(WinForm_filtroscon3parametros.Properties.Settings.Default.NwCn);
        //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["NwCn"].ConnectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Sp_Paises
                    //alter  proc SP_Paises
                    //as
                    // select 'Seleccione' AS Country Union All 
                    // select distinct country from Customers
                    // /*distinct elimina registros duplicados*/
                    //go

                    //SP_Paises
                //alter proc sp_clienteporpais
                //@pais nvarchar(30)
                //as
                //select CustomerID,CompanyName,ContactTitle,City
                //region,Country
                // from Customers where Country=@pais

                //go
                //sp_clienteporpais 'Argentina'

            ///*******CON TECNICA DE BUSQUEDA**********////////////////////
            ///create procedure sp_BuscarCliente
            //@codigo Char(5),
            //@Nombre VARCHAR(40),
            //@Pais Varchar(30)
            //as
            //    Select CustomerID,CompanyName,ContactTitle,Country
	 
            //     from Customers
            //     Where (@codigo='' Or CustomerID=@codigo)
            //     and (@Nombre='' Or CompanyName like @Nombre+'%')
            //     and (@Pais='' or Country=@Pais)
            //     sp_BuscarCliente '','',''
            //he aqui una variante q obtiene los mismos resulstado
            //isnull(tabla.campo﻿ ,0)=isnull(@filtro , isnull(tabla.campo,0) ) and mas filtros

#endregion

            SqlDataAdapter dap = new SqlDataAdapter("SP_Paises", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tbl = new DataTable();
            dap.Fill(tbl);
            cboPais.DataSource = tbl;
            cboPais.DisplayMember = "Country";


        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("sp_BuscarCliente", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("Codigo", txtCodigo.Text);
            cmd.Parameters.AddWithValue("Nombre", txtNombre.Text);
            string strPais = (cboPais.Text == "Seleccione" ? " " : cboPais.Text); //condicionar
            cmd.Parameters.AddWithValue("pais", strPais);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            DataTable tblClientes = new DataTable();
            dap.Fill(tblClientes);
            dgvClientes.DataSource = tblClientes;
        }
    }
}
