//-----------------------------------------------------------------------
// <copyright company="UFASoft Technology">
//     Copyright (c) UFASoft Technology. All rights reserved.
// </copyright>
// <author>Fahmi Rasyid</author>
//-----------------------------------------------------------------------
using System;
using System.Xml.Serialization;

public class ProjectDeadline
{
    /// <remarks/>
    [XmlElement(DataType = "date")]
    public DateTime DueDate { get; set; }

    /// <remarks/>
    [XmlElement(DataType = "date")]
    public DateTime StartDate { get; set; }
}