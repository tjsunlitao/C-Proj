using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Globalization;
using System.Configuration;

namespace TASITJ_3005
{
    #region 委托

    /// <summary>
    /// 数据库操作命令委托
    /// </summary>
    /// <param name="dbCommand">操作命令</param>
    /// <returns>委托的命令</returns>
    internal delegate object CommandDelegate(DbCommand dbCommand);

    /// <summary>
    /// DbDataReader命令委托
    /// </summary>
    /// <param name="dbDataReader">DbDataReader</param>
    internal delegate void DbDataReadDelegate(DbDataReader dbDataReader);

    #endregion

    /// <summary>
    /// 数据库操作辅助类
    /// </summary>
    internal class DbHelper
    {
        #region 字段

        /// <summary>
        /// 数据库操作辅助类实例对象
        /// </summary>
        private static DbHelper _Instance;

        /// <summary>
        /// 表示连接字符串配置文件节中的单个命名连接字符串
        /// </summary>
        private ConnectionStringSettings _ConnectionStringSettings;

        /// <summary>
        /// 表示一组方法，这些方法用于创建提供程序对数据源类的实现的实例。
        /// </summary>
        private DbProviderFactory _DbProviderFactory;

        /// <summary>
        /// 保存数据库链接字符串
        /// </summary>
        public static string DataConnectionString = "ConnectionString";
    

        #endregion

        #region 构造函数

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public DbHelper()
        {
            _ConnectionStringSettings = ConfigurationManager.ConnectionStrings[DataConnectionString];
           

            // 如果连接字符串对象不为空，则创建数据库操作工厂
            if (_ConnectionStringSettings != null)
            {
                if (!string.IsNullOrEmpty(_ConnectionStringSettings.ProviderName) && !string.IsNullOrEmpty(_ConnectionStringSettings.ConnectionString))
                {
                    _DbProviderFactory = DbProviderFactories.GetFactory(_ConnectionStringSettings.ProviderName);
                }
            }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="dbConnectionSettingName">连接字符串名称</param>
        public DbHelper(string dbConnectionSettingName)
        {
            //如果连接字符串为NULL或空串，则将连接字符串名称赋值为_DataConnectionString
            if (string.IsNullOrEmpty(dbConnectionSettingName))
            {
                dbConnectionSettingName = DataConnectionString;
            }

            // 如果连接字符串对象不为空，则创建数据库操作工厂
            _ConnectionStringSettings = ConfigurationManager.ConnectionStrings[dbConnectionSettingName];
            if (_ConnectionStringSettings != null)
            {
                if (!string.IsNullOrEmpty(_ConnectionStringSettings.ProviderName) && !string.IsNullOrEmpty(_ConnectionStringSettings.ConnectionString))
                {
                    _DbProviderFactory = DbProviderFactories.GetFactory(_ConnectionStringSettings.ProviderName);
                }
            }
        }

        #endregion

        #region 类属性

        /// <summary>
        /// 单实例
        /// </summary>
        public static DbHelper Instance
        {
            get
            {
                _Instance = _Instance ?? new DbHelper();
                return _Instance;
            }
        }

        #endregion

        #region 实例属性

        /// <summary>
        /// 获得数据库链接字符串
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return _ConnectionStringSettings.ConnectionString;
            }
        }

        /// <summary>
        /// 获得工厂
        /// </summary>
        public DbProviderFactory ProviderFactory
        {
            get
            {
                return _DbProviderFactory;
            }
        }

        /// <summary>
        /// 获得驱动程序名称
        /// </summary>
        public string ProviderName
        {
            get
            {
                return _ConnectionStringSettings.ProviderName;
            }
        }

        #endregion

        #region 方法

        #region CreateConnection

        /// <summary>
        /// 创建一个数据库连接
        /// </summary>
        /// <returns>数据库连接对象</returns>
        public DbConnection CreateConnection()
        {
            if (_DbProviderFactory == null)
            {
                return null;
            }
            else
            {
                DbConnection dbConnection = _DbProviderFactory.CreateConnection();
                dbConnection.ConnectionString = _ConnectionStringSettings.ConnectionString;
                return dbConnection;
            }
        }

        #endregion

        #region ExecuteNonQuery

        /// <summary>
        /// 执行无结果集Sql
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">占位符参数</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteNonQuery(string sql, params DbParameter[] para)
        {
            return ExecuteNonQuery(CommandType.Text, sql, para);
        }

        /// <summary>
        /// 执行无结果集Sql
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">占位符参数</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteNonQuery(CommandType commandType, string sql, params DbParameter[] para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                return cmd.ExecuteNonQuery();
            };
            return (int)ExecuteCmdCallback(commandType, sql, cd, para);
        }

        /// <summary>
        /// 执行无结果集Sql
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">占位符参数</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteNonQuery(string sql, IList<DbParameter> para)
        {
            return ExecuteNonQuery(CommandType.Text, sql, para);
        }

        /// <summary>
        /// 执行无结果集Sql
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">占位符参数</param>
        /// <returns>影响的记录数</returns>
        public int ExecuteNonQuery(CommandType commandType, string sql, IList<DbParameter> para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                return cmd.ExecuteNonQuery();
            };
            return (int)ExecuteCmdCallback(commandType, sql, cd, para);
        }

        #endregion

        #region ReadData

        /// <summary>
        /// 通过DbDataReader来读取数据
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="readDelegate">DbDataReadDelegate委托</param>
        /// <returns></returns>
        public bool ReadData(string sql, DbDataReadDelegate readDelegate)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                using (DbDataReader dbReader = cmd.ExecuteReader())
                {
                    readDelegate(dbReader);
                    return true;
                }
            };
            return (bool)ExecuteCmdCallback(CommandType.Text, sql, cd);
        }

        #endregion

        #region CreateDataTable

        /// <summary>
        /// 根据Sql创建一个DataTable的结果集
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">查询参数</param>
        /// <returns>DataTable</returns>
        public DataTable CreateDataTable(string sql, IList<DbParameter> para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Locale = CultureInfo.InvariantCulture;
                    dt.Load(dr);
                    return dt;
                }
            };
            return (DataTable)ExecuteCmdCallback(CommandType.Text, sql, cd, para);
        }
        /// <summary>
        /// 根据Sql创建一个DataTable的结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable CreateDataTable(string sql, params DbParameter[] para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                using (DbDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Locale = CultureInfo.InvariantCulture;
                    dt.Load(dr);
                    return dt;
                }
            };
            return (DataTable)ExecuteCmdCallback(CommandType.Text, sql, cd, para);
        }

        #endregion

        #region CreateDataSet

        /// <summary>
        /// 根据Sql语句创建一个DataSet类型的结果集
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">查询参数</param>
        /// <returns>DataSet结果集</returns>
        public DataSet CreateDataSet(string sql, params DbParameter[] para)
        {
            return CreateDataSet(CommandType.Text, sql, para);
        }

        /// <summary>
        /// 根据Sql语句创建一个DataSet类型的结果集
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">查询参数</param>
        /// <returns>DataSet结果集</returns>
        public DataSet CreateDataSet(CommandType commandType, string sql, params DbParameter[] para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                using (DbDataAdapter da = _DbProviderFactory.CreateDataAdapter())
                {
                    DataSet ds = new DataSet();
                    ds.Locale = CultureInfo.InvariantCulture;
                    da.SelectCommand = cmd;
                    da.Fill(ds);
                    return ds;
                }
            };
            return (DataSet)ExecuteCmdCallback(commandType, sql, cd, para);
        }

        #endregion

        #region ExecuteScalar

        /// <summary>
        /// 执行查询，并返回查询所返回的结束集中的第一行的第一列
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">查询参数</param>
        /// <returns>string类型的字符串</returns>
        public string GetValue(string sql, params DbParameter[] para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                return cmd.ExecuteScalar();
            };
            object value = ExecuteCmdCallback(CommandType.Text, sql, cd, para);
            if (value == null)
            {
                value = string.Empty;
            }
            return value.ToString();
        }

        /// <summary>
        /// 执行查询，并返回查询所返回的结束集中的第一行的第一列
        /// </summary>
        /// <param name="sql">Sql语句</param>
        /// <param name="para">查询参数</param>
        /// <returns>对象object</returns>
        public object GetObject(string sql, IList<DbParameter> para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                return cmd.ExecuteScalar();
            };
            return ExecuteCmdCallback(CommandType.Text, sql, cd, para);
        }
        /// <summary>
        ///执行查询，并返回查询所返回的结束集中的第一行的第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="para"></param>
        /// <returns></returns>
        public object GetObject(string sql, params DbParameter[] para)
        {
            CommandDelegate cd = delegate (DbCommand cmd)
            {
                return cmd.ExecuteScalar();
            };
            return ExecuteCmdCallback(CommandType.Text, sql, cd, para);
        }
        #endregion

        #region ExecuteCmdCallback

        /// <summary>
        /// 执行带参数与委托命令的查询语句，并返回相关的委托命令
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sql">Sql语句</param>
        /// <param name="commandDelegate">委托类型</param>
        /// <param name="para">参数集合</param>
        /// <returns>委托的命令</returns>
        private object ExecuteCmdCallback(CommandType commandType, string sql, CommandDelegate commandDelegate, params DbParameter[] para)
        {
            using (DbConnection dbCnn = CreateConnection())
            {
                using (DbCommand cmd = _DbProviderFactory.CreateCommand())
                {
                    cmd.CommandType = commandType;
                    cmd.CommandText = sql;
                    cmd.Connection = dbCnn;
                    foreach (DbParameter dp in para)
                    {
                        cmd.Parameters.Add(dp);
                    }
                    dbCnn.Open();
                    return commandDelegate(cmd);
                }
            }
        }

        /// <summary>
        /// 执行带参数与委托命令的查询语句，并返回相关的委托命令
        /// </summary>
        /// <param name="commandType">命令类型</param>
        /// <param name="sql">Sql语句</param>
        /// <param name="commandDelegate">委托类型</param>
        /// <param name="para">参数集合</param>
        /// <returns>委托的命令</returns>
        private object ExecuteCmdCallback(CommandType commandType, string sql, CommandDelegate commandDelegate, IList<DbParameter> para)
        {
            using (DbConnection dbCnn = CreateConnection())
            {
                using (DbCommand cmd = _DbProviderFactory.CreateCommand())
                {
                    cmd.CommandType = commandType;
                    cmd.CommandText = sql;
                    cmd.Connection = dbCnn;
                    foreach (DbParameter dp in para)
                    {
                        cmd.Parameters.Add(dp);
                    }
                    dbCnn.Open();
                    return commandDelegate(cmd);
                }
            }
        }

        #endregion

        #endregion
    }
}
