
from tkinter.ttk import Frame, Button,Label,Entry, Style
from tkinter import BOTH,END, messagebox
import sys
from StudentIDDlg import StudentIDDlg
from LoanCalculator import LoanCalculator


class MyFrame(Frame):

 def __init__(self, parent):
     Frame.__init__(self, parent)
     self.parent = parent
     self.LCD = None #Loan calculator object
     self.FBD = None #Feedback Dlg object
     self.initUI()

     4

 def initUI(self):
     self.parent.title("GUI Controls Test")
     self.style = Style()
     self.style.theme_use("default")
     self.pack(fill=BOTH, expand=1)
     #--------------------------------------------

     #--------------------create menus------------
     menuBar = Menu(self.parent)
     mnuFile = Menu(menuBar, tearoff=0)
     menuBar.add_cascade(label="File", menu=mnuFile)
     mnuFile.add_command(label="Open", command=self.mnuOpenFileClick)
     mnuFile.add_command(label="Save", command=self.mnuSaveFileClick)
     mnuFile.add_separator()
     mnuFile.add_command(label="Exit", command=self.exitButtonClick)
     mnuCustomers = Menu(menuBar, tearoff=0)
     menuBar.add_cascade(label="Loan Processing", menu=mnuCustomers)
     mnuCustomers.add_command(label="Loan Calculator", command=self.loanCalcButtonClick)
     mnuCustomers.add_separator()
     mnuCustomers.add_command(label="Provide Feedback",command=self.mnuShowFeedbackClick)
     self.parent.config(menu=menuBar)
     #--------------------------------------------

     xpos = 30
     ypos = 40
     xpos2 = xpos + 90
     #------------styling----------------------------------
     style = Style()
     style.configure("Exit.TButton", foreground="red", background="white")
     style.configure("MainButton.TButton", foreground="yellow", background="red")
     #-----------------------------------------------------

     testButton = Button(self, text="Get StudentID", command=self.btnGetStudentIDClick)
     testButton.configure(style="MainButton.TButton")
     testButton.place(x=xpos, y=ypos)
     self.txtID = Entry(self, text="", foreground = "#ff0000", background = "light blue",font = "Arial 9") # Arial 12 bold italic
     self.txtID.place(x=xpos2, y=ypos)
     self.txtID.configure(state="readonly")

     ypos += 30
     btnLoanCalc = Button(self, text="Loan Calculator",command=self.loanCalcButtonClick)
     btnLoanCalc.configure(style="Exit.TButton")
     btnLoanCalc.place(x=xpos, y=ypos)
     ypos += 30
     exitButton = Button(self, text="Exit", command=self.exitButtonClick)
     exitButton.configure(style="Exit.TButton")
     exitButton.place(x=xpos, y=ypos)

 def exitButtonClick(self):
     if (messagebox.askokcancel("OK to close?","Close application?")):
         self.parent.destroy
         exit() # needed to close the main frame

 def btnGetStudentIDClick(self):
     #show modal dialog and collect student ID
     dlg = StudentIDDlg("your ID", "Student ID?", "Please Enter your Student ID:")
     dlg.grab_set() #events only go to the modal dialog
     self.wait_window(dlg)
     self.txtID.configure(state="normal")
     self.txtID.delete(0,END)
     self.txtID.insert(0,dlg.getID())
     self.txtID.configure(state="readonly")
     print(dlg.getID())


 def loanCalcButtonClick(self):
    if (self.LCD is None) :
        self.LCD = LoanCalculator()
    else:
        if (self.LCD.winfo_exists()):
            self.LCD.focus()
        else:
            self.LCD = LoanCalculator()


 def loanCalcButtonClick(self):
    if (self.LCD is None) :
        self.LCD = LoanCalculator()
    else:
        if (self.LCD.winfo_exists()):
            self.LCD.focus()
        else:
            self.LCD = LoanCalculator()

 def mnuOpenFileClick(self):
     options = opts = {}
     opts['initialdir'] = 'd:\\PythonRM'
     opts['filetypes'] = [('all files', '.*'), ('jpeg files', '.jpg')]
     fname = filedialog.askopenfilename(**options) # file in read mode
     img = misc.imread(fname) # read the image file
     toimage(img).show()

 def mnuSaveFileClick(self):
     print("OK2")

 def mnuShowFeedbackClick(self):
    if (self.FBD is None):
        self.FBD = FeedBackDlg()
    else:
        if (self.FBD.winfo_exists()):
            self.LCD.focus()
        else:
            self.FBD = FeedBackDlg ()
