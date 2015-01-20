using Dapper;
using Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Service
{
    public class b_tbProduct:B_Base<tbProduct>
    {
        /// <summary>
        /// 获取商品信息
        /// </summary>
        /// <param name="iPdId"></param>
        /// <returns></returns>
        public tbProduct ProductImages(Int64 iPdId)
        {
            var _tbproductimages = new tbProductImages();
            using (IDbConnection _conn = new SqlConnection(ConnStr))
            {
                _conn.Open();
                string _sql = "SELECT * FROM tbProduct AS a WHERE a.iPdId=@iPdId;";
                return _conn.Query<tbProduct>(_sql, new { iPdId = iPdId }).FirstOrDefault();
            }
        }
        #region 更新商品状态
        /// <summary>
        /// 更新商品状态
        /// </summary>
        /// <param name="ipdid"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public bool updateStatus(long ipdid, int state)
        {
            string _sql = "UPDATE tbProduct SET iStatus =@iStatus  WHERE iPdId=@iPdId";
            return Execute(_sql, new { iStatus = state, iPdId = ipdid }) > 0;
        }
        public bool update(string ipdid)
        {
            string _sql = "UPDATE tbProduct SET iStatus = 2 WHERE iPdId IN @iPdId";
            return Execute(_sql, new { iPdId = ipdid.Split(',')}) > 0;
        }
        public bool updateStatus(long ipdid, int state, string squestiontext)
        {
            string _sql = "UPDATE tbProduct SET iStatus =@iStatus,reason=@reason  WHERE iPdId=@iPdId";
            return Execute(_sql, new { iStatus = state, iPdId = ipdid, reason=squestiontext}) > 0;
        }
        #endregion



        #region 更新库存
        /// <summary>
        /// 更新库存
        /// </summary>
        /// <param name="ipdid"></param>
        /// <param name="iquantity"></param>
        /// <returns></returns>
        public bool updateQuantity(int ipdid, int iquantity)
        {
            string _sql = "UPDATE tbProduct SET iQuantity =@iquantity  WHERE iPdId=@ipdid";
            return Execute(_sql, new { iquantity = iquantity, ipdid = ipdid }) > 0;
        }
        #endregion 
    }
}
