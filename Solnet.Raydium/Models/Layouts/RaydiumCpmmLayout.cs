using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    public class RaydiumCpmmLayout : BaseLayout
    {
        private static Dictionary<PropertyInfo, int> Offsets =
            typeof(RaydiumCpmmLayout)
            .GetProperties()
            .Where(x => Attribute.GetCustomAttribute(x, typeof(DecodeAttribute)) != null)
            .ToDictionary(x => x, y => ((OffsetAttribute)Attribute.GetCustomAttribute(y, typeof(OffsetAttribute))).Value);

        public override Dictionary<PropertyInfo, int> GetOffsets() => Offsets;

        [Offset(8)]
        [Decode]
        public PublicKey AmmConfig { get; set; }

        [Offset(40)]
        [Decode]
        public PublicKey PoolCreator { get; set; }

        [Offset(72)]
        [Decode]
        public PublicKey Token0Vault { get; set; }

        [Offset(104)]
        [Decode]
        public PublicKey Token1Vault { get; set; }

        [Offset(136)]
        [Decode]
        public PublicKey LpMint { get; set; }

        [Offset(168)]
        [Decode]
        public PublicKey Token0Mint { get; set; }

        [Offset(200)]
        [Decode]
        public PublicKey Token1Mint { get; set; }

        [Offset(232)]
        [Decode]
        public PublicKey Token0Program { get; set; }

        [Offset(264)]
        [Decode]
        public PublicKey Token1Program { get; set; }

        [Offset(296)]
        [Decode]
        public PublicKey ObservationKey { get; set; }

        [Offset(328)]
        [Decode]
        public byte AuthBump { get; set; }

        [Offset(329)]
        [Decode]
        public byte Status { get; set; }

        [Offset(330)]
        [Decode]
        public byte lp_mint_decimals { get; set; }

        [Offset(331)]
        [Decode]
        public byte mint_0_decimals { get; set; }

        [Offset(332)]
        [Decode]
        public byte mint_1_decimals { get; set; }


        [Offset(333)]
        [Decode]
        public ulong LpSupply { get; set; }
        
        [Offset(341)]
        [Decode]
        public ulong protocol_fees_token_0 { get; set; }
        
        [Offset(349)]
        [Decode]
        public ulong protocol_fees_token_1 { get; set; }
        
        [Offset(357)]
        [Decode]
        public ulong fund_fees_token_0 { get; set; }
        
        [Offset(365)]
        [Decode]
        public ulong fund_fees_token_1 { get; set; }
        
        [Offset(373)]
        [Decode]
        public ulong open_time { get; set; }
        
        [Offset(381)]
        [Decode]
        public ulong recent_epoch { get; set; }
    }
}
