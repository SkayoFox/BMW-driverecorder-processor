using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveRecorderConverter
{
    // Enumeration for the camera selection
    enum CameraSelection: int
    {
        AllCams = 1,
        FrontAndRear = 2,
        OnlyFront = 3
    }

    // Parameters for the processor
    class ProcessorParameter
    {
        // Path of the original recording (and output)
        public string? Path { get; set; }

        // Name of the driver
        public string? DriverName { get; set; }

        // Name of the car
        public string? Car { get; set; }

        // What cameras are included in the recording
        public CameraSelection CameraSelection { get; set; }

        // What information should be included in the output?
        public bool ShowDriverName { get; set; }
        public bool ShowCar { get; set; }
        public bool ShowCameraNames { get; set; }
        public bool ShowLocation { get; set; }
        public bool ShowSpeed { get; set; }
        public bool ShowAccel { get; set; }
        public bool ShowDateTime { get; set; }

        // Interpolation
        public bool EnableInterpolation { get; set; }
        public string? Fps { get; set; }
        public string? InterpolationAlgo { get; set; }

        // MPH Mode
        public bool MphMode { get; set; }

        // Name of the output file, may include wildcards like %file%
        public string? OutputFileName { get; set; }

        // Should the video be splitted?
        public bool SplitVideo { get; set; }

        // Flip rear camera image horizontally
        public bool FlipRearCam { get; set; }

        // Video trimming options
        public bool TrimVideo { get; set; }
        public int TrimFrom {  get; set; }
        public int TrimTo { get; set; }

        // Scaling options
        public bool ScaleVideo { get; set; }
        public int ScaleFactor { get; set; }

    }
}
