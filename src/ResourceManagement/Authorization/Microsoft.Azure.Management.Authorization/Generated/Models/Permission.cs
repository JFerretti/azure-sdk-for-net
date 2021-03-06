// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Role definition permissions.
    /// </summary>
    public partial class Permission
    {
        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        public Permission() { }

        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        public Permission(IList<string> actions = default(IList<string>), IList<string> notActions = default(IList<string>))
        {
            Actions = actions;
            NotActions = notActions;
        }

        /// <summary>
        /// Role definition allowed actions.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; set; }

        /// <summary>
        /// Role definition denied actions.
        /// </summary>
        [JsonProperty(PropertyName = "notActions")]
        public IList<string> NotActions { get; set; }

    }
}
