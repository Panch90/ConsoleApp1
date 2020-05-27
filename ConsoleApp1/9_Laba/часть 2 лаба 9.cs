// Все примеры были разобраны и запущены
/*  
   принцип действия
   В симметричных криптосистемах для шифрования и расшифровки используется один и тот же ключ.
   Отсюда название - симметричны. Алгоритм и ключ выбирается заранее и известный обеим сторонам.
   Сохранение ключа в секретности является важной задачей для установления и поддержания защищенного канала связи.
   В связи с этим, возникает проблема начальной передачи ключа (синхронизации ключей).
   Кроме того существуют методы криптоатак, позволяющие так или иначе дешифровать информацию
   не имея ключа или с помощью его перехвата на этапе согласования.
   В целом эти моменты являются проблемой криптостойкости конкретного алгоритма шифрования
   и является аргументом при выборе конкретного метода.


  Достоинства симметричных систем:

Скорость расчетов примерно на 3 порядка выше.

Относительная простота реализации за счет использования более простых операций.

Меньшая требуемая длинна ключа для сопоставимой стойкости.

Большая изученность за счет большего времени использования.

Недостатки симметричных систем:

Сложность управления ключами в большой сети пользователей, означает квадратичное возрастание числа пар ключей, 
которые необходимо генерировать, передавать и хранить в сети(количество ключей: N=(n*n-1)/2).

Сложность обмена секретными ключами. Для применения, 
необходимо решить проблему надежной передачи ключей каждому абоненту, 
так как нужен секретный канал, для передачи секретного ключа обеим сторонам
*/



using System;
using System.IO;
using System.Security.Cryptography;
namespace Shifr
{
    class Program
    {
        public static void Main()
        {
            try
            {
                const string original = " Advanced Encryption Standard " ;
                using (var myAes = Aes.Create())
                {
                    byte[] encrypted = EncryptStringToBytesAes(original, myAes.Key, myAes.IV);
                    string roundtrip = DecryptStringFromBytesAes(encrypted, myAes.Key, myAes.IV);
                    Console.WriteLine(" Original: { 0}", original);
                    Console.WriteLine(" Round Trip: { 0}", roundtrip);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(" Error: { 0}", e.Message);
            }
        }
        static byte[] EncryptStringToBytesAes(string plainText, byte[] Key, byte[] IV)
{
if (plainText == null || plainText.Length <= 0)
throw new ArgumentNullException(" plainText ");
if (Key == null || Key.Length <= 0)
throw new ArgumentNullException(" Key ");
if (IV == null || IV.Length <= 0)
throw new ArgumentNullException(" IV ");
byte[] encrypted;
using (Aes aesAlg = Aes.Create())
{
aesAlg.Key = Key;
aesAlg.IV = IV;
ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
using (var msEncrypt = new MemoryStream())
{
using (var csEncrypt = new CryptoStream(msEncrypt, encryptor,
CryptoStreamMode.Write))
{
using (var swEncrypt = new StreamWriter(csEncrypt))
{
//Записываем в поток все данные.
swEncrypt.Write(plainText);
}
encrypted = msEncrypt.ToArray();
}
}
}
return encrypted;
}
static string DecryptStringFromBytesAes(byte[] cipherText, byte[] Key, byte[] IV)
{
    if (cipherText == null || cipherText.Length <= 0)
throw new ArgumentNullException(" cipherText ");
    if (Key == null || Key.Length <= 0)
throw new ArgumentNullException(" Key ");
    if (IV == null || IV.Length <= 0)
throw new ArgumentNullException(" IV ");
    string plaintext;
    using (Aes aesAlg = Aes.Create())
    {
        aesAlg.Key = Key;
        aesAlg.IV = IV;
        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
using (var msDecrypt = new MemoryStream(cipherText))
{
using (var csDecrypt = new CryptoStream(msDecrypt, decryptor,
CryptoStreamMode.Read))
{
using (var srDecrypt = new StreamReader(csDecrypt))
{
plaintext = srDecrypt.ReadToEnd();
}
}
}
}
return plaintext;
}
}
}