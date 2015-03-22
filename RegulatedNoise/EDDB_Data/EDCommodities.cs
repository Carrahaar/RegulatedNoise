﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RegulatedNoise.EDDB_Data.CommoditiesJsonTypes;

namespace RegulatedNoise.EDDB_Data
{

    public class EDCommodities
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        [JsonProperty("average_price")]
        public int? AveragePrice { get; set; }

        [JsonProperty("category")]
        public EDCategory Category { get; set; }

    }

    public class EDCommoditiesWarningLevels
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pricewarninglevel_demand_buy_low")]
        public int PriceWarningLevel_Demand_Buy_Low { get; set; }

        [JsonProperty("pricewarninglevel_demand_buy_high")]
        public int PriceWarningLevel_Demand_Buy_High { get; set; }

        [JsonProperty("pricewarninglevel_supply_buy_low")]
        public int PriceWarningLevel_Supply_Buy_Low { get; set; }
        
        [JsonProperty("pricewarninglevel_supply_buy_high")]
        public int PriceWarningLevel_Supply_Buy_High { get; set; }

        [JsonProperty("pricewarninglevel_demand_sell_low")]
        public int PriceWarningLevel_Demand_Sell_Low { get; set; }

        [JsonProperty("pricewarninglevel_demand_sell_high")]
        public int PriceWarningLevel_Demand_Sell_High { get; set; }

        [JsonProperty("pricewarninglevel_supply_sell_low")]
        public int PriceWarningLevel_Supply_Sell_Low { get; set; }
        
        [JsonProperty("pricewarninglevel_supply_sell_high")]
        public int PriceWarningLevel_Supply_Sell_High { get; set; }
    }

    public class EDCommoditiesExt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int? AveragePrice { get; set; }
        public EDCategory Category { get; set; }

        public int PriceWarningLevel_Demand_Buy_Low { get; set; }
        public int PriceWarningLevel_Demand_Buy_High { get; set; }
        public int PriceWarningLevel_Supply_Buy_Low { get; set; }
        public int PriceWarningLevel_Supply_Buy_High { get; set; }

        public int PriceWarningLevel_Demand_Sell_Low { get; set; }
        public int PriceWarningLevel_Demand_Sell_High { get; set; }
        public int PriceWarningLevel_Supply_Sell_Low { get; set; }
        public int PriceWarningLevel_Supply_Sell_High { get; set; }

        public EDCommoditiesExt(EDCommodities Commodity, EDCommoditiesWarningLevels WarnLevel)
        {

            Id                              = Commodity.Id;
            Name                            = Commodity.Name;
            CategoryId                      = Commodity.CategoryId;
            AveragePrice                    = Commodity.AveragePrice;
            Category                        = Commodity.Category;

            if (WarnLevel != null)
            { 
                PriceWarningLevel_Demand_Buy_Low    = WarnLevel.PriceWarningLevel_Demand_Buy_Low;
                PriceWarningLevel_Demand_Buy_High   = WarnLevel.PriceWarningLevel_Demand_Buy_High;
                PriceWarningLevel_Supply_Buy_Low    = WarnLevel.PriceWarningLevel_Supply_Buy_Low;
                PriceWarningLevel_Supply_Buy_High   = WarnLevel.PriceWarningLevel_Supply_Buy_High;

                PriceWarningLevel_Demand_Sell_Low    = WarnLevel.PriceWarningLevel_Demand_Sell_Low;
                PriceWarningLevel_Demand_Sell_High   = WarnLevel.PriceWarningLevel_Demand_Sell_High;
                PriceWarningLevel_Supply_Sell_Low    = WarnLevel.PriceWarningLevel_Supply_Sell_Low;
                PriceWarningLevel_Supply_Sell_High   = WarnLevel.PriceWarningLevel_Supply_Sell_High;
            }
            else
            {
                PriceWarningLevel_Demand_Buy_Low    = -1;
                PriceWarningLevel_Demand_Buy_High   = -1;
                PriceWarningLevel_Supply_Buy_Low    = -1;
                PriceWarningLevel_Supply_Buy_High   = -1;

                PriceWarningLevel_Demand_Sell_Low    = -1;
                PriceWarningLevel_Demand_Sell_High   = -1;
                PriceWarningLevel_Supply_Sell_Low    = -1;
                PriceWarningLevel_Supply_Sell_High   = -1;
            }

        }

        public void clear()
        { 
            Id                              = -1;
            Name                            = String.Empty;
            CategoryId                      = -1;
            AveragePrice                    = -1;
            Category                        = null;

            PriceWarningLevel_Demand_Buy_Low    = -1;
            PriceWarningLevel_Demand_Buy_High   = -1;
            PriceWarningLevel_Supply_Buy_Low    = -1;
            PriceWarningLevel_Supply_Buy_High   = -1;

            PriceWarningLevel_Demand_Sell_Low    = -1;
            PriceWarningLevel_Demand_Sell_High   = -1;
            PriceWarningLevel_Supply_Sell_Low    = -1;
            PriceWarningLevel_Supply_Sell_High   = -1;
        }

        public static List<EDCommoditiesExt> mergeCommodityData(List<EDCommodities> Commodities, List<EDCommoditiesWarningLevels> WarningLevels)
        {
            List<EDCommoditiesExt> mergedData;
            EDCommoditiesWarningLevels WarnLevel;

            mergedData = new List<EDCommoditiesExt>();

            foreach (EDCommodities Commodity in Commodities)
            {
                WarnLevel = WarningLevels.Find(x => x.Id == Commodity.Id);
                mergedData.Add(new EDCommoditiesExt(Commodity, WarnLevel));
            }

            return mergedData;
        }

        /// <summary>
        /// seperates the included warning levels as list of own objects
        /// </summary>
        /// <param name="mergedData">list seperated to</param>
        /// <returns></returns>
        public static List<EDCommoditiesWarningLevels> extractWarningLevels(List<EDCommoditiesExt> mergedData)
        { 
            List<EDCommoditiesWarningLevels> WarningLevels = new List<EDCommoditiesWarningLevels>();

            foreach (EDCommoditiesExt CommodityExt in mergedData)
            {
                WarningLevels.Add(CommodityExt.getWarningLevels());
            }

            return WarningLevels;
        }

        /// <summary>
        /// seperates the included warning levels as own object
        /// </summary>
        /// <returns></returns>
        private EDCommoditiesWarningLevels getWarningLevels()
        {
            return new EDCommoditiesWarningLevels { Id                              = this.Id, 
                                                    Name                            = this.Name, 
                                                    PriceWarningLevel_Demand_Buy_Low    = this.PriceWarningLevel_Demand_Buy_Low, 
                                                    PriceWarningLevel_Demand_Buy_High   = this.PriceWarningLevel_Demand_Buy_High, 
                                                    PriceWarningLevel_Supply_Buy_Low    = this.PriceWarningLevel_Supply_Buy_Low, 
                                                    PriceWarningLevel_Supply_Buy_High   = this.PriceWarningLevel_Supply_Buy_High,
                                                    PriceWarningLevel_Demand_Sell_Low   = this.PriceWarningLevel_Demand_Sell_Low, 
                                                    PriceWarningLevel_Demand_Sell_High  = this.PriceWarningLevel_Demand_Sell_High, 
                                                    PriceWarningLevel_Supply_Sell_Low   = this.PriceWarningLevel_Supply_Sell_Low, 
                                                    PriceWarningLevel_Supply_Sell_High  = this.PriceWarningLevel_Supply_Sell_High};
        }
    }


}
