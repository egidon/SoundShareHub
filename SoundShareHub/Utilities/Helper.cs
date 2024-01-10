using System.Data.SqlTypes;
using System;

namespace SoundShareHub.Utilities
{
    public class Helper
    {
        public DateTime verifyDate(DateTime a)
        {
            if (a < SqlDateTime.MinValue.Value || a > SqlDateTime.MaxValue.Value)
            {
                // Handle the case where a.PurchaseDate is out of range
                return SqlDateTime.MinValue.Value;
            }
            return a;
        }
    }
}
