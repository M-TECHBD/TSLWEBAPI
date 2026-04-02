using Microsoft.AspNetCore.Mvc;
using CashInsightSoap;
namespace TslWebApi.Controllers
{
    public class SystemController : ControllerBase
    {
        //systemStatus(String sessionId, Device device)
        [HttpGet("SystemStatus")]
        public async Task<IActionResult> systemStatus(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.systemStatusAsync(sessionId, device);
            return Ok(response.@return);
        }
        //count(String sessionId,
        //             String transactionId,
        //             Device device,
        //             int bundleSize,
        //             String currency,
        //             Boolean stopMode)
      

    }
}
