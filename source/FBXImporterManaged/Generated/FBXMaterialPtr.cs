//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FBXMaterialPtr : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FBXMaterialPtr(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FBXMaterialPtr obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FBXMaterialPtr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FBXImporterUnmanagedPINVOKE.delete_FBXMaterialPtr(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FBXMaterialPtr() : this(FBXImporterUnmanagedPINVOKE.new_FBXMaterialPtr__SWIG_0(), true) {
  }

  public FBXMaterialPtr(FBXMaterial p) : this(FBXImporterUnmanagedPINVOKE.new_FBXMaterialPtr__SWIG_1(FBXMaterial.getCPtr(p)), true) {
  }

  public FBXMaterialPtr(FBXMaterialPtr other) : this(FBXImporterUnmanagedPINVOKE.new_FBXMaterialPtr__SWIG_2(FBXMaterialPtr.getCPtr(other)), true) {
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public FBXMaterial get() {
    global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_get(swigCPtr);
    FBXMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXMaterial(cPtr, false);
    return ret;
  }

  public FBXMaterial __deref__() {
    global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr___deref__(swigCPtr);
    FBXMaterial ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXMaterial(cPtr, false);
    return ret;
  }

  public FBXMaterial __ref__() {
    FBXMaterial ret = new FBXMaterial(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr___ref__(swigCPtr), false);
    return ret;
  }

  public bool IsNull() {
    bool ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_IsNull(swigCPtr);
    return ret;
  }

  public static FBXMaterialPtr Null {
    set {
      FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_Null_set(FBXMaterialPtr.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_Null_get();
      FBXMaterialPtr ret = (cPtr == global::System.IntPtr.Zero) ? null : new FBXMaterialPtr(cPtr, false);
      return ret;
    } 
  }

  public FBXMaterialPtr Create() {
    FBXMaterialPtr ret = new FBXMaterialPtr(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_Create(swigCPtr), true);
    return ret;
  }

  public void SetName(string name) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetName(swigCPtr, name);
  }

  public void SetBool(string key, bool value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetBool(swigCPtr, key, value);
  }

  public void SetInt(string key, int value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetInt(swigCPtr, key, value);
  }

  public void SetFloat(string key, float value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetFloat(swigCPtr, key, value);
  }

  public void SetDouble(string key, double value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetDouble(swigCPtr, key, value);
  }

  public void SetVector2(string key, FBXVector2 value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetVector2(swigCPtr, key, FBXVector2.getCPtr(value));
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetVector3(string key, FBXVector3 value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetVector3(swigCPtr, key, FBXVector3.getCPtr(value));
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetVector4(string key, FBXVector4 value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetVector4(swigCPtr, key, FBXVector4.getCPtr(value));
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetString(string key, string value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetString(swigCPtr, key, value);
  }

  public void SetColor(string key, FBXColor value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetColor(swigCPtr, key, FBXColor.getCPtr(value));
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetMatrix4x4(string key, FBXMatrix4x4 value) {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_SetMatrix4x4(swigCPtr, key, FBXMatrix4x4.getCPtr(value));
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetName() {
    string ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetName(swigCPtr);
    return ret;
  }

  public bool GetBool(string key, bool defaultValue) {
    bool ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetBool__SWIG_0(swigCPtr, key, defaultValue);
    return ret;
  }

  public bool GetBool(string key) {
    bool ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetBool__SWIG_1(swigCPtr, key);
    return ret;
  }

  public int GetInt(string key, int defaultValue) {
    int ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetInt__SWIG_0(swigCPtr, key, defaultValue);
    return ret;
  }

  public int GetInt(string key) {
    int ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetInt__SWIG_1(swigCPtr, key);
    return ret;
  }

  public float GetFloat(string key, float defaultValue) {
    float ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetFloat__SWIG_0(swigCPtr, key, defaultValue);
    return ret;
  }

  public float GetFloat(string key) {
    float ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetFloat__SWIG_1(swigCPtr, key);
    return ret;
  }

  public double GetDouble(string key, double defaultValue) {
    double ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetDouble__SWIG_0(swigCPtr, key, defaultValue);
    return ret;
  }

  public double GetDouble(string key) {
    double ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetDouble__SWIG_1(swigCPtr, key);
    return ret;
  }

  public FBXVector2 GetVector2(string key, FBXVector2 defaultValue) {
    FBXVector2 ret = new FBXVector2(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetVector2__SWIG_0(swigCPtr, key, FBXVector2.getCPtr(defaultValue)), true);
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FBXVector2 GetVector2(string key) {
    FBXVector2 ret = new FBXVector2(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetVector2__SWIG_1(swigCPtr, key), true);
    return ret;
  }

  public FBXVector3 GetVector3(string key, FBXVector3 defaultValue) {
    FBXVector3 ret = new FBXVector3(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetVector3__SWIG_0(swigCPtr, key, FBXVector3.getCPtr(defaultValue)), true);
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FBXVector3 GetVector3(string key) {
    FBXVector3 ret = new FBXVector3(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetVector3__SWIG_1(swigCPtr, key), true);
    return ret;
  }

  public FBXVector4 GetVector4(string key, FBXVector4 defaultValue) {
    FBXVector4 ret = new FBXVector4(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetVector4__SWIG_0(swigCPtr, key, FBXVector4.getCPtr(defaultValue)), true);
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FBXVector4 GetVector4(string key) {
    FBXVector4 ret = new FBXVector4(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetVector4__SWIG_1(swigCPtr, key), true);
    return ret;
  }

  public string GetString(string key, string defaultValue) {
    string ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetString__SWIG_0(swigCPtr, key, defaultValue);
    return ret;
  }

  public string GetString(string key) {
    string ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetString__SWIG_1(swigCPtr, key);
    return ret;
  }

  public FBXColor GetColor(string key, FBXColor defaultValue) {
    FBXColor ret = new FBXColor(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetColor__SWIG_0(swigCPtr, key, FBXColor.getCPtr(defaultValue)), true);
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FBXColor GetColor(string key) {
    FBXColor ret = new FBXColor(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetColor__SWIG_1(swigCPtr, key), true);
    return ret;
  }

  public FBXMatrix4x4 GetMatrix4x4(string key, FBXMatrix4x4 defaultValue) {
    FBXMatrix4x4 ret = new FBXMatrix4x4(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetMatrix4x4__SWIG_0(swigCPtr, key, FBXMatrix4x4.getCPtr(defaultValue)), true);
    if (FBXImporterUnmanagedPINVOKE.SWIGPendingException.Pending) throw FBXImporterUnmanagedPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public FBXMatrix4x4 GetMatrix4x4(string key) {
    FBXMatrix4x4 ret = new FBXMatrix4x4(FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_GetMatrix4x4__SWIG_1(swigCPtr, key), true);
    return ret;
  }

  public bool Exist(string key) {
    bool ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_Exist(swigCPtr, key);
    return ret;
  }

  public void addReference() {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_addReference(swigCPtr);
  }

  public void removeReference() {
    FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_removeReference(swigCPtr);
  }

  public int getReferenceCount() {
    int ret = FBXImporterUnmanagedPINVOKE.FBXMaterialPtr_getReferenceCount(swigCPtr);
    return ret;
  }

}
