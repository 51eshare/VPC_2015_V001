using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class Encrypt
    {
        private static string RSAKey =
            "<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

        /// <summary>
        ///     DES����
        /// </summary>
        /// <param name="Data">�����ܵ�����</param>
        public static string deskKey = "xavierxi";

        private static string privateKey =
            "<RSAKeyValue><Modulus>5m9m14XH3oqLJ8bNGw9e4rGpXpcktv9MSkHSVFVMjHbfv+SJ5v0ubqQxa5YjLN4vc49z7SVju8s0X4gZ6AzZTn06jzWOgyPRV54Q4I0DCYadWW4Ze3e+BOtwgVU1Og3qHKn8vygoj40J6U85Z/PTJu3hN1m75Zr195ju7g9v4Hk=</Modulus><Exponent>AQAB</Exponent><P>/hf2dnK7rNfl3lbqghWcpFdu778hUpIEBixCDL5WiBtpkZdpSw90aERmHJYaW2RGvGRi6zSftLh00KHsPcNUMw==</P><Q>6Cn/jOLrPapDTEp1Fkq+uz++1Do0eeX7HYqi9rY29CqShzCeI7LEYOoSwYuAJ3xA/DuCdQENPSoJ9KFbO4Wsow==</Q><DP>ga1rHIJro8e/yhxjrKYo/nqc5ICQGhrpMNlPkD9n3CjZVPOISkWF7FzUHEzDANeJfkZhcZa21z24aG3rKo5Qnw==</DP><DQ>MNGsCB8rYlMsRZ2ek2pyQwO7h/sZT8y5ilO9wu08Dwnot/7UMiOEQfDWstY3w5XQQHnvC9WFyCfP4h4QBissyw==</DQ><InverseQ>EG02S7SADhH1EVT9DD0Z62Y0uY7gIYvxX/uq+IzKSCwB8M2G7Qv9xgZQaQlLpCaeKbux3Y59hHM+KpamGL19Kg==</InverseQ><D>vmaYHEbPAgOJvaEXQl+t8DQKFT1fudEysTy31LTyXjGu6XiltXXHUuZaa2IPyHgBz0Nd7znwsW/S44iql0Fen1kzKioEL3svANui63O3o5xdDeExVM6zOf1wUUh/oldovPweChyoAdMtUzgvCbJk1sYDJf++Nr0FeNW1RB1XG30=</D></RSAKeyValue>";

        public static string DESEncrypt(string InputString)
        {
            try
            {
                byte[] MyStr_E = Encoding.UTF8.GetBytes(InputString);
                byte[] MyKey_E = Encoding.UTF8.GetBytes(deskKey);
                string enStr = "";

                var MyDes_E = new DESCryptoServiceProvider();
                MyDes_E.Key = MyKey_E;
                MyDes_E.IV = MyKey_E;

                var MyMem_E = new MemoryStream();

                var MyCry_E = new CryptoStream(MyMem_E, MyDes_E.CreateEncryptor(), CryptoStreamMode.Write);
                MyCry_E.Write(MyStr_E, 0, MyStr_E.Length);
                MyCry_E.FlushFinalBlock();
                MyCry_E.Close();

                return enStr = Convert.ToBase64String(MyMem_E.ToArray());
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }

        /// <summary>
        ///     DES����
        /// </summary>
        /// <param name="Data">�����ܵ�����</param>
        public static string DESDecrypt(string InputString)
        {
            try
            {
                byte[] MyStr_D = Convert.FromBase64String(InputString);
                byte[] MyKey_D = Encoding.UTF8.GetBytes(deskKey);
                string deStr = "";

                var MyDes_D = new DESCryptoServiceProvider();
                MyDes_D.Key = MyKey_D;
                MyDes_D.IV = MyKey_D;

                var MyMem_D = new MemoryStream();

                var MyCry_D = new CryptoStream(MyMem_D, MyDes_D.CreateDecryptor(), CryptoStreamMode.Write);
                MyCry_D.Write(MyStr_D, 0, MyStr_D.Length);
                MyCry_D.FlushFinalBlock();
                MyCry_D.Close();

                return deStr = Encoding.UTF8.GetString(MyMem_D.ToArray());
            }
            catch (Exception Error)
            {
                throw new Exception(Error.Message);
            }
        }


        /// <summary>
        ///     RSA����
        /// </summary>
        /// <param name="publickey"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RSAEncrypt(string content)
        {
            var rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(RSAKey);
            cipherbytes = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        ///     RSA����
        /// </summary>
        /// <param name="privatekey"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string RSADecrypt(string content)
        {
            var rsa = new RSACryptoServiceProvider();
            byte[] cipherbytes;
            rsa.FromXmlString(privateKey);
            cipherbytes = rsa.Decrypt(Convert.FromBase64String(content), false);
            return Encoding.UTF8.GetString(cipherbytes);
        }

        /// <summary>
        ///     MD5 ���ܾ�̬����
        /// </summary>
        /// <param name="EncryptString">�����ܵ�����</param>
        /// <returns>returns</returns>
        public static string MD5Encrypt(string EncryptString)
        {
            if (string.IsNullOrEmpty(EncryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            MD5 m_ClassMD5 = new MD5CryptoServiceProvider();

            string m_strEncrypt = "";

            try
            {
                m_strEncrypt =
                    BitConverter.ToString(m_ClassMD5.ComputeHash(Encoding.Default.GetBytes(EncryptString)))
                                .Replace("-", "");
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_ClassMD5.Clear();
            }

            return m_strEncrypt;
        }

        /// <summary>
        ///     DES ����(���ݼ��ܱ�׼���ٶȽϿ죬�����ڼ��ܴ������ݵĳ���)
        /// </summary>
        /// <param name="EncryptString">�����ܵ�����</param>
        /// <param name="EncryptKey">���ܵ���Կ</param>
        /// <returns>returns</returns>
        public static string DESEncrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            if (string.IsNullOrEmpty(EncryptKey))
            {
                throw (new Exception("��Կ����Ϊ��"));
            }

            if (EncryptKey.Length != 8)
            {
                throw (new Exception("��Կ����Ϊ8λ"));
            }

            byte[] m_btIV = {0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF};

            string m_strEncrypt = "";

            var m_DESProvider = new DESCryptoServiceProvider();

            try
            {
                byte[] m_btEncryptString = Encoding.Default.GetBytes(EncryptString);

                var m_stream = new MemoryStream();

                var m_cstream = new CryptoStream(m_stream,
                                                 m_DESProvider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey),
                                                                               m_btIV), CryptoStreamMode.Write);

                m_cstream.Write(m_btEncryptString, 0, m_btEncryptString.Length);

                m_cstream.FlushFinalBlock();

                m_strEncrypt = Convert.ToBase64String(m_stream.ToArray());

                m_stream.Close();
                m_stream.Dispose();

                m_cstream.Close();
                m_cstream.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_DESProvider.Clear();
            }

            return m_strEncrypt;
        }

        /// <summary>
        ///     DES ����(���ݼ��ܱ�׼���ٶȽϿ죬�����ڼ��ܴ������ݵĳ���)
        /// </summary>
        /// <param name="DecryptString">�����ܵ�����</param>
        /// <param name="DecryptKey">���ܵ���Կ</param>
        /// <returns>returns</returns>
        public static string DESDecrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            if (string.IsNullOrEmpty(DecryptKey))
            {
                throw (new Exception("��Կ����Ϊ��"));
            }

            if (DecryptKey.Length != 8)
            {
                throw (new Exception("��Կ����Ϊ8λ"));
            }

            byte[] m_btIV = {0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF};

            string m_strDecrypt = "";

            var m_DESProvider = new DESCryptoServiceProvider();

            try
            {
                byte[] m_btDecryptString = Convert.FromBase64String(DecryptString);

                var m_stream = new MemoryStream();

                var m_cstream = new CryptoStream(m_stream,
                                                 m_DESProvider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey),
                                                                               m_btIV), CryptoStreamMode.Write);

                m_cstream.Write(m_btDecryptString, 0, m_btDecryptString.Length);

                m_cstream.FlushFinalBlock();

                m_strDecrypt = Encoding.Default.GetString(m_stream.ToArray());

                m_stream.Close();
                m_stream.Dispose();

                m_cstream.Close();
                m_cstream.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_DESProvider.Clear();
            }

            return m_strDecrypt;
        }

        /// <summary>
        ///     RC2 ����(�ñ䳤��Կ�Դ������ݽ��м���)
        /// </summary>
        /// <param name="EncryptString">����������</param>
        /// <param name="EncryptKey">������Կ</param>
        /// <returns>returns</returns>
        public static string RC2Encrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            if (string.IsNullOrEmpty(EncryptKey))
            {
                throw (new Exception("��Կ����Ϊ��"));
            }

            if (EncryptKey.Length < 5 || EncryptKey.Length > 16)
            {
                throw (new Exception("��Կ����Ϊ5-16λ"));
            }

            string m_strEncrypt = "";

            byte[] m_btIV = {0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF};

            var m_RC2Provider = new RC2CryptoServiceProvider();

            try
            {
                byte[] m_btEncryptString = Encoding.Default.GetBytes(EncryptString);

                var m_stream = new MemoryStream();

                var m_cstream = new CryptoStream(m_stream,
                                                 m_RC2Provider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey),
                                                                               m_btIV), CryptoStreamMode.Write);

                m_cstream.Write(m_btEncryptString, 0, m_btEncryptString.Length);

                m_cstream.FlushFinalBlock();

                m_strEncrypt = Convert.ToBase64String(m_stream.ToArray());

                m_stream.Close();
                m_stream.Dispose();

                m_cstream.Close();
                m_cstream.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_RC2Provider.Clear();
            }

            return m_strEncrypt;
        }

        /// <summary>
        ///     RC2 ����(�ñ䳤��Կ�Դ������ݽ��м���)
        /// </summary>
        /// <param name="DecryptString">����������</param>
        /// <param name="DecryptKey">������Կ</param>
        /// <returns>returns</returns>
        public static string RC2Decrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            if (string.IsNullOrEmpty(DecryptKey))
            {
                throw (new Exception("��Կ����Ϊ��"));
            }

            if (DecryptKey.Length < 5 || DecryptKey.Length > 16)
            {
                throw (new Exception("��Կ����Ϊ5-16λ"));
            }

            byte[] m_btIV = {0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF};

            string m_strDecrypt = "";

            var m_RC2Provider = new RC2CryptoServiceProvider();

            try
            {
                byte[] m_btDecryptString = Convert.FromBase64String(DecryptString);

                var m_stream = new MemoryStream();

                var m_cstream = new CryptoStream(m_stream,
                                                 m_RC2Provider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey),
                                                                               m_btIV), CryptoStreamMode.Write);

                m_cstream.Write(m_btDecryptString, 0, m_btDecryptString.Length);

                m_cstream.FlushFinalBlock();

                m_strDecrypt = Encoding.Default.GetString(m_stream.ToArray());

                m_stream.Close();
                m_stream.Dispose();

                m_cstream.Close();
                m_cstream.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_RC2Provider.Clear();
            }

            return m_strDecrypt;
        }

        /// <summary>
        ///     3DES ����(����DES����һ��������������ͬ����Կ�������μ��ܣ�ǿ�ȸ���)
        /// </summary>
        /// <param name="EncryptString">����������</param>
        /// <param name="EncryptKey1">��Կһ</param>
        /// <param name="EncryptKey2">��Կ��</param>
        /// <param name="EncryptKey3">��Կ��</param>
        /// <returns>returns</returns>
        public static string DES3Encrypt(string EncryptString, string EncryptKey1, string EncryptKey2,
                                         string EncryptKey3)
        {
            string m_strEncrypt = "";

            try
            {
                m_strEncrypt = DESEncrypt(EncryptString, EncryptKey3);

                m_strEncrypt = DESEncrypt(m_strEncrypt, EncryptKey2);

                m_strEncrypt = DESEncrypt(m_strEncrypt, EncryptKey1);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return m_strEncrypt;
        }

        /// <summary>
        ///     3DES ����(����DES����һ��������������ͬ����Կ�������μ��ܣ�ǿ�ȸ���)
        /// </summary>
        /// <param name="DecryptString">����������</param>
        /// <param name="DecryptKey1">��Կһ</param>
        /// <param name="DecryptKey2">��Կ��</param>
        /// <param name="DecryptKey3">��Կ��</param>
        /// <returns>returns</returns>
        public static string DES3Decrypt(string DecryptString, string DecryptKey1, string DecryptKey2,
                                         string DecryptKey3)
        {
            string m_strDecrypt = "";

            try
            {
                m_strDecrypt = DESDecrypt(DecryptString, DecryptKey1);

                m_strDecrypt = DESDecrypt(m_strDecrypt, DecryptKey2);

                m_strDecrypt = DESDecrypt(m_strDecrypt, DecryptKey3);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return m_strDecrypt;
        }

        /// <summary>
        ///     AES ����(�߼����ܱ�׼������һ���ļ����㷨��׼���ٶȿ죬��ȫ����ߣ�Ŀǰ AES ��׼��һ��ʵ���� Rijndael �㷨)
        /// </summary>
        /// <param name="EncryptString">����������</param>
        /// <param name="EncryptKey">������Կ</param>
        /// <returns></returns>
        public static string AESEncrypt(string EncryptString, string EncryptKey)
        {
            if (string.IsNullOrEmpty(EncryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            if (string.IsNullOrEmpty(EncryptKey))
            {
                throw (new Exception("��Կ����Ϊ��"));
            }

            string m_strEncrypt = "";

            byte[] m_btIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");

            Rijndael m_AESProvider = Rijndael.Create();

            try
            {
                byte[] m_btEncryptString = Encoding.Default.GetBytes(EncryptString);

                var m_stream = new MemoryStream();

                var m_csstream = new CryptoStream(m_stream,
                                                  m_AESProvider.CreateEncryptor(Encoding.Default.GetBytes(EncryptKey),
                                                                                m_btIV), CryptoStreamMode.Write);

                m_csstream.Write(m_btEncryptString, 0, m_btEncryptString.Length);
                m_csstream.FlushFinalBlock();

                m_strEncrypt = Convert.ToBase64String(m_stream.ToArray());

                m_stream.Close();
                m_stream.Dispose();

                m_csstream.Close();
                m_csstream.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_AESProvider.Clear();
            }

            return m_strEncrypt;
        }

        /// <summary>
        ///     AES ����(�߼����ܱ�׼������һ���ļ����㷨��׼���ٶȿ죬��ȫ����ߣ�Ŀǰ AES ��׼��һ��ʵ���� Rijndael �㷨)
        /// </summary>
        /// <param name="DecryptString">����������</param>
        /// <param name="DecryptKey">������Կ</param>
        /// <returns></returns>
        public static string AESDecrypt(string DecryptString, string DecryptKey)
        {
            if (string.IsNullOrEmpty(DecryptString))
            {
                throw (new Exception("���Ĳ���Ϊ��"));
            }

            if (string.IsNullOrEmpty(DecryptKey))
            {
                throw (new Exception("��Կ����Ϊ��"));
            }

            string m_strDecrypt = "";

            byte[] m_btIV = Convert.FromBase64String("Rkb4jvUy/ye7Cd7k89QQgQ==");

            Rijndael m_AESProvider = Rijndael.Create();

            try
            {
                byte[] m_btDecryptString = Convert.FromBase64String(DecryptString);

                var m_stream = new MemoryStream();

                var m_csstream = new CryptoStream(m_stream,
                                                  m_AESProvider.CreateDecryptor(Encoding.Default.GetBytes(DecryptKey),
                                                                                m_btIV), CryptoStreamMode.Write);

                m_csstream.Write(m_btDecryptString, 0, m_btDecryptString.Length);
                m_csstream.FlushFinalBlock();

                m_strDecrypt = Encoding.Default.GetString(m_stream.ToArray());

                m_stream.Close();
                m_stream.Dispose();

                m_csstream.Close();
                m_csstream.Dispose();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (CryptographicException ex)
            {
                throw ex;
            }
            catch (ArgumentException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                m_AESProvider.Clear();
            }

            return m_strDecrypt;
        }
    }
}