﻿/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Specialized;
using System.Security.Claims;
using Thinktecture.IdentityServer.Core.Configuration;

namespace Thinktecture.IdentityServer.Core.Validation
{
    /// <summary>
    /// Base class for a validate authorize or token request
    /// </summary>
    public class ValidatedRequest
    {
        /// <summary>
        /// Gets or sets the raw request data
        /// </summary>
        /// <value>
        /// The raw.
        /// </value>
        public NameValueCollection Raw { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public ClaimsPrincipal Subject { get; set; }

        /// <summary>
        /// Gets or sets the identity server options.
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public IdentityServerOptions Options { get; set; }

        /// <summary>
        /// Gets or sets the validated scopes.
        /// </summary>
        /// <value>
        /// The validated scopes.
        /// </value>
        public ScopeValidator ValidatedScopes { get; set; }
    }
}