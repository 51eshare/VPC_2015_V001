using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Dapper;
using Entity;

namespace Service
{
    public class B_Base<T>
    {

        protected DynamicParameters DynamicParameter = new DynamicParameters();

        public static string ConnStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public B_Base()
        {
            
        }

        public virtual T Get(long id)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Get<T>(id);
            }
        }

        public virtual T Get(string sql, DynamicParameters dParameters)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                try
                {
                    return _conn.Query<T>(sql, dParameters).FirstOrDefault();
                }
                catch
                {
                    return default(T);
                }
            }
        }

        public virtual IEnumerable<T> GetList()
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.GetList<T>();
            }
        }

        public virtual IEnumerable<T> GetList(DynamicParameters dParameters)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.GetList<T>(dParameters);
            }
        }

        public virtual IEnumerable<t> GetList<t>(string sql, DynamicParameters dParameters)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Query<t>(sql,dParameters);
            }
        }

        public virtual IEnumerable<T> GetList(string sql, object dParameters = null,CommandType commandType= CommandType.Text)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Query<T>(sql, dParameters,commandType:commandType);
            }
        }
        public virtual Dapper.SqlMapper.GridReader GridReader(string sql, object dParameters = null, CommandType commandType = CommandType.Text)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.QueryMultiple(sql, dParameters, commandType: commandType);
            }
        }
        public virtual int? Insert(T t)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                try
                {
                    return _conn.Insert(t);
                }
                catch {
                    return -1;
                }
            }
        }

        public virtual bool Insert(string sql,DynamicParameters dynamicParameters)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Execute(sql, dynamicParameters)>0;
            }
        }

        public virtual bool Update(T t)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Update(t)>0;
            }
        }

        public virtual bool Delete(long id)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Delete<T>(id)>0;
            }
        }

        public virtual bool Delete(T t)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Delete(t) > 0;
            }
        }

        public virtual int Execute(string sql, object dynamicParameters = null, CommandType commandtype= CommandType.Text)
        {
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                return _conn.Execute(sql, dynamicParameters,commandType:commandtype);
            }
        }


        /// <summary>
        /// 分页
        /// </summary>
        /// <typeparam name="p"></typeparam>
        /// <param name="_parameter"></param>
        /// <returns></returns>
        public virtual p_PageList<p> PageList<p>(p_PageList<p> _parameter)
        {
            DynamicParameter.Add("Tables",_parameter.Tables);
            DynamicParameter.Add("Fields", _parameter.Fields);
            DynamicParameter.Add("OrderFields", _parameter.OrderFields);
            DynamicParameter.Add("Where", _parameter.Where);
            DynamicParameter.Add("PageIndex", _parameter.PageIndex);
            DynamicParameter.Add("PageSize", _parameter.PageSize);
            DynamicParameter.Add("GroupBy", _parameter.GroupBy);
            DynamicParameter.Add("TotalCount",0,dbType:DbType.Int32,direction:ParameterDirection.Output);
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                _parameter.DataList = _conn.Query<p>("p_PageList", DynamicParameter, commandType: CommandType.StoredProcedure);
                _parameter.TotalCount = DynamicParameter.Get<int>("TotalCount");
            }
            return _parameter;
        }
    }
}
