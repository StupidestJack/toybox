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

namespace SHLife
{
    public partial class Chat : Form
    {
        string[][] libs =
        {
            Properties.Resources.广告.Split('\n'),
            Properties.Resources.网址.Split('\n'),
            Properties.Resources.色情类.Split('\n'),
            Properties.Resources.政治类.Split('\n'),
            Properties.Resources.涉枪涉爆.Split('\n'),
        };
        string[] libnames =
        {
            "广告",
            "网址",
            "色情类",
            "政治类",
            "涉枪涉爆"
        };
        ChatRoom room;
        ChatRoomMember member;
        public Account account;
        DateTimeOffset lru = DateTimeOffset.MinValue;
        DateTimeOffset lmu = DateTimeOffset.MinValue;
        public Chat()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = "系統時間：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            using (var db = new Entity())
            {
                if (room != null) {
                    var rec = db.ChatRoomRecords.Where(x => x.ChatRoomId == room.ChatRoomId).OrderBy(x => x.CreateDateTime).ToList();
                    if (rec.Count > 0 )
                    {
                        if (lmu != rec.Last().CreateDateTime)
                        {
                            lmu = rec.Last().CreateDateTime;
                            mf.Controls.Clear();
                            mf.Controls.Add(new Label { Text = $"目前的聊天對象是：{room.Name}", AutoSize = true});
                            foreach (var r in rec)
                            {
                                var vos = db.ChatReviewTasks
                                    .Where(x => x.ChatRoomRecordId == r.ChatRoomRecordId)
                                    .Select(x => x.ReviewStatus)
                                    .ToList()
                                    .Contains(2);
                                var l = new Label
                                {
                                    Text = $"[{r.CreateDateTime:HH:mm}]{(vos ? "" : r.Message)}",
                                    ForeColor = vos ? Color.Red : Color.Black,
                                    AutoSize = true,
                                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                                    TextAlign = r.ChatRoomMemberId == member.ChatRoomMemberId ?
                                        ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft,
                                };
                                l.AutoSize = false;
                                l.Size = new Size(mf.Width, l.Height);
                                mf.Controls.Add(l);
                            }
                        }
                    }
                }
                await Task.Delay(100);
                var mems = db.ChatRoomMembers.Where(x => x.AccountId == account.AccountId);
                var memsguid = mems.Select(x => x.ChatRoomId);
                var rooms = db.ChatRooms
                    .Where(x => memsguid.Contains(x.ChatRoomId))
                    .OrderByDescending(x => x.UpdateDateTime);
                if ((rooms.First().UpdateDateTime ?? DateTimeOffset.MaxValue) != lru)
                {
                clf.Controls.Clear();
                    lru = rooms.First().UpdateDateTime ?? DateTimeOffset.MaxValue;
                    foreach (var r in rooms)
                    {
                        var pnl = new Panel
                        {
                            Size = new Size(200, 50),
                            Padding = new Padding(0, 0, 0, 0),
                            Margin = new Padding(0, 0, 0, 0),
                            BorderStyle = BorderStyle.FixedSingle,
                        };
                        var n = new Label
                        {
                            Text = r.Name,
                            Dock = DockStyle.Top,
                            TextAlign = ContentAlignment.TopLeft
                        };
                        var udtt = r.UpdateDateTime.HasValue ? r.UpdateDateTime.Value.ToString("M/dd HH:mm") : "空的聊天室";
                        var t = new Label
                        {
                            Text = udtt,
                            Dock = DockStyle.Bottom,
                            TextAlign = ContentAlignment.BottomRight
                        };

                        var m = mems.FirstOrDefault(x => x.ChatRoomId == r.ChatRoomId);
                        pnl.Click += (s, E) =>
                        {
                            room = r;
                            member = m;
                            lmu = DateTimeOffset.MinValue;
                        };
                        n.Click += (s, E) =>
                        {
                            room = r;
                            member = m;
                            lmu = DateTimeOffset.MinValue;
                        };
                        t.Click += (s, E) =>
                        {
                            room = r;
                            member = m;
                            lmu = DateTimeOffset.MinValue;
                        };
                        pnl.Controls.Add(n);
                        pnl.Controls.Add(t);
                        clf.Controls.Add(pnl);
                    }
                }
            }
        }

        private void snd_Click(object sender, EventArgs e)
        {
            using (var d = new Entity())
            {

                // 依舊前凸後翹程式碼
                var g = Guid.NewGuid();
                d.ChatRoomRecords.Add(new ChatRoomRecord
                {
                    Message = mt.Text,
                    ChatRoomId = room.ChatRoomId,
                    ChatRoomMemberId = member.ChatRoomMemberId,
                    CreateDateTime = DateTime.Now,
                    UpdateDateTime = DateTime.Now,
                    ChatRoomRecordId = g,
                });
                d.ChatRooms
                    .FirstOrDefault(r => r.ChatRoomId == room.ChatRoomId)
                    .UpdateDateTime = DateTime.Now;
                for (var i = 0;i < 5;i++)
                {
                    foreach (var r in libs[i])
                    {
                        if (mt.Text.Contains(r))
                        {
                            d.ChatReviewTasks.Add(
                                new ChatReviewTask
                                {
                                    ReviewId = Guid.NewGuid(),
                                    ChatRoomRecordId = g,
                                    DetectedKeyword = r,
                                    ReviewStatus = 0,
                                    CreateDateTime = DateTime.Now,
                                    New_KeywordType = libnames[i],
                                }
                            );
                        }
                    }
                }
                d.SaveChanges();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        // 避免null但是很暴力
        private void Chat_Load(object sender, EventArgs e)
        {
            while (account == null) ;
            ml.Text = account.Email;
            nl.Text = account.Nickname;
        }
    }
}
