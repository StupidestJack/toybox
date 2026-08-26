import tkinter as tk
from tkinter import messagebox
import pygame
import os

def nuclear():
    sound_file = os.path.join('sound', 'exploding.mp3')
    try:
        pygame.mixer.init()
        pygame.mixer.music.load(sound_file)
        pygame.mixer.music.play()

    except Exception as e:
        messagebox.showerror("音效播放失敗", str(e))
    

root = tk.Tk()
root.title("原子彈引爆器")
root.geometry("250x300")

# 標題
label = tk.Label(root, text="請確認以下狀態：", font=("Arial", 12))
label.pack(pady=5)

# 每個核對項目都需使用獨立變數
rdp_var = tk.BooleanVar()
rdp = tk.Checkbutton(root, text="確認遠端桌面連線正常", variable=rdp_var)
rdp.pack(pady=5)

rsound_var = tk.BooleanVar()
rsound = tk.Checkbutton(root, text="確認目的地音響正常　", variable=rsound_var)
rsound.pack(pady=5)

check_parent_var = tk.BooleanVar()
check_parent = tk.Checkbutton(root, text="確認目的地無人　　　", variable=check_parent_var)
check_parent.pack(pady=5)

check_python_var = tk.BooleanVar()
check_python = tk.Checkbutton(root, text="確認電路接線正常　　", variable=check_python_var)
check_python.pack(pady=5)

ready_shoot_var = tk.BooleanVar()
ready_shoot = tk.Checkbutton(root, text="確認老爸媽目前在家　", variable=ready_shoot_var)
ready_shoot.pack(pady=5)

# 引爆按鈕（預設隱藏）
button = tk.Button(root, text="引爆", font=("Arial", 28), command=nuclear)

def check_bomb():
    # 所有條件都為 True 才顯示按鈕
    if all([rdp_var.get(), rsound_var.get(), check_parent_var.get(), check_python_var.get(), ready_shoot_var.get()]):
        if not button.winfo_ismapped():
            button.pack(pady=15)
    else:
        if button.winfo_ismapped():
            button.pack_forget()
    root.after(200, check_bomb)

root.after(200, check_bomb)

root.mainloop()
