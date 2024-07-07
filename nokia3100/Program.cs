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
                result = $"Error: {ex.Message}";
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
    }
}
