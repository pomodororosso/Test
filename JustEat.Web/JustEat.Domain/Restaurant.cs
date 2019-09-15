using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustEat.Domain
{
    public class Restaurant
    {
        public object[] Badges { get; set; }
        public float Score { get; set; }
        public float? DriveDistance { get; set; }
        public bool DriveInfoCalculated { get; set; }
        public DateTime NewnessDate { get; set; }
        public int? DeliveryMenuId { get; set; }
        public DateTime? DeliveryOpeningTime { get; set; }
        public float? DeliveryCost { get; set; }
        public float? MinimumDeliveryValue { get; set; }
        public int? DeliveryTime { get; set; }
        public DateTime? OpeningTime { get; set; }
        public DateTime? OpeningTimeIso { get; set; }
        public bool SendsOnItsWayNotifications { get; set; }
        public float RatingAverage { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public string City { get; set; }
        public Cuisinetype[] CuisineTypes { get; set; }
        public string Url { get; set; }
        public bool IsOpenNow { get; set; }
        public bool IsSponsored { get; set; }
        public bool IsNew { get; set; }
        public bool IsTemporarilyOffline { get; set; }
        public string ReasonWhyTemporarilyOffline { get; set; }
        public string UniqueName { get; set; }
        public bool IsCloseBy { get; set; }
        public bool IsHalal { get; set; }
        public int DefaultDisplayRank { get; set; }
        public bool IsOpenNowForDelivery { get; set; }
        public bool IsOpenNowForCollection { get; set; }
        public float RatingStars { get; set; }
        public Logo[] Logo { get; set; }
        public Deal[] Deals { get; set; }
        public int NumberOfRatings { get; set; }
    }

}
