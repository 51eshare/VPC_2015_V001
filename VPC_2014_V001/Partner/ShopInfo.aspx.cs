using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VPC_2014_V001.VPC.Partner
{
    public partial class ShopInfo : P_Base
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Data.DataSet ds = new System.Data.DataSet();
            #region 数据库检索
            using (Sample.clsVPCDB _clsVPCDB = new Sample.clsVPCDB())
            {
                try { _clsVPCDB.OpenCon(); }
                catch{ }

                try
                {
                    //存储过程名称
                    _clsVPCDB.CmdProc = "pcShopInfo";

                    //存储过程参数
                    _clsVPCDB.AddParam("@iShopId", System.Data.SqlDbType.BigInt, UserInfo.RealID);

                    //执行存储过程,获取返回值
                    _clsVPCDB.ExecuteQuery(ref ds, "UI");


                    ////结束事务处理
                    //_clsVPCDB.CommitTrans();
                }
                catch{  }
                finally { try { _clsVPCDB.CloseCon(); } catch { } }


            }
            #endregion

            LbiShopId.Text = ds.Tables["UI"].Rows[0]["微店ID"].ToString();
            LbsShopName.Text = ds.Tables["UI"].Rows[0]["微店名"].ToString();
            LbsShopDesc.Text = ds.Tables["UI"].Rows[0]["微店描述"].ToString();
            LbcOwnerName.Text = ds.Tables["UI"].Rows[0]["微店主姓名"].ToString();
            LbcOwnerMail.Text = ds.Tables["UI"].Rows[0]["微店主邮箱"].ToString();
            LbcOwnerMP.Text = ds.Tables["UI"].Rows[0]["微店主手机号"].ToString();
            LbcOwnerAccout.Text = ds.Tables["UI"].Rows[0]["微店主支付宝帐号"].ToString();
            LbdDate.Text = ds.Tables["UI"].Rows[0]["建档日期"].ToString();
            LbiStatus.Text = ds.Tables["UI"].Rows[0]["微店状态"].ToString();
            LbiDistrict.Text = ds.Tables["UI"].Rows[0]["微店地区"].ToString();
            LbiProductNum.Text = ds.Tables["UI"].Rows[0]["微店商品数量"].ToString();
            LbiCollection.Text = ds.Tables["UI"].Rows[0]["总收藏量"].ToString();
            LbiVolumeNum.Text = ds.Tables["UI"].Rows[0]["总成交数量"].ToString();
            LbiVolumeSum.Text = ds.Tables["UI"].Rows[0]["总成交金额"].ToString();
            LbiVolumeNumMonth1.Text = ds.Tables["UI"].Rows[0]["当月成交数量"].ToString();
            LbiVolumeSumMonth1.Text = ds.Tables["UI"].Rows[0]["当月成交金额"].ToString();
            LbiVolumeNumMonth3.Text = ds.Tables["UI"].Rows[0]["近3个月成交数量"].ToString();
            LbiVolumeSumMonth3.Text = ds.Tables["UI"].Rows[0]["近3个月成交金额"].ToString();

        }
    }
}