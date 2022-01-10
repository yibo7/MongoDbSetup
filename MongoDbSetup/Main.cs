using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using XS.Core.FSO;

namespace MongoDbSetup
{
    public partial class Main : Form
    {
        private string SettingInfo = @"dbpath = #数据位置#
logpath = #日志位置#
";
        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;//使最大化窗口失效
            //下一句用来禁止对窗口大小进行拖拽
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

            txtPort.ReadOnly = true;
        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            pbSetup.Maximum = 100; 
            string sPath = AppDomain.CurrentDomain.BaseDirectory; 
            string sPan = Path.GetPathRoot(sPath);

            //string sPassWord = txtPass.Text.Trim();
            //if (string.IsNullOrEmpty(sPassWord))
            //{
            //    MessageBox.Show("请输入正确的密码！");
            //    return;
            //}

            string sPort = txtPort.Text.Trim();

            if (string.IsNullOrEmpty(sPort) || sPort.Length < 4 || !Tools.IsNumeric(sPort))
            {
                MessageBox.Show("请输入正确的端口,端口为4位到5位的数字！");
                return;
            }

            bool paortUsed = Tools.portInUse(27017);

            if (paortUsed)
            {
                MessageBox.Show($"端口27017已经其他程序占用！");
                return;
            }
             
            string serviceName = "MongoDB";
            if (Tools.CheckService(serviceName))
            {
                MessageBox.Show("已经存在MongoDB服务，要重新安装，请先卸载！");
                return;
            }
           


            string dataPath = $@"{sPath}mongodb\data";
            string logPath = $@"{sPath}mongodb\logs\mongo.log";

            SettingInfo = SettingInfo.Replace("#数据位置#", dataPath).Replace("#日志位置#", logPath);

            string dbSettingFile = string.Concat(sPath, "mongodb\\mongo.conf");

            FObject.WriteFile(dbSettingFile, SettingInfo);
            

            if (FObject.IsExist(dataPath, FsoMethod.Folder))
            {
                MessageBox.Show("mongodb目录已经已经存在data，为了安全起见，请你备份后手动删除此目录再尝试！");
                return;
            }
            if (FObject.IsExist(logPath, FsoMethod.Folder))
            {
                MessageBox.Show("mongodb目录已经已经存在logs，为了安全起见，请你备份后手动删除此目录再尝试！");
                return;
            }
            btnSetup.Enabled = false;
            btnSetup.Text = "开始安装...";
            Thread threadCpuInfo = new Thread(() =>
            {
                Action<int> proce_update = (data) =>
                {
                    pbSetup.Value = data;
                };
                Invoke(proce_update, 20);
                
                
                FObject.Create(dataPath,FsoMethod.Folder);
                FObject.Create(logPath, FsoMethod.File);

                Invoke(proce_update, 40);

                List<string> cmds = new List<string>();

                cmds.Add(string.Format("cd {0}", sPan));
                cmds.Add(string.Format(@"cd {0}mongodb\bin", sPath));
                //string realPath = dbSettingFile.Replace("\\\\", "\\");
                cmds.Add($"mongod --config={dbSettingFile} --install --serviceName 'MongoDB'");

               bool isruned = Tools.RunCmd(cmds);
                if (isruned)
                {
                    Invoke(proce_update, 80);
                    Tools.RunCmd("net start MongoDB");
                    isruned = Tools.RunCmd(cmds);
                    if (isruned)
                    {
                        Invoke(proce_update, 100);
                        MessageBox.Show("安装完成!");
                        Action<int> action = (data) =>
                        {
                            btnSetup.Enabled = true;
                            btnSetup.Text = "开始安装";
                        };
                        Invoke(action, 1);
                    }
                }


            });


            threadCpuInfo.Start();

             

            
        }

        private void lb_del_mysql_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool isok = Tools.ConfirmDialog("确定要删除MongoDB的服务吗！");
            if (isok)
            {
                lb_del_mysql.Enabled = false;
                Thread threadCpuInfo2 = new Thread(() =>
                {

                    bool isRuned = Tools.RunCmd("net stop MongoDB");
                    if (isRuned)
                    {
                        isRuned = Tools.RunCmd("SC Delete 'MongoDB'");
                        if (isRuned)
                        {
                            Action<int> action = (data) =>
                            {
                                lb_del_mysql.Enabled = true;
                                lb_del_mysql.Text = "MongoDB已经删除";
                            };
                            Invoke(action, 1);
                        }
                        else
                        {
                            MessageBox.Show("旧服务删除失败");
                        }


                    }


                });

                threadCpuInfo2.Start();
            }
        }
    }
}
