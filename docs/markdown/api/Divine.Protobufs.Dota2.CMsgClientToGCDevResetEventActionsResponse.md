# <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse"></a> Class CMsgClientToGCDevResetEventActionsResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCDevResetEventActionsResponse : IMessage<CMsgClientToGCDevResetEventActionsResponse>, IEquatable<CMsgClientToGCDevResetEventActionsResponse>, IDeepCloneable<CMsgClientToGCDevResetEventActionsResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md)

#### Implements

IMessage<CMsgClientToGCDevResetEventActionsResponse\>, 
[IEquatable<CMsgClientToGCDevResetEventActionsResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCDevResetEventActionsResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCDevResetEventActionsResponse\>\(CMsgClientToGCDevResetEventActionsResponse, params CMsgClientToGCDevResetEventActionsResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse__ctor"></a> CMsgClientToGCDevResetEventActionsResponse\(\)

```csharp
public CMsgClientToGCDevResetEventActionsResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_"></a> CMsgClientToGCDevResetEventActionsResponse\(CMsgClientToGCDevResetEventActionsResponse\)

```csharp
public CMsgClientToGCDevResetEventActionsResponse(CMsgClientToGCDevResetEventActionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCDevResetEventActionsResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_Result"></a> Result

```csharp
public CMsgClientToGCDevResetEventActionsResponse.Types.EResponse Result { get; set; }
```

#### Property Value

 [CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.Types.md).[EResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.Types.EResponse.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCDevResetEventActionsResponse Clone()
```

#### Returns

 [CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_"></a> Equals\(CMsgClientToGCDevResetEventActionsResponse\)

```csharp
public bool Equals(CMsgClientToGCDevResetEventActionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_"></a> MergeFrom\(CMsgClientToGCDevResetEventActionsResponse\)

```csharp
public void MergeFrom(CMsgClientToGCDevResetEventActionsResponse other)
```

#### Parameters

`other` [CMsgClientToGCDevResetEventActionsResponse](Divine.Protobufs.Dota2.CMsgClientToGCDevResetEventActionsResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCDevResetEventActionsResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

