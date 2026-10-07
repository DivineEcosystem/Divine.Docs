# <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse"></a> Class CMsgClientToGCChinaSSAURLResponse

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCChinaSSAURLResponse : IMessage<CMsgClientToGCChinaSSAURLResponse>, IEquatable<CMsgClientToGCChinaSSAURLResponse>, IDeepCloneable<CMsgClientToGCChinaSSAURLResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCChinaSSAURLResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAURLResponse.md)

#### Implements

IMessage<CMsgClientToGCChinaSSAURLResponse\>, 
[IEquatable<CMsgClientToGCChinaSSAURLResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCChinaSSAURLResponse\>, 
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
[EnumerableExtensions.In<CMsgClientToGCChinaSSAURLResponse\>\(CMsgClientToGCChinaSSAURLResponse, params CMsgClientToGCChinaSSAURLResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse__ctor"></a> CMsgClientToGCChinaSSAURLResponse\(\)

```csharp
public CMsgClientToGCChinaSSAURLResponse()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse__ctor_Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_"></a> CMsgClientToGCChinaSSAURLResponse\(CMsgClientToGCChinaSSAURLResponse\)

```csharp
public CMsgClientToGCChinaSSAURLResponse(CMsgClientToGCChinaSSAURLResponse other)
```

#### Parameters

`other` [CMsgClientToGCChinaSSAURLResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAURLResponse.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_AgreementUrlFieldNumber"></a> AgreementUrlFieldNumber

```csharp
public const int AgreementUrlFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_AgreementUrl"></a> AgreementUrl

```csharp
public string AgreementUrl { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_HasAgreementUrl"></a> HasAgreementUrl

```csharp
public bool HasAgreementUrl { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCChinaSSAURLResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCChinaSSAURLResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAURLResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_ClearAgreementUrl"></a> ClearAgreementUrl\(\)

```csharp
public void ClearAgreementUrl()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCChinaSSAURLResponse Clone()
```

#### Returns

 [CMsgClientToGCChinaSSAURLResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAURLResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_Equals_Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_"></a> Equals\(CMsgClientToGCChinaSSAURLResponse\)

```csharp
public bool Equals(CMsgClientToGCChinaSSAURLResponse other)
```

#### Parameters

`other` [CMsgClientToGCChinaSSAURLResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAURLResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_"></a> MergeFrom\(CMsgClientToGCChinaSSAURLResponse\)

```csharp
public void MergeFrom(CMsgClientToGCChinaSSAURLResponse other)
```

#### Parameters

`other` [CMsgClientToGCChinaSSAURLResponse](Divine.Protobufs.Dota2.CMsgClientToGCChinaSSAURLResponse.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCChinaSSAURLResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

