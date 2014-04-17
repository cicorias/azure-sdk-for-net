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
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute.Models
{
    /// <summary>
    /// The List Dedicated Circuit Link operation response.
    /// </summary>
    public partial class DedicatedCircuitLinkListResponse : OperationResponse, IEnumerable<AzureDedicatedCircuitLink>
    {
        private IList<AzureDedicatedCircuitLink> _dedicatedCircuitLinks;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<AzureDedicatedCircuitLink> DedicatedCircuitLinks
        {
            get { return this._dedicatedCircuitLinks; }
            set { this._dedicatedCircuitLinks = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DedicatedCircuitLinkListResponse
        /// class.
        /// </summary>
        public DedicatedCircuitLinkListResponse()
        {
            this._dedicatedCircuitLinks = new List<AzureDedicatedCircuitLink>();
        }
        
        /// <summary>
        /// Gets the sequence of DedicatedCircuitLinks.
        /// </summary>
        public IEnumerator<AzureDedicatedCircuitLink> GetEnumerator()
        {
            return this.DedicatedCircuitLinks.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of DedicatedCircuitLinks.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
