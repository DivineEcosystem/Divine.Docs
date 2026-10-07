# <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources"></a> Class CMsgServerToGCRequestBatchPlayerResources

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCRequestBatchPlayerResources : IMessage<CMsgServerToGCRequestBatchPlayerResources>, IEquatable<CMsgServerToGCRequestBatchPlayerResources>, IDeepCloneable<CMsgServerToGCRequestBatchPlayerResources>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCRequestBatchPlayerResources](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResources.md)

#### Implements

IMessage<CMsgServerToGCRequestBatchPlayerResources\>, 
[IEquatable<CMsgServerToGCRequestBatchPlayerResources\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCRequestBatchPlayerResources\>, 
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
[EnumerableExtensions.In<CMsgServerToGCRequestBatchPlayerResources\>\(CMsgServerToGCRequestBatchPlayerResources, params CMsgServerToGCRequestBatchPlayerResources\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources__ctor"></a> CMsgServerToGCRequestBatchPlayerResources\(\)

```csharp
public CMsgServerToGCRequestBatchPlayerResources()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources__ctor_Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_"></a> CMsgServerToGCRequestBatchPlayerResources\(CMsgServerToGCRequestBatchPlayerResources\)

```csharp
public CMsgServerToGCRequestBatchPlayerResources(CMsgServerToGCRequestBatchPlayerResources other)
```

#### Parameters

`other` [CMsgServerToGCRequestBatchPlayerResources](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResources.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_AccountIdsFieldNumber"></a> AccountIdsFieldNumber

```csharp
public const int AccountIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_LobbyTypeFieldNumber"></a> LobbyTypeFieldNumber

```csharp
public const int LobbyTypeFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_RankTypesFieldNumber"></a> RankTypesFieldNumber

```csharp
public const int RankTypesFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_AccountIds"></a> AccountIds

```csharp
public RepeatedField<uint> AccountIds { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_HasLobbyType"></a> HasLobbyType

```csharp
public bool HasLobbyType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_LobbyType"></a> LobbyType

```csharp
public int LobbyType { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCRequestBatchPlayerResources> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCRequestBatchPlayerResources](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResources.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_RankTypes"></a> RankTypes

```csharp
public RepeatedField<uint> RankTypes { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_ClearLobbyType"></a> ClearLobbyType\(\)

```csharp
public void ClearLobbyType()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCRequestBatchPlayerResources Clone()
```

#### Returns

 [CMsgServerToGCRequestBatchPlayerResources](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResources.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_Equals_Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_"></a> Equals\(CMsgServerToGCRequestBatchPlayerResources\)

```csharp
public bool Equals(CMsgServerToGCRequestBatchPlayerResources other)
```

#### Parameters

`other` [CMsgServerToGCRequestBatchPlayerResources](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResources.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_"></a> MergeFrom\(CMsgServerToGCRequestBatchPlayerResources\)

```csharp
public void MergeFrom(CMsgServerToGCRequestBatchPlayerResources other)
```

#### Parameters

`other` [CMsgServerToGCRequestBatchPlayerResources](Divine.Protobufs.Dota2.CMsgServerToGCRequestBatchPlayerResources.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCRequestBatchPlayerResources_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

