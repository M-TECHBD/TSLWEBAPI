using CashInsightSoap;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using System.Xml.Linq;

namespace TslWebApi.Controllers
{
    public class ReportController : ControllerBase
    {

        //ReportTransactions(String sessionId,String transactionId,String user,String startTime,String endTime,String device,String location,String searchNote,
        // boolean SearchByJournalId,boolean countingErrors,integer journalId,integer pageNumber,integer pageSize)
        [HttpGet("ReportTransactions")]
        public async Task<IActionResult> reportTransactions(string sessionId, string transactionId, string user, string startTime, string endTime, string device, string location, string searchNote, bool searchByJournalId, bool countingErrors, int journalId, int pageNumber, int pageSize)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportTransactionsAsync(sessionId, transactionId, user, startTime, endTime, device, location, searchNote, searchByJournalId, countingErrors, journalId, pageNumber, pageSize);
            return Ok(response.@return);
        }
        //reportTransactionsDetail(String sessionId,String transactionId,long journalId)
        [HttpGet("ReportTransactionsDetail")]
        public async Task<IActionResult> reportTransactionsDetail(string sessionId, string transactionId, long journalId)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportTransactionDetailAsync(sessionId, transactionId, journalId);
            return Ok(response.@return);
        }
        //reportDeviceSummary(String sessionId,String transactionId,String location,String device,String startTime, String endTime )
        [HttpGet("ReportDeviceSummary")]
        public async Task<IActionResult> reportDeviceSummary(string sessionId, string transactionId, string location, string device, string startTime, string endTime)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportDeviceSummaryAsync(sessionId, transactionId, location, device, startTime, endTime);
            return Ok(response.@return);
        }
        //reportUserSummary(String sessionId, String transactionId, String location, String user, String startTime, String endTime )
        [HttpGet("ReportUserSummary")]
        public async Task<IActionResult> reportUserSummary(string sessionId, string transactionId, string location, string user, string startTime, string endTime)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportUserSummaryAsync(sessionId, transactionId, location, user, startTime, endTime);
            return Ok(response.@return);
        }

        //reportInventorySummary(String sessionId,String transactionId, String location, String device, String startTime, String endTime ) 
        [HttpGet("ReportInventorySummary")]
        public async Task<IActionResult> reportInventorySummary(string sessionId, string transactionId, string location, string device, string startTime, string endTime)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportInventorySummaryAsync(sessionId, transactionId, location, device, startTime, endTime);
            return Ok(response.@return);
        }
        //reportDeviceLocking(String sessionId,String transactionId,String startTime,String endTime, String location, Stringdevice )
        [HttpGet("ReportDeviceLocking")]
        public async Task<IActionResult> reportDeviceLocking(string sessionId, string transactionId, string startTime, string endTime, string location, string device)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportDeviceLockingAsync(sessionId, transactionId, startTime, endTime, location, device);
            return Ok(response.@return);
        }
        //reportRetrieveUsers(String sessionId, String transactionId, String userName )
        [HttpGet("ReportRetrieveUsers")]
        public async Task<IActionResult> reportRetrieveUsers(string sessionId, string transactionId, string userName)
        {
            var client = new CashInsightAPIServicePortTypeClient(CashInsightAPIServicePortTypeClient.EndpointConfiguration.CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.reportRetrieveUsersAsync(sessionId, transactionId, userName);
            return Ok(response.@return);
        }

        }

}
