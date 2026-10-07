# <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse"></a> Class CMsgServerToGCGetGuildContractsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgServerToGCGetGuildContractsResponse : IMessage<CMsgServerToGCGetGuildContractsResponse>, IEquatable<CMsgServerToGCGetGuildContractsResponse>, IDeepCloneable<CMsgServerToGCGetGuildContractsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md)

#### Implements

IMessage<CMsgServerToGCGetGuildContractsResponse\>, 
[IEquatable<CMsgServerToGCGetGuildContractsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgServerToGCGetGuildContractsResponse\>, 
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
[EnumerableExtensions.In<CMsgServerToGCGetGuildContractsResponse\>\(CMsgServerToGCGetGuildContractsResponse, params CMsgServerToGCGetGuildContractsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse__ctor"></a> CMsgServerToGCGetGuildContractsResponse\(\)

```csharp
public CMsgServerToGCGetGuildContractsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse__ctor_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_"></a> CMsgServerToGCGetGuildContractsResponse\(CMsgServerToGCGetGuildContractsResponse\)

```csharp
public CMsgServerToGCGetGuildContractsResponse(CMsgServerToGCGetGuildContractsResponse other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_PlayerContractsFieldNumber"></a> PlayerContractsFieldNumber

```csharp
public const int PlayerContractsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgServerToGCGetGuildContractsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_PlayerContracts"></a> PlayerContracts

```csharp
public RepeatedField<CMsgServerToGCGetGuildContractsResponse.Types.Player> PlayerContracts { get; }
```

#### Property Value

 RepeatedField<[CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.md).[Player](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.Types.Player.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgServerToGCGetGuildContractsResponse Clone()
```

#### Returns

 [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_Equals_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_"></a> Equals\(CMsgServerToGCGetGuildContractsResponse\)

```csharp
public bool Equals(CMsgServerToGCGetGuildContractsResponse other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_"></a> MergeFrom\(CMsgServerToGCGetGuildContractsResponse\)

```csharp
public void MergeFrom(CMsgServerToGCGetGuildContractsResponse other)
```

#### Parameters

`other` [CMsgServerToGCGetGuildContractsResponse](Divine.Protobufs.Dota2.CMsgServerToGCGetGuildContractsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgServerToGCGetGuildContractsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

