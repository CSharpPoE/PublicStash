using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PathOfExile.Model;
using PathOfExile.Model.Internal;
using PathOfExile.Model.Items;

namespace PathOfExile
{
    internal class Http
    {
        private static HttpClient _client;

        internal static HttpClient Instance { get; } =
            _client ?? (_client = new HttpClient());
    }

    /// <summary>
    /// A static class containing methods to get public stash tabs from path of exile's public api
    /// </summary>
    public static class PublicStashAPI
    {
        /// <summary>
        /// The path of exile public stash url.
        /// </summary>
        private const String POE_API_PUBLIC_STASH_URL = "http://api.pathofexile.com/public-stash-tabs/";

        /// <summary>
        /// URLs to a few sites containing the latest change id
        /// </summary>
        private static readonly IEnumerable<String> POE_API_LATEST_CHANGE_ID_URL = new[]
        {
            "https://poe.ninja/api/Data/GetStats",
            "http://api.poe.ovh/ChangeID",
            "http://poe-rates.com/actions/getLastChangeId.php"
        };

        private static readonly JsonSerializerSettings DefaultResolver = new JsonSerializerSettings
        {
            ContractResolver = new DefaultResolver()
        };

        public static void Run(List<Action<PublicStash>> actions, int delay = 10000)
        {
            var init = true;
            PublicStash publicStash = null;
            var nextChangeId = "";
            var cachedChangeId = "";
            while (true)
            {
                try
                {
                    if (init)
                    {
                        publicStash = GetAsync().Result;
                        nextChangeId = publicStash.next_change_id;
                        cachedChangeId = "";
                        init = false;
                    }

                    var Start = DateTime.UtcNow;
                    if (cachedChangeId != nextChangeId)
                    {
                        cachedChangeId = nextChangeId;
                        foreach (var action in actions) action(publicStash);
                    }
                    else
                    {
                        publicStash = GetAsync(nextChangeId).Result;
                        nextChangeId = publicStash.next_change_id;
                        new ManualResetEvent(false).WaitOne(Math.Max(0,
                            delay - (int) (DateTime.UtcNow - Start).TotalMilliseconds));
                    }
                }
                catch
                {
                    if (String.IsNullOrEmpty(nextChangeId))
                        nextChangeId = GetLatestStashIdAsync().Result;
                }
            }
        }

        /// <summary>
        /// Does a GET to the path of exile public stash api with the latest change id as the query
        /// </summary>
        /// <returns></returns>
        public static async Task<PublicStash> GetAsync() =>
            await GetAsync(await GetLatestStashIdAsync());

        /// <summary>
        /// Does a GET to the path of exile public stash api with id as the query
        /// </summary>
        /// <param name="id">unique id for the public stash data set to be fetched</param>
        /// <returns></returns>
        public static async Task<PublicStash> GetAsync(String id) =>
            await GetAsync<PublicStash>(await Http.Instance.GetAsync($"{POE_API_PUBLIC_STASH_URL}?id={id}"));

        /// <summary>
        /// Query up to three popular community provided poe sites for the latest available change id. 
        /// </summary>
        /// <returns></returns>
        public static async Task<String> GetLatestStashIdAsync()
        {
            foreach (var url in POE_API_LATEST_CHANGE_ID_URL)
            {
                String result = GetAsync<dynamic>(await Http.Instance.GetAsync(url)).Result?.next_change_id;
                if (!String.IsNullOrEmpty(result)) return result;
            }

            return default;
        }

        /// <summary>
        /// Takes a HttpResponseMessage as a parameter and returns the deserialized content from the request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        private static async Task<T> GetAsync<T>(HttpResponseMessage response) =>
            JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), DefaultResolver);
    }

    internal class DefaultResolver : DefaultContractResolver
    {
        protected override JsonContract CreateContract(Type objectType)
        {
            var contract = base.CreateContract(objectType);
            if (objectType == typeof(Item)) contract.Converter = new ItemConverter();
            return contract;
        }
    }
}