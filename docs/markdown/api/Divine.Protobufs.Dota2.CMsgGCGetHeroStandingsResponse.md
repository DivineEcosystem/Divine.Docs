# <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse"></a> Class CMsgGCGetHeroStandingsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGCGetHeroStandingsResponse : IMessage<CMsgGCGetHeroStandingsResponse>, IEquatable<CMsgGCGetHeroStandingsResponse>, IDeepCloneable<CMsgGCGetHeroStandingsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md)

#### Implements

IMessage<CMsgGCGetHeroStandingsResponse\>, 
[IEquatable<CMsgGCGetHeroStandingsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGCGetHeroStandingsResponse\>, 
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
[EnumerableExtensions.In<CMsgGCGetHeroStandingsResponse\>\(CMsgGCGetHeroStandingsResponse, params CMsgGCGetHeroStandingsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse__ctor"></a> CMsgGCGetHeroStandingsResponse\(\)

```csharp
public CMsgGCGetHeroStandingsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse__ctor_Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_"></a> CMsgGCGetHeroStandingsResponse\(CMsgGCGetHeroStandingsResponse\)

```csharp
public CMsgGCGetHeroStandingsResponse(CMsgGCGetHeroStandingsResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_StandingsFieldNumber"></a> StandingsFieldNumber

```csharp
public const int StandingsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGCGetHeroStandingsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_Standings"></a> Standings

```csharp
public RepeatedField<CMsgGCGetHeroStandingsResponse.Types.Hero> Standings { get; }
```

#### Property Value

 RepeatedField<[CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.Types.md).[Hero](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.Types.Hero.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgGCGetHeroStandingsResponse Clone()
```

#### Returns

 [CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_Equals_Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_"></a> Equals\(CMsgGCGetHeroStandingsResponse\)

```csharp
public bool Equals(CMsgGCGetHeroStandingsResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_"></a> MergeFrom\(CMsgGCGetHeroStandingsResponse\)

```csharp
public void MergeFrom(CMsgGCGetHeroStandingsResponse other)
```

#### Parameters

`other` [CMsgGCGetHeroStandingsResponse](Divine.Protobufs.Dota2.CMsgGCGetHeroStandingsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGCGetHeroStandingsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

