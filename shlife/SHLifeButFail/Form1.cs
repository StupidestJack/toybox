using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLifeButFail
{
    public partial class Form1 : Form
    {
        Account a;
        ChatRoomMember m;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (var db = new SHLife_ANMEntities())
            {
                var A = db.Account.FirstOrDefault(x => x.Email == toolStripTextBox1.Text && x.Password == toolStripTextBox2.Text);
                if (A == null) return;
                a = A;
            }
            toolStripButton2_Click(null,null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            listBox1.Items.Clear();
            using (var db = new SHLife_ANMEntities())
            {
                var r = db.ChatRoomMember.Where(x => x.AccountId == a.AccountId).ToList();
                foreach (var item in r)
                {
                    var cr = db.ChatRoom.FirstOrDefault(x => x.ChatRoomId == item.ChatRoomId);
                    if (cr != null)
                    {
                        listBox1.Items.Add(new sb { Name = cr.Name, id = cr.ChatRoomId});
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as sb;
            listBox2.Items.Clear();
            using (var db = new SHLife_ANMEntities())
            {
                var r = db.ChatRoomRecord.Where(x => x.ChatRoomId == item.id).ToList();
                m = db.ChatRoomMember.FirstOrDefault(x => x.AccountId == a.AccountId && x.ChatRoomId == item.id);
                foreach (var i in r)
                {
                    listBox2.Items.Add($"[{i.ChatRoomMember}|{i.UpdateDateTime}]{i.Message}");
                }
            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem as sb;
            listBox2.Items.Clear();
            using (var db = new SHLife_ANMEntities())
            {
                var r = db.ChatRoomRecord.Where(x => x.ChatRoomId == item.id).ToList();
                m = db.ChatRoomMember.FirstOrDefault(x => x.AccountId == a.AccountId && x.ChatRoomId == item.id);
                foreach (var i in r)
                {
                    var mm = db.ChatRoomMember.FirstOrDefault(x => x.ChatRoomMemberId == i.ChatRoomMemberId);
                    var name = mm?.Account?.Nickname ?? "Unknown";
                    listBox2.Items.Add($"[{name}|{i.UpdateDateTime ?? DateTimeOffset.MinValue:g}]{i.Message}");
                }
            }
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new SHLife_ANMEntities())
            {
                var r = new ChatRoomRecord
                {
                    ChatRoomRecordId = Guid.NewGuid(),
                    ChatRoomId = m.ChatRoomId,
                    ChatRoomMemberId = m.ChatRoomMemberId,
                    Message = textBox1.Text,
                    UpdateDateTime = DateTime.Now
                };
                db.ChatRoomRecord.Add(r);
                db.SaveChanges();
            }
        }
    }
    class sb
    {
        public string Name { get; set; }
        public Guid id { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
