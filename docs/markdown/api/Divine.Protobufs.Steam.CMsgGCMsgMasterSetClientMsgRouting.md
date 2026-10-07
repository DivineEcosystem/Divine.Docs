# <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting"></a> Class CMsgGCMsgMasterSetClientMsgRouting

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgMasterSetClientMsgRouting : IMessage<CMsgGCMsgMasterSetClientMsgRouting>, IEquatable<CMsgGCMsgMasterSetClientMsgRouting>, IDeepCloneable<CMsgGCMsgMasterSetClientMsgRouting>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md)

#### Implements

IMessage<CMsgGCMsgMasterSetClientMsgRouting\>, 
[IEquatable<CMsgGCMsgMasterSetClientMsgRouting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgMasterSetClientMsgRouting\>, 
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
[EnumerableExtensions.In<CMsgGCMsgMasterSetClientMsgRouting\>\(CMsgGCMsgMasterSetClientMsgRouting, params CMsgGCMsgMasterSetClientMsgRouting\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting__ctor"></a> CMsgGCMsgMasterSetClientMsgRouting\(\)

```csharp
public CMsgGCMsgMasterSetClientMsgRouting()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting__ctor_Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_"></a> CMsgGCMsgMasterSetClientMsgRouting\(CMsgGCMsgMasterSetClientMsgRouting\)

```csharp
public CMsgGCMsgMasterSetClientMsgRouting(CMsgGCMsgMasterSetClientMsgRouting other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_EntriesFieldNumber"></a> EntriesFieldNumber

```csharp
public const int EntriesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_Entries"></a> Entries

```csharp
public RepeatedField<CMsgGCMsgMasterSetClientMsgRouting.Types.Entry> Entries { get; }
```

#### Property Value

 RepeatedField<[CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.Types.Entry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgMasterSetClientMsgRouting> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgMasterSetClientMsgRouting Clone()
```

#### Returns

 [CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_Equals_Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_"></a> Equals\(CMsgGCMsgMasterSetClientMsgRouting\)

```csharp
public bool Equals(CMsgGCMsgMasterSetClientMsgRouting other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_"></a> MergeFrom\(CMsgGCMsgMasterSetClientMsgRouting\)

```csharp
public void MergeFrom(CMsgGCMsgMasterSetClientMsgRouting other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetClientMsgRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetClientMsgRouting.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetClientMsgRouting_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

