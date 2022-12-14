﻿/* *********************************************************************
 * Date: 11 Jun 2012
 * Created by: Zoltan Juhasz
 * E-Mail: forge@jzo.hu
***********************************************************************/

using System;

namespace Forge.Net.Remoting
{

    /// <summary>
    /// Security failed scenario
    /// </summary>
    [Serializable]
    public class MessageSecurityException : Exception
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSecurityException"/> class.
        /// </summary>
        public MessageSecurityException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSecurityException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MessageSecurityException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSecurityException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        public MessageSecurityException(string message, Exception exception) : base(message, exception)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSecurityException" /> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null.</exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
        protected MessageSecurityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
        }

    }

}
