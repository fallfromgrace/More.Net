using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace More.Net.Xml.Linq
{
    public static class XContainerExtensions
    {
        public static XElement ElementOrEmpty<TElement>(
            this TElement element,
            XName name)
            where TElement : XContainer
        {
            return element
                .Elements(name)
                .FirstOrDefault() ?? new XElement(name);
        }

        public static String ElementValueFirstOrDefault<TElement>(
            this TElement element,
            XName name)
            where TElement : XContainer
        {
            return element
                .Elements(name)
                .Select(e => e.Value)
                .FirstOrDefault();
        }

        public static TResult ElementSelectFirstOrDefault<TElement, TResult>(
            this TElement element,
            XName name,
            Func<XElement, TResult> selector)
            where TElement : XContainer
        {
            return element
                .Elements(name)
                .Select(selector)
                .FirstOrDefault();
        }
    }
}
