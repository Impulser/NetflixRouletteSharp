// ****************************************
// Assembly : NetflixRoulette
// File     : RouletteResponse.cs
// Author   : Alex Camilleri
// ****************************************
// Created  : 25/04/2014
// ****************************************

using System.Runtime.Serialization;
using System.Text;

namespace NetflixRouletteSharp
{
    /// <summary>
    ///     Class RouletteResponse.
    /// </summary>
    [DataContract]
    public class RouletteResponse
    {
        /// <summary>
        ///     Gets or sets the unit.
        /// </summary>
        /// <value>The unit.</value>
        [DataMember(Name = "unit")]
        public int Unit { get; set; }

        /// <summary>
        ///     Gets or sets the show identifier.
        /// </summary>
        /// <value>The show identifier.</value>
        [DataMember(Name = "show_id")]
        public int ShowId { get; set; }

        /// <summary>
        ///     Gets or sets the show title.
        /// </summary>
        /// <value>The show title.</value>
        [DataMember(Name = "show_title")]
        public string ShowTitle { get; set; }

        /// <summary>
        ///     Gets or sets the release year.
        /// </summary>
        /// <value>The release year.</value>
        [DataMember(Name = "release_year")]
        public string ReleaseYear { get; set; }

        /// <summary>
        ///     Gets or sets the rating.
        /// </summary>
        /// <value>The rating.</value>
        [DataMember(Name = "rating")]
        public string Rating { get; set; }

        /// <summary>
        ///     Gets or sets the category.
        /// </summary>
        /// <value>The category.</value>
        [DataMember(Name = "category")]
        public string Category { get; set; }

        /// <summary>
        ///     Gets or sets the show cast.
        /// </summary>
        /// <value>The show cast.</value>
        [DataMember(Name = "show_cast")]
        public string ShowCast { get; set; }

        /// <summary>
        ///     Gets or sets the director.
        /// </summary>
        /// <value>The director.</value>
        [DataMember(Name = "director")]
        public string Director { get; set; }

        /// <summary>
        ///     Gets or sets the summary.
        /// </summary>
        /// <value>The summary.</value>
        [DataMember(Name = "summary")]
        public string Summary { get; set; }

        /// <summary>
        ///     Gets or sets the poster.
        /// </summary>
        /// <value>The poster.</value>
        [DataMember(Name = "poster")]
        public string Poster { get; set; }

        /// <summary>
        ///     Gets or sets the type of the media.
        /// </summary>
        /// <value>The type of the media.</value>
        [DataMember(Name = "mediatype")]
        public int MediaType { get; set; }

        /// <summary>
        ///     Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        ///     A string that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return new StringBuilder()
                .AppendFormat("Unit = {0}", Unit)
                .AppendLine()
                .AppendFormat("ShowId = {0}", ShowId)
                .AppendLine()
                .AppendFormat("ShowTitle = {0}", ShowTitle)
                .AppendLine()
                .AppendFormat("ReleaseYear = {0}", ReleaseYear)
                .AppendLine()
                .AppendFormat("Rating = {0}", Rating)
                .AppendLine()
                .AppendFormat("Category = {0}", Category)
                .AppendLine()
                .AppendFormat("ShowCast = {0}", ShowCast)
                .AppendLine()
                .AppendFormat("Director = {0}", Director)
                .AppendLine()
                .AppendFormat("Poster = {0}", Poster)
                .AppendLine()
                .AppendFormat("MediaType = {0}", MediaType)
                .AppendLine()
                .ToString();
        }
    }
}
