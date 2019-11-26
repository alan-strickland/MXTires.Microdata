using MXTires.Microdata.Intangible.Enumeration;
using Newtonsoft.Json;

namespace MXTires.Microdata.Actions.TradeActions
{
    /// <summary>
    /// An agent orders an object/product/service to be delivered/sent.
    /// </summary>
    public class OrderAction : TradeAction
    {
        /// <summary>
        /// DeliveryMethod  - A sub property of instrument. The method of delivery.
        /// </summary>
        [JsonProperty("deliveryMethod")]
        public DeliveryMethod DeliveryMethod { get; set; }
        
    }
}
