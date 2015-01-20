using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public static class Security
    {
        #region MD5加密
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string MD5(string str)
        {
            using (System.Security.Cryptography.MD5CryptoServiceProvider MD5 = new System.Security.Cryptography.MD5CryptoServiceProvider())
            {
                byte[] _bytTemp1 = System.Text.Encoding.UTF8.GetBytes(str);
                byte[] _bytTemp2 = MD5.ComputeHash(_bytTemp1, 0, _bytTemp1.Length);
                return Convert.ToBase64String(_bytTemp2).Length > 24 ? Convert.ToBase64String(_bytTemp2).Substring(0, 24) : Convert.ToBase64String(_bytTemp2);
            }
        }
        #endregion 
    }
}
