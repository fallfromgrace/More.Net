using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace Light
{
    /// <summary>
    /// 
    /// </summary>
    public struct CharEnumerator : IEnumerator, IEnumerator<Char>, IDisposable
    {
        private String source;
        private Int32 index;
        private Char currentElement;

        public CharEnumerator(String source)
        {
            Contract.Requires(source != null);
            this.source = source;
            this.index = -1;
            this.currentElement = '\0';
        }

        private CharEnumerator(String source, Int32 index, Char currentElement)
        {
            Contract.Requires(source != null);
            this.source = source;
            this.index = index;
            this.currentElement = currentElement;
        }

        public CharEnumerator Clone()
        {
            return new CharEnumerator(this.source, this.index, this.currentElement);
        }

        public Boolean MoveNext()
        {
            if (index < (source.Length - 1))
            {
                index++;
                currentElement = source[index];
                return true;
            }
            else
                index = source.Length;
            return false;

        }

        public void Dispose()
        {
            if (source != null)
                index = source.Length;
            source = null;
        }

        /// <internalonly/>
        Object IEnumerator.Current
        {
            get { return this.Current; }
        }

        public Char Current
        {
            get
            {
                if (index == -1)
                    throw new InvalidOperationException();
                if (index >= source.Length)
                    throw new InvalidOperationException();
                return currentElement;
            }
        }

        public void Reset()
        {
            currentElement = '\0';
            index = -1;
        }
    }
}
