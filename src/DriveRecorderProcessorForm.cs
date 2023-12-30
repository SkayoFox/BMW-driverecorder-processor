using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace DriveRecorderConverter
{
    public partial class DriveRecorderProcessorForm : Form
    {
        public DriveRecorderProcessorForm()
        {
            InitializeComponent();
        }

        private void PathChooseBtn_Click(object sender, EventArgs e)
        {
            if (PathBox.Text != null && PathBox.Text.Length > 0)
                pathChooseDlg.InitialDirectory = PathBox.Text;

            if (pathChooseDlg.ShowDialog() == DialogResult.OK)
                PathBox.Text = pathChooseDlg.SelectedPath;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ProcessorParameter param = new ProcessorParameter();
            param.Path = PathBox.Text;
            param.Car = CarNameBox.Text;
            param.DriverName = DriverNameBox.Text;

            if (AllCamsRadio.Checked) { param.CameraSelection = CameraSelection.AllCams; }
            if (RearCamRadio.Checked) { param.CameraSelection = CameraSelection.FrontAndRear; }
            if (FrontCamRadio.Checked) { param.CameraSelection = CameraSelection.OnlyFront; }

            param.ShowDriverName = DriverNameCheck.Checked;
            param.ShowCar = CarNameCheck.Checked;
            param.ShowCameraNames = CamNameCheck.Checked;
            param.ShowLocation = LocationCheck.Checked;
            param.ShowSpeed = SpeedCheck.Checked;
            param.ShowAccel = AccelCheck.Checked;
            param.ShowDateTime = DateTimeCheck.Checked;
            param.EnableInterpolation = InterpolateCheck.Checked;
            param.Fps = (string)FpsCombo.SelectedItem;
            param.InterpolationAlgo = (string)InterpolateCombo.SelectedItem;
            param.MphMode = MphModeCheck.Checked;
            param.OutputFileName = outputFileBox.Text;

            param.SplitVideo = SplitCheck.Checked;
            param.FlipRearCam = FlipCheck.Checked;
            param.ScaleVideo = ScaleCheck.Checked;
            param.ScaleFactor = (int)ScaleNum.Value;
            param.TrimVideo = TrimCheck.Checked;
            param.TrimFrom = (int)TrimFromNum.Value;
            param.TrimTo = (int)TrimToNum.Value;

            string settingsJson = JsonSerializer.Serialize(param);
            File.WriteAllText("settings.json", settingsJson);

            if (!checkParams(param)) return;


            StartBtn.Enabled = false;

            List<Processor> processors = new List<Processor>();

            string[] tsFiles = Directory.GetFiles(param.Path, "*.ts");
            if (tsFiles.Length > 0) processors.Add(new Processor(param, param.Path));
            else
            {
                foreach (string dir in Directory.GetDirectories(param.Path))
                {
                    string[] tsFiles2 = Directory.GetFiles(dir, "*.ts");
                    if (tsFiles2.Length > 0) processors.Add(new Processor(param, dir));
                }
            }

            bool allSuccess = true;
            foreach (Processor processor in processors)
            {
                if (!processor.process()) allSuccess = false;
            }

            if (allSuccess)
            {
                // Converter failed or has been aborted
                // Logging isn't working
                string log = "";
                foreach (Processor processor in processors)
                {
                    log += "Directory: " + processor.getDir() + "\n------------------------------------\n";
                    log += processor.getLog();
                }
                File.WriteAllText("log.log", log);
            }
            else
            {
                MessageBox.Show("Processing successful");
            }
            StartBtn.Enabled = true;
        }

        private void DriveRecorderConverterForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("settings.json"))
            {
                FileStream configStream = File.OpenRead("settings.json");
                StreamReader configReader = new StreamReader(configStream);
                string configJson = configReader.ReadToEnd();

                configReader.Close();
                configStream.Close();

                ProcessorParameter param = JsonSerializer.Deserialize<ProcessorParameter>(configJson);

                PathBox.Text = param.Path;

                switch (param.CameraSelection)
                {
                    case CameraSelection.AllCams:
                        AllCamsRadio.Checked = true;
                        break;
                    case CameraSelection.OnlyFront:
                        FrontCamRadio.Checked = true;
                        break;
                    case CameraSelection.FrontAndRear:
                        FrontCamRadio.Checked = true;
                        break;
                }

                CarNameBox.Text = param.Car;
                DriverNameBox.Text = param.DriverName;

                DriverNameCheck.Checked = param.ShowDriverName;
                CarNameCheck.Checked = param.ShowCar;
                CamNameCheck.Checked = param.ShowCameraNames;
                LocationCheck.Checked = param.ShowLocation;
                DateTimeCheck.Checked = param.ShowDateTime;
                SpeedCheck.Checked = param.ShowSpeed;
                AccelCheck.Checked = param.ShowAccel;
                InterpolateCheck.Checked = param.EnableInterpolation;
                SplitCheck.Checked = param.SplitVideo;
                TrimCheck.Checked = param.TrimVideo;
                FlipCheck.Checked = param.FlipRearCam;
                ScaleCheck.Checked = param.ScaleVideo;

                TrimFromNum.Value = param.TrimFrom;
                TrimToNum.Value = param.TrimTo == 0 ? 40 : param.TrimTo;
                ScaleNum.Value = param.ScaleFactor == 0 ? 2 : param.ScaleFactor;

                for (int i = 0; i < InterpolateCombo.Items.Count; i++)
                {
                    if ((string)InterpolateCombo.Items[i] == param.InterpolationAlgo)
                    {
                        InterpolateCombo.SelectedIndex = i;
                        break;
                    }
                }
                if (InterpolateCombo.SelectedIndex == -1) InterpolateCombo.SelectedIndex = 0;
                for (int i = 0; i < FpsCombo.Items.Count; i++)
                {
                    if ((string)FpsCombo.Items[i] == param.Fps)
                    {
                        FpsCombo.SelectedIndex = i;
                        break;
                    }
                }
                if (FpsCombo.SelectedIndex == -1) FpsCombo.SelectedIndex = 0;

                MphModeCheck.Checked = param.MphMode;
                outputFileBox.Text = (param.OutputFileName == null || param.OutputFileName.Length == 0) ? "output.mp4" : param.OutputFileName;
            }
            else
            {
                FpsCombo.SelectedIndex = 0;
                InterpolateCombo.SelectedIndex = 0;
            }
        }

        private void InterpolateCheck_CheckedChanged(object sender, EventArgs e)
        {
            InterpolateCombo.Enabled = InterpolateCheck.Checked;
            FpsCombo.Enabled = InterpolateCheck.Checked;
        }

        private bool checkParams(ProcessorParameter param)
        {
            if (param.Path == null || param.Path.Length == 0)
            {
                MessageBox.Show("Path cannot be empty!");
                return false;
            }
            if (!Directory.Exists(param.Path))
            {
                MessageBox.Show("Path doesn't exist (anymore)");
                return false;
            }
            if (param.OutputFileName == null || param.OutputFileName.Length == 0)
            {
                MessageBox.Show("Output filename cannot be empty!");
                return false;
            }
            return true;
        }

        private void TrimCheck_CheckedChanged(object sender, EventArgs e)
        {
            TrimFromNum.Enabled = TrimCheck.Checked;
            TrimToNum.Enabled = TrimCheck.Checked;
        }

        private void ScaleCheck_CheckedChanged(object sender, EventArgs e)
        {
            ScaleNum.Enabled = ScaleCheck.Checked;
        }
    }
}
