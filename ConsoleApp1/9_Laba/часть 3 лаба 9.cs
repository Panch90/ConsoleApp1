// Все примеры были разобраны и запущены
/*  
принцип действия
   В системах с открытым ключом используются два ключа - открытый и закрытый,
   связанные определенным математическим образом друг с другом.
   Открытый ключ передается по открытому (то есть незащищенные, доступном для наблюдения) канала
   и используется для шифрования сообщения и для проверки ЭЦП.
   Для расшифровки сообщения и для генерации ЭЦП используется секретный ключ.
   Данная схема решает проблему симметричных схем, связанную с начальной передачей ключа другой стороне.
   Если в симметричных схемах злоумышленник перехватит ключ, то он сможет как «слушать»,
   так и вносить правки в передаваемую информацию. В асимметричных системах другой стороне передается открытый ключ,
   который позволяет шифровать, но не расшифровывать информацию.
   Таким образом решается проблема симметричных систем, связанная с синхронизацией ключей.


плюсы
В асимметричных системах ключ используемый для шифрования также известный как открытый (публичный), 
может свободно передаваться другим пользователям. С другой стороны, 
ключ используемый для расшифровки является приватным и должен храниться в секрете.
В свою очередь, асимметричное шифрование решает проблему распределения ключей, 
используя открытые ключи для шифрования, а приватные для дешифрования.

минусы
асимметричные системы очень медленны по сравнению с симметричными и требуют гораздо большей вычислительной мощности из-за длины ключа

   
*/
using System;
using System.IO;
using System.Security.Cryptography;
namespace Shifr
{
    public class DigitalSignature
    {
        private RSAParameters _publicKey;
        private RSAParameters _privateKey;
        public void AssignNewKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false);
                _privateKey = rsa.ExportParameters(true);
            }
        }
        public byte[] SignData(byte[] hashOfDataToSign)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_privateKey);
                var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
                rsaFormatter.SetHashAlgorithm(&quot; SHA256 & quot;);
                return rsaFormatter.CreateSignature(hashOfDataToSign);
            }
        }
        public bool VerifySignature(byte[] hashOfDataToSign, byte[] signature)
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.ImportParameters(_publicKey);
                var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                rsaDeformatter.SetHashAlgorithm(&quot; SHA256 & quot;);
                return rsaDeformatter.VerifySignature(hashOfDataToSign, signature);
            }
        }
    }
}