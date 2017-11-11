﻿/*
   Copyright 2016 - 2017 Adrian Popescu.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using System;

namespace RedmineApi.Core.Exceptions
{
    /// <summary>
    /// </summary>
    /// <seealso cref="RedmineApi.Core.Exceptions.RedmineException" />
    public class ForbiddenException : RedmineException
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        public ForbiddenException()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        /// <param name="message"></param>
        public ForbiddenException(string message)
            : base(message)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="args"></param>
        public ForbiddenException(string format, params object[] args)
            : base(string.Format(format, args))
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ForbiddenException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="ForbiddenException" /> class.
        /// </summary>
        /// <param name="format"></param>
        /// <param name="innerException"></param>
        /// <param name="args"></param>
        public ForbiddenException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException)
        {
        }

       
    }
}