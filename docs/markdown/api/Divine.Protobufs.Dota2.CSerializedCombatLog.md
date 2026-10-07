# <a id="Divine_Protobufs_Dota2_CSerializedCombatLog"></a> Class CSerializedCombatLog

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CSerializedCombatLog : IMessage<CSerializedCombatLog>, IEquatable<CSerializedCombatLog>, IDeepCloneable<CSerializedCombatLog>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md)

#### Implements

IMessage<CSerializedCombatLog\>, 
[IEquatable<CSerializedCombatLog\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CSerializedCombatLog\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CSerializedCombatLog\>\(CSerializedCombatLog, params CSerializedCombatLog\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog__ctor"></a> CSerializedCombatLog\(\)

```csharp
public CSerializedCombatLog()
```

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog__ctor_Divine_Protobufs_Dota2_CSerializedCombatLog_"></a> CSerializedCombatLog\(CSerializedCombatLog\)

```csharp
public CSerializedCombatLog(CSerializedCombatLog other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_DictionaryFieldNumber"></a> DictionaryFieldNumber

```csharp
public const int DictionaryFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_EntriesFieldNumber"></a> EntriesFieldNumber

```csharp
public const int EntriesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_VersionFieldNumber"></a> VersionFieldNumber

```csharp
public const int VersionFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Dictionary"></a> Dictionary

```csharp
public CSerializedCombatLog.Types.Dictionary Dictionary { get; set; }
```

#### Property Value

 [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md).[Types](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.md).[Dictionary](Divine.Protobufs.Dota2.CSerializedCombatLog.Types.Dictionary.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Entries"></a> Entries

```csharp
public RepeatedField<CMsgDOTACombatLogEntry> Entries { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTACombatLogEntry](Divine.Protobufs.Dota2.CMsgDOTACombatLogEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_HasVersion"></a> HasVersion

```csharp
public bool HasVersion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Parser"></a> Parser

```csharp
public static MessageParser<CSerializedCombatLog> Parser { get; }
```

#### Property Value

 MessageParser<[CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md)\>

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Version"></a> Version

```csharp
public uint Version { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_ClearVersion"></a> ClearVersion\(\)

```csharp
public void ClearVersion()
```

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Clone"></a> Clone\(\)

```csharp
public CSerializedCombatLog Clone()
```

#### Returns

 [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_Equals_Divine_Protobufs_Dota2_CSerializedCombatLog_"></a> Equals\(CSerializedCombatLog\)

```csharp
public bool Equals(CSerializedCombatLog other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_MergeFrom_Divine_Protobufs_Dota2_CSerializedCombatLog_"></a> MergeFrom\(CSerializedCombatLog\)

```csharp
public void MergeFrom(CSerializedCombatLog other)
```

#### Parameters

`other` [CSerializedCombatLog](Divine.Protobufs.Dota2.CSerializedCombatLog.md)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CSerializedCombatLog_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

