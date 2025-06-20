﻿using MDD4All.SVG.DataModels.Extensions;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    public class ForeignObject : SvgElement
    {
        [XmlAttribute("x")]
        public string X { get; set; }

        [XmlAttribute("y")]
        public string Y { get; set; }

        [XmlAttribute("width")]
        public string Width { get; set; }

        [XmlAttribute("height")]
        public string Height { get; set; }

        
    }
}
