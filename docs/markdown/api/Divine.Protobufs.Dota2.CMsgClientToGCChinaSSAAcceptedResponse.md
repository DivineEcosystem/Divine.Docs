# <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse"></a> Class CMsgClientToGCChinaSSAAcceptedResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCChinaSSAAcceptedResponse : IMessage<CMsgClientToGCChinaSSAAcceptedResponse>, IEquatable<CMsgClientToGCChinaSSAAcceptedResponse>, IDeepCloneable<CMsgClientToGCChinaSSAAcceptedResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCChinaSSAAcceptedResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAAcceptedResponse.md)

#### Implements

IMessage<CMsgClientToGCChinaSSAAcceptedResponse\>, 
[IEquatable<CMsgClientToGCChinaSSAAcceptedResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCChinaSSAAcceptedResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCChinaSSAAcceptedResponse\>\(CMsgClientToGCChinaSSAAcceptedResponse, params CMsgClientToGCChinaSSAAcceptedResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse__ctor"></a> CMsgClientToGCChinaSSAAcceptedResponse\(\)

```csharp
public CMsgClientToGCChinaSSAAcceptedResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_"></a> CMsgClientToGCChinaSSAAcceptedResponse\(CMsgClientToGCChinaSSAAcceptedResponse\)

```csharp
public CMsgClientToGCChinaSSAAcceptedResponse(CMsgClientToGCChinaSSAAcceptedResponse other)
```

#### Parameters

`other` [CMsgClientToGCChinaSSAAcceptedResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAAcceptedResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_AgreementAcceptedFieldNumber"></a> AgreementAcceptedFieldNumber

```csharp
public const int AgreementAcceptedFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_AgreementAccepted"></a> AgreementAccepted

```csharp
public bool AgreementAccepted { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_HasAgreementAccepted"></a> HasAgreementAccepted

```csharp
public bool HasAgreementAccepted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCChinaSSAAcceptedResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCChinaSSAAcceptedResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAAcceptedResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_ClearAgreementAccepted"></a> ClearAgreementAccepted\(\)

```csharp
public void ClearAgreementAccepted()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCChinaSSAAcceptedResponse Clone()
```

#### Returns

 [CMsgClientToGCChinaSSAAcceptedResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAAcceptedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_"></a> Equals\(CMsgClientToGCChinaSSAAcceptedResponse\)

```csharp
public bool Equals(CMsgClientToGCChinaSSAAcceptedResponse other)
```

#### Parameters

`other` [CMsgClientToGCChinaSSAAcceptedResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAAcceptedResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_"></a> MergeFrom\(CMsgClientToGCChinaSSAAcceptedResponse\)

```csharp
public void MergeFrom(CMsgClientToGCChinaSSAAcceptedResponse other)
```

#### Parameters

`other` [CMsgClientToGCChinaSSAAcceptedResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAAcceptedResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAAcceptedResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

