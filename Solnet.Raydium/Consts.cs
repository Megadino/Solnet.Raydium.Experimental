using Solnet.Wallet;
using System.Collections.Generic;

namespace Solnet.Raydium
{
    /// <summary>
    /// Collection of Raydium specific consts
    /// </summary>
    public class Consts
    {
        public const string STAKE_PROGRAM_ID = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";
        public const string RAYDIUM_SINGLE_SIDED_STAKING_POOL = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";
        public const string FarmV3 = "EhhTKczWMGQt46ynNeRX1WfeagwwJd7ufHvCDjRxjo5Q";

        public const string STAKE_PROGRAM_ID_V4 = "CBuCnLe26faBpcBP2fktp4rp8abpcAnTWft6ZrP5Q4T";

        public const string STAKE_PROGRAM_ID_V5 = "9KEPoZmtHUrBbhWN1v1KWLMkkvwY6WLtAVUCPRtRjP4z";
        public const string FarmV5 = "9KEPoZmtHUrBbhWN1v1KWLMkkvwY6WLtAVUCPRtRjP4z";
        
        public const string SERUM_MARKET = "9xQeWvG816bUx9EPjHmaT23yvVM2ZWbrrpZb9PusVFin";        
        public const string OPENBOOK_MARKET = "srmqPvymJeFKQ4zGQed1GFppgkRHL9kaELCbyksJtPX";

        public const string UTIL1216 = "CLaimxFqjHzgTJtAGHU47NPhg6qrc5sCnpC4tBLyABQS";
                
        public const string FarmV6 = "FarmqiPv5eAj3j1GMdMCMUGXqPUvmquZtMy86QH6rzhG";
        
        public const string AmmStable = "5quBtoiQqxF9Jv6KYKctB59NT3gtJD2Y65kdnB1Uev3h";
        public const string CLMM = "CAMMCzo5YL8w4VFF8KVHrK22GGUsp5VTaW7grrKgrWqK";
        public const string Router = "routeUGWgWzqBWFcrCfv8tritsqukccJPu3q5GPP3xS";                                

        public const string MetaplexTokenMetadata = "metaqbxxUerdq28cj1RbAWkYQm3ybzjb6a8bt518x1s";        

        public static readonly PublicKey SYSVAR_CLOCK_PUBKEY = new("SysvarC1ock11111111111111111111111111111111");

        public static readonly PublicKey ModelDataPubkey = new PublicKey("CDSr3ssLcRB6XYPJwAfFt18MZvEZp4LjHcvzBVZ45duo");
                
        public static readonly Dictionary<string, string> JitoTips = new Dictionary<string, string>() 
        {
            { "ADuUkR4vqLUMWXxW9gh6D6L8pMSawimctcNZ5pGwDcEt" , "Jitotip 6"},
            { "HFqU5x63VTqvQss8hp11i4wVV8bD44PvwucfZ2bU7gRe" , "Jitotip 2"},
            { "Cw8CFyM9FkoMi7K7Crf6HNQqf4uEMzpKw6QNghXLvLkY" , "Jitotip 3"},
            { "96gYZGLnJYVFmbjzopPSU6QiEV5fGqZNyN9nmNhvrZU5" , "Jitotip 1"},
            { "3AVi9Tg9Uo68tJfuvoKvqKNWKkC5wPdSSdeBnizKZ6jT" , "Jitotip 8"},
            { "ADaUMid9yfUytqMBgopwjb2DTLSokTSzL1zt6iGPaS49" , "Jitotip 4"},
            { "DttWaMuVvTiduZRnguLF7jNxTgiMBZ1hyAumKUiL2KRL" , "Jitotip 7"},
            { "DfXygSm4jCyNCybVYYK6DwvWqjKee8pbDmJGcLWNDXjh" , "Jitotip 5"},            
        };

        public class PumpDotFun
        {
            public const string PumpFunPoolMigrator = "39azUYFWPz3VHgKCf3VChUwbpURdCHRxjWVowf5jUJjg";
            public const string PumpFunMintAuthority = "TSLvdd1pWpHVjahSpsvCXUbgwsL3JAcvokwaKt1eokM";
            public const string PumpFun = "6EF8rrecthR5Dkzon8Nwu78hRvfCKubJ14M5uBEwF6P";
            public const string PumpFunAMM = "pAMMBay6oceH9fJKBRHGP5D4bD4sWpmSwMn52FMfXEA";
            public const string PumpFunGlobalConfig = "ADyA8hdefvWN2dbGGWFotbzWxrAvLW83WG6QCVXvJKqw";
            public const string PumpFunAMMEventAuthority = "GS4CU59F31iL7aR2Q8zVS8DRrcRnXX1yjQ66TqNVQnaR";

            public static readonly byte[] BUY_DISCRIMINATOR = { 102, 6, 61, 18, 1, 218, 235, 234 };
            public static readonly byte[] SELL_DISCRIMINATOR = { 51, 230, 133, 164, 1, 127, 131, 173 };

            public static readonly Dictionary<string, string> ProtocolFee = new Dictionary<string, string>()
            {
                { "7hTckgnGnLQR6sdH7YkqFTAA7VwTfYFaZ6EhEsU3saCX" , "X5QPJcpph4mBAJDzc4hRziFftSbcygV59kRb2Fu6Je1"},                                
            };
        }

        public class RaydiumAmm
        {
            public const string AmmV4 = "675kPX9MHTjS2zt1qfr1NYHuzeLXfQM9H24wFSUt1Mp8";
            public const string RaydiumAuthority = "5Q544fKrFoe6tsEbD7S8EmxGTJYAKtTVhAW5Q5pge4j1";

            public const string RaydiumMigrator = "RAYpQbFNq9i3mu6cKpTKKRwwHFDeK5AuZz8xvxUrCgw";
            public const string RaydiumFeeKeyCpmm = "96wtMuDWqoKkz9Tim3XmqWm3qiySo3FAFjTXLwFJJk4A";
            public const string RaydiumCPMM = "CPMMoo8L3F4NbTegBCKVNunggL7H1ZpdTHKxQB5qKP1C";
            public const string RaydiumVaultAuthority2 = "GpMZbSM2GgvTKHJirzeGfMFoaZ8UR2X7F4v8vHTvxFbL";
            public const string RaydiumCPMMSolFee = "DNXgeM9EiiaAbaWvwjHj9fQQLAX5ZsfHyvmYUNRAdNC8";

            public const string Config = "D4FPEruKEHrG5TenZ2mpDGEfu1iUvTiqBxvpU8HLBvC2";
            public const string GlobalConfig = "6s1xP3hpbAfFoNtUNF8mfHsjr2Bd97JxFJRWLbL6aHuX";

            public const string LockLP = "LockrWmn6K5twhz3y9w1dQERbmgSaRkfnTeTKbpofwE";
            public const string LockCPMMLPAuthority = "3f7GcQFG397GAaEnv51zR6tsTVihYRydnydDD1cXekxH";

            public static readonly byte[] BUY_DISCRIMINATOR = [0x8F, 0xBE, 0x5A, 0xDA, 0xC4, 0x1E, 0x33, 0xDE];
        }

        public class RaydiumLaunchpad
        {
            public const string Launchpad = "LanMV9sAd7wArD4vJFi2qDdfnVhFxYSUg6eADduJ3uj";
            public const string Config = "FfYek5vEz23cMkWsdJwG2oa6EphsvXSHrGpdALN4g6W1";
            public const string Authority = "WLHv2UAZm6z4KyaaELi5pjdbJh6RESMva1Rnn8pJVVh";
        }
    }
}
