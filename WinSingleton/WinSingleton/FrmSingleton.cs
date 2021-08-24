using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSingleton
{
    public partial class FrmSingleton : Form
    {
        static int instanceCounter = 0;
        private static FrmSingleton _instance = null;
        private static readonly object _verrou = new object();
        public static FrmSingleton Instance;
        //{
        //    get
        //    {
        //        lock (_verrou)
        //        {
        //            if (_instance == null)
        //            {
        //                instanceCounter += 1;
        //                _instance = new FrmSingleton();
        //            }
        //        }
        //        return _instance;
        //    }
        //}

        private FrmSingleton()
        {
            InitializeComponent();
            button1.Text = instanceCounter.ToString();
        }
        public static FrmSingleton GetInstance()
        {
            lock (_verrou)
            {
                    if (_instance == null || _instance.IsDisposed)
                    {
                        instanceCounter += 1;
                        _instance = new FrmSingleton();
                        
                    }
                return _instance;
            }
        }


    }
}
