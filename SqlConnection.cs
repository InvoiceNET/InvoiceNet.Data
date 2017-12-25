using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data
{
    public class SqlConnection : IDbConnection
    {
        #region Variables

        private IDbConnection m_connection;

        #endregion

        #region Properties

        public string ConnectionString
        {
            get
            {
                return m_connection.ConnectionString;
            }

            set
            {
                m_connection.ConnectionString = value;
            }
        }

        public int ConnectionTimeout
        {
            get
            {
                return m_connection.ConnectionTimeout;
            }
        }

        public string Database
        {
            get
            {
                return m_connection.Database;
            }
        }

        public ConnectionState State
        {
            get
            {
                return m_connection.State;
            }
        }

        #endregion

        #region Methods

        public IDbTransaction BeginTransaction()
        {
            return m_connection.BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return m_connection.BeginTransaction(il);
        }

        public void ChangeDatabase(string databaseName)
        {
            m_connection.ChangeDatabase(databaseName);
        }

        public void Close()
        {
            m_connection.Close();
        }

        IDbCommand IDbConnection.CreateCommand()
        {
            return new SqlCommand(m_connection.CreateCommand());
        }

        public SqlCommand CreateCommand()
        {
            return new SqlCommand(m_connection.CreateCommand());
        }

        public void Dispose()
        {
            if (m_connection != null)
            {
                if (m_connection.State != ConnectionState.Closed)
                {
                    m_connection.Close();
                }
               
                m_connection.Dispose();
                m_connection = null;
            }
        }

        public void Open()
        {
            m_connection.Open();
        }

        #endregion

        #region Constructors

        public SqlConnection(IDbConnection connection)
        {
            m_connection = connection;
        }

        #endregion
    }
}
