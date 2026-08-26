import tkinter as tk
from tkinter import messagebox
from PIL import Image, ImageTk
from PIL.Image import Resampling

class MouseMonitorApp:
    def __init__(self, root):
        self.root = root
        self.root.withdraw()  # 主視窗先隱藏

        # 建立警告視窗
        self.warning = tk.Toplevel()
        self.warning.title("警告")
        self.warning.geometry("300x100")
        self.warning.attributes('-topmost', True)

        label = tk.Label(self.warning, text="別動滑鼠喔...", font=("Arial", 16))
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
            self.monitor.after(500, self.display_image)  # 延遲 0.5 秒顯示圖片

    def display_image(self):
        try:
            img = Image.open("blue.jpg")
            screen_width = self.monitor.winfo_screenwidth()
            screen_height = self.monitor.winfo_screenheight()
            img = img.resize((screen_width, screen_height), Resampling.LANCZOS)
            self.tk_img = ImageTk.PhotoImage(img)

            self.label = tk.Label(self.monitor, image=self.tk_img)
            self.label.place(x=0, y=0, relwidth=1, relheight=1)
            self.monitor.config(cursor="none")
            self.monitor.attributes('-alpha', 1.0)
        except Exception as e:
            print("圖片載入錯誤：", e)

if __name__ == "__main__":
    root = tk.Tk()
    app = MouseMonitorApp(root)
    root.mainloop()
