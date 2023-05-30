namespace eFoodDelivery_API.Tools
{
    public class CodeUtils
    {
        public static string GenerateCode()
        {
            Random random = new Random();
            string codeResult = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                codeResult += random.NextInt64(0, 9).ToString();
            }

            return codeResult;
        }
    }
}
