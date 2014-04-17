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
using Microsoft.WindowsAzure.Management;
using Microsoft.WindowsAzure.Management.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class AffinityGroupOperationsExtensions
    {
        /// <summary>
        /// The Create Affinity Group operation creates a new affinity group
        /// for the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715317.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Affinity Group
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Create(this IAffinityGroupOperations operations, AffinityGroupCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAffinityGroupOperations)s).CreateAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Create Affinity Group operation creates a new affinity group
        /// for the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715317.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create Affinity Group
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> CreateAsync(this IAffinityGroupOperations operations, AffinityGroupCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Affinity Group operation deletes an affinity group in
        /// the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715314.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='affinityGroupName'>
        /// Required. The name of the affinity group.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Delete(this IAffinityGroupOperations operations, string affinityGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAffinityGroupOperations)s).DeleteAsync(affinityGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete Affinity Group operation deletes an affinity group in
        /// the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715314.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='affinityGroupName'>
        /// Required. The name of the affinity group.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> DeleteAsync(this IAffinityGroupOperations operations, string affinityGroupName)
        {
            return operations.DeleteAsync(affinityGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Get Affinity Group Properties operation returns the system
        /// properties associated with the specified affinity group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460789.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='affinityGroupName'>
        /// Required. The name of the desired affinity group as returned by the
        /// name element of the List Affinity Groups operation.
        /// </param>
        /// <returns>
        /// The Get Affinity Group operation response.
        /// </returns>
        public static AffinityGroupGetResponse Get(this IAffinityGroupOperations operations, string affinityGroupName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAffinityGroupOperations)s).GetAsync(affinityGroupName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Affinity Group Properties operation returns the system
        /// properties associated with the specified affinity group.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460789.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='affinityGroupName'>
        /// Required. The name of the desired affinity group as returned by the
        /// name element of the List Affinity Groups operation.
        /// </param>
        /// <returns>
        /// The Get Affinity Group operation response.
        /// </returns>
        public static Task<AffinityGroupGetResponse> GetAsync(this IAffinityGroupOperations operations, string affinityGroupName)
        {
            return operations.GetAsync(affinityGroupName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Affinity Groups operation lists the affinity groups
        /// associated with the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460797.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <returns>
        /// The List Affinity Groups operation response.
        /// </returns>
        public static AffinityGroupListResponse List(this IAffinityGroupOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAffinityGroupOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Affinity Groups operation lists the affinity groups
        /// associated with the specified subscription.  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460797.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <returns>
        /// The List Affinity Groups operation response.
        /// </returns>
        public static Task<AffinityGroupListResponse> ListAsync(this IAffinityGroupOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
        
        /// <summary>
        /// The Update Affinity Group operation updates the label and/or the
        /// description for an affinity group for the specified subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715316.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='affinityGroupName'>
        /// Required. The name of the affinity group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Affinity Group
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse Update(this IAffinityGroupOperations operations, string affinityGroupName, AffinityGroupUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAffinityGroupOperations)s).UpdateAsync(affinityGroupName, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Update Affinity Group operation updates the label and/or the
        /// description for an affinity group for the specified subscription.
        /// (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/gg715316.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.IAffinityGroupOperations.
        /// </param>
        /// <param name='affinityGroupName'>
        /// Required. The name of the affinity group.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Update Affinity Group
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> UpdateAsync(this IAffinityGroupOperations operations, string affinityGroupName, AffinityGroupUpdateParameters parameters)
        {
            return operations.UpdateAsync(affinityGroupName, parameters, CancellationToken.None);
        }
    }
}
