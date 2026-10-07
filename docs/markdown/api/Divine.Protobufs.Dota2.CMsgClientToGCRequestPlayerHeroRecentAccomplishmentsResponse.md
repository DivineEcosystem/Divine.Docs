# <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse"></a> Class CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse : IMessage<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse>, IEquatable<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse>, IDeepCloneable<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md)

#### Implements

IMessage<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\>, 
[IEquatable<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\>\(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse, params CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse__ctor"></a> CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\(\)

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_"></a> CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\)

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_HeroAccomplishmentsFieldNumber"></a> HeroAccomplishmentsFieldNumber

```csharp
public const int HeroAccomplishmentsFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_HeroAccomplishments"></a> HeroAccomplishments

```csharp
public CMsgPlayerHeroRecentAccomplishments HeroAccomplishments { get; set; }
```

#### Property Value

 [CMsgPlayerHeroRecentAccomplishments](Divine.Protobufs.Dota2.CMsgPlayerHeroRecentAccomplishments.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_Result"></a> Result

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse Clone()
```

#### Returns

 [CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_"></a> Equals\(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\)

```csharp
public bool Equals(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_"></a> MergeFrom\(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse other)
```

#### Parameters

`other` [CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse](Divine.Protobufs.Dota2.CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCRequestPlayerHeroRecentAccomplishmentsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

