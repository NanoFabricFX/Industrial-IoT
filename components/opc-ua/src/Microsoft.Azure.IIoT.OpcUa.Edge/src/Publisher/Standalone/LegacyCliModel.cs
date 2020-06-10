﻿// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.OpcUa.Edge.Publisher.Models {
    using Microsoft.Azure.IIoT.OpcUa.Edge.Publisher.Services;
    using Microsoft.Azure.IIoT.OpcUa.Publisher.Models;
    using System;

    /// <summary>
    /// Model that represents the command line arguments in the format of the
    /// legacy OPC Publisher.
    /// </summary>
    public class LegacyCliModel : ILegacyCliModelProvider {

        /// <summary>
        /// The published nodes file.
        /// </summary>
        public string PublishedNodesFile { get; set; }

        /// <summary>
        /// The time to wait to connect a session.
        /// </summary>
        public TimeSpan? SessionConnectWait { get; set; }

        /// <summary>
        /// The default interval for heartbeats if not set on
        /// node level.
        /// </summary>
        public TimeSpan? DefaultHeartbeatInterval { get; set; }

        /// <summary>
        /// The default flag whether to skip the first value if
        /// not set on node level.
        /// </summary>
        public bool DefaultSkipFirst { get; set; }

        /// <summary>
        /// The default sampling interval.
        /// </summary>
        public TimeSpan? DefaultSamplingInterval { get; set; }

        /// <summary>
        /// The default publishing interval.
        /// </summary>
        public TimeSpan? DefaultPublishingInterval { get; set; }

        /// <summary>
        /// Message type for pub/sub messages
        /// </summary>
        public NetworkMessageType? NetworkMessageType { get; set; }

        /// <summary>
        /// The message schema to use
        /// </summary>
        public string MessageSchema { get; set; }

        /// <summary>
        /// Flag wether to grab the display name of nodes form
        /// the OPC UA Server.
        /// </summary>
        public bool FetchOpcNodeDisplayName { get; set; }

        /// <summary>
        /// set the default queue size for monitored items
        /// </summary>
        public uint DefaultQueueSize { get; set; }

        /// <summary>
        /// The interval to show diagnostics information.
        /// </summary>
        public TimeSpan? DiagnosticsInterval { get; set; }

        /// <summary>
        /// The size of the message batching buffer
        /// </summary>
        public int? BatchSize { get; set; }

        /// <summary>
        /// The interval to trigger batching
        /// </summary>
        public TimeSpan? BatchTriggerInterval { get; set; }

        /// <summary>
        /// The maximum size of the (IoT D2C ) message
        /// </summary>
        public uint? MaxMessageSize { get; set; }

        /// <summary>
        /// The time to flush the log file to the disc.
        /// </summary>
        public TimeSpan? LogFileFlushTimeSpan { get; set; }

        /// <summary>
        /// The filename of the logfile.
        /// </summary>
        public string LogFilename { get; set; }

        /// <summary>
        /// The EdgeHub connection string.
        /// </summary>
        public string EdgeHubConnectionString { get; set; }

        /// <summary>
        /// The operation timeout.
        /// </summary>
        public TimeSpan? OperationTimeout { get; set; }

        /// <summary>
        /// Flag to demand full featured message creation from publisher
        /// </summary>
        public bool FullFeaturedMessage { get; set; }

        /// <summary>
        /// The session creation timeout.
        /// </summary>
        public TimeSpan? SessionCreationTimeout { get; set; }

        /// <summary>
        /// The KeepAlive interval.
        /// </summary>
        public TimeSpan? KeepAliveInterval { get; set; }

        /// <summary>
        /// The maximum keep alive count till disconnect.
        /// </summary>
        public int? MaxKeepAliveCount { get; set; }

        /// <summary>
        /// Flag to trust own certificate.
        /// </summary>
        public bool TrustSelf { get; set; }

        /// <summary>
        /// Flag if all certificates should be trusted.
        /// </summary>
        public bool AutoAcceptUntrustedCertificates { get; set; }

        /// <summary>
        /// Certificate store configuration
        /// </summary>
        public string ApplicationCertificateStoreType { get; set; }

        /// <summary>
        /// Certificate store path
        /// </summary>
        public string ApplicationCertificateStorePath { get; set; }

        /// <summary>
        /// Peer cert path
        /// </summary>
        public string TrustedPeerCertificatesPath { get; set; }

        /// <summary>
        /// Rejected cert path
        /// </summary>
        public string RejectedCertificateStorePath { get; set; }

        /// <summary>
        /// Trusted issuer cert path
        /// </summary>
        public string TrustedIssuerCertificatesPath { get; set; }

        /// <summary>
        /// force mass monitored item clones
        /// </summary>
        public int? ScaleTestCount { get; set; }

        /// <summary>
        /// Helper
        /// </summary>
        LegacyCliModel ILegacyCliModelProvider.LegacyCliModel => this;
    }
}