using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHLife.UC
{
    public partial class Main_Chat : UserControl
    {
        public Main_Chat()
        {
            InitializeComponent();
        }

        private void Main_Chat_Load(object sender, EventArgs e)
        {
            namelbl.Text = Program.A.Nickname;
            maillbl.Text = Program.A.Email;
        }

        private void loutbtn_Click(object sender, EventArgs e)
        {
            Program.A = null;
            Program.M.ChgScr(new Main_Login(), "登入");
            MessageBox.Show("已成功將您登出");
        }
        DateTimeOffset lastcrupdate = DateTimeOffset.MinValue;
        DateTimeOffset lastmupdate = DateTimeOffset.MinValue;
        ChatRoom room;
        ChatRoomMember member;

        private void timer1_Tick(object sender, EventArgs e)
        {
            using (var db = new Entity())
            {
                var members = db
                    .ChatRoomMembers
                    .Where(x => x.AccountId == Program.A.AccountId)
                    .Select(x => x.ChatRoomId)
                    .ToArray();
                var cr = db.ChatRooms
                    .Where(x => members.Contains(x.ChatRoomId))
                    .OrderByDescending(x => x.UpdateDateTime)
                    .ToArray();
                if ((cr.First().UpdateDateTime ?? DateTimeOffset.MaxValue) != lastcrupdate)
                {
                    lastcrupdate = (cr.First().UpdateDateTime ?? DateTimeOffset.MaxValue);
                    clflp.Controls.Clear();
                    foreach (var i in cr)
                    {
                        var m = db.ChatRoomMembers.FirstOrDefault(x =>
                            x.ChatRoomId == i.ChatRoomId &&
                            x.AccountId == Program.A.AccountId
                        );
                        var pnl = new Panel
                        {
                            Size = new Size(154, 50),
                            BorderStyle = BorderStyle.FixedSingle,
                            Margin = new Padding(0)
                        };
                        var n = new Label
                        {
                            Text = i.Name,
                            TextAlign = ContentAlignment.TopLeft,
                            Dock = DockStyle.Top
                        };
                        var t = new Label
                        {
                            Text = i.UpdateDateTime.HasValue ? 
                            i.UpdateDateTime.Value.ToString("M/dd H:mm") : "(空的聊天室)",
                            TextAlign = ContentAlignment.TopRight,
                            Dock = DockStyle.Bottom
                        };
                        pnl.Click += (s, ee) => {
                            room = i;
                            member = m;
                        };
                        n.Click += (s, ee) => {
                            room = i;
                            member = m;
                        };
                        t.Click += (s, ee) => {
                            room = i;
                            member = m;
                        };
                        pnl.Controls.Add(n);
                        pnl.Controls.Add(t);
                        clflp.Controls.Add(pnl);
                    };
                }

                if (room != null) {
                    var msg = db.ChatRoomRecords
                        .Where(x => x.ChatRoomId == room.ChatRoomId)
                        .OrderByDescending(x => x.CreateDateTime)
                        .ToArray();
                    if (msg.Length == 0)
                    {
                        mlflp.Controls.Clear();
                        var l = new Label
                        {
                            Text = $"目前的聊天室是:{room.Name}"
                        };
                        mlflp.Controls.Add(l);
                    }
                    else if (msg.Length > 0 && lastmupdate != msg.First().CreateDateTime)
                    {
                        mlflp.Controls.Clear();
                        lastmupdate = msg.First().CreateDateTime;
                        var lllll = new Label
                        {
                            Text = $"目前的聊天室是:{room.Name}"
                        };
                        mlflp.Controls.Add(lllll);
                        foreach (var x in msg) {
                            bool vol = db.New_ChatReviewTask
                                .Where(b => b.New_ChatRoomRecordId == x.ChatRoomRecordId)
                                .Select(b => b.New_ReviewStatus)
                                .ToList()
                                .Contains(2);
                            var l = new Label
                            {
                                Text = vol
                                ? $"[{x.CreateDateTime:HH:ss}] 內容違反平台規範，內容不予顯示。"
                                : $"[{x.CreateDateTime:HH:ss}] {x.Message}",
                                ForeColor = vol
                                ? Color.Red
                                : SystemColors.WindowText,
                                Font = new Font("Arial", 9, vol ? FontStyle.Italic : FontStyle.Regular),
                                AutoSize = true,
                                TextAlign = x.ChatRoomMemberId == member.ChatRoomMemberId ?
                                ContentAlignment.TopRight :
                                ContentAlignment.TopLeft 
                            };
                            l.AutoSize = false;
                            l.Size = new Size(mlflp.Width, l.Height);
                            mlflp.Controls.Add(l);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (msgTb.Text.Trim() == "") return;
            using (var db = new Entity())
            {
                var crrid = Guid.NewGuid();
                db.ChatRoomRecords.Add(new ChatRoomRecord
                {
                    ChatRoomRecordId = crrid,
                    ChatRoomId = room.ChatRoomId,
                    ChatRoomMemberId = member.ChatRoomMemberId,
                    Message = msgTb.Text.Trim(),
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                });
                foreach (var w in Program.w)
                {
                    foreach (var r in w.Value)
                    {
                        if (msgTb.Text.Trim().Contains(r))
                        {
                            db.New_ChatReviewTask.Add(new New_ChatReviewTask
                            {
                                New_ChatRoomRecordId = crrid,
                                New_CreateDateTime = DateTime.Now,
                                New_DetectedKeyword = r,
                                New_ReviewId = Guid.NewGuid(),
                                New_ReviewStatus = 0
                            });
                        }
                    }
                }
                db.ChatRooms.FirstOrDefault(x => x.ChatRoomId == room.ChatRoomId).UpdateDateTime = DateTime.Now;
                db.SaveChanges();
            }
        }
    }
}
