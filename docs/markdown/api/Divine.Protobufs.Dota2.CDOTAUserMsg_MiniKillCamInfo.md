# <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo"></a> Class CDOTAUserMsg\_MiniKillCamInfo

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAUserMsg_MiniKillCamInfo : IMessage<CDOTAUserMsg_MiniKillCamInfo>, IEquatable<CDOTAUserMsg_MiniKillCamInfo>, IDeepCloneable<CDOTAUserMsg_MiniKillCamInfo>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md)

#### Implements

IMessage<CDOTAUserMsg\_MiniKillCamInfo\>, 
[IEquatable<CDOTAUserMsg\_MiniKillCamInfo\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAUserMsg\_MiniKillCamInfo\>, 
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
[EnumerableExtensions.In<CDOTAUserMsg\_MiniKillCamInfo\>\(CDOTAUserMsg\_MiniKillCamInfo, params CDOTAUserMsg\_MiniKillCamInfo\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo__ctor"></a> CDOTAUserMsg\_MiniKillCamInfo\(\)

```csharp
public CDOTAUserMsg_MiniKillCamInfo()
```

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo__ctor_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_"></a> CDOTAUserMsg\_MiniKillCamInfo\(CDOTAUserMsg\_MiniKillCamInfo\)

```csharp
public CDOTAUserMsg_MiniKillCamInfo(CDOTAUserMsg_MiniKillCamInfo other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_AttackersFieldNumber"></a> AttackersFieldNumber

```csharp
public const int AttackersFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Attackers"></a> Attackers

```csharp
public RepeatedField<CDOTAUserMsg_MiniKillCamInfo.Types.Attacker> Attackers { get; }
```

#### Property Value

 RepeatedField<[CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md).[Types](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.md).[Attacker](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.Types.Attacker.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAUserMsg_MiniKillCamInfo> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Clone"></a> Clone\(\)

```csharp
public CDOTAUserMsg_MiniKillCamInfo Clone()
```

#### Returns

 [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_Equals_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_"></a> Equals\(CDOTAUserMsg\_MiniKillCamInfo\)

```csharp
public bool Equals(CDOTAUserMsg_MiniKillCamInfo other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_MergeFrom_Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_"></a> MergeFrom\(CDOTAUserMsg\_MiniKillCamInfo\)

```csharp
public void MergeFrom(CDOTAUserMsg_MiniKillCamInfo other)
```

#### Parameters

`other` [CDOTAUserMsg\_MiniKillCamInfo](Divine.Protobufs.Dota2.CDOTAUserMsg\_MiniKillCamInfo.md)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAUserMsg_MiniKillCamInfo_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

