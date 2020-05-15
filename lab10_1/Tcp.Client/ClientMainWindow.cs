using System;
using System.Windows.Forms;
using SomeProject.Library.Client;
using SomeProject.Library;

namespace SomeProject.TcpClient
{
    public partial class ClientMainWindow : Form
    {
        public ClientMainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Вызов отпращика сообщений на сервер
        /// </summary>
        private void OnMsgBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();
            var res = client.SendMessageToServer(textBox.Text);
            if(res.Result == Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = res.Message;
            }
            else
            {
                labelRes.Text = res.Message;
            }
            timer.Interval = 3000;
            timer.Start();
        }
        /// <summary>
        /// Очистка labelRes
        /// </summary>
        private void OnTimerTick(object sender, EventArgs e)
        {
            labelRes.Text = "";
            timer.Stop();
        }
        /// <summary>
        /// Вызов отпращика файлов на сервер
        /// </summary>
        private void OnFileBtnClick(object sender, EventArgs e)
        {
            Client client = new Client();
            OpenFileDialog d = new OpenFileDialog();
            d.ShowDialog();
            string fName = d.FileName;
            var res = client.SendFileToServer(fName);
            if (res.Result== Result.OK)
            {
                textBox.Text = "";
                labelRes.Text = res.Message;
            }
            else
            {
                labelRes.Text += res.Message;
            }
            timer.Interval = 3000;
            timer.Start();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
