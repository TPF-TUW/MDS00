using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;

namespace MDS00
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
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
        private IniFile iniConfig;

        private void RunProcess(string processName)
        {
            if (lstProcess.Any(x => x.ProcessName == processName))
            {
                MessageBox.Show(accordionControlElement15.Tag.ToString() + " is running.");
            }
            else 
            {
                Process p = Process.Start(processName + ".exe");
                p.WaitForInputIdle();
                SetParent(p.MainWindowHandle, panelControl1.Handle);
                panelControl1.SizeChanged += Panel1_Resize;
                ShowWindow(p.MainWindowHandle, SW_MAXIMIZE);
                lstProcess.Add(p);
            }
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
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            iniConfig = new IniFile("Config.ini");
        }
    }
}