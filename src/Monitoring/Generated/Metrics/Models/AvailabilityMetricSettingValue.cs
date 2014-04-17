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
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models
{
    /// <summary>
    /// The setting for Endpoint monitoring.
    /// </summary>
    public partial class AvailabilityMetricSettingValue : MetricSettingValue
    {
        private IList<NameConfig> _availableLocations;
        
        /// <summary>
        /// Optional. The locations from which the Urls can be monitored.
        /// </summary>
        public IList<NameConfig> AvailableLocations
        {
            get { return this._availableLocations; }
            set { this._availableLocations = value; }
        }
        
        private IList<EndpointConfig> _endpoints;
        
        /// <summary>
        /// Required. The configuration for Urls to be monitored using endpoint
        /// monitoiring.
        /// </summary>
        public IList<EndpointConfig> Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AvailabilityMetricSettingValue
        /// class.
        /// </summary>
        public AvailabilityMetricSettingValue()
        {
            this._availableLocations = new List<NameConfig>();
            this._endpoints = new List<EndpointConfig>();
        }
    }
}
