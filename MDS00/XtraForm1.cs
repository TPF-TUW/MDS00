using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace MDS00
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
            iniConfig = new IniFile("Config.ini");
            lstProcess = new List<Process>();
            var t=iniConfig.Read("SkinName", "DevExpress");
            UserLookAndFeel.Default.SetSkinStyle(iniConfig.Read("SkinName", "DevExpress"), iniConfig.Read("SkinPalette", "DevExpress"));
        }
        private const int SW_MAXIMIZE = 3;
        private const int SW_MINIMIZE = 6;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        private List<Process> lstProcess;
        private Process[] aryProcess;
        private IniFile iniConfig;

        private void RunProcess(string processName)
        {
            aryProcess = Process.GetProcesses();//เก็บ process ที่รันอยู่ทั้งหมด

            foreach (var item in aryProcess)
            {
                if (processName == item.ProcessName)
                {
                    MessageBox.Show(processName + " is running.");
                    return;
                }
            }
            Process p = Process.Start(processName + ".exe");
            IntPtr hwndP = IntPtr.Zero;
            while (hwndP == IntPtr.Zero)
            {
                p.WaitForInputIdle(1000);//wait for the window to be ready for input;
                p.Refresh();//update process info
                if (p.HasExited) return;//abort if the process finished before we got a handle.
                hwndP = p.MainWindowHandle;//cache the window handle
            }
            SetParent(p.MainWindowHandle, panelControl1.Handle);
            panelControl1.SizeChanged += Panel1_Resize;
            ShowWindow(p.MainWindowHandle, SW_MAXIMIZE);
            lstProcess.Add(p);
            UserLookAndFeel.Default.SetSkinStyle(iniConfig.Read("SkinName", "DevExpress"),iniConfig.Read("SkinPalette","DevExpress"));
        }

        private void Panel1_Resize(object sender, EventArgs e)
        {
            //Change the docked windows size to match its parent's size. 
            foreach (var item in lstProcess)
            {
                MoveWindow(item.MainWindowHandle, 0, 0, panelControl1.Width, panelControl1.Height, true);
            }
        }
        private void accordionControlElement15_Click(object sender, EventArgs e)
        {
            try
            {
                RunProcess(accordionControlElement15.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void accordionControlElement16_Click(object sender, EventArgs e)
        {
            try
            {
                RunProcess(accordionControlElement16.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void accordionControlElement17_Click(object sender, EventArgs e)
        {
            try
            {
                RunProcess(accordionControlElement17.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            try
            {
                RunProcess(accordionControlElement11.Tag.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}