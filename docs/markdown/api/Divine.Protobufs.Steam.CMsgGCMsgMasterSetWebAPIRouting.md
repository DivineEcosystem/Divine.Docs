# <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting"></a> Class CMsgGCMsgMasterSetWebAPIRouting

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCMsgMasterSetWebAPIRouting : IMessage<CMsgGCMsgMasterSetWebAPIRouting>, IEquatable<CMsgGCMsgMasterSetWebAPIRouting>, IDeepCloneable<CMsgGCMsgMasterSetWebAPIRouting>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md)

#### Implements

IMessage<CMsgGCMsgMasterSetWebAPIRouting\>, 
[IEquatable<CMsgGCMsgMasterSetWebAPIRouting\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCMsgMasterSetWebAPIRouting\>, 
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
[EnumerableExtensions.In<CMsgGCMsgMasterSetWebAPIRouting\>\(CMsgGCMsgMasterSetWebAPIRouting, params CMsgGCMsgMasterSetWebAPIRouting\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting__ctor"></a> CMsgGCMsgMasterSetWebAPIRouting\(\)

```csharp
public CMsgGCMsgMasterSetWebAPIRouting()
```

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting__ctor_Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_"></a> CMsgGCMsgMasterSetWebAPIRouting\(CMsgGCMsgMasterSetWebAPIRouting\)

```csharp
public CMsgGCMsgMasterSetWebAPIRouting(CMsgGCMsgMasterSetWebAPIRouting other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_EntriesFieldNumber"></a> EntriesFieldNumber

```csharp
public const int EntriesFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Entries"></a> Entries

```csharp
public RepeatedField<CMsgGCMsgMasterSetWebAPIRouting.Types.Entry> Entries { get; }
```

#### Property Value

 RepeatedField<[CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md).[Types](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.md).[Entry](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.Types.Entry.md)\>

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCMsgMasterSetWebAPIRouting> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Clone"></a> Clone\(\)

```csharp
public CMsgGCMsgMasterSetWebAPIRouting Clone()
```

#### Returns

 [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_Equals_Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_"></a> Equals\(CMsgGCMsgMasterSetWebAPIRouting\)

```csharp
public bool Equals(CMsgGCMsgMasterSetWebAPIRouting other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_MergeFrom_Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_"></a> MergeFrom\(CMsgGCMsgMasterSetWebAPIRouting\)

```csharp
public void MergeFrom(CMsgGCMsgMasterSetWebAPIRouting other)
```

#### Parameters

`other` [CMsgGCMsgMasterSetWebAPIRouting](Divine.Protobufs.Steam.CMsgGCMsgMasterSetWebAPIRouting.md)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgGCMsgMasterSetWebAPIRouting_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

