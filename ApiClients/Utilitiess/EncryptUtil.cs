using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;

namespace TemperatureTool.ApiClients.UtilsUtilitiess
{
    public class EncryptUtil
    {
        /// <summary>
        /// 公開鍵暗号で文字列を暗号化する
        /// </summary>
        /// <param name="text">平文の文字列</param>
        /// <param name="key">鍵</param>
        /// <returns>暗号化された文字列</returns>
        public static string Encrypt(string text, string key, Boolean isPublicKey)
        {

            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] der = Convert.FromBase64String(key);

            if (isPublicKey)
            {
                RSAParameters parameters = CreatePublicParameter(der);

                var provider = new RSACryptoServiceProvider();
                provider.ImportParameters(parameters);
                data = provider.Encrypt(data, true);
            }
            else
            {
                RSAParameters parameters = CreatePrivateParameter(der);

                var provider = new RSACryptoServiceProvider();
                provider.ImportParameters(parameters);


                //メッセージをバイト型配列にして、SHA1ハッシュ値を計算
                SHA256Managed sha = new SHA256Managed();
                byte[] hashData = sha.ComputeHash(data);


                //RSAPKCS1SignatureFormatterオブジェクトを作成
                RSAPKCS1SignatureFormatter rsaFormatter = new RSAPKCS1SignatureFormatter(provider);
                //署名の作成に使用するハッシュアルゴリズムを指定
                rsaFormatter.SetHashAlgorithm("SHA256");

                //署名を作成
                data = rsaFormatter.CreateSignature(hashData);

            }


            //バイト型配列を文字列に変換して返す
            return Convert.ToBase64String(data);


        }

        // 公開鍵クラスを生成
        public static RSAParameters CreatePublicParameter(byte[] der)
        {
            byte[] sequence1 = null;
            using (var reader = new BinaryReader(new MemoryStream(der)))
            {
                sequence1 = Read(reader);
            }

            byte[] sequence2 = null;
            using (var reader = new BinaryReader(new MemoryStream(sequence1)))
            {
                Read(reader); // sequence
                sequence2 = Read(reader); // bit string
            }

            byte[] sequence3 = null;
            using (var reader = new BinaryReader(new MemoryStream(sequence2)))
            {
                sequence3 = Read(reader); // sequence
            }

            var parameters = new RSAParameters();
            using (var reader = new BinaryReader(new MemoryStream(sequence3)))
            {
                parameters.Modulus = Read(reader); // モジュラス
                parameters.Exponent = Read(reader); // 公開指数
            }

            return parameters;
        }

        // 秘密鍵クラスを生成
        private static RSAParameters CreatePrivateParameter(byte[] der)
        {
            byte[] sequence = null;
            using (var reader = new BinaryReader(new MemoryStream(der)))
            {
                sequence = Read(reader);
            }

            var parameters = new RSAParameters();
            using (var reader = new BinaryReader(new MemoryStream(sequence)))
            {
                Read(reader); // version
                parameters.Modulus = Read(reader);
                parameters.Exponent = Read(reader);
                parameters.D = Read(reader);
                parameters.P = Read(reader);
                parameters.Q = Read(reader);
                parameters.DP = Read(reader);
                parameters.DQ = Read(reader);
                parameters.InverseQ = Read(reader);
            }
            return parameters;
        }

        // バイト読み込み
        private static byte[] Read(BinaryReader reader)
        {
            // tag
            reader.ReadByte();

            // length
            int length = 0;
            byte b = reader.ReadByte();
            if ((b & 0x80) == 0x80) // length が128 octet以上
            {
                int n = b & 0x7F;
                byte[] buf = new byte[] { 0x00, 0x00, 0x00, 0x00 };
                for (var i = n - 1; i >= 0; --i)
                    buf[i] = reader.ReadByte();
                length = BitConverter.ToInt32(buf, 0);
            }
            else // length が 127 octet以下
            {
                length = b;
            }

            // value
            if (length == 0)
                return new byte[0];
            byte first = reader.ReadByte();
            if (first == 0x00) length -= 1; // 最上位byteが0x00の場合は、除いておく
            else reader.BaseStream.Seek(-1, SeekOrigin.Current); // 1byte 読んじゃったので、streamの位置を戻しておく
            return reader.ReadBytes(length);
        }

        /// <summary>
        /// JSON オブジェクトへシリアライズ
        /// </summary>
        private string Serialize(object graph)
        {
            using (var stream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(graph.GetType());
                serializer.WriteObject(stream, graph);
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }
    }   
}
