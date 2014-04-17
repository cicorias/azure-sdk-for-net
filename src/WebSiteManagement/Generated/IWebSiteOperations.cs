// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.WebSites.Models;

namespace Microsoft.WindowsAzure.Management.WebSites
{
    /// <summary>
    /// Operations for managing the web sites in a web space.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166981.aspx for
    /// more information)
    /// </summary>
    public partial interface IWebSiteOperations
    {
        /// <summary>
        /// You can swap a web site from one slot to the production slot.
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='slotName'>
        /// The name of the web site slot to swap with the production slot.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified long-running
        /// operation, indicating whether it has succeeded, is inprogress, has
        /// timed out, or has failed. Note that this status is distinct from
        /// the HTTP status code returned for the Get Operation Status
        /// operation itself. If the long-running operation failed, the
        /// response body includes error information regarding the failure.
        /// </returns>
        Task<WebSiteOperationStatusResponse> BeginSwapingSlotsAsync(string webSpaceName, string webSiteName, string slotName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can create a web site by using a POST request that includes the
        /// name of the web site and other information in the request body.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166986.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Create Web Site operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Create Web Site operation response.
        /// </returns>
        Task<WebSiteCreateResponse> CreateAsync(string webSpaceName, WebSiteCreateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a Git repository that you can
        /// use to manage your web site content. By using Git source control
        /// tools, you can push or pull version-controlled changes to your
        /// site. This API executes a repository create operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> CreateRepositoryAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can delete a web site by issuing an HTTP DELETE request. If the
        /// web site being deleted is the only site remaining in a server
        /// farm, you can optionally delete the server farm as well by using
        /// the deleteEmptyServerFarm parameter.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236430.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Delete Web Site operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> DeleteAsync(string webSpaceName, string webSiteName, WebSiteDeleteParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a Git repository that you can
        /// use to manage your web site content. By using Git source control
        /// tools, you can push or pull version-controlled changes to your
        /// site. This API executes a repository delete operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Delete Repository Web Site operation response.
        /// </returns>
        Task<WebSiteDeleteRepositoryResponse> DeleteRepositoryAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can generate a new random password for publishing a site by
        /// issuing an HTTP POST request. Tip: If you want to verify that the
        /// publish password has changed, issue an HTTP GET on /publishxml
        /// before calling /newpassword. In the publish XML, note the hash
        /// value in the userPWD attribute. After calling /newpassword, call
        /// /publishxml again. You can then compare the new value of userPWD
        /// in the Publish XML with the one you noted earlier.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236428.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> GeneratePasswordAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve details for a web site by issuing an HTTP GET
        /// request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167007.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Web Site Operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Web Site operation response.
        /// </returns>
        Task<WebSiteGetResponse> GetAsync(string webSpaceName, string webSiteName, WebSiteGetParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve the config settings for a web site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166985.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Configuration Web Site operation response.
        /// </returns>
        Task<WebSiteGetConfigurationResponse> GetConfigurationAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve historical usage metrics for a site by issuing an
        /// HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166964.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Get Historical Usage Metrics Web Site
        /// operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Historical Usage Metrics Web Site operation response.
        /// </returns>
        Task<WebSiteGetHistoricalUsageMetricsResponse> GetHistoricalUsageMetricsAsync(string webSpaceName, string webSiteName, WebSiteGetHistoricalUsageMetricsParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve the publish settings information for a web site by
        /// issuing an HTTP GET request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166996.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Publish Profile Web Site operation response.
        /// </returns>
        Task<WebSiteGetPublishProfileResponse> GetPublishProfileAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a Git repository that you can
        /// use to manage your web site content. By using Git source control
        /// tools, you can push or pull version-controlled changes to your
        /// site. This API executes a repository get operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Repository Web Site operation response.
        /// </returns>
        Task<WebSiteGetRepositoryResponse> GetRepositoryAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can retrieve current usage metrics for a site by issuing an
        /// HTTP GET request. The metrics returned include CPU Time, Data In,
        /// Data Out, Local Bytes Read, Local Bytes Written, Network Bytes
        /// Read, Network Bytes Written, WP Stop Requests, Memory Usage, CPU
        /// Time - Minute Limit, and File System Storage.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166991.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Get Usage Metrics Web Site operation response.
        /// </returns>
        Task<WebSiteGetUsageMetricsResponse> GetUsageMetricsAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Determines if a host name is available.
        /// </summary>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Is Hostname Available Web Site operation response.
        /// </returns>
        Task<WebSiteIsHostnameAvailableResponse> IsHostnameAvailableAsync(string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can restart a web site by issuing an HTTP POST request.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn236425.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> RestartAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can swap a web site from one slot to the production slot.
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='slotName'>
        /// The name of the web site slot to swap with the production slot.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified long-running
        /// operation, indicating whether it has succeeded, is inprogress, has
        /// timed out, or has failed. Note that this status is distinct from
        /// the HTTP status code returned for the Get Operation Status
        /// operation itself. If the long-running operation failed, the
        /// response body includes error information regarding the failure.
        /// </returns>
        Task<WebSiteOperationStatusResponse> SwapSlotsAsync(string webSpaceName, string webSiteName, string slotName, CancellationToken cancellationToken);
        
        /// <summary>
        /// A web site repository is essentially a Git repository that you can
        /// use to manage your web site content. By using Git source control
        /// tools, you can push or pull version-controlled changes to your
        /// site. This API executes a repository sync operation.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn166967.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> SyncRepositoryAsync(string webSpaceName, string webSiteName, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can update the settings for a web site by using the HTTP PUT
        /// method and by specifying the settings in the request body.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/dn167005.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Web Site operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The Update Web Site operation response.
        /// </returns>
        Task<WebSiteUpdateResponse> UpdateAsync(string webSpaceName, string webSiteName, WebSiteUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// You can update the config settings for a web site by issuing an
        /// HTTP PUT with a request body containing the updated settings.
        /// (see http://msdn.microsoft.com/en-us/library/windowsazure/dn166985.aspx
        /// for more information)
        /// </summary>
        /// <param name='webSpaceName'>
        /// The name of the web space.
        /// </param>
        /// <param name='webSiteName'>
        /// The name of the web site.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to the Update Configuration Web Site operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<OperationResponse> UpdateConfigurationAsync(string webSpaceName, string webSiteName, WebSiteUpdateConfigurationParameters parameters, CancellationToken cancellationToken);
    }
}
