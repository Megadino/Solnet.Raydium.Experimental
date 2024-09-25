using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    /// <summary>
    /// MARKET_STATE_LAYOUT_V3 
    /// </summary>
    public class MarketStateLayoutV3 : BaseLayout
    {
        private static Dictionary<PropertyInfo, int> Offsets =
            typeof(MarketStateLayoutV3)
            .GetProperties()
            .Where(x => Attribute.GetCustomAttribute(x, typeof(DecodeAttribute)) != null)
            .ToDictionary(x => x, y => ((OffsetAttribute)Attribute.GetCustomAttribute(y, typeof(OffsetAttribute))).Value);

        [Offset(0)] 
        public byte[] Blob1 { get; set; }
        
        [Offset(5)] //[Decode]
        public byte[] AccountFlags { get; set; }
        
        [Offset(13)] [Decode]
        public PublicKey OwnAddress { get; set; }

        [Offset(45)] [Decode]
        public ulong VaultSignerNonce {  get; set; }
        
        [Offset(53)]  [Decode]
        public PublicKey BaseMint {  get; set; }
        
        [Offset(85)]  [Decode]
        public PublicKey QuoteMint {  get; set; }
        
        [Offset(117)]  [Decode]
        public PublicKey BaseVault {  get; set; }
        
        [Offset(149)]  [Decode]
        public ulong BaseDepositsTotal {  get; set; }
        
        [Offset(157)]  [Decode]
        public ulong BaseFeesAccrued {  get; set; }
        
        [Offset(165)]  [Decode]
        public PublicKey QuoteVault {  get; set; }
        
        [Offset(197)]   [Decode]
        public ulong QuoteDepositsTotal {  get; set; }
        
        [Offset(205)]   [Decode]
        public ulong QuoteFeesAccrued {  get; set; }
        
        [Offset(213)]   [Decode]
        public ulong QuoteDustThreshold {  get; set; }
        
        [Offset(221)]   [Decode]
        public PublicKey RequestQueue {  get; set; }
        
        [Offset(253)]  [Decode]
        public PublicKey EventQueue {  get; set; }
        
        [Offset(285)]   [Decode]
        public PublicKey Bids {  get; set; }
        
        [Offset(317)]   [Decode]
        public PublicKey Asks {  get; set; }
        
        [Offset(349)]   [Decode]
        public ulong BaseLotSize {  get; set; }
        
        [Offset(357)]   [Decode]
        public ulong QuoteLotSize {  get; set; }
        
        [Offset(365)]   [Decode]
        public ulong FeeRateBps {  get; set; }
        
        [Offset(373)]   [Decode]
        public ulong ReferrerRebatesAccrued {  get; set; }

        [Offset(381)]  
        public byte[] Blob2 {  get; set; } // 7 bytes

        public override Dictionary<PropertyInfo, int> GetOffsets() => Offsets;
    }
}
