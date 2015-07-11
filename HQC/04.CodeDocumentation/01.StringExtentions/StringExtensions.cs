using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace StringExtensions
{
    /// <summary>
    /// String extension methods class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Convert the given <see cref="string"/> to Md5Hash representation
        /// </summary>
        /// <param name="input">The <see cref="string"/> to convert</param>
        /// <returns>Hexadecimal MD5 representation of the <see cref="string"/></returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();

            // Iterate through each byte in the array(data) and append its value to hexadecimal representation
            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(i.ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Converts the <see cref="string"/> to <see cref="bool"/>.
        /// </summary>
        /// <remarks>Everything thats not True, Ok, Yes,1 or Да is considered false.</remarks>
        /// <param name="input">Ths <see cref="string"/> to convert.</param>
        /// <returns><see cref="bool"/> with the result.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Converts the <see cref="string"/> to <see cref="short"/>.
        /// </summary>
        /// <remarks>Returns zero if the conversion fails.</remarks>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>Returns the value as a <see cref="short"/>.</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Converts the <see cref="string"/> to <see cref="int"/>.
        /// </summary>
        /// <remarks>Returns zero if the conversion fails.</remarks>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>Returns the value as a <see cref="int"/>.</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Converts the <see cref="string"/> to <see cref="long"/>.
        /// </summary>
        /// <remarks>Returns zero if the conversion fails.</remarks>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>Returns the value as a <see cref="long"/>.</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Converts the <see cref="string"/> to <see cref="DateTime"/>.
        /// </summary>
        /// <remarks>Returns the <see cref="DateTime.MinValue"/> if the convertion fails.</remarks>
        /// <param name="input">The <see cref="string"/> to convert</param>
        /// <returns>Returns the converted <see cref="DateTime"/></returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Capitalise the <see cref="string"/> first letter.
        /// </summary>
        /// <remarks>Returns the input if its null or empty</remarks>
        /// <param name="input">The <see cref="string"/> to capitalize</param>
        /// <returns>New <see cref="string"/> with capital first letter</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return
                input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) +
                input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Get a part of a whole <see cref="string"/> between two parts of it.
        /// </summary>
        /// <param name="input">The whole <see cref="string"/> to cut.</param>
        /// <param name="startString">The starting point of the wanted <see cref="string"/>.</param>
        /// <param name="endString">The ending point of the wanted <see cref="string"/>.</param>
        /// <param name="startFrom">Index to start from.</param>
        /// <returns>Returns the result <see cref="string"/> or empty if theres no match.</returns>
        public static string GetStringBetween(
            this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition =
                input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// Convert <see cref="string"/> with Cyrillic letters to their latin representation.
        /// </summary>
        /// <remarks>Uses <see cref="CapitalizeFirstLetter"/> to capitalise the needed letters.</remarks>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>The converted <see cref="string"/>.</returns>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
            {
                "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
                "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
            };
            var latinRepresentationsOfBulgarianLetters = new[]
            {
                "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
            };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(),
                    latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Convert a <see cref="string"/> with Latin letters to their Cyrillic representation.
        /// </summary>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>The converted <see cref="string"/>.</returns>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            var bulgarianRepresentationOfLatinKeyboard = new[]
            {
                "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                "в", "ь", "ъ", "з"
            };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(),
                    bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Converts the <see cref="string"/> to valid username.
        /// </summary>
        /// <remarks>Uses <see cref="ConvertCyrillicToLatinLetters"/> for the convertion.</remarks>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>Validated username <see cref="string"/>.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Converts the <see cref="string"/> to valid filename.
        /// </summary>
        /// <remarks>Uses <see cref="ConvertCyrillicToLatinLetters"/> for the convertion.</remarks>
        /// <param name="input">The <see cref="string"/> to convert.</param>
        /// <returns>Valid filename <see cref="string"/>.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty); // Replaces all invalid username characters to blank.
        }


        /// <summary>
        /// Get a number of characters from a <see cref="string"/>.
        /// </summary>
        /// <param name="input">The base <see cref="string"/>.</param>
        /// <param name="charsCount">Number of characters to get.</param>
        /// <returns>Returns a new <see cref="string"/> with the specified number of characters from the start of the base <see cref="string"/>.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Gets the file extension from a filename <see cref="string"/>.
        /// </summary>
        /// <remarks>Returns <see cref="string.Empty"/> if the input is null or empty.</remarks>
        /// <param name="fileName">The filename <see cref="string"/> to get the extension from.</param>
        /// <returns>Returns the extension.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Converts a file extension <see cref="string"/> to its content type representation.
        /// </summary>
        /// <remarks>Returns "application/octet-stream" if the extension is not supported.</remarks>
        /// <param name="fileExtension">The <see cref="string"/> to convert.</param>
        /// <returns>Returns the content type of the given extension.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
            {
                { "jpg", "image/jpeg" },
                { "jpeg", "image/jpeg" },
                { "png", "image/x-png" },
                { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
                { "doc", "application/msword" },
                { "pdf", "application/pdf" },
                { "txt", "text/plain" },
                { "rtf", "application/rtf" }
            };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a <see cref="string"/>string to <see cref="byte"/> array.
        /// </summary>
        /// <param name="input">The <see cref="string"/>string to convert.</param>
        /// <returns>Result <see cref="byte"/> Array.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
