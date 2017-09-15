// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: equip.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from equip.proto</summary>
  public static partial class EquipReflection {

    #region Descriptor
    /// <summary>File descriptor for equip.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EquipReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtlcXVpcC5wcm90bxIFcHJvdG8ioAEKDVBCRXF1aXBFbnRpdHkSEQoJZW50",
            "aXR5X2lkGAEgASgDEg8KB2NvbmZfaWQYAiABKAUSDQoFbGV2ZWwYAyABKAUS",
            "LgoFYXR0dHMYBCADKAsyHy5wcm90by5QQkVxdWlwRW50aXR5LkF0dHRzRW50",
            "cnkaLAoKQXR0dHNFbnRyeRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6",
            "AjgBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.PBEquipEntity), global::Proto.PBEquipEntity.Parser, new[]{ "EntityId", "ConfId", "Level", "Attts" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// 这个位置需要属性吗， 假如装备可以洗练， 还是加上去
  /// </summary>
  public sealed partial class PBEquipEntity : pb::IMessage<PBEquipEntity> {
    private static readonly pb::MessageParser<PBEquipEntity> _parser = new pb::MessageParser<PBEquipEntity>(() => new PBEquipEntity());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PBEquipEntity> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.EquipReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBEquipEntity() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBEquipEntity(PBEquipEntity other) : this() {
      entityId_ = other.entityId_;
      confId_ = other.confId_;
      level_ = other.level_;
      attts_ = other.attts_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PBEquipEntity Clone() {
      return new PBEquipEntity(this);
    }

    /// <summary>Field number for the "entity_id" field.</summary>
    public const int EntityIdFieldNumber = 1;
    private long entityId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long EntityId {
      get { return entityId_; }
      set {
        entityId_ = value;
      }
    }

    /// <summary>Field number for the "conf_id" field.</summary>
    public const int ConfIdFieldNumber = 2;
    private int confId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ConfId {
      get { return confId_; }
      set {
        confId_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "attts" field.</summary>
    public const int AtttsFieldNumber = 4;
    private static readonly pbc::MapField<int, int>.Codec _map_attts_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 34);
    private readonly pbc::MapField<int, int> attts_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> Attts {
      get { return attts_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PBEquipEntity);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PBEquipEntity other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EntityId != other.EntityId) return false;
      if (ConfId != other.ConfId) return false;
      if (Level != other.Level) return false;
      if (!Attts.Equals(other.Attts)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EntityId != 0L) hash ^= EntityId.GetHashCode();
      if (ConfId != 0) hash ^= ConfId.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      hash ^= Attts.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EntityId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(EntityId);
      }
      if (ConfId != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ConfId);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Level);
      }
      attts_.WriteTo(output, _map_attts_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EntityId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(EntityId);
      }
      if (ConfId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ConfId);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      size += attts_.CalculateSize(_map_attts_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PBEquipEntity other) {
      if (other == null) {
        return;
      }
      if (other.EntityId != 0L) {
        EntityId = other.EntityId;
      }
      if (other.ConfId != 0) {
        ConfId = other.ConfId;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      attts_.Add(other.attts_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            EntityId = input.ReadInt64();
            break;
          }
          case 16: {
            ConfId = input.ReadInt32();
            break;
          }
          case 24: {
            Level = input.ReadInt32();
            break;
          }
          case 34: {
            attts_.AddEntriesFrom(input, _map_attts_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
