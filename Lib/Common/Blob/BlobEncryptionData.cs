﻿// <copyright file="BlobEncryptionData.cs" company="Microsoft">
//    Copyright 2013 Microsoft Corporation
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
// </copyright>
// -----------------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.Blob
{
    /// <summary>
    /// Represents the blob encryption data that is stored as metadata on the service.
    /// </summary>
    internal sealed class BlobEncryptionData : EncryptionData
    {
        /// <summary>
        /// Gets or sets the blob client encryption mode.
        /// </summary>
        /// <value>The blob encryption mode.</value>
        public string EncryptionMode { get; set; }
    }
}