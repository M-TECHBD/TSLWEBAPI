using CashInsightSoap;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using System.Xml.Linq;

namespace TslWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        [HttpPost("Login")]
        public async Task<IActionResult> Login(string userid, string password)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.logonAsync(userid, password, false);
            return Ok(response.@return);
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout(string sessionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);

            var response = await client.logoffAsync(sessionId);
            return Ok(response.@return);
        }
        [HttpPost("CreateUser")]
        public async Task<IActionResult> createUser(string sessionId, string transactionId, string loginName, string userName, int role)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.createUserAsync(sessionId, transactionId: transactionId, loginName: loginName, userName: userName, role: role);
            return Ok(response.@return);
        }

        [HttpPost("LogonWithEncryptedPassword")]
        public async Task<IActionResult> logonWithencryptedPassword(string login, byte[] password, bool useActiveDirectory, int encryptionScheme)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.logonWithEncryptedPasswordAsync(login, password, useActiveDirectory, encryptionScheme);
            return Ok(response.@return);
        }
        [HttpGet("businessSessionList")]
        public async Task<IActionResult> businessSessionList(string sessionId, string userName)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.businessSessionListAsync(sessionId, userName);
            return Ok(response.@return);
        }
        [HttpGet("BusinessSessionData")]
        public async Task<IActionResult> businessSessionData(string sessionId, string userName, string startTime)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.businessSessionDataAsync(sessionId, userName, startTime);
            return Ok(response.@return);
        }
        //  balanceUser(String sessionId,String username)
        [HttpGet("BalanceUser")]
        public async Task<IActionResult> balanceUser(string sessionId, string username)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.balanceUserAsync(sessionId, username);
            return Ok(response.@return);
        }
        // changePassword    ( String   login, String oldPassword,String newPassword ) 
        //[HttpPost("ChangePassword")]
        //public async Task<IActionResult> changePassword(string login, string oldPassword, string newPassword)
        //{
        //    var client = new CashInsightAPIServicePortTypeClient(
        //        CashInsightAPIServicePortTypeClient.EndpointConfiguration
        //            .CashInsightAPIServiceHttpSoap12Endpoint);
        //    var response = await client.changePasswordAsync(login, oldPassword, newPassword);
        //    return Ok(response.@return);
        //}
        //changeEncryptedPassword(String login, byte[] oldPassword,byte[] newPassword,int encryptionScheme )
        //[HttpPost("ChangeEncryptedPassword")]
        //public async Task<IActionResult> changeEncryptedPassword(string sessionid, string login, byte[] oldPassword, byte[] newPassword, int encryptionScheme)
        //{
        //    var client = new CashInsightAPIServicePortTypeClient(
        //        CashInsightAPIServicePortTypeClient.EndpointConfiguration
        //            .CashInsightAPIServiceHttpSoap12Endpoint);
        //    var response = await client.changeEncryptedPasswordAsync(sessionid, login, oldPassword, newPassword, encryptionScheme);
        //    return Ok(response.@return);
        //}
        // getUserLockStatus(String sessionId, String transactionId,String userName )
        [HttpGet("GetUserLockStatus")]
        public async Task<IActionResult> getUserLockStatus(string sessionId, string transactionId, string userName)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getUserLockStatusAsync(sessionId, transactionId, userName);
            return Ok(response.@return);
        }
        /// lockUser(String sessionId,String transactionId,String userName )

        [HttpPost("LockUser")]
        public async Task<IActionResult> lockUser(string sessionId, string transactionId, string userName)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.lockUserAsync(sessionId, transactionId, userName);
            return Ok(response.@return);
        }
        //unlockUser(String sessionId,String transactionId,String userName
        [HttpPost("UnlockUser")]
        public async Task<IActionResult> unlockUser(string sessionId, string transactionId, string userName)
        {
            var client = new CashInsightAPIServicePortTypeClient(
                CashInsightAPIServicePortTypeClient.EndpointConfiguration
                    .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.unlockUserAsync(sessionId, transactionId, userName);
            return Ok(response.@return);
        }
        //retrieveRoles(String sessionId,String transactionId)
        [HttpGet("RetrieveRoles")]
        public async Task<IActionResult> retrieveRoles(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.retrieveRolesAsync(sessionId, transactionId);
            return Ok(response.@return);
        }
        //  retrieveUsers(String sessionId,String transactionId)
        [HttpGet("RetrieveUsers")]

        public async Task<IActionResult> retrieveUsers(string sessionId, string transactionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.retrieveUsersAsync(sessionId, transactionId);
            return Ok(response.@return);
        }

        //findUserByLogin(String sessionId,String transactionId,String loginName)
        [HttpGet("FindUserByLogin")]
        public async Task<IActionResult> findUserByLogin(string sessionId, string transactionId, string loginName)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.findUserByLoginAsync(sessionId, transactionId, loginName);
            return Ok(response.@return);
        }
        // getUserDetails(String sessionId)
        [HttpGet("GetUserDetails")]
        public async Task<IActionResult> getUserDetails(string sessionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getUserDetailsAsync(sessionId);
            return Ok(response.@return);
        }


        //deleteUser(String sessionId,String transactionId,String loginName)
        [HttpPost("DeleteUser")]
        public async Task<IActionResult> deleteUser(string sessionId, string transactionId, string loginName)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.deleteUserAsync(sessionId, transactionId, loginName);
            return Ok(response.@return);
        }
        //createUser(string sessionId, String transactionId, String loginName,String username,Integer role)
        [HttpPost("CreateUsers")]
        public async Task<IActionResult> createUsers(string sessionId, string transactionId, string loginName, string username, int role)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.createUserAsync(sessionId, transactionId, loginName, username, role);
            return Ok(response.@return);
        }


        //updateUser(String sessionId,
        //String transactionId,
        //String loginName,
        //String username,
        //Integer role)--2.79
        [HttpPost("UpdateUser")]
        public async Task<IActionResult> updateUser(string sessionId, string transactionId, string loginName, string username, int role)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.updateUserAsync(sessionId, transactionId, loginName, username, role);
            return Ok(response.@return);
        }

        //setUserLimit(String sessionId,String transactionId,String loginName,LimitList limit)
        [HttpPost("SetUserLimit")]
        public async Task<IActionResult> setUserLimit(string sessionId, string transactionId, string loginName, LimitList1 limit)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.setUserLimitAsync(sessionId, transactionId, loginName, limit);
            return Ok(response.@return);
        }

        //  resetPassword(String sessionId,String transactionId,String loginName,String password,Boolean    changePasswordOnFirstLogin ) 
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> resetPassword(string sessionId, string transactionId, string loginName, string password, bool changePasswordOnFirstLogin)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.resetPasswordAsync(sessionId, transactionId, loginName, password, changePasswordOnFirstLogin);
            return Ok(response.@return);
        }
        //resetEncryptedPassword(String sessionId,String transactionId,String loginName,byte[] password,int encrptionScheme,Boolean changePasswordOnFir
        [HttpPost("ResetEncryptedPassword")]
        public async Task<IActionResult> resetEncryptedPassword(string sessionId, string transactionId, string loginName, byte[] password, int encryptionScheme, bool changePasswordOnFirstLogin)
        {
            var client = new CashInsightAPIServicePortTypeClient(
              CashInsightAPIServicePortTypeClient.EndpointConfiguration
                  .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.resetEncryptedPasswordAsync(sessionId, transactionId, loginName, password, encryptionScheme, changePasswordOnFirstLogin);
            return Ok(response.@return);
        }
        //applicationLogging(String applicationName,
        //                                              String logLevel,
        //                                              String clientId,
        //                                              String sessionId,
        //                                              String message)
        //[HttpPost("ApplicationLogging")]
        //public async Task<IActionResult> applicationLogging(string applicationName, string logLevel, string clientId, string sessionId, string message)
        //{
        //    var client = new CashInsightAPIServicePortTypeClient(
        //      CashInsightAPIServicePortTypeClient.EndpointConfiguration
        //          .CashInsightAPIServiceHttpSoap12Endpoint);
        //    var response = await client.applicationLoggingAsync(applicationName, logLevel, clientId, sessionId, message);
        //    return Ok(response.@return);
        //}
        ///Not Found the method applicationLogging in the service reference, so I commented it out. If you want to use it, please uncomment and make sure the method exists in the service reference.
        //queueDispense(String sessionId,String owner,String pin,Integer amount,String currency,Denomination denomination,Device device,String transactionNote,Integer delay,Integer timeout)
        //getUserPermissions  (String sessionId)
        [HttpGet("GetUserPermissions")]
        public async Task<IActionResult> getUserPermissions(string sessionId)
        {
            var client = new CashInsightAPIServicePortTypeClient(
             CashInsightAPIServicePortTypeClient.EndpointConfiguration
                .CashInsightAPIServiceHttpSoap12Endpoint);
            var response = await client.getUserPermissionsAsync(sessionId);
            return Ok(response.@return);
        }
    }
}
