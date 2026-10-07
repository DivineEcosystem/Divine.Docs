# <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated"></a> Class CMsgGCToClientGuildDataUpdated

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientGuildDataUpdated : IMessage<CMsgGCToClientGuildDataUpdated>, IEquatable<CMsgGCToClientGuildDataUpdated>, IDeepCloneable<CMsgGCToClientGuildDataUpdated>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientGuildDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildDataUpdated.md)

#### Implements

IMessage<CMsgGCToClientGuildDataUpdated\>, 
[IEquatable<CMsgGCToClientGuildDataUpdated\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientGuildDataUpdated\>, 
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
[EnumerableExtensions.In<CMsgGCToClientGuildDataUpdated\>\(CMsgGCToClientGuildDataUpdated, params CMsgGCToClientGuildDataUpdated\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated__ctor"></a> CMsgGCToClientGuildDataUpdated\(\)

```csharp
public CMsgGCToClientGuildDataUpdated()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated__ctor_Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_"></a> CMsgGCToClientGuildDataUpdated\(CMsgGCToClientGuildDataUpdated\)

```csharp
public CMsgGCToClientGuildDataUpdated(CMsgGCToClientGuildDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildDataUpdated.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_GuildDataFieldNumber"></a> GuildDataFieldNumber

```csharp
public const int GuildDataFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_UpdateFlagsFieldNumber"></a> UpdateFlagsFieldNumber

```csharp
public const int UpdateFlagsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_GuildData"></a> GuildData

```csharp
public CMsgGuildData GuildData { get; set; }
```

#### Property Value

 [CMsgGuildData](Divine.Protobufs.Dota2.CMsgGuildData.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_HasUpdateFlags"></a> HasUpdateFlags

```csharp
public bool HasUpdateFlags { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientGuildDataUpdated> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientGuildDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildDataUpdated.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_UpdateFlags"></a> UpdateFlags

```csharp
public uint UpdateFlags { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_ClearUpdateFlags"></a> ClearUpdateFlags\(\)

```csharp
public void ClearUpdateFlags()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientGuildDataUpdated Clone()
```

#### Returns

 [CMsgGCToClientGuildDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_Equals_Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_"></a> Equals\(CMsgGCToClientGuildDataUpdated\)

```csharp
public bool Equals(CMsgGCToClientGuildDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildDataUpdated.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_"></a> MergeFrom\(CMsgGCToClientGuildDataUpdated\)

```csharp
public void MergeFrom(CMsgGCToClientGuildDataUpdated other)
```

#### Parameters

`other` [CMsgGCToClientGuildDataUpdated](Divine.Protobufs.Dota2.CMsgGCToClientGuildDataUpdated.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientGuildDataUpdated_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

