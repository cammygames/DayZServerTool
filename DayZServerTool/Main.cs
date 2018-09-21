using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Threading;

namespace DayZServerTool
{
    public partial class Main : Form
    {
        private DirectoryInfo _logDir;
        private Process serverProcess;

        public Main()
        {
            InitializeComponent();

            _logDir = new DirectoryInfo($"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\DayZ");

            LoadSettings();
        }

        private void LoadSettings()
        {
            exePath.Text = Properties.Settings.Default.dayZServerExe;
            serverCFG.Text = Properties.Settings.Default.cfgName;
            bePath.Text = Properties.Settings.Default.bePath;
            cpuCount.Text = Properties.Settings.Default.cpuCount;
            serverPort.Text = Properties.Settings.Default.port.ToString();
            modInput.Text = Properties.Settings.Default.mod;

            var bootOptions = Properties.Settings.Default.bootParams.Split(' ');
            foreach (var option in bootOptions)
            {
                switch (option)
                {
                    case "-dologs":
                        dologs.Checked = true;
                        break;
                    case "-adminlog":
                        adminlog.Checked = true;
                        break;
                    case "-netlog":
                        netlog.Checked = true;
                        break;
                    case "-freezecheck":
                        freezecheck.Checked = true;
                        break;
                    case "-noFilePatching":
                        noFilePatching.Checked = true;
                        break;
                }
            }

        }

        private void SaveSettings()
        {
            Properties.Settings.Default.cfgName = serverCFG.Text;
            Properties.Settings.Default.bePath = bePath.Text;
            Properties.Settings.Default.cpuCount = cpuCount.Text;
            Properties.Settings.Default.port = Int32.Parse(serverPort.Text);
            Properties.Settings.Default.mod = modInput.Text;

            string bootParams = "";

            if (dologs.Checked) bootParams += "-dologs ";
            if (adminlog.Checked) bootParams += "-adminlog ";
            if (netlog.Checked) bootParams += "-netlog ";
            if (freezecheck.Checked) bootParams += "-freezecheck ";
            if (noFilePatching.Checked) bootParams += "-noFilePatching ";

            Properties.Settings.Default.bootParams = bootParams;

            Properties.Settings.Default.Save();
        }

        private void StartServer()
        {
            SaveSettings();

            var fullBootArgs =
                $"-port={Properties.Settings.Default.port} -config={Properties.Settings.Default.cfgName} {Properties.Settings.Default.bootParams}";

            if (Properties.Settings.Default.bePath != "")
                fullBootArgs += $" -BEpath={Properties.Settings.Default.bePath}";

            if (Properties.Settings.Default.cpuCount != "")
                fullBootArgs += $" -cpuCount={Properties.Settings.Default.cpuCount}";

            if (Properties.Settings.Default.mod != "")
                fullBootArgs += $" -mod={Properties.Settings.Default.mod}";

            serverProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = Properties.Settings.Default.dayZServerExe,
                    Arguments = fullBootArgs,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            serverProcess.Start();

            ControlPropertyThreadSafe(startServer, "Text", "Stop Server");
        }

        private void changeExeBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "DayZServer|DayZServer_x64.exe";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    exePath.Text = openFileDialog1.FileName;
                    Properties.Settings.Default.dayZServerExe = openFileDialog1.FileName;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void startServer_Click(object sender, EventArgs e)
        {
            
            if (serverProcess != null)
            {
                try
                {
                    serverProcess.Kill();
                } catch {}

                startServer.Text = "Start Server";
                serverProcess = null;
            }
            else
            {
                var serverThread = new Thread(new ThreadStart(StartServer));
                serverThread.Start();
            }

        }

        private void openLogsFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_logDir.FullName);
        }

        private void latestLog_Click(object sender, EventArgs e)
        {
            var logFile = _logDir.GetFiles("DayZServer_x64" + "*.RPT").OrderByDescending(f => f.LastWriteTime).First();

            Process.Start(logFile.FullName);
        }

        private delegate void ControlMethodThreadSafeDelegate( Control control, string propertyName, object propertyValue);

        public static void ControlMethodThreadSafe( Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new ControlMethodThreadSafeDelegate
                        (ControlMethodThreadSafe),
                    new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.InvokeMethod,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }

        private delegate void ControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        public static void ControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new ControlPropertyThreadSafeDelegate
                        (ControlPropertyThreadSafe),
                    new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }
    }
}
