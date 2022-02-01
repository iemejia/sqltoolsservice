//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlTools.Hosting.Protocol.Contracts;
using Microsoft.SqlTools.Utility;

namespace Microsoft.SqlTools.ServiceLayer.TableDesigner.Contracts
{
    public class PublishTableChangesResponse
    {
    }

    /// <summary>
    /// The service request to publish the changes.
    /// </summary>
    public class PublishTableChangesRequest
    {
        /// <summary>
        /// Request definition
        /// </summary>
        public static readonly RequestType<TableInfo, PublishTableChangesResponse> Type = RequestType<TableInfo, PublishTableChangesResponse>.Create("tabledesigner/publish");
    }
}