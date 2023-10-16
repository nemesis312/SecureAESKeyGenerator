using EncyptDecrypt;

CryptoHelper crypto = new CryptoHelper();

int keySize = 128; // change between 128, 192 and 256
string generatedKey = KeyGenHelper.GenerateKey(keySize);
Console.WriteLine($"Generated Key ({keySize} bits): {generatedKey}");

string originalText = "Text to be encrypted here...";
string encryptedText = crypto.Encrypt(originalText, generatedKey);
string decryptedText = crypto.Decrypt(encryptedText, generatedKey);

Console.WriteLine($"Original text: {originalText}");
Console.WriteLine($"Encrypted text: {encryptedText}");
Console.WriteLine($"Decrypted text: {decryptedText}");