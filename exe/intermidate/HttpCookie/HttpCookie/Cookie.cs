using System;
using System.Collections.Generic;
using System.Drawing;

namespace HttpCookie
{
    public class Cookie
    {
        private readonly Dictionary<string, string> _dictonary;
        public DateTime Expiry { get; set; }

        public Cookie()
        {
            _dictonary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictonary[key]; }
            set { _dictonary[key] = value; }
        }

    }
}
