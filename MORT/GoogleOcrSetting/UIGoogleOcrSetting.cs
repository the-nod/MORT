﻿using MORT.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MORT.GoogleOcrSetting
{
    public partial class UIGoogleOcrSetting : Form
    {
        public UIGoogleOcrSetting()
        {
            InitializeComponent();
        }

        private void Init()
        {
            lbJson.Text = OcrManager.GoogleJsonPath;
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openPanel = new OpenFileDialog();
            openPanel.RestoreDirectory = false;
            openPanel.InitialDirectory = System.Environment.CurrentDirectory;
            openPanel.Filter = "Json File (*.json)|*.json";


            string file = "";
            if (openPanel.ShowDialog() == DialogResult.OK)
            {
                file = openPanel.FileName;
                lbJson.Text = file;

                OcrManager.Instace.SetGoogleOcrJsonPath(file);
            }
        }

        private void UIGoogleOcrSetting_Load(object sender, EventArgs e)
        {
            Init();
        }
    }
}
