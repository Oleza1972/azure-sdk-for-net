// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity excel source.
    /// </summary>
    public partial class ExcelSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the ExcelSource class.
        /// </summary>
        public ExcelSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExcelSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="storeSettings">Excel store settings.</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects (or Expression with
        /// resultType array of objects).</param>
        public ExcelSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), StoreReadSettings storeSettings = default(StoreReadSettings), IList<AdditionalColumns> additionalColumns = default(IList<AdditionalColumns>))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            StoreSettings = storeSettings;
            AdditionalColumns = additionalColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets excel store settings.
        /// </summary>
        [JsonProperty(PropertyName = "storeSettings")]
        public StoreReadSettings StoreSettings { get; set; }

        /// <summary>
        /// Gets or sets specifies the additional columns to be added to source
        /// data. Type: array of objects (or Expression with resultType array
        /// of objects).
        /// </summary>
        [JsonProperty(PropertyName = "additionalColumns")]
        public IList<AdditionalColumns> AdditionalColumns { get; set; }

    }
}