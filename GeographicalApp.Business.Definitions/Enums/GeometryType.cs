using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalApp.Business.Definitions.Enums
{
    /// <summary>
    /// Gibt die Type-property von geometry in GeoJSON Datei
    /// </summary>
    public enum GeometryType
    {
        Point,

        MultiPoint,

        LineString,

        MultiLineString,

        Polygon,

        MultiPolygon,

        GeometryCollection
    }
}
