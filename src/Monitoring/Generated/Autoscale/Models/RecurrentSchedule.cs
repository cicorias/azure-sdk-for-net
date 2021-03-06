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

namespace Microsoft.WindowsAzure.Management.Monitoring.Autoscale.Models
{
    public partial class RecurrentSchedule
    {
        private IList<string> _days;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<string> Days
        {
            get { return this._days; }
            set { this._days = value; }
        }
        
        private IList<int> _hours;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<int> Hours
        {
            get { return this._hours; }
            set { this._hours = value; }
        }
        
        private IList<int> _minutes;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public IList<int> Minutes
        {
            get { return this._minutes; }
            set { this._minutes = value; }
        }
        
        private string _timeZone;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the RecurrentSchedule class.
        /// </summary>
        public RecurrentSchedule()
        {
            this._days = new List<string>();
            this._hours = new List<int>();
            this._minutes = new List<int>();
        }
    }
}
