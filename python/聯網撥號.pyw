import tkinter as tk
import os
from tkinter import ttk
from tkinter import messagebox
import time

# 宣告變數在全域作用域中
progress = None
root2 = None
username = ""
password = ""

def loading():
    global progress, root2, username, password
    progress["value"] += 1
    if progress["value"] >= 20:
        if username != "114514" or password != "1919810":
            messagebox.showerror("無法登入", "帳號或密碼錯誤！")
            root2.destroy()
        elif progress["value"] >= 100:
            messagebox.showinfo("登入成功", "歡迎使用")
            os.system('sudo run netsh interface set interface "Wi-Fi" enable') 
            #我開啟了Sudo for Windows，此代碼看上去錯誤，但Sudo for Windows是使用sudo run沒錯
            #此程式碼在老版本系統或未啟用Sudo for Windows的狀況下會出錯
            root2.destroy()
    root2.after(50, loading)  # 正確使用 after

def login():
    global progress, root2, username, password
    username = ur.get()
    password = pw.get()

    # 關掉登入畫面
    root.destroy()

    # 開啟新畫面
    root2 = tk.Tk()
    root2.title("登入中...")
    root2.geometry("340x100")

    tk.Label(root2, text="正在登入...", font=("Arial", 12)).pack(pady=10)
    progress = ttk.Progressbar(root2, orient="horizontal", length=300, mode="determinate", maximum=100)
    progress.pack(pady=10)

    root2.after(50, loading)  # 啟動 loading
    root2.mainloop()

# 主畫面
root = tk.Tk()
root.title("寬頻連線")
root.geometry("340x200")

tk.Label(root, text="帳號：", font=("Arial", 12)).grid(row=0, column=0, padx=10, pady=10, sticky="e")
ur = tk.Entry(root, width=25)
ur.grid(row=0, column=1, padx=10, pady=10)

tk.Label(root, text="密碼：", font=("Arial", 12)).grid(row=1, column=0, padx=10, pady=10, sticky="e")
pw = tk.Entry(root, width=25, show="*")
pw.grid(row=1, column=1, padx=10, pady=10)

tk.Button(root, text="登入", width=15, command=login).grid(row=2, column=1, pady=15)

root.mainloop()
