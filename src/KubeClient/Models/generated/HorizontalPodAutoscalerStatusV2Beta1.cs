using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     HorizontalPodAutoscalerStatus describes the current status of a horizontal pod autoscaler.
    /// </summary>
    public partial class HorizontalPodAutoscalerStatusV2Beta1
    {
        /// <summary>
        ///     lastScaleTime is the last time the HorizontalPodAutoscaler scaled the number of pods, used by the autoscaler to control how often the number of pods is changed.
        /// </summary>
        [JsonProperty("lastScaleTime")]
        [YamlMember(Alias = "lastScaleTime")]
        public DateTime? LastScaleTime { get; set; }

        /// <summary>
        ///     observedGeneration is the most recent generation observed by this autoscaler.
        /// </summary>
        [JsonProperty("observedGeneration")]
        [YamlMember(Alias = "observedGeneration")]
        public int ObservedGeneration { get; set; }

        /// <summary>
        ///     conditions is the set of conditions required for this autoscaler to scale its target, and indicates whether or not those conditions are met.
        /// </summary>
        [YamlMember(Alias = "conditions")]
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<HorizontalPodAutoscalerConditionV2Beta1> Conditions { get; set; } = new List<HorizontalPodAutoscalerConditionV2Beta1>();

        /// <summary>
        ///     currentMetrics is the last read state of the metrics used by this autoscaler.
        /// </summary>
        [YamlMember(Alias = "currentMetrics")]
        [JsonProperty("currentMetrics", NullValueHandling = NullValueHandling.Ignore)]
        public List<MetricStatusV2Beta1> CurrentMetrics { get; set; } = new List<MetricStatusV2Beta1>();

        /// <summary>
        ///     currentReplicas is current number of replicas of pods managed by this autoscaler, as last seen by the autoscaler.
        /// </summary>
        [JsonProperty("currentReplicas")]
        [YamlMember(Alias = "currentReplicas")]
        public int CurrentReplicas { get; set; }

        /// <summary>
        ///     desiredReplicas is the desired number of replicas of pods managed by this autoscaler, as last calculated by the autoscaler.
        /// </summary>
        [JsonProperty("desiredReplicas")]
        [YamlMember(Alias = "desiredReplicas")]
        public int DesiredReplicas { get; set; }
    }
}