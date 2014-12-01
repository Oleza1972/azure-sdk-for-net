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
using Microsoft.Azure.Insights.Models;
using Microsoft.WindowsAzure.Common.Internals;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// Deprecated. Represents a collection of usage metrics.
    /// </summary>
    public partial class UsageMetricCollectionDeprecated
    {
        private IList<UsageMetricDeprecated> _properties;
        
        /// <summary>
        /// Optional. The usage values.
        /// </summary>
        public IList<UsageMetricDeprecated> Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        private IList<UsageMetricDeprecated> _value;
        
        /// <summary>
        /// Optional. The usage values.
        /// </summary>
        public IList<UsageMetricDeprecated> Value
        {
            get { return this._value; }
            set { this._value = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the UsageMetricCollectionDeprecated
        /// class.
        /// </summary>
        public UsageMetricCollectionDeprecated()
        {
            this.Properties = new LazyList<UsageMetricDeprecated>();
            this.Value = new LazyList<UsageMetricDeprecated>();
        }
    }
}
