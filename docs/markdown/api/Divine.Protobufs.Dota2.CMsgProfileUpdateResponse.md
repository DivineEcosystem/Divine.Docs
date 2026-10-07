# <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse"></a> Class CMsgProfileUpdateResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgProfileUpdateResponse : IMessage<CMsgProfileUpdateResponse>, IEquatable<CMsgProfileUpdateResponse>, IDeepCloneable<CMsgProfileUpdateResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md)

#### Implements

IMessage<CMsgProfileUpdateResponse\>, 
[IEquatable<CMsgProfileUpdateResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgProfileUpdateResponse\>, 
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
[EnumerableExtensions.In<CMsgProfileUpdateResponse\>\(CMsgProfileUpdateResponse, params CMsgProfileUpdateResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse__ctor"></a> CMsgProfileUpdateResponse\(\)

```csharp
public CMsgProfileUpdateResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse__ctor_Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_"></a> CMsgProfileUpdateResponse\(CMsgProfileUpdateResponse\)

```csharp
public CMsgProfileUpdateResponse(CMsgProfileUpdateResponse other)
```

#### Parameters

`other` [CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgProfileUpdateResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_Result"></a> Result

```csharp
public CMsgProfileUpdateResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_Clone"></a> Clone\(\)

```csharp
public CMsgProfileUpdateResponse Clone()
```

#### Returns

 [CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_Equals_Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_"></a> Equals\(CMsgProfileUpdateResponse\)

```csharp
public bool Equals(CMsgProfileUpdateResponse other)
```

#### Parameters

`other` [CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_"></a> MergeFrom\(CMsgProfileUpdateResponse\)

```csharp
public void MergeFrom(CMsgProfileUpdateResponse other)
```

#### Parameters

`other` [CMsgProfileUpdateResponse](Divine.Protobufs.Dota2.CMsgProfileUpdateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgProfileUpdateResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

