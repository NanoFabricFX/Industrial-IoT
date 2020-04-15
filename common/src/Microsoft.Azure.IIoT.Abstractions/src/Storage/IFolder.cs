﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Storage {
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Folder
    /// </summary>
    public interface IFolder {

        /// <summary>
        /// Name of the folder
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Create file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IFile> CreateOrOpenFileAsync(string fileName,
            CancellationToken ct = default);

        /// <summary>
        /// Create folder
        /// </summary>
        /// <param name="folder"></param>
        /// <param name="ct"></param>
        /// <returns></returns>
        Task<IFolder> CreateOrOpenSubFolderAsync(string folder,
            CancellationToken ct = default);
    }
}
