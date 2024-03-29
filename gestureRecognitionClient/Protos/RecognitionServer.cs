// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/RecognitionServer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Recognition {

  /// <summary>Holder for reflection information generated from Protos/RecognitionServer.proto</summary>
  public static partial class RecognitionServerReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/RecognitionServer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RecognitionServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch5Qcm90b3MvUmVjb2duaXRpb25TZXJ2ZXIucHJvdG8SC3JlY29nbml0aW9u",
            "IjYKGUdlc3R1cmVSZWNvZ25pdGlvblJlcXVlc3QSCwoDaWRzGAEgASgJEgwK",
            "BGRhdGEYAiABKAwiVwoXR2VzdHVyZVJlY29nbml0aW9uUmVwbHkSCwoDaWRz",
            "GAEgASgJEg8KB2VyckNvZGUYAiABKAMSDgoGZXJyTXNnGAMgASgJEg4KBnJl",
            "c3VsdBgEIAEoBTJ7ChFSZWNvZ25pdGlvblNlcnZlchJmChJHZXN0dXJlUmVj",
            "b2duaXRpb24SJi5yZWNvZ25pdGlvbi5HZXN0dXJlUmVjb2duaXRpb25SZXF1",
            "ZXN0GiQucmVjb2duaXRpb24uR2VzdHVyZVJlY29nbml0aW9uUmVwbHkoATAB",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Recognition.GestureRecognitionRequest), global::Recognition.GestureRecognitionRequest.Parser, new[]{ "Ids", "Data" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Recognition.GestureRecognitionReply), global::Recognition.GestureRecognitionReply.Parser, new[]{ "Ids", "ErrCode", "ErrMsg", "Result" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GestureRecognitionRequest : pb::IMessage<GestureRecognitionRequest> {
    private static readonly pb::MessageParser<GestureRecognitionRequest> _parser = new pb::MessageParser<GestureRecognitionRequest>(() => new GestureRecognitionRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GestureRecognitionRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Recognition.RecognitionServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GestureRecognitionRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GestureRecognitionRequest(GestureRecognitionRequest other) : this() {
      ids_ = other.ids_;
      data_ = other.data_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GestureRecognitionRequest Clone() {
      return new GestureRecognitionRequest(this);
    }

    /// <summary>Field number for the "ids" field.</summary>
    public const int IdsFieldNumber = 1;
    private string ids_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ids {
      get { return ids_; }
      set {
        ids_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 2;
    private pb::ByteString data_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Data {
      get { return data_; }
      set {
        data_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GestureRecognitionRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GestureRecognitionRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ids != other.Ids) return false;
      if (Data != other.Data) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ids.Length != 0) hash ^= Ids.GetHashCode();
      if (Data.Length != 0) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ids.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Ids);
      }
      if (Data.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ids.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ids);
      }
      if (Data.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GestureRecognitionRequest other) {
      if (other == null) {
        return;
      }
      if (other.Ids.Length != 0) {
        Ids = other.Ids;
      }
      if (other.Data.Length != 0) {
        Data = other.Data;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Ids = input.ReadString();
            break;
          }
          case 18: {
            Data = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GestureRecognitionReply : pb::IMessage<GestureRecognitionReply> {
    private static readonly pb::MessageParser<GestureRecognitionReply> _parser = new pb::MessageParser<GestureRecognitionReply>(() => new GestureRecognitionReply());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GestureRecognitionReply> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Recognition.RecognitionServerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GestureRecognitionReply() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GestureRecognitionReply(GestureRecognitionReply other) : this() {
      ids_ = other.ids_;
      errCode_ = other.errCode_;
      errMsg_ = other.errMsg_;
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GestureRecognitionReply Clone() {
      return new GestureRecognitionReply(this);
    }

    /// <summary>Field number for the "ids" field.</summary>
    public const int IdsFieldNumber = 1;
    private string ids_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ids {
      get { return ids_; }
      set {
        ids_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "errCode" field.</summary>
    public const int ErrCodeFieldNumber = 2;
    private long errCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long ErrCode {
      get { return errCode_; }
      set {
        errCode_ = value;
      }
    }

    /// <summary>Field number for the "errMsg" field.</summary>
    public const int ErrMsgFieldNumber = 3;
    private string errMsg_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ErrMsg {
      get { return errMsg_; }
      set {
        errMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 4;
    private int result_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GestureRecognitionReply);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GestureRecognitionReply other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Ids != other.Ids) return false;
      if (ErrCode != other.ErrCode) return false;
      if (ErrMsg != other.ErrMsg) return false;
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Ids.Length != 0) hash ^= Ids.GetHashCode();
      if (ErrCode != 0L) hash ^= ErrCode.GetHashCode();
      if (ErrMsg.Length != 0) hash ^= ErrMsg.GetHashCode();
      if (Result != 0) hash ^= Result.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Ids.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Ids);
      }
      if (ErrCode != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(ErrCode);
      }
      if (ErrMsg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ErrMsg);
      }
      if (Result != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Result);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Ids.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ids);
      }
      if (ErrCode != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ErrCode);
      }
      if (ErrMsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrMsg);
      }
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GestureRecognitionReply other) {
      if (other == null) {
        return;
      }
      if (other.Ids.Length != 0) {
        Ids = other.Ids;
      }
      if (other.ErrCode != 0L) {
        ErrCode = other.ErrCode;
      }
      if (other.ErrMsg.Length != 0) {
        ErrMsg = other.ErrMsg;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Ids = input.ReadString();
            break;
          }
          case 16: {
            ErrCode = input.ReadInt64();
            break;
          }
          case 26: {
            ErrMsg = input.ReadString();
            break;
          }
          case 32: {
            Result = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
