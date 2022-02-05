import pyautogui
from win32api import GetSystemMetrics
import os
#get the width and height of the monitor
width= GetSystemMetrics(0)
height=GetSystemMetrics(1)

#click on the botton left to launch the start menu
print("click on the botton left to launch the start menu")
pyautogui.click(2,1040)
print("Select the SalesMate + Application")
pyautogui.click(10,1040)

pyautogui.typewrite("SalesMate +",1,1)



print("Press Enter Key to Launch SalesMate + Application and Wait for 10 Sec")

pyautogui.press("enter",1,8)
print("Press Enter Key again to close the Tip Of the Day Dialog")
pyautogui.press("enter",1,3)

pyautogui.press("enter")


print("Now alt and f shortcut key in  Salesmate to invoke the File Root menu")
pyautogui.press(['alt','f'],1,2)
print("Now press 'b' to invoke the Bacuup Folder Dialog")
pyautogui.press("b",1,1)
#print("Go to D Drive")

#pyautogui.press("t")
print("Now press Right arrow Key to Expand the Tree")
pyautogui.press("down",9,1)
pyautogui.press("right")
pyautogui.press("down",4,1)
pyautogui.press("enter",2,1)
print("new record")
pyautogui.keyDown('ctrl')
pyautogui.press('n')
pyautogui.keyUp('ctrl')
lis=["143","799", "goodds","123","gur@co","280","9","test1","first","117","572","gooddr","284","gur@co","2550","8","test3","seocnd"]
i=0
while i<16:

    pyautogui.write(lis[i])


    i += 1
    pyautogui.press("enter")


    pyautogui.write(lis[i])
    pyautogui.press("enter", 1, 1)

    i += 1
    pyautogui.write(lis[i])
    i += 1
    pyautogui.press("enter", 1, 1)
    pyautogui.press("down", 6, 1)
    pyautogui.press("enter", 1, 1)
    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis[i])
    i += 1

    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis[i])
    i += 1

    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis[i])
    i += 1
    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis[i])
    i += 1
    pyautogui.press("enter", 1, 1)
    pyautogui.press("enter", 1, 1)


    pyautogui.write(lis[i])
    i += 1
    pyautogui.press("enter", 1, 1)

    pyautogui.write(lis[i])
    i += 1
    pyautogui.press("enter", 1, 1)
    pyautogui.press("enter", 1, 1)


pyautogui.press("right", 1, 1)
pyautogui.press("enter", 1, 1)

pyautogui.keyDown('ctrl')
pyautogui.press("a")

pyautogui.keyUp('ctrl')
print("customer details")

lis2=["32","51","guru2","E","Mr","xyz","123456789","abc@gmail.com","5","5","6","guru5","E","Mr","xyz1","1234567789","abcd@gmail.com","5"]
i=0
while i<10:


    pyautogui.write(lis2[i])

    i += 1
    pyautogui.press("enter")

    pyautogui.write(lis2[i])
    pyautogui.press("enter", 1, 1)

    i += 1
    pyautogui.write(lis2[i])
    i += 1
    pyautogui.press("enter", 1, 1)

    pyautogui.write(lis2[i])
    i += 1

    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis2[i])
    i += 1

    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis2[i])
    i += 1
    pyautogui.press("enter", 1, 1)
    pyautogui.write(lis2[i])
    i += 1
    pyautogui.press("tab", 2, 1)
    pyautogui.write(lis2[i])
    i += 1
    pyautogui.press("tab", 2, 1)

    pyautogui.press("enter", 1, 1)

print("finsh")


