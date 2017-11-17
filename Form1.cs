using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace NeverIdle
{
    public partial class Form1 : Form
    {
        // From:
        // http://stackoverflow.com/questions/6302185/how-to-prevent-windows-from-entering-idle-state

        [DllImport("kernel32.dll")]
        public static extern uint SetThreadExecutionState(uint esFlags);
        public const uint ES_CONTINUOUS = 0x80000000;
        public const uint ES_SYSTEM_REQUIRED =  0x00000001;
        public const uint ES_DISPLAY_REQUIRED = 0x00000002;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetThreadExecutionState(
                ES_CONTINUOUS |
                ES_SYSTEM_REQUIRED |
                ES_DISPLAY_REQUIRED);
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            // Wait until recording is complete...
            // Clear EXECUTION_STATE flags to disable away mode and allow the system
            // to idle to sleep normally.
            SetThreadExecutionState(ES_CONTINUOUS);
        }
    }
}
