from tkinter import *
from tkinter.ttk import Frame, Button,Label,Entry, Style
from tkinter import BOTH,END, messagebox
import sys


class FeedBackDlg(Toplevel):

 def __init__(self):
     Toplevel.__init__(self)
     self.initUI()



 def initUI(self):
     self.title("Feedback..")
     self.geometry("600x400")
     self.style = Style()
     self.style.theme_use("default") # default
     xpos = 40
     ypos = 30
     xpos2 = xpos+100
     l1 = Label(self, text="First Name", foreground = "#ff0000", background = "light blue", font = "Arial 9") # Arial 12 bold italic
     l1.place(x=xpos, y=ypos)
     self.txtFirstName = Entry(self)
     self.txtFirstName.place(x=xpos2, y = ypos, width=70)

     ypos += 30
     l2 = Label(self, text="Email", foreground = "#ff0000", background = "light blue", font = "Arial 9") # Arial 12 bold italic
     l2.place(x=xpos, y=ypos)
     self.txtEmail = Entry(self)
     self.txtEmail.place(x=xpos2, y = ypos)     ypos += 30
     l3 = Label(self, text="Your interest in type of our products:", foreground ="#ff0000", background = "light blue", font = "Arial 9") # Arial 12 bold italic
     l3.place(x=xpos, y=ypos)

     ypos += 30
     self.electronicsChoice = BooleanVar()
     self.electronicsChoice.set(True)
     self.chkElectronics = Checkbutton(self, text="Electronics", variable=self.electronicsChoice)     self.chkElectronics.place(x=xpos2, y = ypos)

     self.sportsChoice = BooleanVar()
     self.chkSports = Checkbutton(self, text="Sports", variable=self.sportsChoice)
     self.chkSports.place(x=xpos2+80, y = ypos)     self.gardeningChoice = StringVar()
     self.gardeningChoice.set("YES")
     self.chkGardening = Checkbutton(self, text="Gardening", variable=self.gardeningChoice,onvalue="YES", offvalue="NO")     self.chkGardening.place(x=xpos2+160, y = ypos)     #----------radio buttons---------------
     serviceChoices = [("Disappointed", "0"),("Satisfied", "1"),("Good",
    "2"),("Excellent", "3")]
     self.serviceFeedback = StringVar()
     self.serviceFeedback.set("2") # initial value
     inc = 0
     for text, val in serviceChoices:
        radBtn = Radiobutton(self, text=text, variable=self.serviceFeedback,value=val)
     radBtn.place(x = xpos2 + inc, y = ypos)
     inc += 100     ypos += 30
     #--------listbox-----------
     states = [("Connecticut", "0"),("New York", "1"),("New Jersey","2"),("Massachussetts", "3")]
     self.lb = Listbox(self,selectmode=EXTENDED, height=len(states))
     self.lb.place(x=xpos2,y = ypos)
     self.lb.delete(0, END) # clear
     for key,val in states:
        self.lb.insert(END, key)
     self.data = val     #---------------------------
     ypos += 80
     #--------drop down listbox-----------
     #departments = [("Sales","100"),("Marketing","200"), ("HR","300"),("Technology","300")]
     departments = ["Sales","Marketing", "HR","Technology"]
     self.dept = StringVar()
     self.dept.set("HR") # initial value
     #self.ddlDept = OptionMenu(self, self.dept,*(dict(departments).keys()))
     self.ddlDept = OptionMenu(self, self.dept,*departments)
     self.ddlDept.place(x=xpos2,y = ypos)
     #---------------------------     ypos += 30 * (len(states)-1)
     style = Style()
     style.configure("Exit.TButton", foreground="red", background="white")
     #T.Checkbutton for checboxes
     style.configure("MainButton.TButton", foreground="yellow", background="red")

     btnSubmit = Button(self, text="Submit", command=self.btnSubmitClick)
     btnSubmit.configure(style="MainButton.TButton")
     btnSubmit.place(x=xpos2, y=ypos) def exitButtonClick(self):
         if (messagebox.askokcancel("OK to close?","Close aapplication?")):
            self.parent.destroy
            exit() # needed to close the main frame def btnSubmitClick(self):
     print("electronics = " + str(self.electronicsChoice.get()) +
     " sports=" + str(self.sportsChoice.get()) + " gardening=" + str(self.gardeningChoice.get()))
     print("service feedback = " + str(self.serviceFeedback.get()))
     print("state = " + str(self.lb.curselection()[0]))
     print("department = " + self.dept.get())