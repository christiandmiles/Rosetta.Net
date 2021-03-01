# Rosetta.Net

This is simply an api client for Rosetta (https://github.com/coinbase/rosetta-specifications) generated using AutoRest (https://github.com/Azure/autorest).

To recreate / update this library use the following command:

```bash
autorest --use:@autorest/csharp@3.0.0-beta.20210225.1 --input-file:https://raw.githubusercontent.com/coinbase/rosetta-specifications/master/api.json  --clear-output-folder:true --public-clients:true
```

Then add a RosettaClient.Customizations.cs file to provide a publicly accessible constructor e.g.

```csharp
using System;
using Azure.Core.Pipeline;

namespace Rosetta
{
  public partial class RosettaClient
  {
    public RosettaClient(Uri endpoint)
    {
      var options = new RosettaClientOptions();
      var pipeline = HttpPipelineBuilder.Build(options);
      var clientDiagnostics = new ClientDiagnostics(options);
      RestClient = new RosettaRestClient(clientDiagnostics, pipeline, endpoint);
      _clientDiagnostics = clientDiagnostics;
      _pipeline = pipeline;
    }
  }
}
```