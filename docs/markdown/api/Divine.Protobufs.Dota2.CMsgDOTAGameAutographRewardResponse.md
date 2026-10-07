# <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse"></a> Class CMsgDOTAGameAutographRewardResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAGameAutographRewardResponse : IMessage<CMsgDOTAGameAutographRewardResponse>, IEquatable<CMsgDOTAGameAutographRewardResponse>, IDeepCloneable<CMsgDOTAGameAutographRewardResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md)

#### Implements

IMessage<CMsgDOTAGameAutographRewardResponse\>, 
[IEquatable<CMsgDOTAGameAutographRewardResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAGameAutographRewardResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAGameAutographRewardResponse\>\(CMsgDOTAGameAutographRewardResponse, params CMsgDOTAGameAutographRewardResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse__ctor"></a> CMsgDOTAGameAutographRewardResponse\(\)

```csharp
public CMsgDOTAGameAutographRewardResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_"></a> CMsgDOTAGameAutographRewardResponse\(CMsgDOTAGameAutographRewardResponse\)

```csharp
public CMsgDOTAGameAutographRewardResponse(CMsgDOTAGameAutographRewardResponse other)
```

#### Parameters

`other` [CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAGameAutographRewardResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_Result"></a> Result

```csharp
public CMsgDOTAGameAutographRewardResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAGameAutographRewardResponse Clone()
```

#### Returns

 [CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_"></a> Equals\(CMsgDOTAGameAutographRewardResponse\)

```csharp
public bool Equals(CMsgDOTAGameAutographRewardResponse other)
```

#### Parameters

`other` [CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_"></a> MergeFrom\(CMsgDOTAGameAutographRewardResponse\)

```csharp
public void MergeFrom(CMsgDOTAGameAutographRewardResponse other)
```

#### Parameters

`other` [CMsgDOTAGameAutographRewardResponse](Divine.Protobufs.Dota2.CMsgDOTAGameAutographRewardResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAGameAutographRewardResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

