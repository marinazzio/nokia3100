using PhonePadTranslation;

namespace Nokia3100
{
    class Program
    {
        static void Main(string[] args)
        {
            PadTranslator padTranslator = new PadTranslator();

            var result = padTranslator.OldPhonePad(args[0]);

            Console.WriteLine(result);
        }
    }
}
