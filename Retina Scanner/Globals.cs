using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Retina_Scanner
{
    class Globals
    {
        public bool eyefound;
        public bool eyedrawn;

        public string selectedProfile;

        public Bitmap currImg;
        public Bitmap currImgCropped;
        public double currConfidence;
        public int currConfidenceAbove75;
        public List<string> dataFileNames = new List<string>();
        public List<float[]> dataFiles = new List<float[]>();
    }
}
