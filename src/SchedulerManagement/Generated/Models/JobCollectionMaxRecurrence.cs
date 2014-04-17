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
using Microsoft.WindowsAzure.Management.Scheduler.Models;

namespace Microsoft.WindowsAzure.Management.Scheduler.Models
{
    public partial class JobCollectionMaxRecurrence
    {
        private JobCollectionRecurrenceFrequency _frequency;
        
        /// <summary>
        /// Required. Defines the maximum recurrences that can be specified in
        /// any job in this job collection.
        /// </summary>
        public JobCollectionRecurrenceFrequency Frequency
        {
            get { return this._frequency; }
            set { this._frequency = value; }
        }
        
        private int _interval;
        
        /// <summary>
        /// Required. Defines the interval.
        /// </summary>
        public int Interval
        {
            get { return this._interval; }
            set { this._interval = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobCollectionMaxRecurrence class.
        /// </summary>
        public JobCollectionMaxRecurrence()
        {
        }
    }
}
