using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Diagnostics.Contracts;

namespace Light
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Converts the String into a UTF8 byte array.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Byte[] EncodeToBytes(this String source)
        {
            return source.EncodeToBytes(Encoding.UTF8);
        }

        /// <summary>
        /// Converts the String into byte array using the specified encoding.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static Byte[] EncodeToBytes(this String source, Encoding encoding)
        {
            return encoding.GetBytes(source);
        }

        /// <summary>
        /// Converts the specified string to its literal representation.
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<Char> ToLiteral<TSource>(this TSource source)
            where TSource : IEnumerable<Char>
        {
            Contract.Requires(source != null);

            yield return '\"';
            foreach (Char sourceChar in source)
            {
                switch (sourceChar)
                {
                    case '\'': yield return '\\'; yield return '\''; break;
                    case '\"': yield return '\\'; yield return '\"'; break;
                    case '\\': yield return '\\'; yield return '\\'; break;
                    case '\0': yield return '\\'; yield return '0'; break;
                    case '\a': yield return '\\'; yield return 'a'; break;
                    case '\b': yield return '\\'; yield return 'b'; break;
                    case '\f': yield return '\\'; yield return 'f'; break;
                    case '\n': yield return '\\'; yield return 'n'; break;
                    case '\r': yield return '\\'; yield return 'r'; break;
                    case '\t': yield return '\\'; yield return 't'; break;
                    case '\v': yield return '\\'; yield return 'v'; break;
                    default:
                        if (sourceChar >= 0x20 &&
                            sourceChar <= 0x7e)
                        {
                            yield return sourceChar;
                        }
                        else
                        {
                            yield return '\\';
                            yield return 'u';
                            foreach (Char c in (Convert.ToUInt16(sourceChar)).ToString("x4"))
                                yield return c;
                        }
                        break;
                }
            }
            yield return'\"';
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Int32 ToInt32(this String source)
        {
            Contract.Requires(source != null);
            Contract.Requires(source != String.Empty);

            return Convert.ToInt32(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Guid ToGuid(this String source)
        {
            Contract.Requires(source != null);
            Contract.Requires(source != String.Empty);

            return Guid.Parse(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static DateTime ToDateTime(this String source)
        {
            Contract.Requires(source != null);
            Contract.Requires(source != String.Empty);

            return DateTime.Parse(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static XDocument ParseXmlDocument(this String source)
        {
            Contract.Requires(source != null);
            Contract.Ensures(Contract.Result<XDocument>() != null);

            return XDocument.Parse(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static XElement ParseXmlElement(this String source)
        {
            Contract.Requires(source != null);
            Contract.Ensures(Contract.Result<XElement>() != null);

            return XElement.Parse(source);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static Boolean IsNullOrWhiteSpace(this String source)
        {
            return String.IsNullOrWhiteSpace(source);
        }

        /// <summary>
        /// *2?1
        /// 0021201
        /// </summary>
        /// <param name="source"></param>
        /// <param name="mask"></param>
        /// <returns></returns>
        public static Boolean Match(this String source, String mask)
        {
            return Match(new CharEnumerator(source), new CharEnumerator(mask));
        }

        private static Boolean Match(CharEnumerator sourceEnumerator, CharEnumerator maskEnumerator)
        {

            while (maskEnumerator.MoveNext() == true)
            {
                switch (maskEnumerator.Current)
                {
                    case '?':
                        if (sourceEnumerator.MoveNext() == false)
                            return false;
                        else
                            break;
                    case '*':
                        while (Match(sourceEnumerator.Clone(), maskEnumerator.Clone()) == false)
                        {
                            if (sourceEnumerator.MoveNext() == false)
                                return false;
                        }
                        break;
                    default:
                        if (sourceEnumerator.MoveNext() == false ||
                            sourceEnumerator.Current != maskEnumerator.Current)
                            return false;
                        else
                            break;
                }
            }

            return true;
        }
    }
}
