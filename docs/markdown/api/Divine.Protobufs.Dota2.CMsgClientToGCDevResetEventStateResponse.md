# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse"></a> Class CMsgClientToGCDevResetEventStateResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevResetEventStateResponse : IMessage<CMsgClientToGCDevResetEventStateResponse>, IEquatable<CMsgClientToGCDevResetEventStateResponse>, IDeepCloneable<CMsgClientToGCDevResetEventStateResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md)

#### Implements

IMessage<CMsgClientToGCDevResetEventStateResponse\>, 
[IEquatable<CMsgClientToGCDevResetEventStateResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevResetEventStateResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevResetEventStateResponse\>\(CMsgClientToGCDevResetEventStateResponse, params CMsgClientToGCDevResetEventStateResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse__ctor"></a> CMsgClientToGCDevResetEventStateResponse\(\)

```csharp
public CMsgClientToGCDevResetEventStateResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_"></a> CMsgClientToGCDevResetEventStateResponse\(CMsgClientToGCDevResetEventStateResponse\)

```csharp
public CMsgClientToGCDevResetEventStateResponse(CMsgClientToGCDevResetEventStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevResetEventStateResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_Result"></a> Result

```csharp
public CMsgClientToGCDevResetEventStateResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevResetEventStateResponse Clone()
```

#### Returns

 [CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_"></a> Equals\(CMsgClientToGCDevResetEventStateResponse\)

```csharp
public bool Equals(CMsgClientToGCDevResetEventStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_"></a> MergeFrom\(CMsgClientToGCDevResetEventStateResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDevResetEventStateResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventStateResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventStateResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventStateResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

