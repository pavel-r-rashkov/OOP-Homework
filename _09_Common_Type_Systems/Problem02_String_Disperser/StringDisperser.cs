namespace Problem02_String_Disperser
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class StringDisperser : IComparable<StringDisperser>, ICloneable, IEnumerable
    {
        private List<string> Strings { get; set; }

        public StringDisperser(params string[] words)
        {
            this.Strings = words.ToList();
        }

        public void AddString(string str)
        {
            this.Strings.Add(str);
        }

        public string FullString()
        {
            return String.Join("", this.Strings);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            StringDisperser sd = obj as StringDisperser;
            if ((System.Object)sd == null)
            {
                return false;
            }

            if(this.FullString().Equals(sd.FullString()))
            {
                return true;
            }
            return false;
        }

        public bool Equals(StringDisperser sd)
        {
            if ((object)sd == null)
            {
                return false;
            }

            if (this.FullString().Equals(sd.FullString()))
            {
                return true;
            }
            return false;
        }

        public static bool operator ==(StringDisperser a, StringDisperser b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            if (a.FullString().Equals(b.FullString()))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(StringDisperser a, StringDisperser b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (this.FullString()).GetHashCode();
        }

        public override string ToString()
        {
            return this.FullString();
        }


        public int CompareTo(StringDisperser obj)
        {
            return this.FullString().CompareTo((obj as StringDisperser).FullString());
        }

        public object Clone()
        {
            return new StringDisperser(this.Strings.ToArray());
        }

        public IEnumerator GetEnumerator()
        {
            foreach (char ch in this.FullString())
            {
                yield return ch;
            }
        }
    }
}
