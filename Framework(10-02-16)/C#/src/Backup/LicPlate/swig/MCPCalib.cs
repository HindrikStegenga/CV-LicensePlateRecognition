/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class MCPCalib : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MCPCalib(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MCPCalib obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MCPCalib() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_MCPCalib(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public MCPCalib() : this(VisionLabPINVOKE.new_MCPCalib(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InitMCP() {
    VisionLabPINVOKE.MCPCalib_InitMCP(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool TestMultiCore(OpCode op, int nrPixels, double complexity) {
    bool ret = VisionLabPINVOKE.MCPCalib_TestMultiCore__SWIG_0(swigCPtr, (int)op, nrPixels, complexity);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool TestMultiCore(OpCode op, int nrPixels) {
    bool ret = VisionLabPINVOKE.MCPCalib_TestMultiCore__SWIG_1(swigCPtr, (int)op, nrPixels);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetCalibOp(OpCode op, double best, double last, double def) {
    VisionLabPINVOKE.MCPCalib_SetCalibOp__SWIG_0(swigCPtr, (int)op, best, last, def);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetCalibOp(OpCode op, double val) {
    VisionLabPINVOKE.MCPCalib_SetCalibOp__SWIG_1(swigCPtr, (int)op, val);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double CalibrateOp(OpCode op) {
    double ret = VisionLabPINVOKE.MCPCalib_CalibrateOp(swigCPtr, (int)op);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public MCPCalibTabElm GetCalibOp(OpCode op) {
    MCPCalibTabElm ret = new MCPCalibTabElm(VisionLabPINVOKE.MCPCalib_GetCalibOp(swigCPtr, (int)op), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void DefaultCalibTab() {
    VisionLabPINVOKE.MCPCalib_DefaultCalibTab(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToFile(string fileName) {
    VisionLabPINVOKE.MCPCalib_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromFile(string fileName) {
    VisionLabPINVOKE.MCPCalib_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int CalibAutoMCP() {
    int ret = VisionLabPINVOKE.MCPCalib_CalibAutoMCP(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMCPThreshold(int val) {
    VisionLabPINVOKE.MCPCalib_SetMCPThreshold(swigCPtr, val);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetMCPThreshold() {
    int ret = VisionLabPINVOKE.MCPCalib_GetMCPThreshold(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetAutoMultiCore(bool val) {
    bool ret = VisionLabPINVOKE.MCPCalib_SetAutoMultiCore(swigCPtr, val);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsAutoMultiCore() {
    bool ret = VisionLabPINVOKE.MCPCalib_IsAutoMultiCore(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetNested(bool val) {
    bool ret = VisionLabPINVOKE.MCPCalib_SetNested(swigCPtr, val);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsNested() {
    bool ret = VisionLabPINVOKE.MCPCalib_IsNested(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetNrThreads(int val) {
    VisionLabPINVOKE.MCPCalib_SetNrThreads(swigCPtr, val);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNrThreads() {
    int ret = VisionLabPINVOKE.MCPCalib_GetNrThreads(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetGain(double val) {
    VisionLabPINVOKE.MCPCalib_SetGain(swigCPtr, val);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public double GetGain() {
    double ret = VisionLabPINVOKE.MCPCalib_GetGain(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetImageSize(int size) {
    VisionLabPINVOKE.MCPCalib_SetImageSize(swigCPtr, size);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetImageSize() {
    int ret = VisionLabPINVOKE.MCPCalib_GetImageSize(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_MCPCalibTabElm GetCalibTab() {
    vector_MCPCalibTabElm ret = new vector_MCPCalibTabElm(VisionLabPINVOKE.MCPCalib_GetCalibTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}
