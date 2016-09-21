//-----------------------------------------------------------------------
// <copyright company="UFASoft Technology">
//     Copyright (c) UFASoft Technology. All rights reserved.
// </copyright>
// <author>Fahmi Rasyid</author>
//-----------------------------------------------------------------------

namespace UWriter.Libs
{
    using System.Xml.Serialization;

    public class Scene
    {
        /// <remarks/>
        public sbyte ID { get; set; }

        /// <remarks/>
        public string Title { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public string ImageFile { get; set; }

        /// <remarks/>
        public string Notes { get; set; }

        /// <remarks/>
        public string Outcome { get; set; }

        /// <remarks/>
        public string Goal { get; set; }

        /// <remarks/>
        public string Conflict { get; set; }

        /// <remarks/>
        public string LinkFile { get; set; }

        /// <remarks/>
        public sbyte Day { get; set; }

        /// <remarks/>
        public sbyte Field1 { get; set; }

        /// <remarks/>
        public sbyte Field2 { get; set; }

        /// <remarks/>
        public sbyte Field3 { get; set; }

        /// <remarks/>
        public sbyte Field4 { get; set; }

        /// <remarks/>
        public sbyte Status { get; set; }

        /// <remarks/>
        public short WordCount { get; set; }

        /// <remarks/>
        public short LetterCount { get; set; }

        /// <remarks/>
        [XmlArrayItem(nameof(ID), IsNullable = false)]
        public sbyte[] CharactersID { get; set; }

        /// <remarks/>
        [XmlArrayItem(nameof(ID), IsNullable = false)]
        public sbyte[] LocationsID { get; set; }

        /// <remarks/>
        [XmlArrayItem(nameof(ID), IsNullable = false)]
        public sbyte[] ItemsID { get; set; }
    }
}