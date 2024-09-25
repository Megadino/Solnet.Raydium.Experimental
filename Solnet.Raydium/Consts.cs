using Solnet.Wallet;

namespace Solnet.Raydium
{
    /// <summary>
    /// Collection of Raydium specific consts
    /// </summary>
    public class Consts
    {
        public const string STAKE_PROGRAM_ID = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";

        public const string STAKE_PROGRAM_ID_V4 = "CBuCnLe26faBpcBP2fktp4rp8abpcAnTWft6ZrP5Q4T";

        public const string STAKE_PROGRAM_ID_V5 = "9KEPoZmtHUrBbhWN1v1KWLMkkvwY6WLtAVUCPRtRjP4z";

        public const string LIQUIDITY_POOL_PROGRAM_ID_V4 = "675kPX9MHTjS2zt1qfr1NYHuzeLXfQM9H24wFSUt1Mp8";
        
        public const string RAYDIUM_SINGLE_SIDED_STAKING_POOL = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";


        public const string SERUM_MARKET = "9xQeWvG816bUx9EPjHmaT23yvVM2ZWbrrpZb9PusVFin";
        public const string OPENBOOK_MARKET = "srmqPvymJeFKQ4zGQed1GFppgkRHL9kaELCbyksJtPX";

        public const string UTIL1216 = "CLaimxFqjHzgTJtAGHU47NPhg6qrc5sCnpC4tBLyABQS";

        public const string FarmV3 = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";
        public const string FarmV5 = "9KEPoZmtHUrBbhWN1v1KWLMkkvwY6WLtAVUCPRtRjP4z";
        public const string FarmV6 = "FarmqiPv5eAj3j1GMdMCMUGXqPUvmquZtMy86QH6rzhG";
        public const string AmmV4 = "675kPX9MHTjS2zt1qfr1NYHuzeLXfQM9H24wFSUt1Mp8";
        public const string AmmStable = "5quBtoiQqxF9Jv6KYKctB59NT3gtJD2Y65kdnB1Uev3h";
        public const string CLMM = "CAMMCzo5YL8w4VFF8KVHrK22GGUsp5VTaW7grrKgrWqK";
        public const string Router = "routeUGWgWzqBWFcrCfv8tritsqukccJPu3q5GPP3xS";

        /// <summary>
        /// The public key of the sysvar clock account.
        /// </summary>
        public static readonly PublicKey SYSVAR_CLOCK_PUBKEY = new("SysvarC1ock11111111111111111111111111111111");

        public static readonly PublicKey ModelDataPubkey = new PublicKey("CDSr3ssLcRB6XYPJwAfFt18MZvEZp4LjHcvzBVZ45duo");

    }
}
