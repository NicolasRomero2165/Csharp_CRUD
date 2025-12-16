using Integrador2025.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2025.Datos
{
    public class Dal
    {
        public DataSet ListaCliente()
        {
            string SQL = "SELECT * FROM CLIENTEINDIVIDUO;";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataset;
        }
        public DataSet ListaVendedores()
        {
            string SQL = "SELECT * FROM VENDEDOR;";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataset;
        }

        public DataSet ListaEmpresa()
        {
            string SQL = "SELECT * FROM CLIENTEEMPRESA;";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataset;
        }

        public DataSet ListaProductos()
        {
            string SQL = "SELECT * FROM PRODUCTO;";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataset;
        }

        public DataSet BuscarProducto(string pDetalle, string pCategoria)
        {
            string SQL = "SELECT * FROM PRODUCTO WHERE " + pCategoria + " LIKE '%" + pDetalle + "%';";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataset;
        }
        public DataSet BuscarVendedor(string pDetalle, string pCategoria)
        {
            string SQL = "SELECT * FROM VENDEDOR WHERE " + pCategoria + " LIKE '%" + pDetalle + "%';";
            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet objDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(objDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return objDataset;
        }
        private int identidad;
        public static SqlTransaction ObjTransaction = null;
        public int AgregarProducto(string pNombre, string pDescripcion, decimal pPrecioCosto, double pMargen, double pIva, decimal pPrecioBruto, decimal pPrecioVenta, string pProovedor, string pCategoria, string pSubcategoria)
        {
            string SQL = "INSERT INTO PRODUCTO(NOMBRE, DESCRIPCION, PRECIOCOSTO, MARGEN, IVA, PRECIOBRUTO, PRECIOVENTA, PROVEEDOR, CATEGORIA, SUBCATEGORIA)";
            SQL = SQL + "VALUES (@pNombre, @pDescripcion, @pPrecioCosto, @pMargen, @pIva, @pPrecioBruto, @pPrecioVenta, @pProovedor, @pCategoria, @pSubcategoria)";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 30).Value = pNombre;
            com.Parameters.Add("@pDescripcion", SqlDbType.VarChar, 240).Value = pDescripcion;
            com.Parameters.Add("@pPrecioCosto", SqlDbType.Decimal).Value = pPrecioCosto;
            com.Parameters.Add("@pMargen", SqlDbType.Float).Value = pMargen;
            com.Parameters.Add("@pIva", SqlDbType.Float).Value = pIva;
            com.Parameters.Add("@pPrecioBruto", SqlDbType.Decimal).Value = pPrecioBruto;
            com.Parameters.Add("@pPrecioVenta", SqlDbType.Decimal).Value = pPrecioVenta;
            com.Parameters.Add("@pProovedor", SqlDbType.VarChar, 30).Value = pProovedor;
            com.Parameters.Add("@pCategoria", SqlDbType.VarChar, 16).Value = pCategoria;
            com.Parameters.Add("@pSubcategoria", SqlDbType.VarChar, 16).Value = pSubcategoria;

            try
            {
                con.Open();
                ObjTransaction = con.BeginTransaction();
                com.Transaction = ObjTransaction;

                com.ExecuteNonQuery();
                identidad = Convert.ToInt32(retParam.Value);
                ObjTransaction.Commit();
            }
            catch (SqlException ex)
            {
                ObjTransaction.Rollback();
                throw new Exception("Error en base de datos " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                com.Dispose();
            }
            return identidad;
        }

            public int AgregarVendedor(string pNombre, string pApellido, string pDni, string pCuit)
        {
            string SQL = "INSERT INTO VENDEDOR(NOMBRE, APELLIDO, DNI, CUIT)";
            SQL = SQL + "VALUES (@pNombre, @pApellido, @pDni, @pCuit)";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 30).Value = pNombre;
            com.Parameters.Add("@pApellido", SqlDbType.VarChar, 30).Value = pApellido;
            com.Parameters.Add("@pDni", SqlDbType.VarChar, 8).Value = pDni;
            com.Parameters.Add("@pCuit", SqlDbType.VarChar, 13).Value = pCuit;

            try
            {
                con.Open();
                ObjTransaction = con.BeginTransaction();
                com.Transaction = ObjTransaction;

                com.ExecuteNonQuery();
                identidad = Convert.ToInt32(retParam.Value);
                ObjTransaction.Commit();
            }
            catch (SqlException ex)
            {
                ObjTransaction.Rollback();
                throw new Exception("Error en base de datos " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                com.Dispose();
            }
            return identidad;
        }
        public int ModificarProductos(int id, string pNombre, string pDescripcion, decimal pPrecioCosto, double pMargen, double pIva, decimal pPrecioBruto, decimal pPrecioVenta, string pProovedor, string pCategoria, string pSubcategoria)
        {
            string SQL =
                @"UPDATE PRODUCTO SET
                NOMBRE = @pNombre,
                DESCRIPCION = @pDescripcion,
                PRECIOCOSTO = @pPrecioCosto,
                MARGEN = @pMargen,
                IVA = @pIva,
                PRECIOBRUTO = @pPrecioBruto,
                PRECIOVENTA = @pPrecioVenta,
                PROVEEDOR = @pProovedor,
                CATEGORIA = @pCategoria,
                SUBCATEGORIA = @pSubcategoria WHERE ID_PRODUCTO = " + id + ";";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 30).Value = pNombre;
            com.Parameters.Add("@pDescripcion", SqlDbType.VarChar, 240).Value = pDescripcion;
            com.Parameters.Add("@pPrecioCosto", SqlDbType.Decimal).Value = pPrecioCosto;
            com.Parameters.Add("@pMargen", SqlDbType.Float).Value = pMargen;
            com.Parameters.Add("@pIva", SqlDbType.Float).Value = pIva;
            com.Parameters.Add("@pPrecioBruto", SqlDbType.Decimal).Value = pPrecioBruto;
            com.Parameters.Add("@pPrecioVenta", SqlDbType.Decimal).Value = pPrecioVenta;
            com.Parameters.Add("@pProovedor", SqlDbType.VarChar, 30).Value = pProovedor;
            com.Parameters.Add("@pCategoria", SqlDbType.VarChar, 16).Value = pCategoria;
            com.Parameters.Add("@pSubcategoria", SqlDbType.VarChar, 16).Value = pSubcategoria;

            try
            {
                con.Open();
                ObjTransaction = con.BeginTransaction();
                com.Transaction = ObjTransaction;

                com.ExecuteNonQuery();
                identidad = Convert.ToInt32(retParam.Value);
                ObjTransaction.Commit();
            }
            catch (SqlException ex)
            {
                ObjTransaction.Rollback();
                throw new Exception("Error en base de datos " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                com.Dispose();
            }
            return identidad;
        }
        public int ModificarVendedor(int id, string pNombre, string pApellido, string pDni, string pCuit)
        {
            string SQL =
                @"UPDATE VENDEDOR SET
                NOMBRE = @pNombre,
                APELLIDO = @pApellido,
                DNI = @pDni,
                CUIT = @pCuit
                WHERE ID_VENDEDOR = " + id + ";";

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            SqlCommand com = new SqlCommand(SQL, con);
            SqlParameter retParam = com.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            retParam.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("@pNombre", SqlDbType.VarChar, 30).Value = pNombre;
            com.Parameters.Add("@pApellido", SqlDbType.VarChar, 30).Value = pApellido;
            com.Parameters.Add("@pDni", SqlDbType.VarChar, 8).Value = pDni;
            com.Parameters.Add("@pCuit", SqlDbType.VarChar, 13).Value = pCuit;

            try
            {
                con.Open();
                ObjTransaction = con.BeginTransaction();
                com.Transaction = ObjTransaction;

                com.ExecuteNonQuery();
                identidad = Convert.ToInt32(retParam.Value);
                ObjTransaction.Commit();
            }
            catch (SqlException ex)
            {
                ObjTransaction.Rollback();
                throw new Exception("Error en base de datos " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.Dispose();
                com.Dispose();
            }
            return identidad;
        }
        public DataSet EliminarProducto(int Id)
        {
            string SQL = "DELETE FROM PRODUCTO WHERE ID_PRODUCTO=" + Id + ";";  //QUERY

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet ObjDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(ObjDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return ObjDataset;
        }
        public DataSet EliminarVendedor(int Id)
        {
            string SQL = "DELETE FROM VENDEDOR WHERE ID_VENDEDOR = " + Id + ";";  //QUERY

            SqlConnection con = new SqlConnection(Conexion.sConnection);
            DataSet ObjDataset = new DataSet();
            SqlCommand com = new SqlCommand(SQL, con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = com;

            try
            {
                da.Fill(ObjDataset);
            }
            catch (SqlException ex)
            {
                throw new Exception("Error en la base de datos" + ex.Message);
            }
            finally
            {
                con.Dispose();
                com.Dispose();
            }
            return ObjDataset;
        }
    }
    }

