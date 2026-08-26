import tkinter as tk
from tkinter import messagebox
import os
import sys
import pygame


def stop_sleep():
    sound_type = radio_var.get()
    file_map = {
        "0": "national_alarm.mp3",
        "1": "iphone.mp3",
        "2": "exploding.mp3"
    }
    sound_file = os.path.join('sound', file_map[sound_type])
    try:
        pygame.mixer.init()
        pygame.mixer.music.load(sound_file)
        pygame.mixer.music.play()

    except Exception as e:
        messagebox.showerror("音效播放失敗", str(e))

    
root = tk.Tk()
root.title("禁止睡覺")
root.geometry("350x250")


lucky = 0

# 按鈕
button = tk.Button(root, text="禁止睡覺", font=("Arial", 32), command=stop_sleep)
button.pack(pady=5)

label = tk.Label(root, text="請選擇音效：", font=("Arial", 12))
label.pack(pady=5)

radio_var = tk.StringVar(value="2")
radio1 = tk.Radiobutton(root, text="國家級警報", variable=radio_var, value="0")
radio2 = tk.Radiobutton(root, text="iPhone雷達", variable=radio_var, value="1")
radio3 = tk.Radiobutton(root, text="炸彈爆炸", variable=radio_var, value="2")
radio1.pack()
radio2.pack()
radio3.pack()
messagebox.showinfo("注意", "此程式包含部分大聲音效，請其餘同學及老師摀住耳朵或戴上耳塞。")
root.mainloop()


