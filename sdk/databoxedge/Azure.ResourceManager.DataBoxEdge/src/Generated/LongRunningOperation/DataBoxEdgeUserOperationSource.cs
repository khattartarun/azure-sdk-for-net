// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.DataBoxEdge
{
    internal class DataBoxEdgeUserOperationSource : IOperationSource<DataBoxEdgeUserResource>
    {
        private readonly ArmClient _client;

        internal DataBoxEdgeUserOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataBoxEdgeUserResource IOperationSource<DataBoxEdgeUserResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = DataBoxEdgeUserData.DeserializeDataBoxEdgeUserData(document.RootElement);
            return new DataBoxEdgeUserResource(_client, data);
        }

        async ValueTask<DataBoxEdgeUserResource> IOperationSource<DataBoxEdgeUserResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = DataBoxEdgeUserData.DeserializeDataBoxEdgeUserData(document.RootElement);
            return new DataBoxEdgeUserResource(_client, data);
        }
    }
}
