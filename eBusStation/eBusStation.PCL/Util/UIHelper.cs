using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PCLCrypto;

namespace eBusStation.PCL.Util
{
    public class UIHelper
    {
        public static string GenerateSalt()
        {
            var buffer =  WinRTCrypto.CryptographicBuffer.GenerateRandom(16);
            return Convert.ToBase64String(buffer);
        }
        public static string GenerateHash(string password,string salt)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] src = Convert.FromBase64String(salt);
            byte[] destination = new byte[src.Length + bytes.Length];

            Array.Copy(src, 0, destination, 0, src.Length);
            Array.Copy(bytes, 0, destination, src.Length, bytes.Length);

            var algorithm = WinRTCrypto.HashAlgorithmProvider.OpenAlgorithm(HashAlgorithm.Sha256);
            byte[] result = algorithm.HashData(destination);
            return Convert.ToBase64String(result);
        }
        public static int GenerateRandomSeats(int maxSeatNumber)
        {
            Random random = new Random();
            return random.Next(1, maxSeatNumber);
        }
        public static int GetNumberFromString(string input)
        {
            var regex = new Regex(@"\d{2}$");
            if (regex.IsMatch(input))
            {
                var match = regex.Match(input);
                return Convert.ToInt32(match.Value);
            }
            return 0;
        }
    }
}
