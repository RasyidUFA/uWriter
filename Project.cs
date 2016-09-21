//-----------------------------------------------------------------------
// <copyright company="UFASoft Technology">
//     Copyright (c) UFASoft Technology. All rights reserved.
// </copyright>
// <author>Fahmi Rasyid</author>
//-----------------------------------------------------------------------

namespace UWriter.Libs
{
    using System.Xml.Serialization;

    public class Project
    {

        /// <remarks/>
        public string Title
        {
            get;
            set;
        }

        /// <remarks/>
        public string Description
        {
            get;
            set;
        }

        /// <remarks/>
        public string AuthorName
        {
            get;
            set;
        }

        /// <remarks/>
        public string AuthorBio
        {
            get;
            set;
        }

        /// <remarks/>
        public string FieldTitle1
        {
            get;
            set;
        }

        /// <remarks/>
        public string FieldTitle2
        {
            get;
            set;
        }

        /// <remarks/>
        public string FieldTitle3
        {
            get;
            set;
        }

        /// <remarks/>
        public string FieldTitle4
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte WordTarget
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte WordCountStart
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public System.DateTime WordTargetStartDate
        {
            get;
            set;
        }

        /// <remarks/>
        [XmlElement(DataType = "date")]
        public System.DateTime WordTargetEndDate
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte EndFrontMatterChID
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte EndMiddleChID
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte EndBeginningChID
        {
            get;
            set;
        }

        /// <remarks/>
        public sbyte LastViewedScID
        {
            get;
            set;
        }

        /// <remarks/>
        public ProjectDeadline[] Deadlines
        {
            get;
            set;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
        public ProjectNote[] Notes
        {
            get;
            set;
        }

        /// <remarks/>
        public ProjectVariable[] Variables
        {
            get;
            set;
        }
    }
}