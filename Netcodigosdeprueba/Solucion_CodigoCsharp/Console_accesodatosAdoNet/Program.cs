using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; //para la cadena de texto conexion BD en xml

namespace Console_accesodatosAdoNet
{
    public enum Tabla_SQl
    {
        vStoreWithContacts =1,
        ScrapReason=2,
        vStoreWithAddresses=3,
        vVendorWithContacts=4,
        Shift=5,
        vVendorWithAddresses=6,
        ProductCategory=7,
        ShipMethod=8,
        ProductCostHistory=9,
        ProductDescription=10,
        ShoppingCartItem=11,
        ProductDocument=12,
        DatabaseLog=13,
        ProductInventory=14,
        SpecialOffer=15,
        ErrorLog=16,
        ProductListPriceHistory=17,
        Address=18,
        SpecialOfferProduct=19,
        ProductModel=20,
        AddressType=21,
        StateProvince=22,
        ProductModelIllustration=23,
        AWBuildVersion=24,
        ProductModelProductDescriptionCulture=25,
        BillOfMaterials=26,
        Store =27,
        ProductPhoto=28,
        ProductProductPhoto =29,
        TransactionHistory =30,
        ProductReview=31,
        vSalesPersonSalesByFiscalYears_2006_2008 =32,
        BusinessEntity =33,
        TransactionHistoryArchive =34,
        ProductSubcategory =35,
        BusinessEntityAddress =36,
        ProductVendor =37,
        BusinessEntityContact =38,
        UnitMeasure =39,
        Vendor =40,
        ContactType =41,
        CountryRegionCurrency =42,
        CountryRegion=43,
        WorkOrder=44,
        PurchaseOrderDetail=45,
        CreditCard = 46,
        Culture = 47
    }
     
    class Program
    {
        static void Main(string[] args)
        {
            string StrCn = ConfigurationManager.ConnectionStrings["SQlserver"].ConnectionString;
            SqlConnection cnn = new SqlConnection(StrCn); //lineaconsultaalaBD

            #region Estado de la conexion
            //cnn.StateChange += cnn_StateChange;   //Estado de la conexion (open ó close)
                //cnn.Open();
            //cnn.Close();  
            #endregion
                cnn.Open();
                DataTable tbltablas = cnn.GetSchema("Tables");
               
                 DataView dv = tbltablas.DefaultView;
                dv.RowFilter = "TABLE_TYPE ='BASE TABLE' ";
                dv.Sort="TABLE_NAME ASC";
                
               tbltablas= dv.ToTable();

               Console.WriteLine("Seleccione su tabla a visualizar:");

               int posicion = 0;
               foreach (DataRow item in tbltablas.Rows)
               {
                   posicion++;
                   Console.WriteLine(posicion.ToString() + ":" + item["TABLE_NAME"].ToString());
               }

               Console.WriteLine();
               Console.Write("Ingrese Codigo de la tabla para visualizar:");
               int intTabla = Convert.ToInt32(Console.ReadLine());

               Tabla_SQl tb = (Tabla_SQl)intTabla;
               string tabla = Enum.GetName(typeof(Tabla_SQl), tb);
               string SQl = "sp_pruebadedatos" + tabla;  //storeprocedure
               SqlDataAdapter dap = new SqlDataAdapter(SQl, cnn);
               dap.SelectCommand.CommandType = CommandType.StoredProcedure;
               dap.SelectCommand.Parameters.AddWithValue("TABLA",tabla); //tomamos el stringtabla para que haga las busquedas.
                DataTable tblinfo = new DataTable();
               
               dap.Fill(tblinfo);

               for (int i = 0; i < tblinfo.Rows.Count; i++)
               {
                   string strinfo = "";
                   for (int j = 0; j < tblinfo.Columns.Count; j++)
                   {
                       strinfo += tblinfo.Rows[i][j].ToString() + "\t";
                   }
                   Console.WriteLine(strinfo);
               }
               
            
            
              Console.ReadLine();

        }

        //static void cnn_StateChange(object sender, StateChangeEventArgs e)
        //{
        //    Console.WriteLine(e.OriginalState + "\t" + e.CurrentState);
        //}
    }

     
}

