using PhonePadTranslation;

namespace Nokia3100
{
    class Program
    {
        private static readonly PadTranslator padTranslator = new PadTranslator();

        static void Main(string[] args)
        {
            string result;

            try
            {
                validateArguments(args);
                result = padTranslator.OldPhonePad(args[0]);
            }
            catch (Exception ex)
            {
                result = $"\nError: {ex.Message}\n\n{usageInfo()}";
            }

            Console.WriteLine(result);
        }

        private static void validateArguments(string[] args)
        {
            if (args.Length == 0)
            {
                throw new ArgumentException("No argument provided");
            }
        }

        private static string usageInfo()
        {
            #region Usage info
            return @"
    
    Sample application to demontrate the usage of the PhonePadLib.

    Usage:

        nokia3100.exe <sequence>


    Or:

        dotnet run -c Release -- <sequence>


    Where:

        <sequence> should contain only digits, spaces, * and # as a final character; all after the # will be ignored.

            ";
            #endregion
        }
    }
}
