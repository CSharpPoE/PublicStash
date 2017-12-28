using System;
using PoEPublicStash.Model;

namespace PublicStashExample.Example.Trade
{
    class Price
    {
        public String Seller { get; set; }
        public String League { get; set; }
        public Buy Buying { get; set; }
        public Sell Selling { get; set; }
        public decimal PricePerUnit { get; set; }
        public String TextedPrice { get; set; }
        public String OriginalText { get; set; }

        public Price(String seller, String league, decimal pricePerUnit, String textedPrice, String originalText,
            Sell selling, Buy buying)
        {
            Seller = seller;
            League = league;
            TextedPrice = textedPrice;
            OriginalText = originalText;
            PricePerUnit = pricePerUnit;
            Buying = buying;
            Selling = selling;
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
        public int Amount { get; set; }

        public Sell(String selling, int amount)
        {
            Selling = selling;
            Amount = amount;
        }
    }
}