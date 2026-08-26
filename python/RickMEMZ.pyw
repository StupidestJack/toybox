import tkinter as tk
from tkinter import messagebox
import webbrowser
import os
import subprocess

# 指定網址
url = "https://www.youtube.com/watch?v=dQw4w9WgXcQ"

# 記事本路徑與內容
note_path = r"note.txt"
note_content = """Your computer has been rickrolled by fake MEMZ Trojan. 
So your computer can boot up again.
MEMZ isn't real executed, trust it! :D 
"""

def show_second_popup():
    result2 = messagebox.askyesno(
        "MEMZ",
        "THIS PROGRAM IS STILL A VIRUS!\n"
        "It will cause permanent, IRREVERSIBLE damage to your computer!\n"
        "You have been warned.\n\n"
        "Do you REALLY want to execute it?"
    )
    if result2:
        # 建立目錄（如果不存在）
        # 寫入記事本
        with open(note_path, "w") as f:
            f.write(note_content)
        # 打開記事本
        try:
            subprocess.Popen(["notepad.exe", note_path])
        except:
            subprocess.Popen(["xdg-open", note_path])
        # 打開網址
        webbrowser.open(url)

def show_first_popup():
    result1 = messagebox.askyesno(
        "MEMZ",
        "THIS PROGRAM IS A VIRUS!\n"
        "It will harm your computer and make it unusable!\n"
        "ONLY run this in a virtual machine!\n\n"
        "Do you really want to execute it?"
    )
    if result1:
        show_second_popup()

# 建立主視窗（隱藏）
root = tk.Tk()
root.withdraw()
show_first_popup()
