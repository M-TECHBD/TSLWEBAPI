using CashInsightSoap;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace TslWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        [HttpGet("RetrieveDispensableInventory")]
        public async Task<IActionResult> retrieveDispensableInventory(string sessionId, Device device, string currency)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).retrieveDispensableInventoryAsync(sessionId, device, currency));
        }

        [HttpGet("RetrieveInventory")]
        public async Task<IActionResult> retrieveInventory(string sessionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).retrieveInventoryAsync(sessionId, device));
        }
        [HttpGet("GetMixes")]
        public async Task<IActionResult> getMixes(string sessionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).getMixesAsync(sessionId, device));
        }
        // getInventory(String sessionId,Device device,String currency ) 
        [HttpPost("GetInventory")]
        public async Task<IActionResult> getInventory(string sessionId, Device device, string currency)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).getInventoryAsync(sessionId, device, currency));
        }
        //getDispensableInventory(String sessionId,Device device)
        [HttpGet("GetDispensableInventory")]
        public async Task<IActionResult> getDispensableInventory(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getDispensableInventoryAsync(sessionId, device);
            return Ok(response.@return);
        }
        //emptyCollectionBin(String sessionId,String transactionId,Device device,Int position)
        [HttpPost("EmptyCollectionBin")]
        public async Task<IActionResult> emptyCollectionBin(string sessionId, string transactionId, Device device, int position)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.emptyCollectionBinAsync(sessionId, transactionId, device, position);
            return Ok(response.@return);
        }


        //isSafeDoorOpen(String sessionId,Device device )
        [HttpGet("IsSafeDoorOpen")]
        public async Task<IActionResult> isSafeDoorOpen(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.isSafeDoorOpenAsync(sessionId, device);
            return Ok(response.@return);
        }
        //setInventory(String sessionId,String transactionId,Device device, ContainerList cashUnitsChanged)
        //[HttpPost("SetInventory")]
        //public async Task<IActionResult> setInventory(string sessionId, string transactionId, Device device, ContainerList cashUnitsChanged)
        //{
        //var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
        //var response = await client.setInventoryAsync(sessionId, transactionId, device, cashUnitsChanged);
        //return Ok(response.@return);
        //}
    }

}
