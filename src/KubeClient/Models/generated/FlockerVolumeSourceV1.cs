using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Represents a Flocker volume mounted by the Flocker agent. One and only one of datasetName and datasetUUID should be set. Flocker volumes do not support ownership management or SELinux relabeling.
    /// </summary>
    public partial class FlockerVolumeSourceV1
    {
        /// <summary>
        ///     UUID of the dataset. This is unique identifier of a Flocker dataset
        /// </summary>
        [JsonProperty("datasetUUID")]
        [YamlMember(Alias = "datasetUUID")]
        public string DatasetUUID { get; set; }

        /// <summary>
        ///     Name of the dataset stored as metadata -&gt; name on the dataset for Flocker should be considered as deprecated
        /// </summary>
        [JsonProperty("datasetName")]
        [YamlMember(Alias = "datasetName")]
        public string DatasetName { get; set; }
    }
}