using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Data.OleDb;
namespace ScarpBarcode.DataAccess
{
    public class AccessDataHelper : ConnectionHelper
    {
        const int COMMAND_TIMEOUT = 30 * 20;

        #region Common Methods to Execute Stored Functions

        public DataSet ExecuteStoredProcedure(string procedureName, OleDbParameter[] para, CommandType commandType = CommandType.StoredProcedure)
        {
            using (OleDbConnection connection = new OleDbConnection(AccessConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandTimeout = COMMAND_TIMEOUT;
                cmd.CommandType = commandType;
                cmd.Connection = connection;
                cmd.Connection.Open();

                cmd.CommandText = procedureName;

                if (para != null && para.Length > 0) cmd.Parameters.AddRange(para);

                OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                cmd.Connection.Close();

                return ds;
            }
        }
        public DataTable ExecuteStoredProcedureDataTable(string procedureName, OleDbParameter[] para, CommandType commandType = CommandType.StoredProcedure)
        {
            var ds = ExecuteStoredProcedure(procedureName, para, commandType);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ds.Tables[0];
            }
            else
                return null;
        }

        public List<T> ExecuteStoredProcedure<T>(string procedureName, OleDbParameter[] para, CommandType commandType = CommandType.StoredProcedure)
        {
            var ds = ExecuteStoredProcedure(procedureName, para, commandType);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ConvertToList<T>(ds.Tables[0]);
            }
            else
                return null;
        }

        public List<T> ExecuteStoredQuery<T>(string procedureName, OleDbParameter[] para)
        {
            var ds = ExecuteStoredProcedure(procedureName, para);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                return ConvertToList<T>(ds.Tables[0]);
            }
            else
                return null;
        }

        public Object ExecuteScaler(string procedureName, OleDbParameter[] para, CommandType commandType = CommandType.StoredProcedure)
        {
            using (OleDbConnection connection = new OleDbConnection(AccessConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandTimeout = COMMAND_TIMEOUT;
                cmd.CommandType = commandType;
                cmd.Connection = connection;
                cmd.Connection.Open();

                cmd.CommandText = procedureName;

                if (para != null && para.Length > 0) cmd.Parameters.AddRange(para);

                object value = cmd.ExecuteScalar();

                cmd.Connection.Close();

                return value;
            }
        }

        public int ExecuteNonQuery(string procedureName, OleDbParameter[] para, CommandType commandType = CommandType.StoredProcedure)
        {
            using (OleDbConnection connection = new OleDbConnection(AccessConnectionString))
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandTimeout = COMMAND_TIMEOUT;
                cmd.CommandType = commandType;
                cmd.Connection = connection;
                cmd.Connection.Open();

                cmd.CommandText = procedureName;

                if (para != null && para.Length > 0) cmd.Parameters.AddRange(para);

                int value = cmd.ExecuteNonQuery();

                cmd.Connection.Close();

                return value;
            }
        }

        public List<T> ConvertToList<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }

        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        public DataTable ConvertToDataTable<T>(IEnumerable<T> iList)
        {
            DataTable dataTable = new DataTable();
            PropertyDescriptorCollection propertyDescriptorCollection =
                TypeDescriptor.GetProperties(typeof(T));
            for (int i = 0; i < propertyDescriptorCollection.Count; i++)
            {
                PropertyDescriptor propertyDescriptor = propertyDescriptorCollection[i];
                Type type = propertyDescriptor.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
                    type = Nullable.GetUnderlyingType(type);


                dataTable.Columns.Add(propertyDescriptor.Name, type);
            }
            object[] values = new object[propertyDescriptorCollection.Count];
            foreach (T iListItem in iList)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = propertyDescriptorCollection[i].GetValue(iListItem);
                }
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        #endregion
    }
}
