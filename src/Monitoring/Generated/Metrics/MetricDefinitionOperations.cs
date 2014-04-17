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
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Common;
using Microsoft.WindowsAzure.Common.Internals;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics;
using Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.WindowsAzure.Management.Monitoring.Metrics
{
    internal partial class MetricDefinitionOperations : IServiceOperations<MetricsClient>, Microsoft.WindowsAzure.Management.Monitoring.Metrics.IMetricDefinitionOperations
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinitionOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal MetricDefinitionOperations(MetricsClient client)
        {
            this._client = client;
        }
        
        private MetricsClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Monitoring.Metrics.MetricsClient.
        /// </summary>
        public MetricsClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The List Metric Definitions operation lists the metric definitions
        /// for the resource.
        /// </summary>
        /// <param name='resourceId'>
        /// Required. The id of the resource.The resource id can be built using
        /// the resource id builder class under utilities
        /// </param>
        /// <param name='metricNames'>
        /// Optional. The names of the metrics.
        /// </param>
        /// <param name='metricNamespace'>
        /// Required. The namespace of the metrics.The value is either null or
        /// WindowsAzure.Availability.WindowsAzure.Availability returns the
        /// metric definitions for endpoint monitoring metrics
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Metric Definitions operation response.
        /// </returns>
        public async System.Threading.Tasks.Task<Microsoft.WindowsAzure.Management.Monitoring.Metrics.Models.MetricDefinitionListResponse> ListAsync(string resourceId, IList<string> metricNames, string metricNamespace, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceId == null)
            {
                throw new ArgumentNullException("resourceId");
            }
            
            // Tracing
            bool shouldTrace = CloudContext.Configuration.Tracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = Tracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceId", resourceId);
                tracingParameters.Add("metricNames", metricNames);
                tracingParameters.Add("metricNamespace", metricNamespace);
                Tracing.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            string url = "/" + this.Client.Credentials.SubscriptionId.Trim() + "/services/monitoring/metricdefinitions/query?";
            url = url + "&resourceId=" + Uri.EscapeUriString(resourceId.Trim());
            if (metricNamespace != null)
            {
                url = url + "&namespace=" + Uri.EscapeUriString(metricNamespace.Trim());
            }
            if (metricNames != null && metricNames.Count > 0)
            {
                url = url + "&names=" + Uri.EscapeUriString(string.Join(",", metricNames));
            }
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2013-10-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        Tracing.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        Tracing.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false), CloudExceptionType.Json);
                        if (shouldTrace)
                        {
                            Tracing.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    MetricDefinitionListResponse result = null;
                    // Deserialize Response
                    cancellationToken.ThrowIfCancellationRequested();
                    string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                    result = new MetricDefinitionListResponse();
                    JToken responseDoc = null;
                    if (string.IsNullOrEmpty(responseContent) == false)
                    {
                        responseDoc = JToken.Parse(responseContent);
                    }
                    
                    if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                    {
                        MetricDefinitionCollection metricDefinitionCollectionInstance = new MetricDefinitionCollection();
                        result.MetricDefinitionCollection = metricDefinitionCollectionInstance;
                        
                        JToken valueArray = responseDoc["Value"];
                        if (valueArray != null && valueArray.Type != JTokenType.Null)
                        {
                            foreach (JToken valueValue in ((JArray)valueArray))
                            {
                                MetricDefinition metricDefinitionInstance = new MetricDefinition();
                                metricDefinitionCollectionInstance.Value.Add(metricDefinitionInstance);
                                
                                JToken nameValue = valueValue["Name"];
                                if (nameValue != null && nameValue.Type != JTokenType.Null)
                                {
                                    string nameInstance = ((string)nameValue);
                                    metricDefinitionInstance.Name = nameInstance;
                                }
                                
                                JToken namespaceValue = valueValue["Namespace"];
                                if (namespaceValue != null && namespaceValue.Type != JTokenType.Null)
                                {
                                    string namespaceInstance = ((string)namespaceValue);
                                    metricDefinitionInstance.Namespace = namespaceInstance;
                                }
                                
                                JToken resourceIdSuffixValue = valueValue["ResourceIdSuffix"];
                                if (resourceIdSuffixValue != null && resourceIdSuffixValue.Type != JTokenType.Null)
                                {
                                    string resourceIdSuffixInstance = ((string)resourceIdSuffixValue);
                                    metricDefinitionInstance.ResourceIdSuffix = resourceIdSuffixInstance;
                                }
                                
                                JToken displayNameValue = valueValue["DisplayName"];
                                if (displayNameValue != null && displayNameValue.Type != JTokenType.Null)
                                {
                                    string displayNameInstance = ((string)displayNameValue);
                                    metricDefinitionInstance.DisplayName = displayNameInstance;
                                }
                                
                                JToken unitValue = valueValue["Unit"];
                                if (unitValue != null && unitValue.Type != JTokenType.Null)
                                {
                                    string unitInstance = ((string)unitValue);
                                    metricDefinitionInstance.Unit = unitInstance;
                                }
                                
                                JToken primaryAggregationValue = valueValue["PrimaryAggregation"];
                                if (primaryAggregationValue != null && primaryAggregationValue.Type != JTokenType.Null)
                                {
                                    string primaryAggregationInstance = ((string)primaryAggregationValue);
                                    metricDefinitionInstance.PrimaryAggregation = primaryAggregationInstance;
                                }
                                
                                JToken metricAvailabilitiesArray = valueValue["MetricAvailabilities"];
                                if (metricAvailabilitiesArray != null && metricAvailabilitiesArray.Type != JTokenType.Null)
                                {
                                    foreach (JToken metricAvailabilitiesValue in ((JArray)metricAvailabilitiesArray))
                                    {
                                        MetricAvailability metricAvailabilityInstance = new MetricAvailability();
                                        metricDefinitionInstance.MetricAvailabilities.Add(metricAvailabilityInstance);
                                        
                                        JToken timeGrainValue = metricAvailabilitiesValue["TimeGrain"];
                                        if (timeGrainValue != null && timeGrainValue.Type != JTokenType.Null)
                                        {
                                            TimeSpan timeGrainInstance = TypeConversion.From8601TimeSpan(((string)timeGrainValue));
                                            metricAvailabilityInstance.TimeGrain = timeGrainInstance;
                                        }
                                        
                                        JToken retentionValue = metricAvailabilitiesValue["Retention"];
                                        if (retentionValue != null && retentionValue.Type != JTokenType.Null)
                                        {
                                            TimeSpan retentionInstance = TypeConversion.From8601TimeSpan(((string)retentionValue));
                                            metricAvailabilityInstance.Retention = retentionInstance;
                                        }
                                    }
                                }
                                
                                JToken minimumAlertableTimeWindowValue = valueValue["MinimumAlertableTimeWindow"];
                                if (minimumAlertableTimeWindowValue != null && minimumAlertableTimeWindowValue.Type != JTokenType.Null)
                                {
                                    TimeSpan minimumAlertableTimeWindowInstance = TypeConversion.From8601TimeSpan(((string)minimumAlertableTimeWindowValue));
                                    metricDefinitionInstance.MinimumAlertableTimeWindow = minimumAlertableTimeWindowInstance;
                                }
                                
                                JToken isAlertableValue = valueValue["IsAlertable"];
                                if (isAlertableValue != null && isAlertableValue.Type != JTokenType.Null)
                                {
                                    bool isAlertableInstance = ((bool)isAlertableValue);
                                    metricDefinitionInstance.IsAlertable = isAlertableInstance;
                                }
                            }
                        }
                    }
                    
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        Tracing.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
