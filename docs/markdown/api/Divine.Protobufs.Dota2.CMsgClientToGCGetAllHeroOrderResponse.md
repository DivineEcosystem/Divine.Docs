# <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse"></a> Class CMsgClientToGCGetAllHeroOrderResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCGetAllHeroOrderResponse : IMessage<CMsgClientToGCGetAllHeroOrderResponse>, IEquatable<CMsgClientToGCGetAllHeroOrderResponse>, IDeepCloneable<CMsgClientToGCGetAllHeroOrderResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCGetAllHeroOrderResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroOrderResponse.md)

#### Implements

IMessage<CMsgClientToGCGetAllHeroOrderResponse\>, 
[IEquatable<CMsgClientToGCGetAllHeroOrderResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCGetAllHeroOrderResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCGetAllHeroOrderResponse\>\(CMsgClientToGCGetAllHeroOrderResponse, params CMsgClientToGCGetAllHeroOrderResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse__ctor"></a> CMsgClientToGCGetAllHeroOrderResponse\(\)

```csharp
public CMsgClientToGCGetAllHeroOrderResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_"></a> CMsgClientToGCGetAllHeroOrderResponse\(CMsgClientToGCGetAllHeroOrderResponse\)

```csharp
public CMsgClientToGCGetAllHeroOrderResponse(CMsgClientToGCGetAllHeroOrderResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAllHeroOrderResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroOrderResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_HeroIdsFieldNumber"></a> HeroIdsFieldNumber

```csharp
public const int HeroIdsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_HeroIds"></a> HeroIds

```csharp
public RepeatedField<int> HeroIds { get; }
```

#### Property Value

 RepeatedField<[int](https://learn.microsoft.com/dotnet/api/system.int32)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCGetAllHeroOrderResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCGetAllHeroOrderResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroOrderResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCGetAllHeroOrderResponse Clone()
```

#### Returns

 [CMsgClientToGCGetAllHeroOrderResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroOrderResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_"></a> Equals\(CMsgClientToGCGetAllHeroOrderResponse\)

```csharp
public bool Equals(CMsgClientToGCGetAllHeroOrderResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAllHeroOrderResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroOrderResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_"></a> MergeFrom\(CMsgClientToGCGetAllHeroOrderResponse\)

```csharp
public void MergeFrom(CMsgClientToGCGetAllHeroOrderResponse other)
```

#### Parameters

`other` [CMsgClientToGCGetAllHeroOrderResponse](Divine.Protobufs.Dota2.CMsgClientToGCGetAllHeroOrderResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCGetAllHeroOrderResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

