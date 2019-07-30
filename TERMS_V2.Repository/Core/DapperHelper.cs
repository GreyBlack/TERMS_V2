using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using MySql.Data.MySqlClient;
using Dapper;
using TERMS_V2.Infrastructure;
using Oracle.ManagedDataAccess.Client;

namespace TERMS_V2.Repository
{
    public class DapperHelper<T>
    {
        private static IDbConnection dbConnection = new MySqlConnection(ConfigHelper.GetValue("ConnectionStrings:MySqlConnection"));
        //private static IDbConnection dbConnection = new OracleConnection(ConfigHelper.GetValue("ConnectionStrings:OracleConnection"));

        public static IDbConnection GetConn()
        {
            return dbConnection;
        }

        /// <summary>
        /// 查询列表
        /// </summary>
        /// <param name="sql">查询的sql</param>
        /// <param name="param">替换参数</param>
        /// <returns></returns>
        public static List<T> Query(string sql, object param = null)
        {
            return dbConnection.Query<T>(sql, param).ToList();
        }

        /// <summary>
        /// 查询第一个数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T QueryFirst(string sql, object param)
        {
            return dbConnection.QueryFirst<T>(sql, param);
        }

        /// <summary>
        /// 查询第一个数据没有返回默认值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T QueryFirstOrDefault(string sql, object param)
        {
            return dbConnection.QueryFirstOrDefault<T>(sql, param);
        }

        /// <summary>
        /// 查询单条数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T QuerySingle(string sql, object param)
        {
            return dbConnection.QuerySingle<T>(sql, param);
        }

        /// <summary>
        /// 查询单条数据没有返回默认值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T QuerySingleOrDefault(string sql, object param)
        {
            return dbConnection.QuerySingleOrDefault<T>(sql, param);
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static int Execute(string sql, object param)
        {
            return dbConnection.Execute(sql, param);
        }

        /// <summary>
        /// Reader获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static IDataReader ExecuteReader(string sql, object param)
        {
            return dbConnection.ExecuteReader(sql, param);
        }

        /// <summary>
        /// Scalar获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, object param)
        {
            return dbConnection.ExecuteScalar(sql, param);
        }

        /// <summary>
        /// Scalar获取数据
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static T ExecuteScalarForT(string sql, object param)
        {
            return dbConnection.ExecuteScalar<T>(sql, param);
        }

        /// <summary>
        /// 带参数的存储过程
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public static List<T> ExecutePro(string proc, object param)
        {
            List<T> list = dbConnection.Query<T>(proc,
                   param,
                   null,
                   true,
                   null,
                   CommandType.StoredProcedure).ToList();
            return list;
        }


        /// <summary>
        /// 事务1 - 全SQL
        /// </summary>
        /// <param name="sqlarr">多条SQL</param>
        /// <param name="param">param</param>
        /// <returns></returns>
        public static int ExecuteTransaction(string[] sqlarr)
        {
            using (var transaction = dbConnection.BeginTransaction())
            {
                try
                {
                    int result = 0;
                    foreach (var sql in sqlarr)
                    {
                        result += dbConnection.Execute(sql, null, transaction);
                    }
                    transaction.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return 0;
                }
            }
        }

        /// <summary>
        /// 事务2 - 声明参数
        ///demo:
        ///dic.Add("Insert into Users values (@UserName, @Email, @Address)",
        ///        new { UserName = "jack", Email = "380234234@qq.com", Address = "上海" });
        /// </summary>
        /// <param name="Key">多条SQL</param>
        /// <param name="Value">param</param>
        /// <returns></returns>
        public static int ExecuteTransaction(Dictionary<string, object> dic)
        {
            using (var transaction = dbConnection.BeginTransaction())
            {
                try
                {
                    int result = 0;
                    foreach (var sql in dic)
                    {
                        result += dbConnection.Execute(sql.Key, sql.Value, transaction);
                    }

                    transaction.Commit();
                    return result;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    return 0;
                }
            }
        }
    }
}
