using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab3
{
    public record PrivateKey(BigInteger P, BigInteger Q);
    public record OpenKey(BigInteger N, BigInteger B);
    internal static class Program
    {
        public static bool IsCorrectParam(BigInteger number, int min, string paramName, out string error)
        {
            error = string.Empty;
            if (number < min + 1)
            {
                error += $"{paramName} должен быть больше {min}!\r\n";
            }

            if (!IsAlmostDivBy4(number))
            {
                error += $"{paramName} должен при делении на 4 иметь остаток 3\r\n";
            }

            if (!IsPrimeMillerRabin(number))
            {
                error += $"{paramName} должно быть простым\r\n";
            }

            return error.Equals(string.Empty);
        }

        public static bool IsCorrectParamB(BigInteger number, int min, int max, string paramName, out string error)
        {
            error = string.Empty;
            if (number < min + 1)
            {
                error += $"{paramName} должен быть больше {min}!\r\n";
            }

            return error.Equals(string.Empty);
        }

        private static bool IsAlmostDivBy4(BigInteger number)
        {
            return number % 4 == 3;
        }

        private static bool IsPrimeMillerRabin(BigInteger number, int iterations = 40)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0) return false;

            BigInteger d = number - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s++;
            }

            Random rand = new Random();

            for (int i = 0; i < iterations; i++)
            {
                BigInteger x = BigInteger.ModPow(2, d, number);

                if (x == 1 || x == number - 1)
                    continue;

                for (int j = 0; j < s - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, number);
                    if (x == 1) return false;
                    if (x == number - 1) break;
                }

                if (x != number - 1) return false;
            }

            return true;
        }







        public static async Task<BigInteger[]> ReadEncryptedFileAsync(string filePath)
        {
            await using FileStream fs = File.OpenRead(filePath);
            using BinaryReader reader = new BinaryReader(fs);

            int length = reader.ReadInt32();
            var encrypted = new BigInteger[length];
            for (int i = 0; i < length; i++)
            {
                int bytes = reader.ReadInt32();
                encrypted[i] = new BigInteger(reader.ReadBytes(bytes));
            }

            return encrypted;
        }

        public static async Task SaveFile(string filePath, BigInteger[] cryptoMessages)
        {
            await using FileStream fs = File.Open(filePath, FileMode.OpenOrCreate);
            await using BinaryWriter writer = new BinaryWriter(fs);

            writer.Write(cryptoMessages.Length);
            foreach (var cryptoMessage in cryptoMessages)
            {
                byte[] buffer = cryptoMessage.ToByteArray();
                writer.Write(buffer.Length);
                writer.Write(buffer);
            }
        }

        public static async Task<byte[]> ReadSimpleFileAsync(string filePath)
        {
            return await File.ReadAllBytesAsync(filePath);
        }

        public static async Task SaveFile(string filePath, byte[] data)
        {
            await File.WriteAllBytesAsync(filePath, data);
        }






        public static BigInteger[] Encrypt(OpenKey openKey, BigInteger[] messages)
        {
            BigInteger[] encrypted = new BigInteger[messages.Length];

            if (messages.Length > 1000)
            {
                Parallel.For(0, messages.Length, i =>
                {
                    encrypted[i] = messages[i] * (openKey.B + messages[i]) % openKey.N;
                });
            }
            else
            {
                for (int i = 0; i < messages.Length; i++)
                {
                    encrypted[i] = messages[i] * (openKey.B + messages[i]) % openKey.N;
                }
            }

            return encrypted;
        }

        public static BigInteger[] Decrypt(OpenKey openKey, PrivateKey privateKey, BigInteger[] encryptedMessages)
        {
            BigInteger[] decrypted = new BigInteger[encryptedMessages.Length];


            for (int i = 0; i < encryptedMessages.Length; i++)
            {
                BigInteger d = (openKey.B * openKey.B + 4 * encryptedMessages[i]) % openKey.N;
                BigInteger mp = ModPow(d, ((privateKey.P + 1) / 4), privateKey.P);
                BigInteger mq = ModPow(d, ((privateKey.Q + 1) / 4), privateKey.Q);

                (BigInteger yp, BigInteger yq) = EuclidExt(privateKey.P, privateKey.Q);
                BigInteger[] dArray = new BigInteger[4];
    
                dArray[0] = (yp * privateKey.P * mq + yq * privateKey.Q * mp) % openKey.N;

                dArray[1] = openKey.N - dArray[0];

                dArray[2] = (yp * privateKey.P * mq - yq * privateKey.Q * mp) % openKey.N;

                dArray[3] = openKey.N - dArray[2];

                BigInteger message = BigInteger.Zero;

                foreach (var dValue in dArray)
                {
                    if ((dValue - openKey.B) % 2 == BigInteger.Zero)
                    {
                        message = (-openKey.B + dValue) / 2 % openKey.N;
                    }
                    else
                    {
                        message = (-openKey.B + openKey.N + dValue) / 2 % openKey.N;
                    }

                    if (message >= 0 && message <= 255)
                        break;
                }

                decrypted[i] = message;
            }

            return decrypted;
        }

        private static BigInteger ModPow(BigInteger a, BigInteger z, BigInteger n)
        {
            BigInteger result = BigInteger.One;

            while (z != 0)
            {
                while (z % 2 == BigInteger.Zero)
                {
                    z /= 2;
                    a = (a * a) % n;
                }

                z -= BigInteger.One;
                result = (result * a) % n;
            }

            return result;
        }

        private static (BigInteger yp, BigInteger yq) EuclidExt(BigInteger a, BigInteger b)
        {
            BigInteger d0 = a, d1 = b;
            BigInteger x0 = BigInteger.One, x1 = BigInteger.Zero;
            BigInteger y0 = BigInteger.Zero, y1 = BigInteger.One;


            while (d1 > 1)
            {
                BigInteger q = d0 / d1;
                BigInteger d2 = d0 % d1;

                BigInteger x2 = x0 - q * x1;
                BigInteger y2 = y0 - q * y1;

                d0 = d1; d1 = d2;
                x0 = x1; x1 = x2;
                y0 = y1; y1 = y2;
            }

            return (x1, y1);
        }






        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}