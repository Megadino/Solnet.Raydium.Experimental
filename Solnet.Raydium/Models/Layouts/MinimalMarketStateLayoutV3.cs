using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    //MINIMAL_MARKET_STATE_LAYOUT_V3
    public class MinimalMarketStateLayoutV3 : BaseLayout
    {
        private static Dictionary<PropertyInfo, int> Offsets =
            typeof(MinimalMarketStateLayoutV3)
            .GetProperties()
            .Where(x => Attribute.GetCustomAttribute(x, typeof(DecodeAttribute)) != null)
            .ToDictionary(x => x, y => ((OffsetAttribute)Attribute.GetCustomAttribute(y, typeof(OffsetAttribute))).Value);

        
        [Offset(0)]    [Decode]
        public PublicKey EventQueue { get; set; }

        [Offset(1 * 32)] [Decode]
        public PublicKey Bids { get; set; }

        [Offset(2 * 32)] [Decode]
        public PublicKey Asks { get; set; }


        public override Dictionary<PropertyInfo, int> GetOffsets() => Offsets;
    }
}
