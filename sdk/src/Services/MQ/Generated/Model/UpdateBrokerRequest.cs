/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBroker operation.
    /// Adds a pending configuration change to a broker.
    /// </summary>
    public partial class UpdateBrokerRequest : AmazonMQRequest
    {
        private string _brokerId;
        private ConfigurationId _configuration;
        private Logs _logs;

        /// <summary>
        /// Gets and sets the property BrokerId. The name of the broker. This value must be unique
        /// in your AWS account, 1-50 characters long, must contain only letters, numbers, dashes,
        /// and underscores, and must not contain whitespaces, brackets, wildcard characters,
        /// or special characters.
        /// </summary>
        public string BrokerId
        {
            get { return this._brokerId; }
            set { this._brokerId = value; }
        }

        // Check to see if BrokerId property is set
        internal bool IsSetBrokerId()
        {
            return this._brokerId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. A list of information about the configuration.
        /// </summary>
        public ConfigurationId Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property Logs. Enables Amazon CloudWatch logging for brokers.
        /// </summary>
        public Logs Logs
        {
            get { return this._logs; }
            set { this._logs = value; }
        }

        // Check to see if Logs property is set
        internal bool IsSetLogs()
        {
            return this._logs != null;
        }

    }
}