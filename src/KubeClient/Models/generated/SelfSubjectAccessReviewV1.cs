using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using YamlDotNet.Serialization;

namespace KubeClient.Models
{
    /// <summary>
    ///     SelfSubjectAccessReview checks whether or the current user can perform an action.  Not filling in a spec.namespace means "in all namespaces".  Self is a special case, because users should always be able to check whether they can perform an action
    /// </summary>
    [KubeObject("SelfSubjectAccessReview", "v1")]
    [KubeApi(KubeAction.Create, "apis/authorization.k8s.io/v1/selfsubjectaccessreviews")]
    public partial class SelfSubjectAccessReviewV1 : KubeResourceV1
    {
        /// <summary>
        ///     Spec holds information about the request being evaluated.  user and groups must be empty
        /// </summary>
        [JsonProperty("spec")]
        [YamlMember(Alias = "spec")]
        public SelfSubjectAccessReviewSpecV1 Spec { get; set; }

        /// <summary>
        ///     Status is filled in by the server and indicates whether the request is allowed or not
        /// </summary>
        [JsonProperty("status")]
        [YamlMember(Alias = "status")]
        public SubjectAccessReviewStatusV1 Status { get; set; }
    }
}
