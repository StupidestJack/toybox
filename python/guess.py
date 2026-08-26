#剩餘5秒
import random

guess = random.randrange(1,100)
while True:
  a=input("enter:")
  try:
    a = int(a)
    if a < guess: print("太小")
    elif a > guess:print("太大")
    elif a == guess:
      print("對了")
      break
  except:
    print("err")
input()
