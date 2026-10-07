# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers"></a> Class CMsgClientToGCGetFavoritePlayers

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetFavoritePlayers : IMessage<CMsgClientToGCGetFavoritePlayers>, IEquatable<CMsgClientToGCGetFavoritePlayers>, IDeepCloneable<CMsgClientToGCGetFavoritePlayers>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetFavoritePlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFavoritePlayers.md)

#### Implements

IMessage<CMsgClientToGCGetFavoritePlayers\>, 
[IEquatable<CMsgClientToGCGetFavoritePlayers\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetFavoritePlayers\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetFavoritePlayers\>\(CMsgClientToGCGetFavoritePlayers, params CMsgClientToGCGetFavoritePlayers\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers__ctor"></a> CMsgClientToGCGetFavoritePlayers\(\)

```csharp
public CMsgClientToGCGetFavoritePlayers()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_"></a> CMsgClientToGCGetFavoritePlayers\(CMsgClientToGCGetFavoritePlayers\)

```csharp
public CMsgClientToGCGetFavoritePlayers(CMsgClientToGCGetFavoritePlayers other)
```

#### Parameters

`other` [CMsgClientToGCGetFavoritePlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFavoritePlayers.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_PaginationCountFieldNumber"></a> PaginationCountFieldNumber

```csharp
public const int PaginationCountFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_PaginationKeyFieldNumber"></a> PaginationKeyFieldNumber

```csharp
public const int PaginationKeyFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_HasPaginationCount"></a> HasPaginationCount

```csharp
public bool HasPaginationCount { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_HasPaginationKey"></a> HasPaginationKey

```csharp
public bool HasPaginationKey { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_PaginationCount"></a> PaginationCount

```csharp
public int PaginationCount { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_PaginationKey"></a> PaginationKey

```csharp
public ulong PaginationKey { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetFavoritePlayers> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetFavoritePlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFavoritePlayers.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_ClearPaginationCount"></a> ClearPaginationCount\(\)

```csharp
public void ClearPaginationCount()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_ClearPaginationKey"></a> ClearPaginationKey\(\)

```csharp
public void ClearPaginationKey()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetFavoritePlayers Clone()
```

#### Returns

 [CMsgClientToGCGetFavoritePlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFavoritePlayers.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_"></a> Equals\(CMsgClientToGCGetFavoritePlayers\)

```csharp
public bool Equals(CMsgClientToGCGetFavoritePlayers other)
```

#### Parameters

`other` [CMsgClientToGCGetFavoritePlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFavoritePlayers.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_"></a> MergeFrom\(CMsgClientToGCGetFavoritePlayers\)

```csharp
public void MergeFrom(CMsgClientToGCGetFavoritePlayers other)
```

#### Parameters

`other` [CMsgClientToGCGetFavoritePlayers](Divine.Protobufs.Dota2.CMsgClientToGCGetFavoritePlayers.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetFavoritePlayers_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

