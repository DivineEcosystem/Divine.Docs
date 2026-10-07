# <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse"></a> Class CMsgPurchaseHeroRandomRelicResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPurchaseHeroRandomRelicResponse : IMessage<CMsgPurchaseHeroRandomRelicResponse>, IEquatable<CMsgPurchaseHeroRandomRelicResponse>, IDeepCloneable<CMsgPurchaseHeroRandomRelicResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPurchaseHeroRandomRelicResponse](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelicResponse.md)

#### Implements

IMessage<CMsgPurchaseHeroRandomRelicResponse\>, 
[IEquatable<CMsgPurchaseHeroRandomRelicResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPurchaseHeroRandomRelicResponse\>, 
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
[EnumerableExtensions.In<CMsgPurchaseHeroRandomRelicResponse\>\(CMsgPurchaseHeroRandomRelicResponse, params CMsgPurchaseHeroRandomRelicResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse__ctor"></a> CMsgPurchaseHeroRandomRelicResponse\(\)

```csharp
public CMsgPurchaseHeroRandomRelicResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse__ctor_Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_"></a> CMsgPurchaseHeroRandomRelicResponse\(CMsgPurchaseHeroRandomRelicResponse\)

```csharp
public CMsgPurchaseHeroRandomRelicResponse(CMsgPurchaseHeroRandomRelicResponse other)
```

#### Parameters

`other` [CMsgPurchaseHeroRandomRelicResponse](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelicResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_KillEaterTypeFieldNumber"></a> KillEaterTypeFieldNumber

```csharp
public const int KillEaterTypeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_HasKillEaterType"></a> HasKillEaterType

```csharp
public bool HasKillEaterType { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_KillEaterType"></a> KillEaterType

```csharp
public uint KillEaterType { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPurchaseHeroRandomRelicResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPurchaseHeroRandomRelicResponse](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelicResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_Result"></a> Result

```csharp
public EPurchaseHeroRelicResult Result { get; set; }
```

#### Property Value

 [EPurchaseHeroRelicResult](Divine.Protobufs.Dota2.EPurchaseHeroRelicResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_ClearKillEaterType"></a> ClearKillEaterType\(\)

```csharp
public void ClearKillEaterType()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_Clone"></a> Clone\(\)

```csharp
public CMsgPurchaseHeroRandomRelicResponse Clone()
```

#### Returns

 [CMsgPurchaseHeroRandomRelicResponse](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelicResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_Equals_Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_"></a> Equals\(CMsgPurchaseHeroRandomRelicResponse\)

```csharp
public bool Equals(CMsgPurchaseHeroRandomRelicResponse other)
```

#### Parameters

`other` [CMsgPurchaseHeroRandomRelicResponse](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelicResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_"></a> MergeFrom\(CMsgPurchaseHeroRandomRelicResponse\)

```csharp
public void MergeFrom(CMsgPurchaseHeroRandomRelicResponse other)
```

#### Parameters

`other` [CMsgPurchaseHeroRandomRelicResponse](Divine.Protobufs.Dota2.CMsgPurchaseHeroRandomRelicResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPurchaseHeroRandomRelicResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

