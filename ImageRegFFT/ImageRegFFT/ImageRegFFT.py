from __future__ import division
import sys
import numpy
from numpy import fft,conj
from skimage import io
from scipy import ndimage
from numpy.fft.fftpack import fft2, ifft2
from numpy.fft import fftshift
from matplotlib import pyplot as plt
from scipy import misc, mgrid,cos,sin
import math


try:
    import scipy.ndimage.interpolation as ndii
except ImportError:
    import ndimage.interpolation as ndii

def main():
    im0 = misc.imread("C:/Users/bashar.alhafni/Desktop/donald_duck.jpeg")
    im0g = rgb2gray(im0)
    im1 = misc.imread("C:/Users/bashar.alhafni/Desktop/rotated_donald3.jpg")
    im1g = rgb2gray(im1)
    resTranslation = getTranslation(im0g,im1g)
    print(resTranslation)
    # remove the translation i.e., shift it back before finding the rotation
    shifted_img1gs = RemoveShiftFromImage(im1g, resTranslation)
    plt.imshow(shifted_img1gs)#, interpolation='nearest')
    plt.show()
    rot, scale = getRotationScale(im0g, shifted_img1gs)
    print(rot)

def rgb2gray(rgb):
    r,g,b = rgb[:,:,0],rgb[:,:,1],rgb[:,:,2]
    gray = 0.2989 * r + 0.5870 * g + 0.1140 *b
    return gray

def RemoveShiftFromImage(img, translation): # remove translation from image
     non = lambda num: num if num<0 else None
     mx = lambda num: max(0,num)
     sx, sy = translation[0], translation[1]
     shifted_img = numpy.zeros_like(img)
     shifted_img[mx(sy):non(sy), mx(sx):non(sx)] = img[mx(-sy):non(-sy), mx(-sx):non(-sx)]
     return shifted_img

def getTranslation(im0, im1):
     """get translation vector for registering im2 with im1"""
     shape = im0.shape
     f0 = fft2(im0)
     f1 = fft2(im1)
     ir = abs(ifft2((f0 * f1.conjugate()) / (abs(f0) * abs(f1))))
     s2 = ir.shape
     irmax = numpy.argmax(ir)
     t0, t1 = numpy.unravel_index(irmax, shape)
     if t0 > shape[0] // 2:
        t0 -= shape[0]
     if t1 > shape[1] // 2:
        t1 -= shape[1]
     return [t1, t0]

def getRotationScale(im0,im1): # uses logolar coordinates
     lpim0,yy = logpolar(im0)
     lpim1,yy = logpolar(im1)
     f0 = fft2(lpim0)
     f1 = fft2(lpim1)
     Fcorr = (f0*conj(f1))/(abs(f0)*abs(f1))
     correlation = ifft2(Fcorr)
     irp = abs(correlation[1:correlation.shape[0]-1,1:correlation.shape[1]-1]) # skip the first,last row column, as it produces some times wrong answer
     rot, scale = numpy.unravel_index(numpy.argmax(irp), irp.shape)
     rot = rot + 1 # because first row/col was not used in correlation indexing

     if rot < -90.0:
        rot += 180.0
     elif rot > 90.0:
        rot -= 180.0
     return rot, scale

def logpolar(image, angles=None, radii=None): # Ref: from http://www.lfd.uci.edu/~gohlke/code/imreg.py.html
     """Return log-polar transformed image and log base."""
     shape = image.shape
     center = shape[0] / 2, shape[1] / 2
     if angles is None:
        angles = shape[0]
     if radii is None:
        radii = shape[1]
     theta = numpy.empty((angles, radii), dtype=numpy.float64)
     theta.T[:] = -numpy.linspace(0, numpy.pi, angles, endpoint=False)
     #d = radii
     d = numpy.hypot(shape[0]-center[0], shape[1]-center[1])
     log_base = 10.0 ** (math.log10(d) / (radii))
     radius = numpy.empty_like(theta)
     radius[:] = numpy.power(log_base, numpy.arange(radii,
     dtype=numpy.float64)) - 1.0
     x = radius * numpy.sin(theta) + center[0]
     y = radius * numpy.cos(theta) + center[1]
     output = numpy.empty_like(x)
     ndii.map_coordinates(image, [x, y], output=output)
     return output, log_base

if __name__ == "__main__":
    sys.exit(int(main() or 0))
