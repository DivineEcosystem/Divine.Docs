# <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse"></a> Class CMsgDOTAAnchorPhoneNumberResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAAnchorPhoneNumberResponse : IMessage<CMsgDOTAAnchorPhoneNumberResponse>, IEquatable<CMsgDOTAAnchorPhoneNumberResponse>, IDeepCloneable<CMsgDOTAAnchorPhoneNumberResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md)

#### Implements

IMessage<CMsgDOTAAnchorPhoneNumberResponse\>, 
[IEquatable<CMsgDOTAAnchorPhoneNumberResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAAnchorPhoneNumberResponse\>, 
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
[EnumerableExtensions.In<CMsgDOTAAnchorPhoneNumberResponse\>\(CMsgDOTAAnchorPhoneNumberResponse, params CMsgDOTAAnchorPhoneNumberResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse__ctor"></a> CMsgDOTAAnchorPhoneNumberResponse\(\)

```csharp
public CMsgDOTAAnchorPhoneNumberResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse__ctor_Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_"></a> CMsgDOTAAnchorPhoneNumberResponse\(CMsgDOTAAnchorPhoneNumberResponse\)

```csharp
public CMsgDOTAAnchorPhoneNumberResponse(CMsgDOTAAnchorPhoneNumberResponse other)
```

#### Parameters

`other` [CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAAnchorPhoneNumberResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_Result"></a> Result

```csharp
public CMsgDOTAAnchorPhoneNumberResponse.Types.Result Result { get; set; }
```

#### Property Value

 [CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.Types.md).[Result](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.Types.Result.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAAnchorPhoneNumberResponse Clone()
```

#### Returns

 [CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_Equals_Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_"></a> Equals\(CMsgDOTAAnchorPhoneNumberResponse\)

```csharp
public bool Equals(CMsgDOTAAnchorPhoneNumberResponse other)
```

#### Parameters

`other` [CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_"></a> MergeFrom\(CMsgDOTAAnchorPhoneNumberResponse\)

```csharp
public void MergeFrom(CMsgDOTAAnchorPhoneNumberResponse other)
```

#### Parameters

`other` [CMsgDOTAAnchorPhoneNumberResponse](Divine.Protobufs.Dota2.CMsgDOTAAnchorPhoneNumberResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAAnchorPhoneNumberResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

