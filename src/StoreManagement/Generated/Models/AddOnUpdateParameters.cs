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

namespace Microsoft.WindowsAzure.Management.Store.Models
{
    /// <summary>
    /// Represents the data passed to the Update Store Resource API method.
    /// </summary>
    public partial class AddOnUpdateParameters
    {
        private string _plan;
        
        /// <summary>
        /// Required. The selected plan for this store addon.
        /// </summary>
        public string Plan
        {
            get { return this._plan; }
            set { this._plan = value; }
        }
        
        private string _promotionCode;
        
        /// <summary>
        /// Optional. The promotion code for this store addon.
        /// </summary>
        public string PromotionCode
        {
            get { return this._promotionCode; }
            set { this._promotionCode = value; }
        }
        
        private string _type;
        
        /// <summary>
        /// Required. The type of store item to be created.
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AddOnUpdateParameters class.
        /// </summary>
        public AddOnUpdateParameters()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the AddOnUpdateParameters class with
        /// required arguments.
        /// </summary>
        public AddOnUpdateParameters(string type, string plan)
            : this()
        {
            if (type == null)
            {
                throw new ArgumentNullException("type");
            }
            if (plan == null)
            {
                throw new ArgumentNullException("plan");
            }
            this.Type = type;
            this.Plan = plan;
        }
    }
}
