using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLH
{
    public class GlobalExchange
    {
        private static GlobalExchange _Instance;

        public List<DLHEntry> dlhEntries = new List<DLHEntry>();

        public static GlobalExchange Inst
        {
            get
            {
                if (_Instance == null) _Instance = new GlobalExchange();
                return _Instance;
            }
        }
    }
}
