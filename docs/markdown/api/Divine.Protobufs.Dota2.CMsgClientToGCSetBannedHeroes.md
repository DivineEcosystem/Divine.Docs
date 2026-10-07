# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes"></a> Class CMsgClientToGCSetBannedHeroes

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetBannedHeroes : IMessage<CMsgClientToGCSetBannedHeroes>, IEquatable<CMsgClientToGCSetBannedHeroes>, IDeepCloneable<CMsgClientToGCSetBannedHeroes>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetBannedHeroes](Divine.Protobufs.Dota2.CMsgClientToGCSetBannedHeroes.md)

#### Implements

IMessage<CMsgClientToGCSetBannedHeroes\>, 
[IEquatable<CMsgClientToGCSetBannedHeroes\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetBannedHeroes\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetBannedHeroes\>\(CMsgClientToGCSetBannedHeroes, params CMsgClientToGCSetBannedHeroes\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes__ctor"></a> CMsgClientToGCSetBannedHeroes\(\)

```csharp
public CMsgClientToGCSetBannedHeroes()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_"></a> CMsgClientToGCSetBannedHeroes\(CMsgClientToGCSetBannedHeroes\)

```csharp
public CMsgClientToGCSetBannedHeroes(CMsgClientToGCSetBannedHeroes other)
```

#### Parameters

`other` [CMsgClientToGCSetBannedHeroes](Divine.Protobufs.Dota2.CMsgClientToGCSetBannedHeroes.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_BannedHeroIdsFieldNumber"></a> BannedHeroIdsFieldNumber

```csharp
public const int BannedHeroIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_BannedHeroIds"></a> BannedHeroIds

```csharp
public RepeatedField<int> BannedHeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetBannedHeroes> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetBannedHeroes](Divine.Protobufs.Dota2.CMsgClientToGCSetBannedHeroes.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetBannedHeroes Clone()
```

#### Returns

 [CMsgClientToGCSetBannedHeroes](Divine.Protobufs.Dota2.CMsgClientToGCSetBannedHeroes.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_"></a> Equals\(CMsgClientToGCSetBannedHeroes\)

```csharp
public bool Equals(CMsgClientToGCSetBannedHeroes other)
```

#### Parameters

`other` [CMsgClientToGCSetBannedHeroes](Divine.Protobufs.Dota2.CMsgClientToGCSetBannedHeroes.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_"></a> MergeFrom\(CMsgClientToGCSetBannedHeroes\)

```csharp
public void MergeFrom(CMsgClientToGCSetBannedHeroes other)
```

#### Parameters

`other` [CMsgClientToGCSetBannedHeroes](Divine.Protobufs.Dota2.CMsgClientToGCSetBannedHeroes.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetBannedHeroes_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

