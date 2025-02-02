//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//

using Microsoft.SqlTools.Hosting.Protocol.Contracts;

namespace Microsoft.SqlTools.ServiceLayer.TableDesigner.Contracts
{
    /// <summary>
    /// The service request to initialize a table designer.
    /// </summary>
    public class InitializeTableDesignerRequest
    {
        /// <summary>
        /// Request definition
        /// </summary>
        public static readonly RequestType<TableInfo, TableDesignerInfo> Type = RequestType<TableInfo, TableDesignerInfo>.Create("tabledesigner/initialize");
    }
}
