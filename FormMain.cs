using GetOrderInfo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;

using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetOrderInfo
{
    public partial class FormMain : Form
    {
        public FormBarCode formBar;
        private class Order
        {
            public string data_type;
            public string state;
            public string wmscode;
            public string grpcode;

            public Order(string s1, string s2, string s3, string s4)
            {
                data_type = s1;
                state = s2;
                wmscode = s3;
                grpcode = s4;
            }
            public Order(string[] str)
            {
                data_type = str[0];
                state = str[1];
                wmscode = str[2];
                grpcode = str[3];
            }
        }


        List<Order> orders;
        List<Komplekt> komplekt;
        string tokenId;
        string tLogin;
        string tPass;
        string orderData;
        string strGetOrder;
        string AddrIP = "10.10.10.4";
        string strGetId;





        public FormMain()
        {
            InitializeComponent();
            Text = "GetOrderInfo by(c)Kandakov Dmitry   v" +  Application.ProductVersion;
            tokenId = statusStripMain.Items[1].Text = Properties.Settings.Default.TokenId;
            tLogin = textLogin.Text = Properties.Settings.Default.Login;
            tPass = textPassword.Text = Properties.Settings.Default.Password;
            
            this.Height = Properties.Settings.Default.WinHeight;
            Location = new Point(Properties.Settings.Default.WinX, Properties.Settings.Default.WinY);
            orders = new List<Order>();
            if (Properties.Settings.Default.ConnetcionLocal == "локальный") {
                strGetId = WebHTTP.getStrId("10.10.10.4");
                strGetOrder = WebHTTP.getStrOrder("10.10.10.4");
                remoteToolStripMenuItem.Checked = true;

            }
            else { 
                strGetId = WebHTTP.getStrId("109.73.38.93:61079");
                strGetOrder = WebHTTP.getStrOrder("109.73.38.93:61079");
                editGETRequset.Text = strGetOrder;
                
                localToolStripMenuItem.Checked = true;
            }
            editGETRequset.Text = strGetOrder;
            toolStripDropDownButton1.Text = Properties.Settings.Default.ConnetcionLocal;
        }



        private void SetFilterOnList(string filter)
        {
            ListViewItem l;
            listView1.Items.Clear();
                
            foreach (Order ord in orders)
            {
                if (filter != ord.state) {
                    l = new ListViewItem();
                    l.SubItems.Add(ord.data_type);
                    l.SubItems.Add(ord.state);
                    l.SubItems.Add(ord.wmscode);
                    l.SubItems.Add(ord.grpcode);
                    listView1.Items.Add(l);
                }
            }
            listView1.Refresh();
            

        }

        private void GeiTokenId(object sender)
        {
            string subs;

            string json = "{\r\n\"login\":\"" + tLogin + "\",\r\n\"password\":\"" + tPass + "\"\r\n}";
            string line;

            var httpRequest = (HttpWebRequest)WebRequest.Create(strGetId);
            httpRequest.Method = "POST";
            httpRequest.ContentType = "application/json";
            using (var requestStream = httpRequest.GetRequestStream())
            using (var writer = new StreamWriter(requestStream))
            {
                writer.Write(json);
            }
            WebResponse httpResponse;
            //using (var httpResponse = httpRequest.GetResponse())
            try
            {
                httpResponse = httpRequest.GetResponse();
            }
            catch
            {
                MessageBox.Show("Пользователь/пароль не верны!", "Внимание", MessageBoxButtons.OK);
                return;

            }

            using (var responseStream = httpResponse.GetResponseStream())
            using (var reader = new StreamReader(responseStream))
            {
                line = reader.ReadToEnd();
                //Console.WriteLine(line);
            }

            int start = line.IndexOf("\"id\":");

            subs = line.Substring(start, 50);
            tokenId = subs.Substring(6, subs.IndexOf(",") - 7);

            statusStripMain.Items[1].Text = tokenId;
            Properties.Settings.Default.TokenId = tokenId;
            Properties.Settings.Default.Save();
        }


        private void SendGETRequest(object sender)
        {

            if (cbOrderId.FindString(cbOrderId.Text) == -1)
                cbOrderId.Items.Add(cbOrderId.Text);

            editGETRequset.Text = strGetOrder + cbOrderId.Text + "?access-token=" + tokenId;
            listView1.Items.Clear();
            ListViewItem l = new ListViewItem();
            WebRequest request;

            try
            {
                request = WebRequest.Create(editGETRequset.Text);
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        orderData = reader.ReadToEnd();
                        Console.WriteLine(orderData);
                    }
                }
                response.Close();
            }
            catch (WebException webExcp)
            {
                string excp = webExcp.Message;
                // ДОБАВИТЬ АВТОЗАПРОС ТОКЕНА, ЕСЛИ ОН ПРОСРОЧЕН
                if (excp.Contains("(401)"))
                    MessageBox.Show("Ошибка авторизации!", "Внимание!", MessageBoxButtons.OK);
                    
                if (excp.Contains("(400)"))
                    MessageBox.Show("Неверный код!", "Внимание!", MessageBoxButtons.OK);
                return;
            }


            var obj = JsonConvert.DeserializeObject<Object>(orderData);
            string ss;

            ss = orderData.Substring(1);
            ss = ss.Substring(0,ss.Length-1);


            
            

            int len = orderData.Length;
            int start = orderData.IndexOf("[");
            string[] words = orderData.Split(new char[] { ',' });
            orders.Clear();

            words[0] = words[0].Remove(0, 2);
            words[words.Length - 1] = words[words.Length - 1].Substring(0, words[words.Length - 1].Length - 2);
            string pattern = @"[""\{\}]";
            if (words.Length <2 )
            {
                MessageBox.Show("Заказ не взят в работу!", "Внимание", MessageBoxButtons.OK);
                return;

            }
            foreach (string strs in words)
            {
                string[] strings = strs.Split(new char[] { ':' });

                strings[0] = Regex.Replace(strings[0], pattern, "");
                strings[1] = Regex.Replace(strings[1], pattern, "");
                if (strings[0] == "state")
                    if (strings[1] == "1")
                        strings[1] = "да";//Regex.Replace(strings[1], pattern, "");
                    else
                        strings[1] = "нет";//Regex.Replace(strings[1], pattern, "");*/
                else
                    if (strings[1] == "null")
                        strings[1] = "отсутствует";
                else
                    if (strings[1] == "pallet")
                        strings[1] = "паллета";
                    else
                        if (strings[1] == "pallet_full")
                            strings[1] = "монопаллета";
                if (strings[1] == "korob")
                    strings[1] = "короб";

                l.SubItems.Add(strings[1]);
                if (strings[0] == "grpcode")
                {

                    listView1.Items.Add(l);
                    orders.Add(new Order(l.SubItems[1].Text, l.SubItems[2].Text, l.SubItems[3].Text, l.SubItems[4].Text));
                    l = new ListViewItem();
                }
            }
            lRecCount.Text = listView1.Items.Count.ToString();
            //statusStripMain.Items[4].Text = listView1.Items.Count.ToString();
        }
        private void buttonSendGETRequest_Click(object sender, EventArgs e)
        {
            cbOnlyBad.Checked = false;
            tabControl1.SelectedIndex = 0;

            SendGETRequest(sender);
        }



        private void bSaveLogPass_Click(object sender, EventArgs e)
        {
            if (bSaveLogPass.Text == "Сохранить")
            {
                Properties.Settings.Default.Login = tLogin = textLogin.Text;
                Properties.Settings.Default.Password = tPass = textPassword.Text;
                Properties.Settings.Default.Save();
                textLogin.Enabled = false;
                textPassword.Enabled = false;
                bSaveLogPass.Text = "Изменить";
                GeiTokenId(this);
            }
            else
            {
                textLogin.Enabled = true;
                textPassword.Enabled = true;
                bSaveLogPass.Text = "Сохранить";
            }
        }




        private void tsslTokenId_Click(object sender, EventArgs e)
        {
            GeiTokenId(this);
        }


        

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string s;

            Point mousePosition = listView1.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listView1.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
            s = listView1.FocusedItem.SubItems[columnindex].Text;
            Clipboard.SetText(s);           
        }



        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                cmenuCopy2Clpbrd.Show(listView1,e.X - 40,e.Y - 10);
            }
        }

        private void cbOrderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Return)
            {
                SendGETRequest(sender);
                cbOrderId.SelectAll();
            }
        }

        private void копироватьСеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "\tID: " + cbOrderId.Text + "\r\n";
            output += "\tтип\tзакрыт\twmscode\tgrpcode\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                    output += listView1.Items[i].SubItems[j].Text + "\t";
                output += "\r\n";
            }
            Clipboard.SetText(output);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Properties.Settings.Default.WinHeight = this.Height;
            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.WinX = Location.X;
            Properties.Settings.Default.WinY = Location.Y;
            Properties.Settings.Default.Save();
        }

        private void cbOnlyBad_CheckedChanged(object sender, EventArgs e)
        {
            CheckFilter();
            lRecCount.Text = listView1.Items.Count.ToString();
           // statusStripMain.Items[4].Text = listView1.Items.Count.ToString();
        }

        private void CheckFilter()
        {
            if (!cbOnlyBad.Checked)
                SetFilterOnList("");
            else
                SetFilterOnList("да");
        }

        private void remoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!remoteToolStripMenuItem.Checked)
            {
                strGetId = WebHTTP.getStrId("10.10.10.4");
                strGetOrder = WebHTTP.getStrOrder("10.10.10.4");
                editGETRequset.Text = strGetOrder;
                localToolStripMenuItem.Checked = false;
                remoteToolStripMenuItem.Checked = true;
                toolStripDropDownButton1.Text = "локальный";
                Properties.Settings.Default.ConnetcionLocal = "локальный";
                Properties.Settings.Default.Save();
            }
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!localToolStripMenuItem.Checked)
            {
                strGetId = WebHTTP.getStrId("109.73.38.93:61079");
                strGetOrder = WebHTTP.getStrOrder("109.73.38.93:61079");
                editGETRequset.Text = strGetOrder;
                localToolStripMenuItem.Checked = true;
                remoteToolStripMenuItem.Checked = false;
                toolStripDropDownButton1.Text = "удаленный";
                Properties.Settings.Default.ConnetcionLocal = "удаленный";
                Properties.Settings.Default.Save();
            }

        }

        private void copySelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "\tID: " + cbOrderId.Text + "\r\n";
            output += "\tтип\tзакрыт\twmscode\t\t\tgrpcode\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                        output += listView1.Items[i].SubItems[j].Text + "\t";
                    output += "\r\n";
                }
            
            }
            Clipboard.SetText(output);
        }

        private void copyNoClosedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "\tID: " + cbOrderId.Text + "\r\n";
            output += "\tтип\tзакрыт\twmscode\t\t\tgrpcode\r\n";
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[2].Text == "нет")
                {
                    for (int j = 0; j < listView1.Items[i].SubItems.Count; j++)
                        output += listView1.Items[i].SubItems[j].Text + "\t";
                    output += "\r\n";
                }

            }
            Clipboard.SetText(output);
        }

        private void shkFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string s;

            Point mousePosition = listView1.PointToClient(Control.MousePosition);
            ListViewHitTestInfo hit = listView1.HitTest(mousePosition);
            int columnindex = hit.Item.SubItems.IndexOf(hit.SubItem);
            s = listView1.FocusedItem.SubItems[columnindex].Text;
            Clipboard.SetText(s);

            formBar = new FormBarCode(s);
            formBar.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            gridInfo.DataSource = null;
            labelProcess.Visible = true;
            gridInfo.Refresh();
            tabControl1.Refresh();
            string str = WebHTTP.getStrInfoBox(AddrIP, @"/api/tss/assembly-order/" + cbOrderId.Text + @"/get-cases?access-token=" + tokenId);
            editGETRequset.Text = str;
            str = WebHTTP.SendGet(str);
            List<InfoLevelBox> ilb = JsonConvert.DeserializeObject<List<InfoLevelBox>>(str);
            List<InfoLevelBoxDetail> ilb_det = new List<InfoLevelBoxDetail>();

            foreach (InfoLevelBox item in ilb)
                foreach(string s in item.childes)
                {
                    ilb_det.Add(new InfoLevelBoxDetail(item.id, item.data_type, item.grpcode, item.wmscode, s, item.childes.Count));
                }
                    

            gridInfo.DataSource = ilb_det;
            gridInfo.Refresh();
            labelProcess.Visible = false;

            PalCount.Text = gridView1.RowCount.ToString();// GetChildRowCount.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}




