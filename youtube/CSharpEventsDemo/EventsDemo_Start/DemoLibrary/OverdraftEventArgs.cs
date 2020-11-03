using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class OverdraftEventArgs : EventArgs
    {
        public decimal AmountOverdrafed { get; private set; }
        public string MoreInfo { get; private set; }
        public bool CanncelTransation { get; set; } = false;

        public OverdraftEventArgs(decimal amountOverdrafted, string moreInfo)
        {
            AmountOverdrafed = amountOverdrafted;
            MoreInfo = moreInfo;
        }
    }
}
