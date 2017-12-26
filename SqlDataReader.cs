using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceNet.Data
{
    public class SqlDataReader : IDataReader
    {
        IDataReader m_dataReader;

        #region Properties

        public object this[string name]
        {
            get
            {
                return m_dataReader[name];
            }
        }

        public object this[int i]
        {
            get
            {
                return m_dataReader[i];
            }
        }

        public int Depth
        {
            get
            {
                return m_dataReader.Depth;
            }
        }

        public int FieldCount
        {
            get
            {
                return m_dataReader.FieldCount;
            }
        }

        public bool IsClosed
        {
            get
            {
                return m_dataReader.IsClosed;
            }
        }

        public int RecordsAffected
        {
            get
            {
                return m_dataReader.RecordsAffected;
            }
        }

        #endregion

        #region Methods

        public void Close()
        {
            m_dataReader.Close();
        }

        public void Dispose()
        {
            if (m_dataReader != null)
            {
                if (!m_dataReader.IsClosed)
                {
                    m_dataReader.Close();
                }
                m_dataReader.Dispose();
                m_dataReader = null;
            }
        }

        public bool GetBoolean(int i)
        {
            return m_dataReader.GetBoolean(i);
        }

        public bool GetBoolean(String name)
        {
            return GetBoolean(GetOrdinal(name));
        }

        public byte GetByte(int i)
        {
            return m_dataReader.GetByte(i);
        }

        public byte GetByte(String name)
        {
            return GetByte(GetOrdinal(name));
        }

        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            return m_dataReader.GetBytes(i, fieldOffset, buffer, bufferoffset, length);
        }

        public long GetBytes(String name, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            return GetBytes(GetOrdinal(name), fieldOffset, buffer, bufferoffset, length);
        }

        public char GetChar(int i)
        {
            return m_dataReader.GetChar(i);
        }

        public char GetChar(String name)
        {
            return GetChar(GetOrdinal(name));
        }

        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            return m_dataReader.GetChars(i, fieldoffset, buffer, bufferoffset, length);
        }

        public long GetChars(String name, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            return GetChars(GetOrdinal(name), fieldoffset, buffer, bufferoffset, length);
        }

        public IDataReader GetData(int i)
        {
            return m_dataReader.GetData(i);
        }

        public IDataReader GetData(String name)
        {
            return GetData(GetOrdinal(name));
        }

        public string GetDataTypeName(int i)
        {
            return m_dataReader.GetDataTypeName(i);
        }
  
        public string GetDataTypeName(String name)
        {
            return GetDataTypeName(GetOrdinal(name));
        }

        public DateTime GetDateTime(int i)
        {
            return m_dataReader.GetDateTime(i);
        }

        public DateTime GetDateTime(String name)
        {
            return GetDateTime(GetOrdinal(name));
        }

        public decimal GetDecimal(int i)
        {
            return m_dataReader.GetDecimal(i);
        }

        public decimal GetDecimal(String name)
        {
            return GetDecimal(GetOrdinal(name));
        }

        public double GetDouble(int i)
        {
            return m_dataReader.GetDouble(i);
        }

        public double GetDouble(String name)
        {
            return GetDouble(GetOrdinal(name));
        }

        public Type GetFieldType(int i)
        {
            return m_dataReader.GetFieldType(i);
        }

        public Type GetFieldType(String name)
        {
            return GetFieldType(GetOrdinal(name));
        }

        public float GetFloat(int i)
        {
            return m_dataReader.GetFloat(i);
        }

        public float GetFloat(String name)
        {
            return GetFloat(GetOrdinal(name));
        }

        public Guid GetGuid(int i)
        {
            return m_dataReader.GetGuid(i);
        }

        public Guid GetGuid(String name)
        {
            return GetGuid(GetOrdinal(name));
        }

        public short GetInt16(int i)
        {
            return m_dataReader.GetInt16(i);
        }

        public short GetInt16(String name)
        {
            return GetInt16(GetOrdinal(name));
        }

        public int GetInt32(int i)
        {
            return m_dataReader.GetInt32(i);
        }

        public int GetInt32(String name)
        {
            return GetInt32(GetOrdinal(name));
        }

        public long GetInt64(int i)
        {
            return m_dataReader.GetInt64(i);
        }

        public long GetInt64(String name)
        {
            return GetInt64(GetOrdinal(name));
        }

        public UInt16 GetUInt16(int i)
        {
            return Convert.ToUInt16(m_dataReader.GetValue(i));
        }

        public UInt16 GetUInt16(String name)
        {
            return GetUInt16(GetOrdinal(name));
        }

        public UInt32 GetUInt32(int i)
        {
            return Convert.ToUInt32(m_dataReader.GetValue(i));
        }

        public UInt32 GetUInt32(String name)
        {
            return GetUInt32(GetOrdinal(name));
        }

        public UInt64 GetUInt64(int i)
        {
            return Convert.ToUInt64(m_dataReader.GetValue(i));
        }

        public UInt64 GetUInt64(String name)
        {
            return GetUInt64(GetOrdinal(name));
        }

        public string GetName(int i)
        {
            return m_dataReader.GetName(i);
        }

        public int GetOrdinal(string name)
        {
            return m_dataReader.GetOrdinal(name);
        }

        public DataTable GetSchemaTable()
        {
            return m_dataReader.GetSchemaTable();
        }

        public string GetString(int i)
        {
            return m_dataReader.GetString(i);
        }

        public string GetString(String name)
        {
            return GetString(GetOrdinal(name));
        }

        public object GetValue(int i)
        {
            return m_dataReader.GetValue(i);
        }

        public object GetValue(String name)
        {
            return GetValue(GetOrdinal(name));
        }

        public int GetValues(object[] values)
        {
            return m_dataReader.GetValues(values);
        }

        public bool IsDBNull(int i)
        {
            return m_dataReader.IsDBNull(i);
        }

        public bool IsDBNull(String name)
        {
            return IsDBNull(GetOrdinal(name));
        }

        public bool NextResult()
        {
            return m_dataReader.NextResult();
        }

        public bool Read()
        {
            return m_dataReader.Read();
        }

        #endregion

        #region Constructor

        internal SqlDataReader(IDataReader dataReader)
        {
            m_dataReader = dataReader;
        }

        #endregion
    }
}
