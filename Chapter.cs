//-----------------------------------------------------------------------
// <copyright company="UFASoft Technology">
//     Copyright (c) UFASoft Technology. All rights reserved.
// </copyright>
// <author>Fahmi Rasyid</author>
//-----------------------------------------------------------------------
namespace UWriter.Libs
{
    using System.Xml.Serialization;

    public partial class Chapter
    {
        /// <remarks/>
        public sbyte ID
        {
            get;
            set;
        }

        /// <remarks/>
        public string Title
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte SortOrder
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte Type
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte SectionStart
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlArrayItem(nameof(ID), IsNullable = false)]
        public sbyte[] ScenesID
        {
            get;
            set;
        }
    }
}