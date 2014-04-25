// ****************************************
// Assembly : NetflixRouletteSharp
// File     : RouletteRequest.cs
// Author   : Alex Camilleri
// ****************************************
// Created  : 25/04/2014
// ****************************************

using System.Text;

namespace NetflixRouletteSharp
{
    /// <summary>
    ///     Class RouletteRequest.
    /// </summary>
    public class RouletteRequest
    {
        /// <summary>
        ///     Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        ///     Gets or sets the year.
        /// </summary>
        /// <value>The year.</value>
        public int Year { get; set; }

        public string ApiUrl
        {
            get
            {
                var stringBuilder = new StringBuilder(NetflixRouletteSharp.NetflixRoulette.API_URL).AppendFormat("title={0}", Title);
                return (Year > 0 ? stringBuilder.AppendFormat("&year={0}", Year) : stringBuilder).ToString();
            }
        }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString()
        {
            return string.Format("RouletteRequest(Title = \"{0}\", Year = {1})", Title, Year);
        }
    }
}
