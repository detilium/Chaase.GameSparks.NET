using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSparks.NET.Entities
{
    public class GameSparksVirtualGood
    {
        [JsonProperty("WP8StoreProductId")]
        public string WP8StoreProductId { get; set; }
        [JsonProperty("amazonStoreProductId")]
        public string AmazonStoreProductId { get; set; }
        [JsonProperty("baseCurrency1Cost")]
        public int BaseCurrency1Cost { get; set; }
        [JsonProperty("baseCurrency2Cost")]
        public int BaseCurrency2Cost { get; set; }
        [JsonProperty("baseCurrency3Cost")]
        public int BaseCurrency3Cost { get; set; }
        [JsonProperty("baseCurrency4Cost")]
        public int BaseCurrency4Cost { get; set; }
        [JsonProperty("baseCurrency5Cost")]
        public int BaseCurrency5Cost { get; set; }
        [JsonProperty("baseCurrency6Cost")]
        public int BaseCurrency6Cost { get; set; }
        [JsonProperty("bundledGoods")]
        public List<GameSparksBundledGood> BundledGoods { get; set; }
        [JsonProperty("currency1Cost")]
        public int Currency1Cost { get; set; }
        [JsonProperty("currency2Cost")]
        public int Currency2Cost { get; set; }
        [JsonProperty("currency3Cost")]
        public int Currency3Cost { get; set; }
        [JsonProperty("currency4Cost")]
        public int Currency4Cost { get; set; }
        [JsonProperty("currency5Cost")]
        public int Currency5Cost { get; set; }
        [JsonProperty("currency6Cost")]
        public int Currency6Cost { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }
        [JsonProperty("googlePlayProductId")]
        public string GooglePlayProductId { get; set; }
        [JsonProperty("iosAppStoreProductId")]
        public string IOSAppStoreProductId { get; set; }
        [JsonProperty("maxQuantity")]
        public int MaxQuantity { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("propertySet")]
        public dynamic PropertySet { get; set; }
        [JsonProperty("psnStoreProductId")]
        public string PSNStoreProductId { get; set; }
        [JsonProperty("segmentedCurrency1Cost")]
        public int SegmentedCurrency1Cost { get; set; }
        [JsonProperty("segmentedCurrency2Cost")]
        public int SegmentedCurrency2Cost { get; set; }
        [JsonProperty("segmentedCurrency3Cost")]
        public int SegmentedCurrency3Cost { get; set; }
        [JsonProperty("segmentedCurrency4Cost")]
        public int SegmentedCurrency4Cost { get; set; }
        [JsonProperty("segmentedCurrency5Cost")]
        public int SegmentedCurrency5Cost { get; set; }
        [JsonProperty("segmentedCurrency6Cost")]
        public int SegmentedCurrency6Cost { get; set; }
        [JsonProperty("shortCode")]
        public string ShortCode { get; set; }
        [JsonProperty("steamStoreProductId")]
        public string SteamStoreProductId { get; set; }
        [JsonProperty("tags")]
        public string Tags { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("w8StoreProductId")]
        public string W8StoreProductId { get; set; }
    }
}
