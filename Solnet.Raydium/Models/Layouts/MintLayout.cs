using Solnet.Wallet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    /// <summary>
    /// Mint Layout 
    /// </summary>
    /// 

    /*
     export const MintLayout = struct<RawMint>([
        u32('mintAuthorityOption'),
        publicKey('mintAuthority'),
        u64('supply'),
        u8('decimals'),
        bool('isInitialized'),
        u32('freezeAuthorityOption'),
        publicKey('freezeAuthority'),
    ]);
     * 
    https://github.com/solana-labs/solana-program-library/blob/d11011af60ec42df5c0cb5d38940d353f55392ca/token/js/src/state/mint.ts#L41
     */

    public class MintLayout : BaseLayout
    {
        private static Dictionary<PropertyInfo, int> Offsets =
            typeof(MintLayout)
            .GetProperties()
            .Where(x => Attribute.GetCustomAttribute(x, typeof(DecodeAttribute)) != null)
            .ToDictionary(x => x, y => ((OffsetAttribute)Attribute.GetCustomAttribute(y, typeof(OffsetAttribute))).Value);

        [Offset(0)] [Decode]
        public uint MintAuthorityOption { get; set; }
                
        [Offset(4)] [Decode]
        public PublicKey MintAuthority { get; set; }

        [Offset(36)] [Decode]
        public ulong Supply {  get; set; }
        
        [Offset(44)]  [Decode]
        public byte Decimals {  get; set; }
        
        [Offset(45)]  [Decode]
        public byte IsInitialized {  get; set; }
        
        [Offset(46)]  [Decode]
        public uint FreezeAuthorityOption {  get; set; }
        
        [Offset(50)] 
        public PublicKey FreezeAuthority {  get; set; }
        

        public override Dictionary<PropertyInfo, int> GetOffsets() => Offsets;
    }
}
