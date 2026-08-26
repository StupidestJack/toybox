using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CookieUI
{
    // 這個文件專門放那種日常必需品
    // 相較於桌面、開始選單、任務欄這些核心功能
    // 這裡的東西就比較像是一些輔助功能了
    class Notepad : BaseApp
    {
        string currentFilePath = null;
        public override Tuple<string, Bitmap> DefaultInfo => new Tuple<string, Bitmap>("記事本", Properties.Resources.Write);
        public Notepad()
        {
            Initialize();
            LoadContent();
        }
        public override void LoadContent()
        {
            // 挖靠AI你幹嘛
            // throw new NotImplementedException();
            this.DefaultSize = new Size(400, 300);

            var tBox = new TextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 12),
                Multiline = true
            };
            this.mainPanel.Controls.Add(tBox);

            var menuStrip = new ContextMenuStrip { Dock = DockStyle.Fill };
            var saveMenu = new ToolStripMenuItem("儲存");
            var saveAsMenu = new ToolStripMenuItem("另存為");
            var openMenu = new ToolStripMenuItem("開啟");
            var fontMenu = new ToolStripMenuItem("字體");

            saveMenu.Click += (s, e) =>
            {
                if (currentFilePath == null)
                {
                    var sfd = new SaveFileDialog();
                    sfd.Filter = "文字文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK) currentFilePath = sfd.FileName;
                    else return;
                }
                File.WriteAllText(currentFilePath, tBox.Text);
            };
            saveAsMenu.Click += (s, e) =>
            {
                var sfd = new SaveFileDialog();
                sfd.Filter = "文字文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK) currentFilePath = sfd.FileName;
                else return;
                File.WriteAllText(currentFilePath, tBox.Text);
            };
            openMenu.Click += (s, e) =>
            {
                var ofd = new OpenFileDialog();
                ofd.Filter = "文字文件 (*.txt)|*.txt|所有文件 (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK) currentFilePath = ofd.FileName;
                else return;
                tBox.Text = File.ReadAllText(currentFilePath);
            };
            fontMenu.Click += (s, e) =>
            {
                var fd = new FontDialog();
                fd.Font = tBox.Font;
                if (fd.ShowDialog() == DialogResult.OK) tBox.Font = fd.Font;
            };

            menuStrip.Items.AddRange(new[] { saveMenu, saveAsMenu, openMenu, fontMenu });
            tBox.ContextMenuStrip = menuStrip;
        }
    }
    class FileManager : BaseApp
    {
        public override Tuple<string, Bitmap> DefaultInfo => new Tuple<string, Bitmap>("檔案總管", Properties.Resources.FileMgr);
        public FileManager()
        {
            Initialize();
            LoadContent();
        }
        public override void LoadContent()
        {
            this.AppName = "檔案總管";
            this.AppIcon = Properties.Resources.FileMgr;
            this.Size = new Size(800, 600);

            var sc = new SplitContainer {Dock = DockStyle.Fill };

            var il = new ImageList { ImageSize = new Size(16, 16) };
            il.Images.Add("fc", Properties.Resources.FolderOff);
            il.Images.Add("fo", Properties.Resources.FolderOpen);
            il.Images.Add("fi", Properties.Resources.File);

            var tree = new TreeView { Dock = DockStyle.Fill, ImageList = il, LabelEdit = true };
            sc.Panel1.Controls.Add(tree);

            var list = new ListView { Dock = DockStyle.Fill, View = View.Details, SmallImageList = il, LabelEdit = true };
            list.Columns.Add("名稱", 300);
            list.Columns.Add("類型", 100);
            list.Columns.Add("大小", 100, HorizontalAlignment.Right);
            sc.Panel2.Controls.Add(list);

            this.mainPanel.Controls.Add(sc);

            tree.Nodes.Add(new TreeNode("我的文件")
            {
                Tag = Path.Combine(Directory.GetCurrentDirectory(), "Documents"),
                ImageIndex = 0,
            });
            var pcNode = new TreeNode("這台電腦") { ImageIndex = 0, Tag = "0:Computer" };
            tree.Nodes.Add(pcNode);

            foreach (var drive in DriveInfo.GetDrives())
            {
                var node = new TreeNode(drive.Name)
                {
                    Tag = drive.RootDirectory.FullName,
                    ImageIndex = 0,
                };
                node.Nodes.Add(new TreeNode("*Notloaded"));
                pcNode.Nodes.Add(node);
            }

            tree.AfterExpand += (s, e) =>
            {

                e.Node.ImageIndex = 1;
                if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Text == "*Notloaded")
                {
                    e.Node.Nodes.Clear();
                    try
                    {
                        foreach (var dir in Directory.GetDirectories((string)e.Node.Tag))
                        {
                            var node = new TreeNode(Path.GetFileName(dir))
                            {
                                Tag = dir,
                                ImageIndex = 0,
                            };
                            node.Nodes.Add(new TreeNode("*Notloaded"));
                            e.Node.Nodes.Add(node);
                        }
                        if (Directory.GetDirectories((string)e.Node.Tag).Count() == 0)
                        {
                            e.Node.Nodes.Add(new TreeNode("*這裡沒有子資料夾喔*"));
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                        e.Node.Nodes.Add(new TreeNode("*沒有權限瀏覽*"));
                    }
                    catch (IOException)
                    {
                        e.Node.Nodes.Add(new TreeNode("*裝置有點問題*"));
                    }
                    catch
                    {
                        e.Node.Nodes.Add(new TreeNode("*反正出錯了pwp*"));
                    }
                }
            };
            tree.AfterCollapse += (s, e) =>
            {
                e.Node.ImageIndex = 0;
                e.Node.Nodes.Clear();
                e.Node.Nodes.Add(new TreeNode("*Notloaded"));
            };
            tree.AfterSelect += (s, e) =>
            {
                
                if ((e.Node.Tag?.ToString() ?? "0:1").StartsWith("0:")) return; // 這台電腦不顯示內容
                list.Items.Clear();
                try
                {
                    foreach (var file in Directory.GetFiles((string)e.Node.Tag))
                    {
                        var item = new ListViewItem(Path.GetFileName(file)) { ImageKey = "fi", Tag = file };
                        item.SubItems.Add("檔案");
                        var info = new FileInfo(file);
                        item.SubItems.Add(info.Length.ToString("N0") + " bytes");
                        list.Items.Add(item);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    list.Items.Add(new ListViewItem("*沒有權限瀏覽*"));
                }
                catch (IOException)
                {
                    list.Items.Add(new ListViewItem("*裝置有點問題*"));
                }
                catch
                {
                    list.Items.Add(new ListViewItem("*反正出錯了pwp*"));
                }
            };
            tree.AfterLabelEdit += (s, e) =>
            {
                if (e.Label == null) return; // 取消編輯
                Directory.Move(Path.Combine((string)e.Node.Parent.Tag, e.Node.Text), Path.Combine((string)e.Node.Parent.Tag, e.Label));
                e.Node.Tag = Path.Combine((string)e.Node.Parent.Tag, e.Label);
            };
            list.DoubleClick += (s, e) =>
            {
                if (list.SelectedItems.Count == 0) return;
                var selected = list.SelectedItems[0];
                var path = Path.Combine((string)tree.SelectedNode.Tag, selected.Text);
                if (File.Exists(path))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true
                    });
                }
            };
            list.AfterLabelEdit += (s, e) =>
            {
                var oldPath = Path.Combine((string)tree.SelectedNode.Tag, list.Items[e.Item].Tag.ToString());
                var newPath = Path.Combine((string)tree.SelectedNode.Tag, e.Label);
                if (File.Exists(oldPath))
                {
                    File.Move(oldPath, newPath);
                }
                else list.Items[e.Item].Text = e.Label; // 如果檔案不存在了就不改名字了
            };
            var ms = new MenuStrip();
            var refreshMenu = new ToolStripMenuItem("重新整理");
            var backMenu = new ToolStripMenuItem("上一層");
            var newMenu = new ToolStripMenuItem("新增");
            var newFolderMenu = new ToolStripMenuItem("資料夾");
            var newTextMenu = new ToolStripMenuItem("文字文件");
            var renameMenu = new ToolStripMenuItem("重新命名");
            var delMenu = new ToolStripMenuItem("刪除");

            refreshMenu.Click += (s, e) =>
            {
                if (tree.SelectedNode == null) return;
                var path = (string)tree.SelectedNode.Tag;
                tree.SelectedNode.Nodes.Clear();
                try
                {
                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        var node = new TreeNode(Path.GetFileName(dir))
                        {
                            Tag = dir,
                            ImageIndex = 0,
                        };
                        node.Nodes.Add(new TreeNode("*Notloaded"));
                        tree.SelectedNode.Nodes.Add(node);
                    }
                    if (Directory.GetDirectories(path).Count() == 0)
                    {
                        tree.SelectedNode.Nodes.Add(new TreeNode("*這裡沒有子資料夾喔*"));
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    tree.SelectedNode.Nodes.Add(new TreeNode("*沒有權限瀏覽*"));
                }
                try
                {
                    list.Items.Clear();
                    foreach (var file in Directory.GetFiles(path))
                    {
                        var item = new ListViewItem(Path.GetFileName(file)) { ImageKey = "fi", Tag = file };
                        item.SubItems.Add("檔案");
                        var info = new FileInfo(file);
                        item.SubItems.Add(info.Length.ToString("N0") + " bytes");
                        list.Items.Add(item);
                    }

                }
                catch (UnauthorizedAccessException)
                {
                    list.Items.Add(new ListViewItem("*沒有權限瀏覽*"));
                }
            };
            backMenu.Click += (s, e) =>
            {
                if (tree.SelectedNode == null) return;
                var parent = tree.SelectedNode.Parent;
                if (parent != null) tree.SelectedNode = parent;
            };
            newFolderMenu.Click += (s, e) =>
            {
                if (tree.SelectedNode == null) return;
                tree.SelectedNode.Nodes.Add(new TreeNode("新資料夾") { Tag = Path.Combine((string)tree.SelectedNode.Tag, "新資料夾"), ImageIndex = 0 });
                Directory.CreateDirectory(Path.Combine((string)tree.SelectedNode.Tag, "新資料夾"));
                tree.SelectedNode.Expand();
                tree.SelectedNode.Nodes[tree.SelectedNode.Nodes.Count - 1].BeginEdit();
            };
            newTextMenu.Click += (s, e) =>
            {
                if (tree.SelectedNode == null) return;
                var newFilePath = Path.Combine((string)tree.SelectedNode.Tag, "新文字文件.txt");
                File.WriteAllText(newFilePath, "");
                var item = new ListViewItem("新文字文件.txt") { ImageKey = "fi", Tag = newFilePath };
                item.SubItems.Add("檔案");
                item.SubItems.Add("0 bytes");
                list.Items.Add(item);
                item.BeginEdit();
            };
            renameMenu.Click += (s, e) =>
            {
                if (list.SelectedItems.Count > 0) list.SelectedItems[0].BeginEdit();
                else if (tree.SelectedNode != null) tree.SelectedNode.BeginEdit();
            };


            ms.Items.Add(refreshMenu);
            ms.Items.Add(newMenu);
            newMenu.DropDownItems.Add(newFolderMenu);
            newMenu.DropDownItems.Add(newTextMenu);
            ms.Items.Add(renameMenu);
            ms.Items.Add(delMenu);

            mainPanel.Controls.Add(ms);
            sc.Size = new Size(mainPanel.Width, mainPanel.Height - ms.Height);
            sc.Location = new Point(0, ms.Height);
        }
    }
}
