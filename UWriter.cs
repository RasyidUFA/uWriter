//-----------------------------------------------------------------------
// <copyright company="UFASoft Technology">
//     Copyright (c) UFASoft Technology. All rights reserved.
// </copyright>
// <author>Fahmi Rasyid</author>
//-----------------------------------------------------------------------
namespace UWriter.Libs
{
    using System.Xml.Serialization;

    /// <summary>
    /// UWriter Library Class
    /// </summary>
    public class UWriter
    {
        /// <summary>
        ///
        /// </summary>
        [XmlArrayItem(nameof(Chapter), IsNullable = false)]
        public Chapter[] Chapters
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [XmlArrayItem(nameof(Character), IsNullable = false)]
        public Character[] Characters
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [XmlArrayItem(nameof(Item), IsNullable = false)]
        public Item[] Items
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [XmlArrayItem(nameof(Location), IsNullable = false)]
        public Location[] Locations
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        public Project Project
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [XmlArrayItem(nameof(Scene), IsNullable = false)]
        public Scene[] Scenes
        {
            get;
            set;
        }

        /// <summary>
        ///
        /// </summary>
        [XmlArrayItem(nameof(WordCount), IsNullable = false)]
        public WordCount[] WCLog
        {
            get;
            set;
        }

        /// <remarks />
        public sbyte Ver
        {
            get;
            set;
        }
    }
}