using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace trabajoPractico
{
  static   class BD_ABM_ALMACEN
    {
      //   static SqlConnection CN = new SqlConnection("Data Source= 172.16.1.32; Initial Catalog= Blanc_Usay; user id= Blanc");
   static SqlConnection CN = new SqlConnection("Data Source=.\\sqlexpress; Initial Catalog=Guia1_lab; Integrated Security=SSPI");

      static private void Conectar()
       {

           if (CN.State == ConnectionState.Closed)
               CN.Open();
       }

      static private void Desconectar()
       {
           if (CN.State == ConnectionState.Open)
               CN.Close();
           else throw new ArgumentException("Error en la conexión");
           
       }

     static  public DataTable CargarRubros()
       {

           DataTable DTrubro = new DataTable();
           SqlDataReader reader;

           SqlCommand cmd = new SqlCommand("select * from RUBROS",CN);
           //cmd.Connection = CN;

           //cmd.CommandText = ;
           Conectar();

           reader = cmd.ExecuteReader();

           DTrubro.Load(reader);
           Desconectar();
           return DTrubro;
         
       }

 
      static public void AgregarRubro(Rubros oRubro)
      {
          SqlCommand  cmd = new SqlCommand();
          
          cmd.CommandText = "insert into RUBROS values ('" + oRubro.Nombre + "')";
          cmd.Connection = CN;
          Conectar();
          cmd.ExecuteNonQuery();
          Desconectar();
      }
      static public void AgregarProducto(producto oProducto)
      {

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = CN;

          cmd.CommandText = "insert into PRODUCTOS(CodProducto,Nombre,StockActual,IdRubro) values ("+ oProducto.codigoProducto +",'"+ oProducto.Nombre +"',"+ oProducto.stockActual+ "," + oProducto.idRubro + ")";
          Conectar();
          cmd.ExecuteNonQuery();
          Desconectar();
      }


      static public void BorrarProducto(int cod)
      {

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = CN;
          cmd.CommandText = "delete from PRODUCTOS where CodProducto = " + cod.ToString(); 
          Conectar();
          cmd.ExecuteNonQuery();
          Desconectar();
      }

        static public void BorrarRubro(int cod)
      {

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = CN;

          cmd.CommandText = "delete from RUBROS where idRubro =" + cod.ToString(); 
          Conectar();
          cmd.ExecuteNonQuery();
          Desconectar();
      }


      static public void modificarProducto(producto oProducto)
      {

          SqlCommand cmd = new SqlCommand();
          cmd.Connection = CN;
          cmd.CommandText= "update PRODUCTOS set Nombre= '" + oProducto.Nombre + "',StockActual= " +oProducto.stockActual + "where CodProducto=" + oProducto.codigoProducto; 
          Conectar();
          cmd.ExecuteNonQuery();
          Desconectar();

      }

      static public DataTable buscarProductosxNombre(string busqueda)
      {
          DataTable DT = new DataTable();
          SqlDataReader DR;
          SqlCommand cmd = new SqlCommand();
          cmd.Connection = CN;
          cmd.CommandText = "select * from PRODUCTOS where Nombre like '" + busqueda + "%'";
          Conectar();
          DR = cmd.ExecuteReader();
          DT.Load(DR);
          Desconectar();
          return DT;

      }

      

    }
}







    

