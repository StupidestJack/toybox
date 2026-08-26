using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastestSHLife
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        class w
        {
            public string s;
            public Guid g;
            public override string ToString()
            {
                return s;
            }
        }
        w s;

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            using (var d = new a())
            {
                var a = d.ChatRoomMember.Where(x => x.AccountId == Program.a.AccountId).Select(x => x.ChatRoomId);
                var b = d.ChatRoom.Where(x => a.Contains(x.ChatRoomId));
                foreach (var q in b)
                {
                    listBox1.Items.Add(new w { s = q.Name, g = q.ChatRoomId});
                }
                //if (s == null) return;
                //var c = d.ChatRoomRecord.Where(x => x.ChatRoomId == s.g);
                //foreach (var q in c)
                //{
                //    listBox2.Items.Add(q.Message);
                //}
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var d = new a()) {
                var m = d.ChatRoomMember.Where(x => x.AccountId == Program.a.AccountId).FirstOrDefault(x => x.ChatRoomId == s.g);
                d.ChatRoomRecord.Add(new ChatRoomRecord
                {
                    ChatRoomRecordId = Guid.NewGuid(),
                    ChatRoomId = s.g,
                    ChatRoomMemberId = m.ChatRoomMemberId,
                    Message = textBox1.Text,
                    CreateDateTime = DateTimeOffset.Now,
                    UpdateDateTime = DateTimeOffset.Now,
                });
                d.SaveChanges();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s = (w)(listBox1.SelectedItem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var d = new a()) {
                if (s == null) return;
                listBox2.Items.Clear();
                var c = d.ChatRoomRecord.Where(x => x.ChatRoomId == s.g);
                foreach (var q in c)
                {
                    listBox2.Items.Add(q.Message);
                }
            }
        }
    }
}
