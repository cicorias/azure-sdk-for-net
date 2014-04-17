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
    /// A metric value set represents a set of metric values in a time period.
    /// </summary>
    public partial class MetricValueSet
    {
        private string _displayName;
        
        /// <summary>
        /// Optional. Metric display name.
        /// </summary>
        public string DisplayName
        {
            get { return this._displayName; }
            set { this._displayName = value; }
        }
        
        private DateTime _endTime;
        
        /// <summary>
        /// Optional. The end time in UTC for the metric queried.
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }
        
        private IList<MetricValue> _metricValues;
        
        /// <summary>
        /// Optional. Metric values.
        /// </summary>
        public IList<MetricValue> MetricValues
        {
            get { return this._metricValues; }
            set { this._metricValues = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Metric name.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _namespace;
        
        /// <summary>
        /// Optional. Metric namespace.
        /// </summary>
        public string Namespace
        {
            get { return this._namespace; }
            set { this._namespace = value; }
        }
        
        private string _primaryAggregation;
        
        /// <summary>
        /// Optional. Metric primary aggregation.
        /// </summary>
        public string PrimaryAggregation
        {
            get { return this._primaryAggregation; }
            set { this._primaryAggregation = value; }
        }
        
        private DateTime _startTime;
        
        /// <summary>
        /// Optional. The start time in UTC for the metric queried.
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }
        
        private TimeSpan _timeGrain;
        
        /// <summary>
        /// Optional. The time grain specifies the aggregation period of the
        /// metric value.
        /// </summary>
        public TimeSpan TimeGrain
        {
            get { return this._timeGrain; }
            set { this._timeGrain = value; }
        }
        
        private string _unit;
        
        /// <summary>
        /// Optional. Metric unit.
        /// </summary>
        public string Unit
        {
            get { return this._unit; }
            set { this._unit = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the MetricValueSet class.
        /// </summary>
        public MetricValueSet()
        {
            this._metricValues = new List<MetricValue>();
        }
    }
}
