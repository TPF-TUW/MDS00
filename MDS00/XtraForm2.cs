using System;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using DevExpress.XtraBars.Navigation;

namespace MDS00
{
    public partial class XtraForm2 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm2()
        {
            InitializeComponent();
        }
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);


        private void RunProcess(string processName)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(typeof(SplashScreen1));
            var aryProcess = Process.GetProcesses();
            if (aryProcess.Any(x=>x.ProcessName==processName))
            {
                MessageBox.Show(processName + " is running.");
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
                return;
            }
            else
            {
                
                Process p = Process.Start(processName + ".exe");
                SetForegroundWindow(p.MainWindowHandle);
                ShowWindow(p.MainWindowHandle,SW_MAXIMIZE);
                
            }
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm();
        }

        private void aceM01_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM02_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM03_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM04_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM05_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM06_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM07_Click(object sender, EventArgs e)
        {
            
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void aceM08_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM09_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM10_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM11_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM12_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM13_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM14_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceM15_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceDEV01_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceDEV02_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceDEV03_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceF01_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceF02_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceF03_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceF04_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void aceF05_Click(object sender, EventArgs e)
        {
            var obj = sender as AccordionControlElement;
            try
            {
                RunProcess(obj.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}