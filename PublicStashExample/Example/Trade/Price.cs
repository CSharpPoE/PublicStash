using System;
using PoEPublicStash.Model;

namespace PublicStashExample.Example.Trade
{
    class Price
    {
        public Seller Seller { get; set; }
        public Buy Buying { get; set; }
        public Sell Selling { get; set; }
        public decimal PricePerUnit { get; set; }
        public String TextedPrice { get; set; }
        public String OriginalText { get; set; }

        public Price(Seller seller, decimal pricePerUnit, String textedPrice, String originalText,
            Sell selling, Buy buying)
        {
            Seller = seller;

            TextedPrice = textedPrice;
            OriginalText = originalText;
            PricePerUnit = pricePerUnit;
            Buying = buying;
            Selling = selling;
        }
    }

    class Seller
    {
        public String Account { get; set; }
        public String LastKnownCharacter{ get; set; }
        public String League { get; set; }

        public Seller(String account, String lastKnownCharacter, String league)
        {
            Account = account;
            LastKnownCharacter = lastKnownCharacter;
            League = league;
        }

    }

    class Buy
    {
        public String Buying { get; set; }
        public int Amount { get; set; }

        public Buy(String buying, int amount)
        {
            Buying = buying;
            Amount = amount;
        }
    }

    class Sell
    {
        public String Selling { get; set; }
        public int Stock { get; set; }

        public Sell(String selling, int stock)
        {
            Selling = selling;
            Stock = stock;
        }
    }
}