# <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse"></a> Class CMsgClientToGCSetEventActiveSeasonIDResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCSetEventActiveSeasonIDResponse : IMessage<CMsgClientToGCSetEventActiveSeasonIDResponse>, IEquatable<CMsgClientToGCSetEventActiveSeasonIDResponse>, IDeepCloneable<CMsgClientToGCSetEventActiveSeasonIDResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md)

#### Implements

IMessage<CMsgClientToGCSetEventActiveSeasonIDResponse\>, 
[IEquatable<CMsgClientToGCSetEventActiveSeasonIDResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCSetEventActiveSeasonIDResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCSetEventActiveSeasonIDResponse\>\(CMsgClientToGCSetEventActiveSeasonIDResponse, params CMsgClientToGCSetEventActiveSeasonIDResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse__ctor"></a> CMsgClientToGCSetEventActiveSeasonIDResponse\(\)

```csharp
public CMsgClientToGCSetEventActiveSeasonIDResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_"></a> CMsgClientToGCSetEventActiveSeasonIDResponse\(CMsgClientToGCSetEventActiveSeasonIDResponse\)

```csharp
public CMsgClientToGCSetEventActiveSeasonIDResponse(CMsgClientToGCSetEventActiveSeasonIDResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCSetEventActiveSeasonIDResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_Result"></a> Result

```csharp
public CMsgClientToGCSetEventActiveSeasonIDResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCSetEventActiveSeasonIDResponse Clone()
```

#### Returns

 [CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_"></a> Equals\(CMsgClientToGCSetEventActiveSeasonIDResponse\)

```csharp
public bool Equals(CMsgClientToGCSetEventActiveSeasonIDResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_"></a> MergeFrom\(CMsgClientToGCSetEventActiveSeasonIDResponse\)

```csharp
public void MergeFrom(CMsgClientToGCSetEventActiveSeasonIDResponse other)
```

#### Parameters

`other` [CMsgClientToGCSetEventActiveSeasonIDResponse](Divine.Protobufs.Dota2.CMsgClientToGCSetEventActiveSeasonIDResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCSetEventActiveSeasonIDResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

