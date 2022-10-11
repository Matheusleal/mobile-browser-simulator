using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowserSimulator.Resources.Models
{
    public class PhoneType
    {
        /// <summary>
        /// Brand referenced
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Model referenced
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Phone, Tablet, etc...
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Real Resolution
        /// </summary>
        public Size Resolution { get; set; } = new();
        /// <summary>
        /// Best to simulate on PC
        /// </summary>
        public Size ViewPort { get; set; } = new();


        public string Header { get => $"{Brand} {Model} - {ViewPortText}"; }
        public string ResolutionText { get => $"{Resolution.Width}x{Resolution.Height}"; }
        public string ViewPortText { get => $"{ViewPort.Width}x{ViewPort.Height}"; }
        public bool IsDefault { get; set; } = false;
    }

    public class Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
