using System.Text;

namespace JupiterWeb.Persistence.Helper
{
    /// <summary>
    /// Added by YReddy on 08/10/2022 
    /// Used to generate Random password for users
    /// </summary>
    public static class ApplicationHelper
    {
        public static string ConnectionStringkey = "ConnectionStrings:MedullaEmergencyDBConn";

        private readonly static Random r = new Random();
        static string alphaCaps = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        static string alphaLow = "abcdefghijklmnopqrstuvwxyz";
        static string numerics = "1234567890";
        static string special = "@#$-=/";
        static string allChars = alphaCaps + alphaLow + numerics + special;

        /// <summary>
        /// Generate random password with given length
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateRandomPassword(int length = 10)
        {
            string generatedPassword = "";

            int lowerpass, upperpass, numpass, specialchar;
            string posarray = "0123456789";
            if (length < posarray.Length)
                posarray = posarray.Substring(0, length);

            lowerpass = getRandomPosition(ref posarray);
            upperpass = getRandomPosition(ref posarray);
            numpass = getRandomPosition(ref posarray);
            specialchar = getRandomPosition(ref posarray);

            for (int i = 0; i < length; i++)
            {
                if (i == lowerpass)
                    generatedPassword += getRandomChar(alphaCaps);
                else if (i == upperpass)
                    generatedPassword += getRandomChar(alphaLow);
                else if (i == numpass)
                    generatedPassword += getRandomChar(numerics);
                else if (i == specialchar)
                    generatedPassword += getRandomChar(special);
                else
                    generatedPassword += getRandomChar(allChars);
            }


            return generatedPassword;
        }

        /// <summary>
        /// Get Random character for password
        /// </summary>
        /// <param name="fullString"></param>
        /// <returns></returns>
        private static string getRandomChar(string fullString)
        {
            return fullString.ToCharArray()[(int)Math.Floor(r.NextDouble() * fullString.Length)].ToString();
        }

        /// <summary>
        /// Get Random position for password
        /// </summary>
        /// <param name="posArray"></param>
        /// <returns></returns>
        private static int getRandomPosition(ref string posArray)
        {
            int pos;
            string randomChar = posArray.ToCharArray()[(int)Math.Floor(r.NextDouble() * posArray.Length)].ToString();
            pos = int.Parse(randomChar);
            posArray = posArray.Replace(randomChar, "");
            return pos;
        }
    }
}
