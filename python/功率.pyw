import pyautogui
from PIL import Image, ImageTk
import tkinter as tk
import os

# 截圖並轉灰階
screenshot = pyautogui.screenshot()
gray_image = screenshot.convert('L').convert('RGB')

# 建立主視窗（全螢幕背景）
root = tk.Tk()
root.attributes('-fullscreen', True)
root.configure(bg='black')

# 顯示灰階背景
tk_image = ImageTk.PhotoImage(gray_image)
canvas = tk.Canvas(root, width=gray_image.width, height=gray_image.height)
canvas.pack()
canvas.create_image(0, 0, anchor='nw', image=tk_image)

# 建立仿 XP 關機視窗
shutdown_window = tk.Toplevel(root)
shutdown_window.title("Windows 功率選項") #改了
shutdown_window.geometry("300x220+770+430")
shutdown_window.configure(bg='#0827F5') #改了
shutdown_window.resizable(False, False)
shutdown_window.attributes('-topmost', True)
shutdown_window.overrideredirect(True) #這句是額外加的
# 禁用右上角的 X
shutdown_window.protocol("WM_DELETE_WINDOW", lambda: None)

label = tk.Label(shutdown_window, text="關閉此電腦", font=("Arial", 14), bg='#0827F5') #改了
label.pack(pady=20)

# 功能按鈕（不使用 confirm）
def shutdown():
    os.system("shutdown /s /t 0")

def restart():
    os.system("shutdown /r /t 0")

def cancel():
    shutdown_window.destroy()
    root.destroy()

btn_shutdown = tk.Button(shutdown_window, text="關機", width=15, command=shutdown)
btn_restart = tk.Button(shutdown_window, text="重新啟動", width=15, command=restart)
btn_cancel = tk.Button(shutdown_window, text="取消", width=15, command=cancel)

btn_shutdown.pack(pady=5)
btn_restart.pack(pady=5)
btn_cancel.pack(pady=5)

root.mainloop()
