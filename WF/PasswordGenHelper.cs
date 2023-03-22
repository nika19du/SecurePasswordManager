using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF
{
    public enum CharType
    {
        LowerCase,
        Uppercase,
        Symbols,
        Digits
    }
    public class PasswordGenHelper
    {
        public static string GeneratePassword(GenerateConfig generateConfig)
        {
            string generatedPassword = string.Empty;

            List<char> characters = new List<char>();

            if (generateConfig.IsLowerCase)
                characters.AddRange(GetCharacters(CharType.LowerCase));
            if (generateConfig.IsUpperCase)
                characters.AddRange(GetCharacters(CharType.Uppercase));
            if (generateConfig.IsDigits)
                characters.AddRange(GetCharacters(CharType.Digits));
            if (generateConfig.IsSymbols)
                characters.AddRange(GetCharacters(CharType.Symbols));

            Random random = new Random();

            List<char> selectedChars = Enumerable.Range(0, generateConfig.Length)
                .Select(x => characters[random.Next(characters.Count)]).ToList();
 
            generatedPassword = string.Join("", selectedChars);

            return generatedPassword;
        }

        public static List<char> GetCharacters(CharType charType)
        {
            if (charType==CharType.LowerCase)
            {//za vseski ascii simbol ot ascii tablicata a do z go convertiram kum char
                return Enumerable.Range('a','z'-'a'+1).Select(x=>(char)x).ToList();
            }
            if (charType == CharType.Uppercase)
            {
                return Enumerable.Range('A', 'Z' - 'A'+1).Select(x => (char)x).ToList();
            }
            if (charType == CharType.Digits)
            {
                return Enumerable.Range('0', '9' - '0' + 1).Select(x => (char)x).ToList();
            }
            return "!@#$%^&*()_+-={}[]\\|;:'\"<>,.?/~`".Where(c => char.IsSymbol(c)).ToList();
        }
    }
}
