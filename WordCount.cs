//-----------------------------------------------------------------------
// <copyright company="UFASoft Technology">
//     Copyright (c) UFASoft Technology. All rights reserved.
// </copyright>
// <author>Fahmi Rasyid</author>
//-----------------------------------------------------------------------
using System;
using System.Xml.Serialization;

public class WordCount
{
    /// <remarks/>
    [XmlElement(DataType = "date")]
    public System.DateTime Date { get; set; }

    /// <remarks/>
    public short Count { get; set; }

    /// <remarks/>
    public short TotalCount { get; set; }
}