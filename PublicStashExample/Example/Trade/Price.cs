using System;

namespace PublicStashExample.Example.Trade
{
    public class Price
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

    public class Seller
    {
        public String Account { get; set; }
        public String LastKnownCharacter { get; set; }
        public String League { get; set; }

        public Seller(String account, String lastKnownCharacter, String league)
        {
            Account = account;
            LastKnownCharacter = lastKnownCharacter;
            League = league;
        }
    }

    public class Sell
    {
        public Currency Currency { get; set; }
        public String Texted { get; set; }
        public int Stock { get; set; }

        public Sell(String currency, int stock)
        {
            Currency = Currency.Parse(currency);
            Texted = currency;
            Stock = stock;
        }
    }


    public class Buy
    {
        public Currency Currency { get; set; }
        public String Texted { get; set; }
        public int Amount { get; set; }

        public Buy(String currency, int amount)
        {
            Currency = Currency.Parse(currency);
            Texted = currency;
            Amount = amount;
        }
    }
}