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
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql.Models
{
    /// <summary>
    /// Parameters supplied to the DAC Import operation.
    /// </summary>
    public partial class DacImportParameters
    {
        private string _azureEdition;
        
        /// <summary>
        /// Optional. The edition of this database.
        /// </summary>
        public string AzureEdition
        {
            get { return this._azureEdition; }
            set { this._azureEdition = value; }
        }
        
        private DacImportParameters.BlobCredentialsParameter _blobCredentials;
        
        /// <summary>
        /// Optional. Gets or sets credentials for getting the DAC.
        /// </summary>
        public DacImportParameters.BlobCredentialsParameter BlobCredentials
        {
            get { return this._blobCredentials; }
            set { this._blobCredentials = value; }
        }
        
        private DacImportParameters.ConnectionInfoParameter _connectionInfo;
        
        /// <summary>
        /// Optional. Gets or sets connection information for the SQL Server
        /// Database.
        /// </summary>
        public DacImportParameters.ConnectionInfoParameter ConnectionInfo
        {
            get { return this._connectionInfo; }
            set { this._connectionInfo = value; }
        }
        
        private int _databaseSizeInGB;
        
        /// <summary>
        /// Optional. Gets or sets the size of this database.
        /// </summary>
        public int DatabaseSizeInGB
        {
            get { return this._databaseSizeInGB; }
            set { this._databaseSizeInGB = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DacImportParameters class.
        /// </summary>
        public DacImportParameters()
        {
        }
        
        /// <summary>
        /// Credentials for getting the DAC.
        /// </summary>
        public partial class BlobCredentialsParameter
        {
            private string _storageAccessKey;
            
            /// <summary>
            /// Required. Gets or sets the key for the Windows Azure Storage
            /// account.
            /// </summary>
            public string StorageAccessKey
            {
                get { return this._storageAccessKey; }
                set { this._storageAccessKey = value; }
            }
            
            private Uri _uri;
            
            /// <summary>
            /// Required. Gets or sets the URI of the DAC file stored in
            /// Windows Azure Blob Storage.
            /// </summary>
            public Uri Uri
            {
                get { return this._uri; }
                set { this._uri = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the BlobCredentialsParameter
            /// class.
            /// </summary>
            public BlobCredentialsParameter()
            {
            }
        }
        
        /// <summary>
        /// Connection information for the SQL Server Database.
        /// </summary>
        public partial class ConnectionInfoParameter
        {
            private string _databaseName;
            
            /// <summary>
            /// Required. Gets or sets the name of the database.
            /// </summary>
            public string DatabaseName
            {
                get { return this._databaseName; }
                set { this._databaseName = value; }
            }
            
            private string _password;
            
            /// <summary>
            /// Required. Gets or sets the password for the database user.
            /// </summary>
            public string Password
            {
                get { return this._password; }
                set { this._password = value; }
            }
            
            private string _serverName;
            
            /// <summary>
            /// Required. Gets or sets the SQL server name.
            /// </summary>
            public string ServerName
            {
                get { return this._serverName; }
                set { this._serverName = value; }
            }
            
            private string _userName;
            
            /// <summary>
            /// Required. Gets or sets the username of the database user.
            /// </summary>
            public string UserName
            {
                get { return this._userName; }
                set { this._userName = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the ConnectionInfoParameter class.
            /// </summary>
            public ConnectionInfoParameter()
            {
            }
        }
    }
}
