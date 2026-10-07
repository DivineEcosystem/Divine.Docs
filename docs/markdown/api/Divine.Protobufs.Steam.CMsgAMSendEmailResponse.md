# <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse"></a> Class CMsgAMSendEmailResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMSendEmailResponse : IMessage<CMsgAMSendEmailResponse>, IEquatable<CMsgAMSendEmailResponse>, IDeepCloneable<CMsgAMSendEmailResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMSendEmailResponse](Divine.Protobufs.Steam.CMsgAMSendEmailResponse.md)

#### Implements

IMessage<CMsgAMSendEmailResponse\>, 
[IEquatable<CMsgAMSendEmailResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMSendEmailResponse\>, 
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
[EnumerableExtensions.In<CMsgAMSendEmailResponse\>\(CMsgAMSendEmailResponse, params CMsgAMSendEmailResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse__ctor"></a> CMsgAMSendEmailResponse\(\)

```csharp
public CMsgAMSendEmailResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse__ctor_Divine_Protobufs_Steam_CMsgAMSendEmailResponse_"></a> CMsgAMSendEmailResponse\(CMsgAMSendEmailResponse\)

```csharp
public CMsgAMSendEmailResponse(CMsgAMSendEmailResponse other)
```

#### Parameters

`other` [CMsgAMSendEmailResponse](Divine.Protobufs.Steam.CMsgAMSendEmailResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_Eresult"></a> Eresult

```csharp
public uint Eresult { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMSendEmailResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMSendEmailResponse](Divine.Protobufs.Steam.CMsgAMSendEmailResponse.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_Clone"></a> Clone\(\)

```csharp
public CMsgAMSendEmailResponse Clone()
```

#### Returns

 [CMsgAMSendEmailResponse](Divine.Protobufs.Steam.CMsgAMSendEmailResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_Equals_Divine_Protobufs_Steam_CMsgAMSendEmailResponse_"></a> Equals\(CMsgAMSendEmailResponse\)

```csharp
public bool Equals(CMsgAMSendEmailResponse other)
```

#### Parameters

`other` [CMsgAMSendEmailResponse](Divine.Protobufs.Steam.CMsgAMSendEmailResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_MergeFrom_Divine_Protobufs_Steam_CMsgAMSendEmailResponse_"></a> MergeFrom\(CMsgAMSendEmailResponse\)

```csharp
public void MergeFrom(CMsgAMSendEmailResponse other)
```

#### Parameters

`other` [CMsgAMSendEmailResponse](Divine.Protobufs.Steam.CMsgAMSendEmailResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMSendEmailResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

