using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Event is a report of an event somewhere in the cluster.
    /// </summary>
    [KubeObject("Event", "v1")]
    [KubeApi(KubeAction.List, "api/v1/events")]
    [KubeApi(KubeAction.WatchList, "api/v1/watch/events")]
    [KubeApi(KubeAction.List, "api/v1/namespaces/{namespace}/events")]
    [KubeApi(KubeAction.Create, "api/v1/namespaces/{namespace}/events")]
    [KubeApi(KubeAction.Get, "api/v1/namespaces/{namespace}/events/{name}")]
    [KubeApi(KubeAction.Patch, "api/v1/namespaces/{namespace}/events/{name}")]
    [KubeApi(KubeAction.Delete, "api/v1/namespaces/{namespace}/events/{name}")]
    [KubeApi(KubeAction.Update, "api/v1/namespaces/{namespace}/events/{name}")]
    [KubeApi(KubeAction.WatchList, "api/v1/watch/namespaces/{namespace}/events")]
    [KubeApi(KubeAction.DeleteCollection, "api/v1/namespaces/{namespace}/events")]
    [KubeApi(KubeAction.Watch, "api/v1/watch/namespaces/{namespace}/events/{name}")]
    public partial class EventV1 : KubeResourceV1
    {
        /// <summary>
        ///     A human-readable description of the status of this operation.
        /// </summary>
        [JsonProperty("message")]
        [YamlMember(Alias = "message")]
        public string Message { get; set; }

        /// <summary>
        ///     The component reporting this event. Should be a short machine understandable string.
        /// </summary>
        [JsonProperty("source")]
        [YamlMember(Alias = "source")]
        public EventSourceV1 Source { get; set; }

        /// <summary>
        ///     Type of this event (Normal, Warning), new types could be added in the future
        /// </summary>
        [JsonProperty("type")]
        [YamlMember(Alias = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     This should be a short, machine understandable string that gives the reason for the transition into the object's current status.
        /// </summary>
        [JsonProperty("reason")]
        [YamlMember(Alias = "reason")]
        public string Reason { get; set; }

        /// <summary>
        ///     The time at which the event was first recorded. (Time of server receipt is in TypeMeta.)
        /// </summary>
        [JsonProperty("firstTimestamp")]
        [YamlMember(Alias = "firstTimestamp")]
        public DateTime? FirstTimestamp { get; set; }

        /// <summary>
        ///     The time at which the most recent occurrence of this event was recorded.
        /// </summary>
        [JsonProperty("lastTimestamp")]
        [YamlMember(Alias = "lastTimestamp")]
        public DateTime? LastTimestamp { get; set; }

        /// <summary>
        ///     The number of times this event has occurred.
        /// </summary>
        [JsonProperty("count")]
        [YamlMember(Alias = "count")]
        public int Count { get; set; }

        /// <summary>
        ///     The object that this event is about.
        /// </summary>
        [JsonProperty("involvedObject")]
        [YamlMember(Alias = "involvedObject")]
        public ObjectReferenceV1 InvolvedObject { get; set; }
    }
}
