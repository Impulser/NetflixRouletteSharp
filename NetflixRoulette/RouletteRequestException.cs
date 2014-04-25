// ****************************************
// Assembly : NetflixRouletteSharp
// File     : RouletteRequestException.cs
// Author   : Alex Camilleri
// ****************************************
// Created  : 25/04/2014
// ****************************************

using System;
using System.Runtime.Serialization;

namespace NetflixRouletteSharp
{
    /// <summary>
    ///     Class RouletteRequestException.
    /// </summary>
    [Serializable]
    public class RouletteRequestException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="T:NetflixRouletteSharp.RouletteRequestException" /> class.
        /// </summary>
        public RouletteRequestException()
        { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:NetflixRouletteSharp.RouletteRequestException" /> class with a specified
        ///     error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public RouletteRequestException(string message)
            : base(message)
        { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:NetflixRouletteSharp.RouletteRequestException" /> class with a specified
        ///     error message.
        /// </summary>
        /// <param name="format">The message that describes the error, where the message contains format tokens.</param>
        /// <param name="arguments">An object array that contains zero or more objects to format. </param>
        public RouletteRequestException(string format, params object[] arguments)
            : this(string.Format(format, arguments))
        { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RouletteRequestException" /> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="inner">The inner.</param>
        public RouletteRequestException(string message, Exception inner)
            : base(message, inner)
        { }

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Exception" /> class with serialized data.
        /// </summary>
        /// <param name="info">
        ///     The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object
        ///     data about the exception being thrown.
        /// </param>
        /// <param name="context">
        ///     The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual
        ///     information about the source or destination.
        /// </param>
        protected RouletteRequestException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }
    }
}
