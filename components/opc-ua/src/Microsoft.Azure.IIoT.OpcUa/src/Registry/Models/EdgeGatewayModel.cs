// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Registry.Models {

    /// <summary>
    /// Edge Gateway registration
    /// </summary>
    public class EdgeGatewayModel {

        /// <summary>
        /// Identifier of the gateway
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Site of the gateway
        /// </summary>
        public string SiteId { get; set; }

        /// <summary>
        /// Whether the registration is out of sync between
        /// client (module) and server (service) (default: false).
        /// </summary>
        public bool? OutOfSync { get; set; }

        /// <summary>
        /// Whether gateway is connected
        /// </summary>
        public bool? Connected { get; set; }
    }
}
