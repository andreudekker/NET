using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinformBDCompletainsertdeleteupdate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region listadeprocedure
        //     CREATE PROCEDURE sp_insertardatos
        //@nombre nvarchar(20),
        //@apellido nvarchar(20),
        //@telefono int
        //as	
        //BEGIN
        //    insert into persona
        //    (nombre,apellido,telefono)
        //     values(@nombre,@apellido,@telefono)
        //END
        //GO
        //exec  sp_insertardatos 'Andreu','Dekker','1234567'
       // select * from persona
        //SP_para eliminar registros
        //create procedure SP_eliminarRegistro
        //@id int output
        //as
        //delete from persona where id=@id
        //go
        /***************************************************************/
            //create procedure SP_eliminarRegistro
            //    @id int output
            //    as
            //    delete from persona where id=@id
            //    go
         //* /************************************************************/
         ////SP_PARA ELIMINAR EJEMPLO ESPECIAL
         //* create proc EliminarRegistro(@id int,@msj varchar(50) output) 
         //   as 
         //   begin 
         //   if(@id in(select id from persona)) 
         //   begin 
         //   delete from persona where id=@id
         //   set @msj='Registro eliminado' 
         //   end 
         //   else 
         //   set @msj='No existe el codigo en la base de datos' 
         //   end 
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
