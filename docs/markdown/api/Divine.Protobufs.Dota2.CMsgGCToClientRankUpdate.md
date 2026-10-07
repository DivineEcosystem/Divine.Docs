# <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate"></a> Class CMsgGCToClientRankUpdate

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCToClientRankUpdate : IMessage<CMsgGCToClientRankUpdate>, IEquatable<CMsgGCToClientRankUpdate>, IDeepCloneable<CMsgGCToClientRankUpdate>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCToClientRankUpdate](Divine.Protobufs.Dota2.CMsgGCToClientRankUpdate.md)

#### Implements

IMessage<CMsgGCToClientRankUpdate\>, 
[IEquatable<CMsgGCToClientRankUpdate\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCToClientRankUpdate\>, 
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
[EnumerableExtensions.In<CMsgGCToClientRankUpdate\>\(CMsgGCToClientRankUpdate, params CMsgGCToClientRankUpdate\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate__ctor"></a> CMsgGCToClientRankUpdate\(\)

```csharp
public CMsgGCToClientRankUpdate()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate__ctor_Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_"></a> CMsgGCToClientRankUpdate\(CMsgGCToClientRankUpdate\)

```csharp
public CMsgGCToClientRankUpdate(CMsgGCToClientRankUpdate other)
```

#### Parameters

`other` [CMsgGCToClientRankUpdate](Divine.Protobufs.Dota2.CMsgGCToClientRankUpdate.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_RankInfoFieldNumber"></a> RankInfoFieldNumber

```csharp
public const int RankInfoFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_RankTypeFieldNumber"></a> RankTypeFieldNumber

```csharp
public const int RankTypeFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_HasRankType"></a> HasRankType

```csharp
public bool HasRankType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCToClientRankUpdate> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCToClientRankUpdate](Divine.Protobufs.Dota2.CMsgGCToClientRankUpdate.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_RankInfo"></a> RankInfo

```csharp
public CMsgGCToClientRankResponse RankInfo { get; set; }
```

#### Property Value

 [CMsgGCToClientRankResponse](Divine.Protobufs.Dota2.CMsgGCToClientRankResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_RankType"></a> RankType

```csharp
public ERankType RankType { get; set; }
```

#### Property Value

 [ERankType](Divine.Protobufs.Dota2.ERankType.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_ClearRankType"></a> ClearRankType\(\)

```csharp
public void ClearRankType()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_Clone"></a> Clone\(\)

```csharp
public CMsgGCToClientRankUpdate Clone()
```

#### Returns

 [CMsgGCToClientRankUpdate](Divine.Protobufs.Dota2.CMsgGCToClientRankUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_Equals_Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_"></a> Equals\(CMsgGCToClientRankUpdate\)

```csharp
public bool Equals(CMsgGCToClientRankUpdate other)
```

#### Parameters

`other` [CMsgGCToClientRankUpdate](Divine.Protobufs.Dota2.CMsgGCToClientRankUpdate.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_MergeFrom_Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_"></a> MergeFrom\(CMsgGCToClientRankUpdate\)

```csharp
public void MergeFrom(CMsgGCToClientRankUpdate other)
```

#### Parameters

`other` [CMsgGCToClientRankUpdate](Divine.Protobufs.Dota2.CMsgGCToClientRankUpdate.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCToClientRankUpdate_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

