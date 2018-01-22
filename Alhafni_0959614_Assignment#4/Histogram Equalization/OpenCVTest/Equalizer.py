import cv2
import sys
import collections
import math
import numpy as np

class Equalizer():
    def __init__(self):
   
        self.img = None
        self.frequency =dict()
        self.cdf = dict()
        self.equalized = dict()
       

    def display(self,image):
        self.img  = image
         
        count = 0
        #filling all dictionaries with zeros
        for  i in range(0,256):
            self.frequency [i] = 0
            self.cdf [i] = 0
            self.equalized[i] = 0
       
        #setting the frequency 
        for i in range(0,self.img.shape[0]):
            for j in range (0,self.img.shape[1]):
                self.frequency[self.img[i,j]] = self.frequency[self.img[i,j]] + 1
        
        #deleting pixels are not in the image
        self.frequency = {key: value for key, value in self.frequency.items() if value != 0}
        #sorting by key
        self.frequency = collections.OrderedDict(sorted(self.frequency.items()))

        #setting cdf
        prev_key = 0
        first = True
        for  key,value in self.frequency.items():
            if first:
                self.cdf[key] = self.frequency[key]
                first = False
            else:
                self.cdf[key] = self.frequency[key] + self.cdf[prev_key]
            prev_key = key

        #deleting pixels are not in the image
        self.cdf = {key: value for key, value in self.cdf.items() if value != 0}
        #sorting by key
        self.cdf = collections.OrderedDict(sorted(self.cdf.items()))

        first = True
        for key,value in self.cdf.items():
            if first:
                min = value
                first = False
            else:
                top = value  - min
                bottom = (self.img.shape[0]  * self.img.shape[1]) - 1
                res = (top/bottom) *255
                self.equalized[key] = int(math.floor(res))

        equalized_img = np.zeros((self.img.shape[0],self.img.shape[1],3), np.uint8)
        for i in range(0,equalized_img.shape[0]):
            for j in range (0,equalized_img.shape[1]):
                equalized_img[i,j] = self.equalized[self.img[i,j]]

         #printing
        for k,v in self.frequency.items():
            if v !=0:
                print("pixel: " +str(k)+" was repeated "+str(v) +" times, CDF: "+str(self.cdf[k]))
        print(self.img.shape)
      
       
        cv2.imshow('equalized image', equalized_img)
        cv2.waitKey(0)
        cv2.distroyAllWindows()
    
def main():
    eq = Equalizer()
    eq.display()

if __name__ == "__main__":
     sys.exit(int(main() or 0))





