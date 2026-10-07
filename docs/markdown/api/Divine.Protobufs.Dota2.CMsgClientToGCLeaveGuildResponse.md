# <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse"></a> Class CMsgClientToGCLeaveGuildResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCLeaveGuildResponse : IMessage<CMsgClientToGCLeaveGuildResponse>, IEquatable<CMsgClientToGCLeaveGuildResponse>, IDeepCloneable<CMsgClientToGCLeaveGuildResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md)

#### Implements

IMessage<CMsgClientToGCLeaveGuildResponse\>, 
[IEquatable<CMsgClientToGCLeaveGuildResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCLeaveGuildResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCLeaveGuildResponse\>\(CMsgClientToGCLeaveGuildResponse, params CMsgClientToGCLeaveGuildResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse__ctor"></a> CMsgClientToGCLeaveGuildResponse\(\)

```csharp
public CMsgClientToGCLeaveGuildResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_"></a> CMsgClientToGCLeaveGuildResponse\(CMsgClientToGCLeaveGuildResponse\)

```csharp
public CMsgClientToGCLeaveGuildResponse(CMsgClientToGCLeaveGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCLeaveGuildResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_Result"></a> Result

```csharp
public CMsgClientToGCLeaveGuildResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCLeaveGuildResponse Clone()
```

#### Returns

 [CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_"></a> Equals\(CMsgClientToGCLeaveGuildResponse\)

```csharp
public bool Equals(CMsgClientToGCLeaveGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_"></a> MergeFrom\(CMsgClientToGCLeaveGuildResponse\)

```csharp
public void MergeFrom(CMsgClientToGCLeaveGuildResponse other)
```

#### Parameters

`other` [CMsgClientToGCLeaveGuildResponse](Divine.Protobufs.Dota2.CMsgClientToGCLeaveGuildResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCLeaveGuildResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

