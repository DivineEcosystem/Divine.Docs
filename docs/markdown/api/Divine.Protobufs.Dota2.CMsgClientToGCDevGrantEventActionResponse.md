# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse"></a> Class CMsgClientToGCDevGrantEventActionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevGrantEventActionResponse : IMessage<CMsgClientToGCDevGrantEventActionResponse>, IEquatable<CMsgClientToGCDevGrantEventActionResponse>, IDeepCloneable<CMsgClientToGCDevGrantEventActionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md)

#### Implements

IMessage<CMsgClientToGCDevGrantEventActionResponse\>, 
[IEquatable<CMsgClientToGCDevGrantEventActionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevGrantEventActionResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevGrantEventActionResponse\>\(CMsgClientToGCDevGrantEventActionResponse, params CMsgClientToGCDevGrantEventActionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse__ctor"></a> CMsgClientToGCDevGrantEventActionResponse\(\)

```csharp
public CMsgClientToGCDevGrantEventActionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_"></a> CMsgClientToGCDevGrantEventActionResponse\(CMsgClientToGCDevGrantEventActionResponse\)

```csharp
public CMsgClientToGCDevGrantEventActionResponse(CMsgClientToGCDevGrantEventActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevGrantEventActionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_Result"></a> Result

```csharp
public CMsgClientToGCDevGrantEventActionResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevGrantEventActionResponse Clone()
```

#### Returns

 [CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_"></a> Equals\(CMsgClientToGCDevGrantEventActionResponse\)

```csharp
public bool Equals(CMsgClientToGCDevGrantEventActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_"></a> MergeFrom\(CMsgClientToGCDevGrantEventActionResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDevGrantEventActionResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevGrantEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevGrantEventActionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

