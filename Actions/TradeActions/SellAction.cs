﻿using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TradeActions
{
    /// <summary>
    /// The act of taking money from a buyer in exchange for goods or services rendered. An agent sells an object, product, or service to a buyer for a price. 
    /// Reciprocal of BuyAction.
    /// </summary>
    public class SellAction : TradeAction
    {
        /// <summary>
        /// Person - A sub property of participant. The participant/person/organization that bought the object.
        /// </summary>
        [JsonProperty("buyer")]
        public Person Buyer { get; set; }
    }
}
