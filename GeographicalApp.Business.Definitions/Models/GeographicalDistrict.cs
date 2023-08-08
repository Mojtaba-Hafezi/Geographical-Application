using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GeographicalApp.Business.Definitions.Models
{
    public class GeographicalDistrict
    {
        /// <summary>
        /// ID der Bezirk
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Bezirk Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Angabe, ob die Region aktuell ausgewählt ist
        /// </summary>
        public bool IsSelected { get; set; }

        #region ------ BEZIEHUNGEN ------
        public Shape Shape { get; set; }
        #endregion
    }
}
