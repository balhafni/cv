import sys
from tkinter import *
from MyFrame import MyFrame

def main():
     root = Tk()
     root.geometry("700x600")
     app = MyFrame(root)
     root.mainloop()

if __name__ == "__main__":
     sys.exit(int(main() or 0))