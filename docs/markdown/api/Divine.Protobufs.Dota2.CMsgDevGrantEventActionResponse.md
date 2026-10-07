# <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse"></a> Class CMsgDevGrantEventActionResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDevGrantEventActionResponse : IMessage<CMsgDevGrantEventActionResponse>, IEquatable<CMsgDevGrantEventActionResponse>, IDeepCloneable<CMsgDevGrantEventActionResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgDevGrantEventActionResponse.md)

#### Implements

IMessage<CMsgDevGrantEventActionResponse\>, 
[IEquatable<CMsgDevGrantEventActionResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDevGrantEventActionResponse\>, 
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
[EnumerableExtensions.In<CMsgDevGrantEventActionResponse\>\(CMsgDevGrantEventActionResponse, params CMsgDevGrantEventActionResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse__ctor"></a> CMsgDevGrantEventActionResponse\(\)

```csharp
public CMsgDevGrantEventActionResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse__ctor_Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_"></a> CMsgDevGrantEventActionResponse\(CMsgDevGrantEventActionResponse\)

```csharp
public CMsgDevGrantEventActionResponse(CMsgDevGrantEventActionResponse other)
```

#### Parameters

`other` [CMsgDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgDevGrantEventActionResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDevGrantEventActionResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgDevGrantEventActionResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_Result"></a> Result

```csharp
public EDevEventRequestResult Result { get; set; }
```

#### Property Value

 [EDevEventRequestResult](Divine.Protobufs.Dota2.EDevEventRequestResult.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDevGrantEventActionResponse Clone()
```

#### Returns

 [CMsgDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgDevGrantEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_Equals_Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_"></a> Equals\(CMsgDevGrantEventActionResponse\)

```csharp
public bool Equals(CMsgDevGrantEventActionResponse other)
```

#### Parameters

`other` [CMsgDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgDevGrantEventActionResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_"></a> MergeFrom\(CMsgDevGrantEventActionResponse\)

```csharp
public void MergeFrom(CMsgDevGrantEventActionResponse other)
```

#### Parameters

`other` [CMsgDevGrantEventActionResponse](Divine.Protobufs.Dota2.CMsgDevGrantEventActionResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDevGrantEventActionResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

