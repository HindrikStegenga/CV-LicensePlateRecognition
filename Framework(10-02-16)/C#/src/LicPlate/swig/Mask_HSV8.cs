/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.7
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class Mask_HSV8 : MaskBase {
  private HandleRef swigCPtr;

  internal Mask_HSV8(IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.Mask_HSV8_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Mask_HSV8 obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Mask_HSV8() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_Mask_HSV8(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public Mask_HSV8() : this(VisionLabPINVOKE.new_Mask_HSV8__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_HSV8(Mask_HSV8 mask) : this(VisionLabPINVOKE.new_Mask_HSV8__SWIG_1(Mask_HSV8.getCPtr(mask)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_HSV8(int height, int width) : this(VisionLabPINVOKE.new_Mask_HSV8__SWIG_2(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_HSV8(int height, int width, HSV888Pixel v) : this(VisionLabPINVOKE.new_Mask_HSV8__SWIG_3(height, width, HSV888Pixel.getCPtr(v)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_HSV8(int height, int width, int orgX, int orgY, HSV888Pixel v) : this(VisionLabPINVOKE.new_Mask_HSV8__SWIG_4(height, width, orgX, orgY, HSV888Pixel.getCPtr(v)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Mask_HSV8(int height, int width, int orgX, int orgY) : this(VisionLabPINVOKE.new_Mask_HSV8__SWIG_5(height, width, orgX, orgY), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEqual_Op(Mask_HSV8 mask) {
    bool ret = VisionLabPINVOKE.Mask_HSV8_IsEqual_Op(swigCPtr, Mask_HSV8.getCPtr(mask));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(Mask_HSV8 mask) {
    bool ret = VisionLabPINVOKE.Mask_HSV8_Not(swigCPtr, Mask_HSV8.getCPtr(mask));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Mask_HSV8 Assign_Op(Mask_HSV8 mask) {
    Mask_HSV8 ret = new Mask_HSV8(VisionLabPINVOKE.Mask_HSV8_Assign_Op(swigCPtr, Mask_HSV8.getCPtr(mask)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMask(int height, int width, int orgX, int orgY) {
    VisionLabPINVOKE.Mask_HSV8_SetMask(swigCPtr, height, width, orgX, orgY);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV888Pixel GetMaskValue(int x, int y) {
    HSV888Pixel ret = new HSV888Pixel(VisionLabPINVOKE.Mask_HSV8_GetMaskValue(swigCPtr, x, y), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaskValue(int x, int y, HSV888Pixel v) {
    VisionLabPINVOKE.Mask_HSV8_SetMaskValue(swigCPtr, x, y, HSV888Pixel.getCPtr(v));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public HSV888Pixel tab {
    set {
      VisionLabPINVOKE.Mask_HSV8_tab_set(swigCPtr, HSV888Pixel.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      IntPtr cPtr = VisionLabPINVOKE.Mask_HSV8_tab_get(swigCPtr);
      HSV888Pixel ret = (cPtr == IntPtr.Zero) ? null : new HSV888Pixel(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

}