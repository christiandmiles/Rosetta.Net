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