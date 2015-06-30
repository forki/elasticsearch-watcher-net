
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

///This file contains all the typed enums that the client rest api spec exposes.
///This file is automatically generated from https://github.com/elasticsearch/elasticsearch-rest-api-spec
///Generated of commit 
namespace Nest
{

    
        public enum Metric
        {
        [EnumMember(Value = "_all")]
		All,
		[EnumMember(Value = "queued_watches")]
		QueuedWatches,
		[EnumMember(Value = "pending_watches")]
		PendingWatches
        }
    
    
        public enum WatcherStatsMetric
        {
        [EnumMember(Value = "_all")]
		All,
		[EnumMember(Value = "queued_watches")]
		QueuedWatches,
		[EnumMember(Value = "pending_watches")]
		PendingWatches
        }
    

	public static class KnownEnums
	{
		public static string Resolve(Enum e)
		{
    
        if (e is Metric)
        {
        switch((Metric)e)
        {
        case Metric.All: return "_all";
					case Metric.QueuedWatches: return "queued_watches";
					case Metric.PendingWatches: return "pending_watches";
        }
        }
    
    
        if (e is WatcherStatsMetric)
        {
        switch((WatcherStatsMetric)e)
        {
        case WatcherStatsMetric.All: return "_all";
					case WatcherStatsMetric.QueuedWatches: return "queued_watches";
					case WatcherStatsMetric.PendingWatches: return "pending_watches";
        }
        }
    
			return "UNKNOWNENUM";
		}
	}
}
