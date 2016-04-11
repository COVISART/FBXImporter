//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class FBXGlobalSettings : RCObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal FBXGlobalSettings(global::System.IntPtr cPtr, bool cMemoryOwn) : base(FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FBXGlobalSettings obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FBXGlobalSettings() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FBXImporterUnmanagedPINVOKE.delete_FBXGlobalSettings(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public float unitScaleFactor {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_unitScaleFactor_set(swigCPtr, value);
    } 
    get {
      float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_unitScaleFactor_get(swigCPtr);
      return ret;
    } 
  }

  public float originalScaleFactor {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_originalScaleFactor_set(swigCPtr, value);
    } 
    get {
      float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_originalScaleFactor_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.UpVector upVector {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_upVector_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_upVector_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.UpVector originalUpVector {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_originalUpVector_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_originalUpVector_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.FrontVector frontVector {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_frontVector_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.FrontVector ret = (FBXGlobalSettings.FrontVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_frontVector_get(swigCPtr);
      return ret;
    } 
  }

  public FBXGlobalSettings.CoordinateSystem coordinateSystem {
    set {
      FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_coordinateSystem_set(swigCPtr, (int)value);
    } 
    get {
      FBXGlobalSettings.CoordinateSystem ret = (FBXGlobalSettings.CoordinateSystem)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_coordinateSystem_get(swigCPtr);
      return ret;
    } 
  }

  public static FBXGlobalSettingsPtr Create() {
    FBXGlobalSettingsPtr ret = new FBXGlobalSettingsPtr(FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_Create(), true);
    return ret;
  }

  public FBXGlobalSettings() : this(FBXImporterUnmanagedPINVOKE.new_FBXGlobalSettings(), true) {
  }

  public void SetUnitScaleFactor(float value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SetUnitScaleFactor(swigCPtr, value);
  }

  public void SetOriginalUnitScaleFactor(float value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SetOriginalUnitScaleFactor(swigCPtr, value);
  }

  public void SetUpVector(FBXGlobalSettings.UpVector value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SetUpVector(swigCPtr, (int)value);
  }

  public void SetOriginalUpVector(FBXGlobalSettings.UpVector value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SetOriginalUpVector(swigCPtr, (int)value);
  }

  public void SetFrontVector(FBXGlobalSettings.FrontVector value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SetFrontVector(swigCPtr, (int)value);
  }

  public void SetCoordinateSystem(FBXGlobalSettings.CoordinateSystem value) {
    FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_SetCoordinateSystem(swigCPtr, (int)value);
  }

  public float GetUnitScaleFactor() {
    float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_GetUnitScaleFactor(swigCPtr);
    return ret;
  }

  public float GetOriginalUnitScaleFactor() {
    float ret = FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_GetOriginalUnitScaleFactor(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.UpVector GetUpVector() {
    FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_GetUpVector(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.UpVector GetOriginalUpVector() {
    FBXGlobalSettings.UpVector ret = (FBXGlobalSettings.UpVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_GetOriginalUpVector(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.FrontVector GetFrontVector() {
    FBXGlobalSettings.FrontVector ret = (FBXGlobalSettings.FrontVector)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_GetFrontVector(swigCPtr);
    return ret;
  }

  public FBXGlobalSettings.CoordinateSystem GetCoordinateSystem() {
    FBXGlobalSettings.CoordinateSystem ret = (FBXGlobalSettings.CoordinateSystem)FBXImporterUnmanagedPINVOKE.FBXGlobalSettings_GetCoordinateSystem(swigCPtr);
    return ret;
  }

  public enum UpVector {
    X,
    Y,
    Z
  }

  public enum FrontVector {
    Odd,
    Even
  }

  public enum CoordinateSystem {
    LeftHand,
    RightHand
  }

}
