using Solnet.Raydium.Utilities;
using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    /// <summary>
    /// LIQUIDITY_STATE_LAYOUT_V4 
    /// </summary>
    public class LiquidityStateLayoutV4 : BaseLayout
    {
        private static Dictionary<PropertyInfo, int> Offsets =
            typeof(LiquidityStateLayoutV4)
            .GetProperties()
            .Where(x => Attribute.GetCustomAttribute(x, typeof(DecodeAttribute)) != null)
            .ToDictionary(x => x, y => ((OffsetAttribute)Attribute.GetCustomAttribute(y, typeof(OffsetAttribute))).Value);

        [Offset (8 * 0)]
        public ulong Status {  get; set; }
        [Offset(8 * 1)]
        public ulong Nonce { get; set; }
        [Offset(8 * 2)]
        public ulong MaxOrder { get; set; }
        [Offset(8 * 3)]
        public ulong Depth { get; set; }
        
        [Offset(8 * 4)] [Decode]
        public ulong BaseDecimal {  get; set; }
        [Offset(8 * 5)] [Decode]
        public ulong QuoteDecimal {  get; set; }
        
        [Offset(8 * 6)]
        public ulong State {  get; set; }
        [Offset(8 * 7)]
        public ulong ResetFlag {  get; set; }
        [Offset(8 * 8)]
        public ulong MinSize {  get; set; }
        [Offset(8 * 9)]
        public ulong VolMaxCutRatio {  get; set; }
        [Offset(8 * 10)]
        public ulong AmountWaveRatio {  get; set; }
        [Offset(8 * 11)]
        public ulong BaseLotSize {  get; set; }
        [Offset(8 * 12)]
        public ulong QuoteLotSize {  get; set; }
        [Offset(8 * 13)]
        public ulong MinPriceMultiplier {  get; set; }
        [Offset(8 * 14)]
        public ulong MaxPriceMultiplier {  get; set; }
        [Offset(8 * 15)]
        public ulong SystemDecimalValue {  get; set; }
        [Offset(8 * 16)]
        public ulong MinSeparateNumerator {  get; set; }
        [Offset(8 * 17)]
        public ulong MinSeparateDenominator {  get; set; }
        [Offset(8 * 18)]
        public ulong TradeFeeNumerator {  get; set; }
        [Offset(8 * 19)]
        public ulong TradeFeeDenominator {  get; set; }
        [Offset(8 * 20)]
        public ulong PnlNumerator {  get; set; }
        [Offset(8 * 21)]
        public ulong PnlDenominator {  get; set; }
        [Offset(8 * 22)]
        public ulong SwapFeeNumerator {  get; set; }
        [Offset(8 * 23)]
        public ulong SwapFeeDenominator {  get; set; }
        [Offset(8 * 24)]
        public ulong BaseNeedTakePnl {  get; set; }
        [Offset(8 * 25)]
        public ulong QuoteNeedTakePnl {  get; set; }
        [Offset(8 * 26)]
        public ulong QuoteTotalPnl {  get; set; }
        [Offset(8 * 27)]
        public ulong BaseTotalPnl {  get; set; }
        [Offset(8 * 28)]
        public ulong PoolOpenTime {  get; set; }
        [Offset(8 * 29)]
        public ulong PunishPcAmount {  get; set; }
        [Offset(8 * 30)]
        public ulong PunishCoinAmount {  get; set; }
        [Offset(8 * 31)]
        public ulong OrderbookToInitTime {  get; set; }

        // u128 equivalents: represented using two ulong fields in C#
        [Offset(8 * 32)]  [Decode]
        public U128 SwapBaseInAmount {  get; set; }
        [Offset(8 * 34)]  [Decode]
        public U128 SwapQuoteOutAmount {  get; set; }
        [Offset(8 * 36)]  [Decode]
        public ulong SwapBase2QuoteFee {  get; set; }
        [Offset(8 * 37)]  [Decode]
        public U128 SwapQuoteInAmount {  get; set; }
        [Offset(8 * 39)]  [Decode]
        public U128 SwapBaseOutAmount {  get; set; }
        [Offset(8 * 41)]  [Decode]
        public ulong SwapQuote2BaseFee {  get; set; }

        // Amm vault
        [Offset(8 * 42)] [Decode]
        public PublicKey BaseVault {  get; set; }
        [Offset(8 * 46)]  [Decode]
        public PublicKey QuoteVault {  get; set; }

        // Mint        
        [Offset(8 * 50)] [Decode]
        public PublicKey BaseMint {  get; set; }
        
        [Offset(8 * 54)] [Decode]
        public PublicKey QuoteMint {  get; set; }
        
        [Offset(8 * 58)] [Decode]
        public PublicKey LpMint {  get; set; }

        // Market
        [Offset(8 * 62)] [Decode]
        public PublicKey OpenOrders {  get; set; }
        
        [Offset(8 * 66)] [Decode]
        public PublicKey MarketId {  get; set; }
        
        [Offset(8 * 70)] [Decode]
        public PublicKey MarketProgramId {  get; set; }
        
        [Offset(8 * 74)] [Decode]
        public PublicKey TargetOrders {  get; set; }
        
        [Offset(8 * 78)] [Decode]
        public PublicKey WithdrawQueue {  get; set; }
        
        [Offset(8 * 82)][Decode]
        public PublicKey LpVault {  get; set; }
        
        [Offset(8 * 86)] [Decode]
        public PublicKey Owner {  get; set; }

        // Circulating supply
        [Offset(8 * 90)]
        public ulong LpReserve {  get; set; }

        // Padding
        [Offset(8 * 91)]
        public ulong Padding1 {  get; set; }
        [Offset(8 * 92)]
        public ulong Padding2 {  get; set; }
        [Offset(8 * 93)]
        public ulong Padding3 {  get; set; }

        public override Dictionary<PropertyInfo, int> GetOffsets() => Offsets;
    }
}
