import numpy as np
import cv2
from matplotlib import pyplot as plt


# Load a color image in grayscale
img = cv2.imread('c:/users/bashar.alhafni/desktop/donald_duck.jpeg',1) # 0 for gray, 1 for color

#---------------canny edge detection-------------
img = cv2.imread('c:/users/bashar.alhafni/desktop/donald_duck.jpeg',0)
edges = cv2.Canny(img,50,200)
plt.subplot(121),plt.imshow(img,cmap = 'gray')
plt.title('Original Image'), plt.xticks([]), plt.yticks([])
plt.subplot(122),plt.imshow(edges,cmap = 'gray')
plt.title('Edge Image'), plt.xticks([]), plt.yticks([])
plt.show()
#-------------------------------------------------

#--------------------Harris Corner Detection------
filename = 'c:/users/bashar.alhafni/desktop/chessboard.jpeg'
img = cv2.imread(filename)
gray = cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
# find Harris corners
gray = np.float32(gray)
dst = cv2.cornerHarris(gray,2,3,0.04)
#result is dilated for marking the corners, not important
dst = cv2.dilate(dst,None)
# Threshold for an optimal value, it may vary depending on the image.
img[dst>0.01*dst.max()]=[0,0,255]

cv2.imshow('dst',img)
#-------------------------------------------------
cv2.waitKey(0)
cv2.destroyAllWindows()
