using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     Deployment enables declarative updates for Pods and ReplicaSets.
    /// </summary>
    [KubeObject("Deployment", "v1")]
    [KubeApi(KubeAction.List, "apis/apps/v1/deployments")]
    [KubeApi(KubeAction.WatchList, "apis/apps/v1/watch/deployments")]
    [KubeApi(KubeAction.List, "apis/apps/v1/namespaces/{namespace}/deployments")]
    [KubeApi(KubeAction.Create, "apis/apps/v1/namespaces/{namespace}/deployments")]
    [KubeApi(KubeAction.Get, "apis/apps/v1/namespaces/{namespace}/deployments/{name}")]
    [KubeApi(KubeAction.Patch, "apis/apps/v1/namespaces/{namespace}/deployments/{name}")]
    [KubeApi(KubeAction.Delete, "apis/apps/v1/namespaces/{namespace}/deployments/{name}")]
    [KubeApi(KubeAction.Update, "apis/apps/v1/namespaces/{namespace}/deployments/{name}")]
    [KubeApi(KubeAction.WatchList, "apis/apps/v1/watch/namespaces/{namespace}/deployments")]
    [KubeApi(KubeAction.DeleteCollection, "apis/apps/v1/namespaces/{namespace}/deployments")]
    [KubeApi(KubeAction.Get, "apis/apps/v1/namespaces/{namespace}/deployments/{name}/status")]
    [KubeApi(KubeAction.Watch, "apis/apps/v1/watch/namespaces/{namespace}/deployments/{name}")]
    [KubeApi(KubeAction.Patch, "apis/apps/v1/namespaces/{namespace}/deployments/{name}/status")]
    [KubeApi(KubeAction.Update, "apis/apps/v1/namespaces/{namespace}/deployments/{name}/status")]
    public partial class DeploymentV1 : KubeResourceV1
    {
        /// <summary>
        ///     Specification of the desired behavior of the Deployment.
        /// </summary>
        [JsonProperty("spec")]
        [YamlMember(Alias = "spec")]
        public DeploymentSpecV1 Spec { get; set; }

        /// <summary>
        ///     Most recently observed status of the Deployment.
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public DeploymentStatusV1 Status { get; set; }
    }
}