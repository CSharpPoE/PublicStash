using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using PathOfExile.Model.Items.Cards;

namespace PathOfExile.Model.Internal
{
    internal class CardBuilder : IJsonBuilder<Card>
    {
        private JObject JObject { get; set; }
        private IParser<JObject> Parser { get; }

        IDictionary<String, Type> CardTypes { get; }

        public CardBuilder()
        {
            Parser = new CardParser();
            CardTypes = AttributeHelper.CreateTypeDictionary<CardAttribute>(new Dictionary<String, Type>());
        }

        public IBuilder<JObject, Card> For(JObject obj)
        {
            JObject = obj;
            return this;
        }

        public Card Build()
        {
            if (CardTypes.TryGetValue(Parser.Parse(JObject), out var cardClass))
            {
                return (Card) JObject.ToObject(cardClass);
            }

            return null;
        }
    }
}