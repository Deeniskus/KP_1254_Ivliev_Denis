using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypher
{
    class Decryptor
    {
        public string Decrypt(string key, string textToDecrypt)
        {
            string decryptedText = string.Empty;
            DecryptContainer container = new DecryptContainer(key);

            for (int i = 0; i < textToDecrypt.Length; i++)
            {
                decryptedText += container.processorList[i % container.processorList.Count].Process(textToDecrypt[i]);
            }
            return decryptedText;

        }
    }
}
