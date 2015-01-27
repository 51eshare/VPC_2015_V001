using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Dapper;

namespace Service
{
    public class b_tbUser : B_Base<tbUser>
    {
        public b_tbUser()
        {

        }

        /// <summary>
        /// 修改用户各个类型的状态
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UpdateStatus(tbUserTypeRefUser user)
        {
            string _sql = @"UPDATE  tbUserTypeRefUser SET iStatus = @iStatus WHERE iUserId=@iUserId AND iUserTypeId=@iUserTypeId";
            DynamicParameter.Add("iStatus", user.iStatus);
            DynamicParameter.Add("iUserId", user.iUserId);
            DynamicParameter.Add("iUserTypeId", user.iUserTypeId);
            return Execute(_sql, DynamicParameter, commandtype: CommandType.Text) > 0;
        }

        /// <summary>
        /// 修改会员邮箱
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool UpdateEmail(tbUser _user)
        {
            string _sql = "UPDATE tbUser SET sUserEmail = @sUserEmail WHERE iUserId=@iUserId";
            DynamicParameter.Add("sUserEmail", _user.sUserEmail);
            DynamicParameter.Add("iUserId", _user.iUserId);
            return Execute(_sql, DynamicParameter, commandtype: CommandType.Text) > 0;
        }

        /// <summary>
        /// 修改会员支付宝信息
        /// </summary>
        /// <param name="_user"></param>
        /// <returns></returns>
        public bool Updateilipay(tbUser _user)
        {
            string _sql = "UPDATE tbUser SET ilipay = @ilipay,ilipaydate=getdate() WHERE iUserId=@iUserId";
            DynamicParameter.Add("ilipay", _user.ilipay);
            DynamicParameter.Add("iUserId", _user.iUserId);
            return Execute(_sql, DynamicParameter, commandtype: CommandType.Text) > 0;
        }


        public bool AddUserInfo(tbUser user)
        {
            DynamicParameter.Add("iUserId",user.iUserId);
            DynamicParameter.Add("sLoginId", user.sLoginId);
            DynamicParameter.Add("sNickname", user.sNickName);
            DynamicParameter.Add("sPassword", user.sPassword);
            DynamicParameter.Add("sUserEmail", user.sUserEmail);
            DynamicParameter.Add("iParentID", user.iParentID);
            DynamicParameter.Add("result",1,DbType.Int32,ParameterDirection.Output);
            Execute("pcUserAddCustomer", DynamicParameter, CommandType.StoredProcedure);
            return DynamicParameter.Get<Int32>("result") == 1;
        }
        public tbUser GetUserInfoByUid(long iUserId)
        {
            DynamicParameter.Add("iUserId", iUserId);
            var _user = new tbUser();
            using (var _dbconn = new SqlConnection(ConnStr))
            {
                _dbconn.Open();
                var _reader = _dbconn.QueryMultiple("pcUserLoginByUid", DynamicParameter, commandType: System.Data.CommandType.StoredProcedure);
                _user = _reader.Read<tbUser>().FirstOrDefault();
                if (_user != null)
                    _user.UserType = _reader.Read<long>();
            }
            return _user;
        }
        /// <summary>
        /// 根据微信号登录
        /// </summary>
        /// <param name="sWxOpenId"></param>
        /// <returns></returns>
        public tbUser GetUserInfoBysWxOpenId(string sWxOpenId)
        {
            DynamicParameter.Add("sWxOpenId", sWxOpenId);
            var _user = new tbUser();
            using (var _dbconn = new SqlConnection(ConnStr))
            {
                _dbconn.Open();
                var _reader = _dbconn.QueryMultiple("pcUserLoginBysWxOpenId", DynamicParameter, commandType: System.Data.CommandType.StoredProcedure);
                if (_reader.Read<int>().FirstOrDefault()>0)
                {
                    _user = _reader.Read<tbUser>().FirstOrDefault();
                    if (_user != null)
                        _user.UserType = _reader.Read<long>();
                }
            }
            return _user;
        }
        public tbUser GetUserInfo(string sLoginId, string sPassword, string sWxOpenId)
        {
            DynamicParameter.Add("sLoginId", sLoginId);
            DynamicParameter.Add("sPassword", sPassword);
            DynamicParameter.Add("sWxOpenId", sWxOpenId);
            var _user = new tbUser();
            using (var _dbconn = new SqlConnection(ConnStr))
            {
                _dbconn.Open();
                var _reader = _dbconn.QueryMultiple("pcUserLogin", DynamicParameter, commandType: System.Data.CommandType.StoredProcedure);
                _user = _reader.Read<tbUser>().FirstOrDefault();
                if (_user!=null)
                _user.UserType = _reader.Read<long>();
            }
            return _user;
        }
    }
}
