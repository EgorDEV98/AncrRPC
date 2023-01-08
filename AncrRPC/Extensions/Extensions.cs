using System.Collections.Generic;
using System.Linq;
using System.Text;
using AncrRPC.Enums;
using AncrRPC.Token;

namespace AncrRPC.Extensions
{
    internal static class Extentions
    {
        internal static string[] EnumToString(this Blockchain blockchain)
        {
            switch (blockchain)
            {
                case Blockchain.BSC:
                    return new[] { "bsc" };
                case Blockchain.ETH:
                    return new[] { "eth" };
                case Blockchain.FANTOM:
                    return new[] {"fantom" };
                case Blockchain.POLYGON:
                    return new[] { "polygon" };
                case Blockchain.SYSCOIN:
                    return new[] { "syscoin" };
                case Blockchain.ARBITRUM:
                    return new[] { "arbitrum" };
                case Blockchain.OPTIMISM:
                    return new[] { "optimism" };
                case Blockchain.AVALANCHE:
                    return new[] { "avalanche"};
            }

            return null;
        }
        
        internal static string EnumToString(this TransactionType transactionType)
        {
            switch (transactionType)
            {
                case TransactionType.REGULAR_TRANSACTION:
                    return "REGULAR_TRANSACTION";
                case TransactionType.TRANSFER_TOKEN:
                    return "TRANSFER_TOKEN";
                case TransactionType.ERC721:
                    return "ERC721";
                case TransactionType.ERC1155:
                    return "ERC1155";
            }

            return null;
        }
        
        internal static bool ToBool(this OrderBy orderBy)
        {
            switch (orderBy)
            {
                case OrderBy.ASC:
                    return true;
                case OrderBy.DESC:
                    return false;
            }
            return false;
        }
        internal static string[] ListToString(this IEnumerable<Blockchain> blockchaines)
        {
            var toListString = blockchaines
                .Select(x => x.ToString())
                .ToArray();
            return toListString;
        }
    }
}