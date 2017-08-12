from tkinter.ttk import Frame, Button,Label,Entry, Style
from tkinter import BOTH,END, messagebox, Menu, filedialog
from tkinter import *
from Equalizer import Equalizer
import cv2


class MyFrame(Frame):
    def __init__(self,parent):
         Frame.__init__(self,parent)
         self.parent = parent
         self.style = Style()
         self.style.theme_use("default")
         self.pack(fill=BOTH, expand=1)
         loadButton = Button(self, text="Load Image" ,background = "light blue", command=self.openFile)
         #okButton.configure(style="ExitButton.TButton") # does not work
         loadButton.place(x=50, y=50)

    def openFile(self):
     options = opts = {}
     opts['initialdir'] = 'd:\\PythonRM'
     opts['filetypes'] = [('all files', '.*'), ('jpeg files', '.jpg')]
     fname = filedialog.askopenfilename(**options) # file in read mode
     image = cv2.imread(fname,0) # read the image file
     cv2.imshow('image',image)
     
     equlalizer =  Equalizer()
     equlalizer.display(image)
    

def main():
     root = Tk()
     root.geometry("700x600")
     root.title("Histogram Equalization")
     app = MyFrame(root)
     root.mainloop()
     

if __name__ == "__main__":
     sys.exit(int(main() or 0))
