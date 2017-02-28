

from tkinter.ttk import Frame, Button,Label,Entry, Style
from tkinter import BOTH,END, messagebox
import sys


class MyFrame(Frame):
   def __init__(self, parent):
      Frame.__init__(self,parent)
      self.parent = parent 
      self.initUI()


   

   def initUI(self):
        self.parent.title("Loan Calculator")
        self.style = Style()
        self.style.theme_use("default")
        self.pack(fill = BOTH, expand = 1)
        xpos = 40
        ypos = 30
        xpos2 = xpos + 100
        l1 = Label(self,text = "Amount",foreground = "#ff0000",background = "light blue" , font = "Arial 9")
        l1.place(x = xpos , y =ypos)
        self.txtAmount = Entry()
        self.txtAmount.place(x = xpos2, y = ypos, width = 70)
        ypos +=30
        l2 = Label(self, text = "Rate(%)",foreground = "#ff0000", background = "light blue", font = "Arial 9")
        l2.place(x = xpos, y = ypos)
        self.txtRate = Entry()
        self.txtRate.place(x = xpos2, y = ypos)
        ypos +=30
        l3 = Label(self, text="Duration(months)", foreground = "#ff0000", background = "light blue", font = "Arial 9") 
        l3.place(x=xpos, y=ypos)
        self.txtDuration = Entry()
        self.txtDuration.place(x=xpos2, y = ypos)
        ypos += 30
        l4 = Label(self, text="Monthly Payment", foreground = "#ff0000", background ="yellow", font = "Arial 9") 
        l4.place(x=xpos, y=ypos)
        self.txtMonthlyPayment = Entry()
        self.txtMonthlyPayment.configure(state="readonly")
        self.txtMonthlyPayment.place(x=xpos2, y = ypos)
        ypos += 30
        l5 = Label(self, text="Total Payments", foreground = "#ff0000", background = "yellow",font = "Arial 9") # Arial 12 bold italic
        l5.place(x=xpos, y=ypos)
        self.txtTotalPayment = Entry();
        self.txtTotalPayment.configure(state="readonly")
        self.txtTotalPayment.place(x=xpos2, y = ypos)
        ypos += 30
        style = Style()
        style.configure("Exit.TButton", foreground="red", background="white")
        style.configure("MainButton.TButton", foreground="yellow", background="red")
        exitButton = Button(self, text="Exit", command=self.exitButtonClick)
        exitButton.configure(style="Exit.TButton")
        exitButton.place(x=xpos, y=ypos)
        calcButton = Button(self, text="Calculate", command=self.calcButtonClick)
        calcButton.configure(style="MainButton.TButton")
        calcButton.place(x=xpos2, y=ypos)

   def exitButtonClick(self):
        if (messagebox.askokcancel("OK to close?","Close application?")):
            self.parent.destroy
            exit() # needed to close the main frame

    

   def calcButtonClick(self):
        amt = float(self.txtAmount.get())
        rate = float(self.txtRate.get())
        dur = float(self.txtDuration.get())
        monthlyPayment = amt * (rate / 1200.0) * ((rate / 1200 + 1)** dur) / (((rate / 1200 + 1)** dur) - 1)
        totalPayment = amt * ((1 + rate / 1200) ** dur)
        self.txtMonthlyPayment.configure(state="normal") # has to be turned back to normal otherwise, data is not modified, as text box is declared readonly
        self.txtMonthlyPayment.delete(0,END)
        self.txtMonthlyPayment.insert(0,format(monthlyPayment, "0.2f"))
        self.txtMonthlyPayment.configure(state="readonly")
        self.txtTotalPayment.configure(state="normal")
        self.txtTotalPayment.delete(0,END)
        self.txtTotalPayment.insert(0,format(totalPayment, "0.2f"))
        self.txtTotalPayment.configure(state="readonly")

    






