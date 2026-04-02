using CashInsightSoap;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Transactions;
using System.Xml.Linq;
namespace TslWebApi.Controllers
{
    public class TransactionController : ControllerBase
    {
        [HttpPost("StartTransaction")]
        public async Task<IActionResult> startTransaction(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, string password, int type)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startTransactionAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password, type: type));
        }

        [HttpPost("startTransactionWithEncryptedPassword")]

        public async Task<IActionResult> startTransactionWithEncryptedPassword(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, byte[] encryptedPassword, int type, int encryptionScheme)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startTransactionWithEncryptedPasswordAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: encryptedPassword, type: type, encryptionScheme: encryptionScheme));
        }
        [HttpPost("ResetUserTransactionDayTotal")]
        public async Task<IActionResult> resetUserTransactionDayTotal(string sessionId, string transactionId, string userName)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).resetUserTransactionDayTotalAsync(sessionId, transactionId: transactionId, userName: userName));
        }
        [HttpGet("GetLimits")]
        public async Task<IActionResult> getLimits(string sessionId, string transactionId, string username)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).getLimitsAsync(sessionId, transactionId, username));
        }
        [HttpPost("EndTransaction")]
        public async Task<IActionResult> endTransaction(string sessionId, string transactionId, int transactionState)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).endTransactionAsync(sessionId, transactionId: transactionId, transactionState: transactionState));
        }
        [HttpPost("StartDispenseTransaction")]
        public async Task<IActionResult> startDispenseTransaction(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, string password)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startDispenseTransactionAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password));
        }
        [HttpPost("StartDispenseTransactionWithEncryptedPassword")]
        public async Task<IActionResult> startDispenseTransactionWithEncryptedPassword(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, byte[] password, int encryptionScheme)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startDispenseTransactionWithEncryptedPasswordAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password, encryptionScheme: encryptionScheme));

        }
        [HttpGet("GenerateMix")]
        public async Task<IActionResult> generateMix(string sessionId, string transactionId, long amount, string currency, Device device, int algorithm)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).generateMixAsync(sessionId, transactionId, amount, currency, device, algorithm));
        }
        [HttpPost("dispense")]
        public async Task<IActionResult> dispense(string sessionId, string transactionId, Denomination denomination, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).dispenseAsync(sessionId, transactionId, denomination, device));
        }
        [HttpPost("cashboxDispense")]
        public async Task<IActionResult> cashboxDispense(string sessionId, string transactionId, long amount, string currency)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).cashboxDispenseAsync(sessionId, transactionId, amount, currency));
        }
        [HttpPost("Collect")]
        public async Task<IActionResult> collect(string sessionId, string transactionId, Denomination denomination, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).collectAsync(sessionId, transactionId, denomination, device));
        }
        [HttpPost("SetNote")]
        public async Task<IActionResult> setNote(string sessionId, string transactionId, string note)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).setNoteAsync(sessionId, transactionId, note));
        }
        [HttpGet("GetNote")]
        public async Task<IActionResult> getNote(string sessionId, string transactionId)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).getNoteAsync(sessionId, transactionId));

        }
        [HttpPost("StartDepositTransaction")]
        public async Task<IActionResult> startDepositTransaction(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, string password)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startDepositTransactionAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password));
        }
        [HttpPost("StartDepositTransactionWithEncryptedPassword")]
        public async Task<IActionResult> startDepositTransactionWithEncryptedPassword(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, byte[] password, int encryptionScheme)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startDepositTransactionWithEncryptedPasswordAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password, encryptionScheme: encryptionScheme));
        }
        [HttpPost("CashInStart")]
        public async Task<IActionResult> cashInStart(string sessionId, string transactionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).cashInStartAsync(sessionId, transactionId, device));
        }
        [HttpPost("CashInRollback")]
        public async Task<IActionResult> cashInRollback(string sessionId, string transactionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).cashInRollbackAsync(sessionId, transactionId, device));
        }
        [HttpPost("CashInEnd")]
        public async Task<IActionResult> cashInEnd(string sessionId, string transactionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).cashInEndAsync(sessionId, transactionId, device));
        }
        [HttpPost("CashboxDeposit")]
        public async Task<IActionResult> cashboxDeposit(string sessionId, string transactionId, long amount, string currency)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).cashboxDepositAsync(sessionId, transactionId, amount, currency));
        }
        [HttpPost("Reset")]
        public async Task<IActionResult> reset(string sessionId, Device device, bool keepReservation)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).resetAsync(sessionId, device, keepReservation));
        }
        [HttpPost("ReserveDevice")]
        public async Task<IActionResult> reserveDevice(string sessionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).reserveDeviceAsync(sessionId, device));
        }
        [HttpPost("ReleaseDevice")]
        public async Task<IActionResult> releaseDevice(string sessionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).releaseDeviceAsync(sessionId, device));
        }
        [HttpPost("FreeDevice")]
        public async Task<IActionResult> freeDevice(string sessionId, Device device)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).freeDeviceAsync(sessionId, device));
        }
        [HttpGet("transactionList")]
        public async Task<IActionResult> transactionList(string sessionId, string strartTime, string endTime, string userName, string details)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).transactionListAsync(sessionId, strartTime, endTime, userName, details));

        }
        [HttpGet("TransactionSearch")]
        public async Task<IActionResult> transactionSearch(string sessionId, SearchParameters searchParameters, string details)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).transactionSearchAsync(sessionId, searchParameters, details));
        }
        [HttpPost("Count")]
        public async Task<IActionResult> count(string sessionId, string transactionId, Device device, int bundleSize, string currency, bool stopMode)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.countAsync(sessionId, transactionId, device, bundleSize, currency, stopMode);
            return Ok(response.@return);
        }
        //        startCountingTransaction(String sessionId,
        //long amount
        //String currency,
        //DeviceList deviceList,
        //int position,
        //string login,
        //string password)
        [HttpPost("StartCountingTransaction")]
        public async Task<IActionResult> startCountingTransaction(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, string password)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startCountingTransactionAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password));
        }
        //        startCountingTransactionWithEncryptedPassword(String sessionId,
        //long amount
        //String currency,
        //DeviceList deviceList,
        //int position,
        //string login,
        //byte[] password,
        //int encryptionScheme)
        [HttpPost("StartCountingTransactionWithEncryptedPassword")]
        public async Task<IActionResult> startCountingTransactionWithEncryptedPassword(string sessionId, long amount, string currency, DeviceList deviceList, int position, string login, byte[] password, int encryptionScheme)
        {
            return Ok(await new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint).startCountingTransactionWithEncryptedPasswordAsync(sessionId, amount: amount, currency: currency, deviceList: deviceList, position: position, login: login, password: password, encryptionScheme: encryptionScheme));

        }
        [HttpPost("QueueDispense")]
        public async Task<IActionResult> queueDispense(string sessionId, string orderSearchId, int amount, string currency, Denomination denomination, Device device, string transactionNote, int delay, int timeout, int cashBox, string pin, string owener)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.queueDispenseAsync(sessionId, orderSearchId, amount, currency, denomination, device, transactionNote, delay, timeout, cashBox, pin, owener);
            return Ok(response.@return);
        }
        //queueDeposit(String sessionId, String owner,String pin,Integer amount,String currency,Device device,String transactionNote,Integer delay, Integer timeout)
        [HttpPost("QueueDeposit")]
        public async Task<IActionResult> queueDeposit(string sessionId, string orderSearchId, int amount, string currency, Device device, string transactionNote, int delay, int timeout, int cashBox, string pin, string owener)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.queueDepositAsync(sessionId, orderSearchId, amount, currency, device, transactionNote, delay, timeout, cashBox, pin, owener);
            return Ok(response.@return);
        }

        //   selfAudit(String sessionId,String transactionId,Device device,String cashUnitId)
        [HttpPost("SelfAudit")]
        public async Task<IActionResult> selfAudit(string sessionId, string transactionId, Device device, string cashUnitId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.selfAuditAsync(sessionId, transactionId, device, cashUnitId);
            return Ok(response.@return);
        }
        //findOrder(String sessionId,String orderSearchId ) 
        [HttpGet("FindOrder")]
        public async Task<IActionResult> findOrder(string sessionId, string orderSearchId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.findOrderAsync(sessionId, orderSearchId);
            return Ok(response.@return);
        }
        //startQueuedTransaction(String sessionId,String orderId,String pin,DeviceList deviceList,Int position,String login,byte[] password,Int type,Int encryptionScheme)
        //[HttpPost("StartQueuedTransaction")]
        //public async Task<IActionResult> startQueuedTransaction(string sessionId, string orderId, string pin, DeviceList deviceList, int position, string login, byte[] password, int type, int encryptionScheme)
        //{
        //    var client = new CashInsightAPIServicePortTypeClient(
        //      CashInsightAPIServicePortTypeClient.EndpointConfiguration
        //          .CashInsightAPIServiceHttpSoap12Endpoint);
        //    var response = await client.startQueuedTransactionAsync(sessionId, orderId, pin, deviceList, position, login, password, type, encryptionScheme);
        //    return Ok(response.@return);
        //}


        //cancelOrder(String sessionId,String orderSearchId)
        [HttpPost("CancelOrder")]
        public async Task<IActionResult> cancelOrder(string sessionId, long orderId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.cancelOrderAsync(sessionId, orderId);
            return Ok(response.@return);
        }
        //startQueuedTransactionWithEncryptedPassword(String sessionId,
        //                                                  String orderId,
        //                                                  String pin,
        //                                                  DeviceList deviceList,
        //                                                  Int position,
        //                                                  String login,
        //                                                  byte[] password,
        //                                                  Int type,
        //                                                  Int encryptionScheme)
        [HttpPost("StartQueuedTransactionWithEncryptedPassword")]
        public async Task<IActionResult> startQueuedTransactionWithEncryptedPassword(string sessionId, string orderId, DeviceList deviceList, int position, string login, byte[] password, string pin, int encryptionScheme)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.startQueuedTransctionstartWithEncryptedPasswordAsync(sessionId, orderId, deviceList, position, login, password, pin, encryptionScheme);
            return Ok(response.@return);
        }
        //startWorkstationMappingTransaction(String sessionId,String login,String password)
        [HttpPost("StartWorkstationMappingTransaction")]
        public async Task<IActionResult> startWorkstationMappingTransaction(string sessionId, string login, string password)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.startWorkstationMappingTransactionAsync(sessionId, login, password);
            return Ok(response.@return);
        }
        [HttpPost("StartContinuousDeposit")]
        public async Task<IActionResult> startContinuousDeposit(string senssionId, string transactionId, Device device, string currency)
        {

            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).startContinuousDepositAsync(senssionId, transactionId, device, currency));
        }
        //checkForEvents(String sessionId,String transactionId,Device device,long timeout)
        [HttpGet("CheckForEvents")]
        public async Task<IActionResult> checkForEvents(string sessionId, string transactionId, Device device, long timeout)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.checkForEventsAsync(sessionId, transactionId, device, timeout);
            return Ok(response.@return);
        }
        //stopContinuousDeposit(String sessionId,String transactionId,Device device)
        [HttpPost("StopContinuousDeposit")]
        public async Task<IActionResult> stopContinuousDeposit(string sessionId, string transactionId, Device device)
        {
            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).stopContinuousDepositAsync(sessionId, transactionId, device));
        }
        //load(String sessionId,String transactionId,Device device )
        [HttpPost("Load")]
        public async Task<IActionResult> load(string sessionId, string transactionId, Device device)
        {
            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).loadAsync(sessionId, transactionId, device));
        }


        //empty(String sessionId,String transactionId, Device device, String[] cashUnitIds )
        [HttpPost("Empty")]
        public async Task<IActionResult> empty(string sessionId, string transactionId, Device device, string[] cashUnitIds)
        {
            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).emptyAsync(sessionId, transactionId, device, cashUnitIds));
        }
        //isCounterCorrectionRequired(String sessionId,Device device)

        [HttpGet("IsCounterCorrectionRequired")]
        public async Task<IActionResult> isCounterCorrectionRequired(string sessionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.isCounterCorrectionRequiredAsync(sessionId, device);
            return Ok(response.@return);
        }
        //getCounterCorrectionResult(String sessionId,Device device,String transactionId)
        [HttpGet("GetCounterCorrectionResult")]
        public async Task<IActionResult> getCounterCorrectionResult(string sessionId, string transactionId, Device device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getCounterCorrectionResultAsync(sessionId, transactionId, device);
            return Ok(response.@return);
        }

        //emptyISM(String sessionId,String transactionId,Device device )
        [HttpPost("EmptyISM")]
        public async Task<IActionResult> emptyISM(string sessionId, string transactionId, Device device)
        {
            return Ok(new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint).emptyISMAsync(sessionId, transactionId, device));
        }

        //searchTransactionWithTerminalId(String sessionId, SearchParameters searchParameters, String details,String terminalId )
        [HttpGet("SearchTransactionWithTerminalId")]
        public async Task<IActionResult> searchTransactionWithTerminalId(string sessionId, SearchParameters searchParameters, string details, string terminalId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.searchTransactionsWithTerminalIdAsync(sessionId, searchParameters, details, terminalId);
            return Ok(response.@return);

        }
        //getTransactionTotalResult(sessionId, transactionId ) 
        [HttpGet("GetTransactionTotalResult")]
        public async Task<IActionResult> getTransactionTotalResult(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getTransactionTotalResultAsync(sessionId, transactionId);
            return Ok(response.@return);
        }

        }
}
