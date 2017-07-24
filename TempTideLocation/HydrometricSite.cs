//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class HydrometricSite
    {
        public HydrometricSite()
        {
            this.HydrometricDataValues = new HashSet<HydrometricDataValue>();
        }
    
        public int HydrometricSiteID { get; set; }
        public int HydrometricSiteTVItemID { get; set; }
        public string FedSiteNumber { get; set; }
        public string QuebecSiteNumber { get; set; }
        public string HydrometricSiteName { get; set; }
        public string Description { get; set; }
        public string Province { get; set; }
        public Nullable<double> Elevation_m { get; set; }
        public Nullable<System.DateTime> StartDate_Local { get; set; }
        public Nullable<System.DateTime> EndDate_Local { get; set; }
        public Nullable<double> TimeOffset_hour { get; set; }
        public Nullable<double> DrainageArea_km2 { get; set; }
        public Nullable<bool> IsNatural { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> Sediment { get; set; }
        public Nullable<bool> RHBN { get; set; }
        public Nullable<bool> RealTime { get; set; }
        public Nullable<bool> HasRatingCurve { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual ICollection<HydrometricDataValue> HydrometricDataValues { get; set; }
        public virtual TVItem TVItem { get; set; }
    }
}