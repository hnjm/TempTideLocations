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
    
    public partial class MWQMRun
    {
        public MWQMRun()
        {
            this.MWQMRunLanguages = new HashSet<MWQMRunLanguage>();
        }
    
        public int MWQMRunID { get; set; }
        public int SubsectorTVItemID { get; set; }
        public Nullable<int> MWQMRunTVItemID { get; set; }
        public System.DateTime DateTime_Local { get; set; }
        public Nullable<System.DateTime> StartDateTime_Local { get; set; }
        public Nullable<System.DateTime> EndDateTime_Local { get; set; }
        public Nullable<System.DateTime> LabReceivedDateTime_Local { get; set; }
        public Nullable<double> TemperatureControl_C { get; set; }
        public Nullable<int> SeaStateAtStart_BeaufortScale { get; set; }
        public Nullable<int> SeaStateAtEnd_BeaufortScale { get; set; }
        public Nullable<double> WaterLevelAtBrook_m { get; set; }
        public Nullable<double> WaveHightAtStart_m { get; set; }
        public Nullable<double> WaveHightAtEnd_m { get; set; }
        public Nullable<int> SamplingContactTVItemID { get; set; }
        public Nullable<int> AnalyzeMethod { get; set; }
        public Nullable<int> SampleMatrix { get; set; }
        public Nullable<int> Laboratory { get; set; }
        public Nullable<int> SampleStatus { get; set; }
        public Nullable<int> ValidatorContactTVItemID { get; set; }
        public Nullable<System.DateTime> LabAnalyzeDateTime_Local { get; set; }
        public Nullable<System.DateTime> ValidateDateTime_Local { get; set; }
        public Nullable<double> PPT24_mm { get; set; }
        public Nullable<double> PPT48_mm { get; set; }
        public Nullable<double> PPT72_mm { get; set; }
        public System.DateTime LastUpdateDate_UTC { get; set; }
        public int LastUpdateContactTVItemID { get; set; }
    
        public virtual ICollection<MWQMRunLanguage> MWQMRunLanguages { get; set; }
        public virtual TVItem TVItem { get; set; }
        public virtual TVItem TVItem1 { get; set; }
        public virtual TVItem TVItem2 { get; set; }
        public virtual TVItem TVItem3 { get; set; }
    }
}
