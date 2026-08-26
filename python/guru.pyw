import tkinter as tk

def exit_app(event):
    root.destroy()  # 點左鍵退出

root = tk.Tk()
root.title("Guru Meditation")
root.geometry("1920x1080")
root.attributes('-fullscreen', True)
root.configure(bg="#000000")
root.overrideredirect(True)
root.config(cursor="none")

label = tk.Label(
    root, 
    text="Software Failure. Press left mouse button to continue.\nGuru Meditation #23333333,00039CAT", 
    font=("Lucida Console", 25), 
    fg="red", 
    bg="black"
)
label.pack(expand=True)

# 綁定滑鼠左鍵事件
root.bind("<Button-1>", exit_app)

root.mainloop()
