using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    public class PumpSwapAmmLayout : BaseLayout
    {
        private static Dictionary<PropertyInfo, int> Offsets =
            typeof(PumpSwapAmmLayout)
            .GetProperties()
            .Where(x => Attribute.GetCustomAttribute(x, typeof(DecodeAttribute)) != null)
            .ToDictionary(x => x, y => ((OffsetAttribute)Attribute.GetCustomAttribute(y, typeof(OffsetAttribute))).Value);

        public override Dictionary<PropertyInfo, int> GetOffsets() => Offsets;

        [Offset(8)]
        [Decode]
        public byte PoolBump { get; set; }

        [Offset(9)]
        [Decode]
        public ushort Index { get; set; }

        [Offset(11)]
        [Decode]
        public PublicKey Creator { get; set; }

        [Offset(43)]
        [Decode]
        public PublicKey BaseMint { get; set; }

        [Offset(75)]
        [Decode]
        public PublicKey QuoteMint { get; set; }

        [Offset(107)]
        [Decode]
        public PublicKey LpMint { get; set; }

        [Offset(139)]
        [Decode]
        public PublicKey PoolBaseTokenAccount { get; set; }

        [Offset(171)]
        [Decode]
        public PublicKey PoolQuoteTokenAccount { get; set; }

        [Offset(203)]
        [Decode]
        public ulong LpSupply { get; set; }
    }
}
