import time

time.sleep(3)

# 計時開始
start = time.time()
duration = 114.514

while True:
    elapsed = time.time() - start
    remain = duration - elapsed
    if remain <= 0:
        break
    print(f"\n剩下時間：{remain:.3f} 秒",end="")
    #c("cls")

print("結束！")

