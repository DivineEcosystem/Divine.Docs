# <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse"></a> Class CMsgAMAddFreeLicenseResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMAddFreeLicenseResponse : IMessage<CMsgAMAddFreeLicenseResponse>, IEquatable<CMsgAMAddFreeLicenseResponse>, IDeepCloneable<CMsgAMAddFreeLicenseResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMAddFreeLicenseResponse](Divine.Protobufs.Steam.CMsgAMAddFreeLicenseResponse.md)

#### Implements

IMessage<CMsgAMAddFreeLicenseResponse\>, 
[IEquatable<CMsgAMAddFreeLicenseResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMAddFreeLicenseResponse\>, 
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
[EnumerableExtensions.In<CMsgAMAddFreeLicenseResponse\>\(CMsgAMAddFreeLicenseResponse, params CMsgAMAddFreeLicenseResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse__ctor"></a> CMsgAMAddFreeLicenseResponse\(\)

```csharp
public CMsgAMAddFreeLicenseResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse__ctor_Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_"></a> CMsgAMAddFreeLicenseResponse\(CMsgAMAddFreeLicenseResponse\)

```csharp
public CMsgAMAddFreeLicenseResponse(CMsgAMAddFreeLicenseResponse other)
```

#### Parameters

`other` [CMsgAMAddFreeLicenseResponse](Divine.Protobufs.Steam.CMsgAMAddFreeLicenseResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_EresultFieldNumber"></a> EresultFieldNumber

```csharp
public const int EresultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_PurchaseResultDetailFieldNumber"></a> PurchaseResultDetailFieldNumber

```csharp
public const int PurchaseResultDetailFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_TransidFieldNumber"></a> TransidFieldNumber

```csharp
public const int TransidFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Eresult"></a> Eresult

```csharp
public int Eresult { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_HasEresult"></a> HasEresult

```csharp
public bool HasEresult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_HasPurchaseResultDetail"></a> HasPurchaseResultDetail

```csharp
public bool HasPurchaseResultDetail { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_HasTransid"></a> HasTransid

```csharp
public bool HasTransid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMAddFreeLicenseResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMAddFreeLicenseResponse](Divine.Protobufs.Steam.CMsgAMAddFreeLicenseResponse.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_PurchaseResultDetail"></a> PurchaseResultDetail

```csharp
public int PurchaseResultDetail { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Transid"></a> Transid

```csharp
public ulong Transid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_ClearEresult"></a> ClearEresult\(\)

```csharp
public void ClearEresult()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_ClearPurchaseResultDetail"></a> ClearPurchaseResultDetail\(\)

```csharp
public void ClearPurchaseResultDetail()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_ClearTransid"></a> ClearTransid\(\)

```csharp
public void ClearTransid()
```

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Clone"></a> Clone\(\)

```csharp
public CMsgAMAddFreeLicenseResponse Clone()
```

#### Returns

 [CMsgAMAddFreeLicenseResponse](Divine.Protobufs.Steam.CMsgAMAddFreeLicenseResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_Equals_Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_"></a> Equals\(CMsgAMAddFreeLicenseResponse\)

```csharp
public bool Equals(CMsgAMAddFreeLicenseResponse other)
```

#### Parameters

`other` [CMsgAMAddFreeLicenseResponse](Divine.Protobufs.Steam.CMsgAMAddFreeLicenseResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_MergeFrom_Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_"></a> MergeFrom\(CMsgAMAddFreeLicenseResponse\)

```csharp
public void MergeFrom(CMsgAMAddFreeLicenseResponse other)
```

#### Parameters

`other` [CMsgAMAddFreeLicenseResponse](Divine.Protobufs.Steam.CMsgAMAddFreeLicenseResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMAddFreeLicenseResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

