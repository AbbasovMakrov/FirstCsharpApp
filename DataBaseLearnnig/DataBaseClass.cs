using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataBaseLearnnig
{
    class DataBaseClass
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private DataSet dataSet = new DataSet();
        private DataTable dataTable = new DataTable();
        //constructer
     //public  string x
     //   {
     //       get;
     //       set;
     //   }
        public DataBaseClass(string DataSource, bool IntegratedSecurity, string database)
        {
          
            SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder();
            sqlConnection.DataSource = DataSource;
            sqlConnection.IntegratedSecurity = IntegratedSecurity;
            sqlConnection.InitialCatalog = database;
            connection = new SqlConnection(sqlConnection.ConnectionString);
          //  x = sqlConnection.ConnectionString;
        }

        // Properties
        public SqlConnection connectionProperty
        {

            get { return this.connection; }
            set { this.connection = value; }
        }
        public SqlCommand sqlCommand
        {
            get { return this.command; }
            set { this.command = value; }
        }
        public SqlDataReader dataReader
        {
            get { return this.reader; }
            set { this.reader = value; }
        }
        public DataSet dataSet_Property
        {
            get { return this.dataSet; }
            set { this.dataSet = value; }
        }
        public SqlDataAdapter adapter_Property
        {
            get { return this.adapter; }
            set { this.adapter = value; }
        }
        public DataTable dataTable_Property
        {
            get { return this.dataTable; }
            set { this.dataTable = value; }
        }
    }
}
