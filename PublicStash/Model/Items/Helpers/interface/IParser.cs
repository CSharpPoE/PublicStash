using System;
using Newtonsoft.Json.Linq;

namespace PathOfExile.Model.Items
{
    internal interface IParser<in T>
    {
        String Parse(T obj);
    }

    internal interface IJsonParser : IParser<JObject>
    {
    }
}