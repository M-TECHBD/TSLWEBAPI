using CashInsightSoap;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using System.Xml.Linq;

namespace TslWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        [HttpGet("ListDevices")]
        public async Task<IActionResult> ListDevices(string sessionId)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).listDevicesAsync(sessionId));
        }
        [HttpGet("RetrieveLocalDevices")]
        public async Task<IActionResult> retrieveLocalDevices(string sessionId, string workStation)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).retrieveLocalDevicesAsync(sessionId, workStation));
        }
        [HttpGet("RetrieveDeviceState")]
        public async Task<IActionResult> retrieveDeviceState(string sessionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).retrieveDeviceStateAsync(sessionId, device));
        }
        //[HttpPost("EmptyDevice")]
        //public async Task<IActionResult> emptyDevice(string sessionId, Device device, string cashUnitIds, int position)
        //{
        //    return Ok(await new CashInsightAPIServicePortTypeClient(
        //        CashInsightAPIServicePortTypeClient.EndpointConfiguration
        //            .CashInsightAPIServiceHttpSoap12Endpoint).emptyDeviceAsync(sessionId, device, cashUnitIds, position));
        //}
        //   lockDevice(String sessionId, Device device)
        [HttpPost("LockDevice")]
        public async Task<IActionResult> lockDevice(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.lockDeviceAsync(sessionId, device);
            return Ok(response.@return);


        }
        //  unlockDevice(String sessionId,Device device)
        [HttpPost("UnlockDevice")]
        public async Task<IActionResult> unlockDevice(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.unlockDeviceAsync(sessionId, device);
            return Ok(response.@return);
        }
        // disableDevice(String sessionId,Device device)
        [HttpPost("DisableDevice")]
        public async Task<IActionResult> disableDevice(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.disableDeviceAsync(sessionId, device);
            return Ok(response.@return);
        }
        //enableDevice(String sessionId,Device device)
        [HttpPost("EnableDevice")]
        public async Task<IActionResult> enableDevice(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.enableDeviceAsync(sessionId, device);
            return Ok(response.@return);
        }
        //lowerLifts(String sessionId,Device device)
        [HttpPost("LowerLifts")]
        public async Task<IActionResult> lowerLifts(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.lowerLiftsAsync(sessionId, device);
            return Ok(response.@return);
        }
        // raiseLifts(Strings sessionId,Device device)
        [HttpPost("RaiseLifts")]
        public async Task<IActionResult> raiseLifts(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.raiseLiftsAsync(sessionId, device);
            return Ok(response.@return);
        }
        //deviceSummary( String sessionId,String startTime,string endTime,String detaxils )
        [HttpGet("DeviceSummary")]
        public async Task<IActionResult> deviceSummary(string sessionId, string startTime, string endTime, string details)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.deviceSummaryAsync(sessionId, startTime, endTime, details);
            return Ok(response.@return);
        }
        //        workstationConfig(String sessionId,
        //DeviceList deviceList)
        [HttpPost("WorkstationConfig")]
        public async Task<IActionResult> workstationConfig(string sessionId, string workStationName, int position, DeviceList deviceList)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.workstationConfigAsync(sessionId, workStationName, position, deviceList);
            return Ok(response.@return);
        }
        //        enableSTC(String sessionId,
        //Device device,
        //Boolean clearInventory)
        [HttpPost("EnableSTC")]
        public async Task<IActionResult> enableSTC(string sessionId, Device device, bool clearInventory)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.enableSTCAsync(sessionId, device, clearInventory);
            return Ok(response.@return);
        }
        //        getSTCStatus(String sessionId,
        //Device device)
        [HttpGet("GetSTCStatus")]
        public async Task<IActionResult> getSTCStatus(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getSTCStatusAsync(sessionId, device);
            return Ok(response.@return);
        }
        //        getIdRanges(String sessionId,
        //Device device)
        [HttpGet("GetIdRanges")]
        public async Task<IActionResult> getIdRanges(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getIdRangesAsync(sessionId, device);
            return Ok(response.@return);
        }
        //transferCash(String sessionId,
        //                                              Device device,
        //                                              Int cashUnitPosition,
        //                                              Boolean empty,
        //                                              Int noOfNotes,
        //                                              Int transferType)

        [HttpPost("TransferCash")]
        public async Task<IActionResult> transferCash(string sessionId, Device device, int cashUnitPosition, bool empty, int noOfNotes, int transferType)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.transferCashAsync(sessionId, device, cashUnitPosition, empty, noOfNotes, transferType);
            return Ok(response.@return);
        }
        //        depositSTCReceipt(String sessionId,
        //Device device)
        [HttpPost("DepositSTCReceipt")]
        public async Task<IActionResult> depositSTCReceipt(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.depositSTCReceiptAsync(sessionId, device);
            return Ok(response.@return);
        }
        //    getJournalId (String sessionId,String transactionId)
        [HttpGet("GetJournalId")]
        public async Task<IActionResult> getJournalId(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getJournalIdAsync(sessionId, transactionId);
            return Ok(response.@return);
        }

        // transactionById(String sessionId,String journalId,String details)
        [HttpGet("TransactionById")]
        public async Task<IActionResult> transactionById(string sessionId, string journalId, string details)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.transactionByIdAsync(sessionId, journalId, details);
            return Ok(response.@return);
        }
        // listDeviceController(String sessionId,String transactionId)
        [HttpGet("ListDeviceController")]
        public async Task<IActionResult> listDeviceController(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = client.listDeviceControllerAsync(sessionId, transactionId);
            return Ok(response);
        }
        //addDeviceController(String sessionId,String transactionId,String deviceControllerHost)
        [HttpPost("AddDeviceController")]
        public async Task<IActionResult> addDeviceController(string sessionId, string transactionId, string deviceControllerHost)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.addDeviceControllerAsync(sessionId, transactionId, deviceControllerHost);
            return Ok(response);
        }
        // removeDeviceController(String sessionId,String transactionId,String deviceControllerHost)
        [HttpPost("RemoveDeviceController")]
        public async Task<IActionResult> removeDeviceController(string sessionId, string transactionId, string deviceControllerHost)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.removeDeviceControllerAsync(sessionId, transactionId, deviceControllerHost);
            return Ok(response);
        }

        // sychronizeDeviceController(String sessionId,String transactionId,String deviceControllerHost)
        [HttpGet("SychronizeDeviceController")]
        public async Task<IActionResult> sychronizeDeviceController(string sessionId, string transactionId, string deviceControllerHost)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.synchronizeDeviceControllerAsync(sessionId, transactionId, deviceControllerHost);
            return Ok(response);
        }
        [HttpPost("TerminalConfiguration")]
        public async Task<IActionResult> terminalConfiguration(string sessionId, string transactionId, string terminalId, DeviceList deviceList,
                                               int postion)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.terminalConfigurationAsync(sessionId, transactionId, terminalId, deviceList, postion);
            return Ok(response);
        }
        //    setTerminalId(String sessionId,String transactionId,String terminalId)
        [HttpPost("SetTerminalId")]
        public async Task<IActionResult> setTerminalId(string sessionId, string transactionId, string terminalId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.setTerminalIdAsync(sessionId, transactionId, terminalId);
            return Ok(response);
        }
        //retrieveTerminalIds(String sessionId)
        [HttpGet("RetrieveTerminalIds")]
        public async Task<IActionResult> retrieveTerminalIds(string sessionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.retrieveTerminalIdsAsync(sessionId);
            return Ok(response);
        }
        [HttpGet("TerminalBalance")]
        public async Task<IActionResult> terminalBalance(string sessionId, string transactionId, string terminalId, string startTime,
                                                   string endTime)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.terminalBalanceAsync(sessionId, transactionId, terminalId, startTime, endTime);
            return Ok(response);
        }        //updateDeviceList(String sessionId,String orderSearchId)

        [HttpPost("UpdateDeviceList")]
        public async Task<IActionResult> updateDeviceList(string sessionId, string deviceControllerHost, string deviceContrllerPort)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.updateDeviceListAsync(sessionId, deviceControllerHost, deviceContrllerPort);
            return Ok(response.@return);
        }
        //triggerAlarm(String sessionId,Device device)
        [HttpPost("TriggerAlarm")]
        public async Task<IActionResult> triggerAlarm(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.triggerAlarmAsync(sessionId, device);
            return Ok(response.@return);
        }


        //listConfiguredTerminals(String sessionId, String transactionId )
        [HttpGet("ListConfiguredTerminals")]
        public async Task<IActionResult> listConfiguredTerminals(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.listConfiguredTerminalsAsync(sessionId, transactionId);
            return Ok(response.@return);
        }

        //addWorkstationMapping(String sessionId,String transactionId,String workstationId,String branchId)
        [HttpPost("AddWorkstationMapping")]
        public async Task<IActionResult> addWorkstationMapping(string sessionId, string transactionId, string workstationId, string branchId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.addWorkstationMappingAsync(sessionId, transactionId, workstationId, branchId);
            return Ok(response.@return);
        }


        //deleteWorkstationMapping(String sessionId,String transactionId,String workstationId,String branchId)
        [HttpGet("DeleteWorkstationMapping")]
        public async Task<IActionResult> deleteWorkstationMapping(string sessionId, string transactionId, string workstationId, string branchId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = client.deleteWorkstationMappingAsync(sessionId, transactionId, workstationId);
            return Ok(response);
        }
        //startContinuousDeposit(String sessionId,String transactionId,Device device,String currency)
        //showBranchId(String sessionId,String transactionId)
        [HttpGet("ShowBranchId")]
        public async Task<IActionResult> showBranchId(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.showBranchIDAsync(sessionId, transactionId);
            return Ok(response.@return);
        }

        //showCurrentBranchId(String sessionId,String transactionId,String workstationId

        [HttpGet("ShowCurrentBranchId")]
        public async Task<IActionResult> showCurrentBranchId(string sessionId, string transactionId, string workstationId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.showCurrentBranchIDAsync(sessionId, transactionId, workstationId);
            return Ok(response.@return);
        }

        //getRecoveryAppURL(String sessionId,Device device)
        [HttpGet("GetRecoveryAppURL")]
        public async Task<IActionResult> getRecoveryAppURL(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getRecoveryAppURLAsync(sessionId, device);
            return Ok(response.@return);
        }

        //startRecovery(String sessionId,Device device)
        [HttpPost("StartRecovery")]
        public async Task<IActionResult> startRecovery(string sessionId, Device device)
        {
            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).startRecoveryAsync(sessionId, device));
        }
        //recoveryCompleted(String sessionId,Device device,Boolean restoreReservation)
        [HttpPost("RecoveryCompleted")]
        public async Task<IActionResult> recoveryCompleted(string sessionId, Device device, bool restoreReservation)
        {
            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).recoveryCompletedAsync(sessionId, device, restoreReservation));
        }

        //isISMEmpty(String sessionId,Device device )
        [HttpGet("IsISMEmpty")]
        public async Task<IActionResult> isISMEmpty(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.isISMEmptyAsync(sessionId, device);
            return Ok(response.@return);
        }
        //loadFromSTC(String sessionId,String transactionId,Device device )
        [HttpPost("LoadFromSTC")]
        public async Task<IActionResult> loadFromSTC(string sessionId, string transactionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.loadFromSTCAsync(sessionId, transactionId, device);
            return Ok(response.@return);
        }
        //getDeviceVersions(String sessionId,Device device)
        [HttpGet("GetDeviceVersions")]
        public async Task<IActionResult> getDeviceVersions(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getDeviceVersionsAsync(sessionId, device);
            return Ok(response.@return);
        }
        //emptyFrontStackBin(String sessionId,String transactionId,Device device )
        [HttpPost("EmptyFrontStackBin")]
        public async Task<IActionResult> emptyFrontStackBin(string sessionId, string transactionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.emptyFrontStackBinAsync(sessionId, transactionId, device);
            return Ok(response.@return);
        }
        // retrieveDistressDispenseProperties(String sessionId)
        [HttpGet("RetrieveDistressDispenseProperties")]
        public async Task<IActionResult> retrieveDistressDispenseProperties(string sessionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.retrieveDistressDispensePropertiesAsync(sessionId);
            return Ok(response.@return);
        }
    }
}

