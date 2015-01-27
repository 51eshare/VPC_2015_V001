using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace VPC_2014_V001.WEIXIN
{
    /// <summary>
    /// mp 的摘要说明
    /// </summary>
    public class mp : IHttpHandler
    {

        private string[] OpenParameters = { "signature", "timestamp", "nonce", "echostr" };


        private bool checkSignature(string signature, string timestamp, string nonce, string token)
        {
            ArrayList tmpArray = new ArrayList();
            tmpArray.Add(token);
            tmpArray.Add(timestamp);
            tmpArray.Add(nonce);
            tmpArray.Sort();
            string tmpStr = (string)tmpArray[0] + (string)tmpArray[1] + (string)tmpArray[2];

            //建立SHA1对象
            SHA1 sha = new SHA1CryptoServiceProvider();

            //将mystr转换成byte[]
            ASCIIEncoding enc = new ASCIIEncoding();
            byte[] dataToHash = enc.GetBytes(tmpStr);

            //Hash运算
            byte[] dataHashed = sha.ComputeHash(dataToHash);

            //将运算结果转换成string
            string hash = BitConverter.ToString(dataHashed).Replace("-", "");
            //log("hash:" + hash); //记录日志，不需要可以注释掉

            if (hash.ToLower() == signature.ToLower())
                return true;
            else
                return false;

        }


        public void ProcessRequest(HttpContext context)
        {
            bool isLanding = true;
            foreach (string s in OpenParameters)
            {
                if (!context.Request.QueryString.AllKeys.Contains(s))
                    isLanding = false;
            }

            if (isLanding && checkSignature(context.Request.QueryString["signature"], context.Request.QueryString["timestamp"], context.Request.QueryString["nonce"], "vpc2015"))
            {
                context.Response.ContentType = "text/plain";
                string echoString = context.Request.QueryString["echostr"];
                context.Response.Write(echoString);
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}