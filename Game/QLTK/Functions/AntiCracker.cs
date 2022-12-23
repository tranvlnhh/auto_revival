using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using LitJSON;
using LitJson;

namespace QLTK.Functions
{
    internal class AntiCracker
    {
        #region
        static AntiCracker instance;
        public static AntiCracker gI()
        {
            if (instance == null)
            {
                instance = new AntiCracker();
                instance.init();
            }
            return instance;
        }
        #endregion


        const string HOST_IP = "103.200.22.212";
        const string TOOL_NAME = "a/C3msOFulFCe/tpw3z/i00bOlq+qQvEyyVEBjC+f0KqRk3SgXPWyKrVk1G66h2Rjpb5wfA/2R0btE37067uIOjiidlG4IMdGh315ofQe3dWM3kJ3rZxI+sSBrU8AS88plvnvbKo9cfgW/UslEAworoDBfpjh+i5JqhW52xS5GQ=";

        const string private_key_client_pem = "-----BEGIN RSA PRIVATE KEY-----\r\nMIICXAIBAAKBgQDmORJWE0b/eknTLXNBjgNtyLQ9jqNZStwfI74c3FNBCpjL2oHm\r\nW75vtioRLvIC/Nuz3EsYT0BcBoe2mJb8nyeiGHwy3t75jlb2eynhYmB+I3hAFQx2\r\n/u/gyTd7FnrFYKr5Ykg7cfwxsTrnNwk5jD+gXCHFZTaM//W1FJajKG99eQIDAQAB\r\nAoGARLOBQkhsZm6yux8UBtr/MPK0vq3jFxFc0LoU0H37JiyoXiTtoLV+Bc4hjZEp\r\nzTRxx6GUk0OLHCsisp2kaOyBoa+c1GBBYMXwzyvKtVAGOLJJH3+xPv4RLkRiq28o\r\nc5IgeDhdswxGTrvyZz4weyrTfTfTvtq9QaKheRq/ydTnLbUCQQDqpbKHdEi89XCe\r\n5RDcnh6TbggsYRLyFotDw/gBX+D6go8RUMZpjmjGp5lEUGrWTvVdJGfctX1/HnOy\r\ngKmC1jzzAkEA+yxOWZEVR253pmRmMkcYiwdhdXErvwpCiJFEkS+krsfEiMh/hK/g\r\nNowxtJMQgoOkKLHaiSuXZ5AQC1O9MD9G4wJAZIiPwCdbTtJd6UY9fjik4we+qr0A\r\nsAZmrqcU6AnbS5mKkKGqEOm6DHscWL+XtrBnwftqII8F8OPsMCud9PezbwJBAMvr\r\n9NCTEgukjE/zQ2WegzadD2siLrozwkDOcDTP0Yx1dAL5hU5c3FRtDg3lOIo+BpFj\r\nlGG5mnriY6ROoFMDjLECQFUTXnwg+owxi9H8U7iYjiMVUIMUQuEhMJEbnSWMHQ8h\r\n6hA9zL+iYLOGrN3lFIWUdYfMhZ2+rX2arP6ksqZ+KGk=\r\n-----END RSA PRIVATE KEY-----4mm8F+gVsN/Zd0vlulJj5wufB8FjOm\r\nDT4jH5lNaOjmDcKBmSPrSgbOZZIJ7Cl0TiXWtjSS7/2bzRBBUBfXvkoD2sVtlO6+\r\nkVXBEkB2OMeT8oQiyvGF+IuX/MUWlq58OoKIFX38Lt/alxBTxnPV7WP6oQIDAQAB\r\nAoGBAMI4irhPD0qT/YEzEOitzkmahXhA41VYT/wt+ZTpTBfEXrtbwHg9fLkKqVr+\r\n+pe1DQqG+hdsZ30Lt52bi5KFoFstopMQXfc/LMgeLP+wYeEkORrjPlvU19L8Xij6\r\nIhKveje6f5wj9zdqJxnNHBouR24whJy8oBWUnOrgsdP5NLJVAkEA9Le++X05OvW3\r\nwWaZ3kxOhJTq41scwP91QpMMeSAQQBHGiH7bGtOxBjXFFnQsxPEA225FvS4KE/Ob\r\n8bcpt9ZKGwJBAPCXLShDSJfUdrx+asAGqATw3zieL+xN/U5LxpmmmETU0rdR0+3L\r\niStmRrfB+dIGfxmYf2iQisdwLvtaL/stGfMCQHeOdZzKEvW9KkMwbyftu8aGQqNE\r\n1i1sIMufr85VXdsPVCFHaKAYoDnadylbJKwq2jJaE3QzU/UfZSaYR6dq59UCQQCH\r\nZHwMKXkjwHQldXr7n4NUbH0iLptHf0gqlKgp9b/BFIeUlJ8QNjd2TfNEHAxLrk4+\r\niDxDCvyeabp2xvUzg9kTAkBF8EkMQF/Ykm7HVY2wDp9nb2DEXhH/5CFsWphfct0H\r\nMwUgC3g9PVcbi7ivIuEWbuxdmjM3WhQ2Bs71WMmDlUiv\r\n-----END RSA PRIVATE KEY-----";
        const string public_key_server_pem = "-----BEGIN PUBLIC KEY-----\r\nMIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDHBF99kLXFdTYXwpn4GpSujHxT\r\nvoE3k+eDvqJc7gCzD1LiKaJhEDmS8RCJ7LJQAFiW95gGkc7F5Fc0u5sT837JhWdO\r\n78ZMQ6iUPY3c6z2YoZwE/01ejYvKZctrSstIb1c625XYl3HBVJOIRaA8w12Q6yNW\r\nVLFDOR0nQFjldIC24QIDAQAB\r\n-----END PUBLIC KEY-----";
        RSACryptoServiceProvider private_key_client;
        RSACryptoServiceProvider public_key_server;

        void init()
        {
            private_key_client = new RSACryptoServiceProvider();
            private_key_client.ImportParameters(DotNetUtilities.ToRSAParameters((RsaPrivateCrtKeyParameters)((AsymmetricCipherKeyPair)(new PemReader(new StringReader(private_key_client_pem))).ReadObject()).Private));

            public_key_server = new RSACryptoServiceProvider();
            public_key_server.ImportParameters(DotNetUtilities.ToRSAParameters((RsaKeyParameters)((AsymmetricKeyParameter)new PemReader(new StringReader(public_key_server_pem)).ReadObject())));
        }

        public bool check_key_license()
        {
            if (!IsConnectedToInternet())
            {
                MessageBox.Show("Không có mạng dùng tool kiểu gì :v", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            if (check_host_ip(HOST_IP))
            {
                MessageBox.Show("Crack kon kặk =))", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }

            using (WebClient w = new WebClient())
            {
                try
                {
                    var respone = w.UploadValues("http://licensekey.123tool.shop/", "POST", new NameValueCollection()
                    {
                        { "name", TOOL_NAME },
                        { "key", "" }
                    });
                    var a = decrypt(Encoding.UTF8.GetString(respone));
                    var data = JsonMapper.ToObject(a);
                    var time_out = TimeHelper.gI().CheckTimeOut(data["check_time"].ToString());
                    if (time_out > 5000)
                    {
                        MessageBox.Show("[" + time_out + "] " + "Time out!");
                        return true;

                    }
                    mainForm.gI.time_expired = TimeHelper.gI().DateTimeFromString(data["time_expired"].ToString());
                }
                catch
                {
                   // return true;
                }
            }


            return false;
        }

        public string decrypt(string str)
        {
            return Encoding.UTF8.GetString(private_key_client.Decrypt(Convert.FromBase64String(str), false));
        }
        public string encrypt(string str)
        {
            return Convert.ToBase64String(public_key_server.Encrypt(Encoding.UTF8.GetBytes(str), false));
        }


        bool check_host_ip(string host)
        {
            bool result = true;
            using (Ping p = new Ping())
            {
                try
                {
                    var pr = p.Send(host, 2000);
                    if (pr.Status == IPStatus.Success && pr.Address.ToString() == HOST_IP && pr.Address.MapToIPv4().ToString() == HOST_IP)
                    {
                        result = false;
                    }
                }
                catch (Exception)
                {
                    result = true;
                }
            }
            return result;
        }

        [Flags] 
        enum ConnectionInternetState : int 
        {
            INTERNET_CONNECTION_MODEM = 0x1,
            INTERNET_CONNECTION_LAN = 0x2,
            INTERNET_CONNECTION_PROXY = 0x4,
            INTERNET_RAS_INSTALLED = 0x10,
            INTERNET_CONNECTION_OFFLINE = 0x20,
            INTERNET_CONNECTION_CONFIGURED = 0x40 
        }
        [DllImport("wininet.dll", CharSet = CharSet.Auto)] 
        static extern bool InternetGetConnectedState(ref ConnectionInternetState lpdwFlags, int dwReserved);

        public static bool IsConnectedToInternet()
        {
            try
            {
                ConnectionInternetState Description = 0;
                bool conn = InternetGetConnectedState(ref Description, 0);
                return conn;
            }
            catch
            {
                return false;
            }
        }
    }
}
