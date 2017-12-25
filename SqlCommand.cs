using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data
{
    public class SqlCommand : IDbCommand
    {
        private IDbCommand m_command;

        public string CommandText
        {
            get { return m_command.CommandText; }

            set { m_command.CommandText = value; }
        }

        public int CommandTimeout
        {
            get { return m_command.CommandTimeout; }

            set { m_command.CommandTimeout = value; }
        }

        public CommandType CommandType
        {
            get { return m_command.CommandType; }

            set { m_command.CommandType = value; }
        }

        public IDbConnection Connection
        {
            get { return m_command.Connection; }

            set { m_command.Connection = value; }
        }

        public IDataParameterCollection Parameters
        {
            get { return m_command.Parameters; }
        }

        public IDbTransaction Transaction
        {
            get { return m_command.Transaction;  }

            set { m_command.Transaction = value;  }
        }

        public UpdateRowSource UpdatedRowSource
        {
            get { return m_command.UpdatedRowSource;  }

            set { m_command.UpdatedRowSource = value; }
        }

        public void Cancel()
        {
            m_command.Cancel();
        }

        public IDbDataParameter CreateParameter()
        {
            return m_command.CreateParameter();
        }

        public void Dispose()
        {
            if (m_command != null)
            {
                m_command.Dispose();
                m_command = null;
            }
        }

        public int ExecuteNonQuery()
        {
            return m_command.ExecuteNonQuery();
        }

        IDataReader IDbCommand.ExecuteReader()
        {
            return new SqlDataReader(m_command.ExecuteReader());
        }

        public SqlDataReader ExecuteReader()
        {
            return new SqlDataReader(m_command.ExecuteReader());
        }

        IDataReader IDbCommand.ExecuteReader(CommandBehavior behavior)
        {
            return m_command.ExecuteReader(behavior);
        }

        public SqlDataReader ExecuteReader(CommandBehavior behaviour)
        {
            return new SqlDataReader(m_command.ExecuteReader());
        }

        public object ExecuteScalar()
        {
            return m_command.ExecuteScalar();
        }

        public void Prepare()
        {
            m_command.Prepare();
        }

        #region Constructor

        internal SqlCommand(IDbCommand command)
        {
            m_command = command;
        }

        #endregion
    }
}
