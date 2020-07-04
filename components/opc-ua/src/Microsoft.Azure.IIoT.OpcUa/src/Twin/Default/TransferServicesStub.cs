// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Edge.Twin {
    using Microsoft.Azure.IIoT.OpcUa.Twin;
    using Microsoft.Azure.IIoT.OpcUa.Twin.Models;
    using System.Threading.Tasks;

    /// <summary>
    /// Stubbed out transfer functionality
    /// </summary>
    public sealed class TransferServicesStub<T> : ITransferServices<T> {

        /// <inheritdoc/>
        public Task<ModelUploadStartResultModel> ModelUploadStartAsync(
            T endpoint, ModelUploadStartRequestModel request) {
            return Task.FromResult(new ModelUploadStartResultModel());
        }
    }
}