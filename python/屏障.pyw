import tkinter as tk
from tkinter import messagebox

class MouseMonitorApp:
    def __init__(self, root):
        self.root = root
        self.root.withdraw()  # 主視窗先隱藏

        # 取得滑鼠位置
        mouse_x = root.winfo_pointerx()
        mouse_y = root.winfo_pointery()
        warning_x = mouse_x + 200
        warning_y = mouse_y + 200

        # 建立警告視窗
        self.warning = tk.Toplevel()
        self.warning.title("警告")
        self.warning.geometry(f"300x100+{warning_x}+{warning_y}")
        self.warning.attributes('-topmost', True)

        label = tk.Label(self.warning, text="/fill 0 0 0 1920 1090 0 barrier", font=("Arial", 16))
        label.pack(expand=True)

        # 建立監控視窗（透明全螢幕）
        self.monitor = tk.Toplevel()
        self.monitor.attributes('-fullscreen', True)
        self.monitor.attributes('-alpha', 0.01)
        self.monitor.attributes('-topmost', True)
        self.monitor.configure(bg='black')
        self.monitor.bind('<Motion>', self.trigger_bsod)
        self.monitor.bind('<Button-1>', self.trigger_bsod)
        self.monitor.bind('<Button-3>', self.trigger_bsod)

        self.image_displayed = False
        self.tk_img = None
        self.label = None


    def trigger_bsod(self, event=None):
        if not self.image_displayed:
            self.image_displayed = True  # 防止重複觸發
            self.warning.destroy()       # 關掉警告視窗
            



if __name__ == "__main__":
    root = tk.Tk()
    app = MouseMonitorApp(root)
    root.mainloop()
