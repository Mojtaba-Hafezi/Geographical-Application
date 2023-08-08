using GeographicalApp.Business.Definitions.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalApp.Business.Definitions.Models
{
    /// <summary>
    /// Koordinaten
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// ID der Koordinaten
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Koordinaten als JSON-Array
        /// </summary>
        public string Coordinates { get; set; }

        /// <summary>
        /// Type-property von geometry-property 
        /// </summary>
        public GeometryType Type { get; set; }

        #region ------ BEZIEHUNGEN ------

        public GeographicalDistrict GeographicalDistrict { get; set; }
        public int GeographicalDistrict_Id { get; set; }
        #endregion
    }
}
