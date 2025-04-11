/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using MDD4All.SVG.DataModels.Extensions;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace MDD4All.SVG.DataModels
{
    [XmlType(typeName: "g")]
    public class Group : SvgElement
    {
        
        public Group()
        {
            //Groups = new List<Group>();
            //Rectangles = new List<Rectangle>();
            //Circles = new List<Circle>();
            //Polylines = new List<Polyline>();
            //Paths = new List<Path>();
            //Texts = new List<Text>();
            //Lines = new List<Line>();
        }

        [XmlAttribute("id")]
        public string ID { get; set; } = null;

        //[XmlAttribute("class")]
        //public string Class { get; set; } = null;

        [XmlElement("g", typeof(Group)),
         XmlElement("rect", typeof(Rectangle)),
         XmlElement("circle", typeof (Circle)),
         XmlElement("ellipse", typeof(Ellipse)),
         XmlElement("polyline", typeof(Polyline)),
         XmlElement("path", typeof(Path)),
         XmlElement("text", typeof(Text)),
         XmlElement("line", typeof(Line))]
        public List<PresentationElement> Elements { get; set; } = new List<PresentationElement>();

        //[XmlElement("g")]
        //public List<Group> Groups { get; set; }

        //[XmlElement("rect")]
        //public List<Rectangle> Rectangles { get; set; }

        //[XmlElement("circle")]
        //public List<Circle> Circles { get; set; }

        //[XmlElement("ellipse")]
        //public List<Ellipse> Ellipses { get; set; } = new List<Ellipse>();

        //[XmlElement("polyline")]
        //public List<Polyline> Polylines { get; set; }

        //[XmlElement("path")]
        //public List<Path> Paths { get; set; }

        //[XmlElement("text")]
        //public List<Text> Texts { get; set; }

        //[XmlElement("line")]
        //public List<Line> Lines { get; set; }

    }
}
