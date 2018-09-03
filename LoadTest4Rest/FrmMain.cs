using com.Repower.LoadTest4Rest.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.Repower.LoadTest4Rest
{
    public partial class FrmMain : Form
    {



        public FrmMain()
        {
            InitializeComponent();
            JobInfo.Load();
        }
    }
}
