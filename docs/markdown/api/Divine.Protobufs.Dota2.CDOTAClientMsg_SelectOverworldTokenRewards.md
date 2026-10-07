# <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards"></a> Class CDOTAClientMsg\_SelectOverworldTokenRewards

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CDOTAClientMsg_SelectOverworldTokenRewards : IMessage<CDOTAClientMsg_SelectOverworldTokenRewards>, IEquatable<CDOTAClientMsg_SelectOverworldTokenRewards>, IDeepCloneable<CDOTAClientMsg_SelectOverworldTokenRewards>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CDOTAClientMsg\_SelectOverworldTokenRewards](Divine.Protobufs.Dota2.CDOTAClientMsg\_SelectOverworldTokenRewards.md)

#### Implements

IMessage<CDOTAClientMsg\_SelectOverworldTokenRewards\>, 
[IEquatable<CDOTAClientMsg\_SelectOverworldTokenRewards\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CDOTAClientMsg\_SelectOverworldTokenRewards\>, 
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
[EnumerableExtensions.In<CDOTAClientMsg\_SelectOverworldTokenRewards\>\(CDOTAClientMsg\_SelectOverworldTokenRewards, params CDOTAClientMsg\_SelectOverworldTokenRewards\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards__ctor"></a> CDOTAClientMsg\_SelectOverworldTokenRewards\(\)

```csharp
public CDOTAClientMsg_SelectOverworldTokenRewards()
```

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards__ctor_Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_"></a> CDOTAClientMsg\_SelectOverworldTokenRewards\(CDOTAClientMsg\_SelectOverworldTokenRewards\)

```csharp
public CDOTAClientMsg_SelectOverworldTokenRewards(CDOTAClientMsg_SelectOverworldTokenRewards other)
```

#### Parameters

`other` [CDOTAClientMsg\_SelectOverworldTokenRewards](Divine.Protobufs.Dota2.CDOTAClientMsg\_SelectOverworldTokenRewards.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_TokenIdsFieldNumber"></a> TokenIdsFieldNumber

```csharp
public const int TokenIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_Parser"></a> Parser

```csharp
public static MessageParser<CDOTAClientMsg_SelectOverworldTokenRewards> Parser { get; }
```

#### Property Value

 MessageParser<[CDOTAClientMsg\_SelectOverworldTokenRewards](Divine.Protobufs.Dota2.CDOTAClientMsg\_SelectOverworldTokenRewards.md)\>

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_TokenIds"></a> TokenIds

```csharp
public RepeatedField<uint> TokenIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_Clone"></a> Clone\(\)

```csharp
public CDOTAClientMsg_SelectOverworldTokenRewards Clone()
```

#### Returns

 [CDOTAClientMsg\_SelectOverworldTokenRewards](Divine.Protobufs.Dota2.CDOTAClientMsg\_SelectOverworldTokenRewards.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_Equals_Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_"></a> Equals\(CDOTAClientMsg\_SelectOverworldTokenRewards\)

```csharp
public bool Equals(CDOTAClientMsg_SelectOverworldTokenRewards other)
```

#### Parameters

`other` [CDOTAClientMsg\_SelectOverworldTokenRewards](Divine.Protobufs.Dota2.CDOTAClientMsg\_SelectOverworldTokenRewards.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_MergeFrom_Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_"></a> MergeFrom\(CDOTAClientMsg\_SelectOverworldTokenRewards\)

```csharp
public void MergeFrom(CDOTAClientMsg_SelectOverworldTokenRewards other)
```

#### Parameters

`other` [CDOTAClientMsg\_SelectOverworldTokenRewards](Divine.Protobufs.Dota2.CDOTAClientMsg\_SelectOverworldTokenRewards.md)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CDOTAClientMsg_SelectOverworldTokenRewards_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

