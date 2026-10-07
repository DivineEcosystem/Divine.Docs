# <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse"></a> Class CMsgEventTipsSummaryResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgEventTipsSummaryResponse : IMessage<CMsgEventTipsSummaryResponse>, IEquatable<CMsgEventTipsSummaryResponse>, IDeepCloneable<CMsgEventTipsSummaryResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md)

#### Implements

IMessage<CMsgEventTipsSummaryResponse\>, 
[IEquatable<CMsgEventTipsSummaryResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgEventTipsSummaryResponse\>, 
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
[EnumerableExtensions.In<CMsgEventTipsSummaryResponse\>\(CMsgEventTipsSummaryResponse, params CMsgEventTipsSummaryResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse__ctor"></a> CMsgEventTipsSummaryResponse\(\)

```csharp
public CMsgEventTipsSummaryResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse__ctor_Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_"></a> CMsgEventTipsSummaryResponse\(CMsgEventTipsSummaryResponse\)

```csharp
public CMsgEventTipsSummaryResponse(CMsgEventTipsSummaryResponse other)
```

#### Parameters

`other` [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_TipsReceivedFieldNumber"></a> TipsReceivedFieldNumber

```csharp
public const int TipsReceivedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgEventTipsSummaryResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Result"></a> Result

```csharp
public bool Result { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_TipsReceived"></a> TipsReceived

```csharp
public RepeatedField<CMsgEventTipsSummaryResponse.Types.Tipper> TipsReceived { get; }
```

#### Property Value

 RepeatedField<[CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md).[Types](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.md).[Tipper](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.Types.Tipper.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Clone"></a> Clone\(\)

```csharp
public CMsgEventTipsSummaryResponse Clone()
```

#### Returns

 [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_Equals_Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_"></a> Equals\(CMsgEventTipsSummaryResponse\)

```csharp
public bool Equals(CMsgEventTipsSummaryResponse other)
```

#### Parameters

`other` [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_"></a> MergeFrom\(CMsgEventTipsSummaryResponse\)

```csharp
public void MergeFrom(CMsgEventTipsSummaryResponse other)
```

#### Parameters

`other` [CMsgEventTipsSummaryResponse](Divine.Protobufs.Dota2.CMsgEventTipsSummaryResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgEventTipsSummaryResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

