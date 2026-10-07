# <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse"></a> Class CMsgAMGetLicensesResponse

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgAMGetLicensesResponse : IMessage<CMsgAMGetLicensesResponse>, IEquatable<CMsgAMGetLicensesResponse>, IDeepCloneable<CMsgAMGetLicensesResponse>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgAMGetLicensesResponse](Divine.Protobufs.Steam.CMsgAMGetLicensesResponse.md)

#### Implements

IMessage<CMsgAMGetLicensesResponse\>, 
[IEquatable<CMsgAMGetLicensesResponse\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgAMGetLicensesResponse\>, 
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
[EnumerableExtensions.In<CMsgAMGetLicensesResponse\>\(CMsgAMGetLicensesResponse, params CMsgAMGetLicensesResponse\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse__ctor"></a> CMsgAMGetLicensesResponse\(\)

```csharp
public CMsgAMGetLicensesResponse()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse__ctor_Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_"></a> CMsgAMGetLicensesResponse\(CMsgAMGetLicensesResponse\)

```csharp
public CMsgAMGetLicensesResponse(CMsgAMGetLicensesResponse other)
```

#### Parameters

`other` [CMsgAMGetLicensesResponse](Divine.Protobufs.Steam.CMsgAMGetLicensesResponse.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_LicenseFieldNumber"></a> LicenseFieldNumber

```csharp
public const int LicenseFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_License"></a> License

```csharp
public RepeatedField<CMsgPackageLicense> License { get; }
```

#### Property Value

 RepeatedField<[CMsgPackageLicense](Divine.Protobufs.Steam.CMsgPackageLicense.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_Parser"></a> Parser

```csharp
public static MessageParser<CMsgAMGetLicensesResponse> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgAMGetLicensesResponse](Divine.Protobufs.Steam.CMsgAMGetLicensesResponse.md)\>

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_Clone"></a> Clone\(\)

```csharp
public CMsgAMGetLicensesResponse Clone()
```

#### Returns

 [CMsgAMGetLicensesResponse](Divine.Protobufs.Steam.CMsgAMGetLicensesResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_Equals_Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_"></a> Equals\(CMsgAMGetLicensesResponse\)

```csharp
public bool Equals(CMsgAMGetLicensesResponse other)
```

#### Parameters

`other` [CMsgAMGetLicensesResponse](Divine.Protobufs.Steam.CMsgAMGetLicensesResponse.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_MergeFrom_Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_"></a> MergeFrom\(CMsgAMGetLicensesResponse\)

```csharp
public void MergeFrom(CMsgAMGetLicensesResponse other)
```

#### Parameters

`other` [CMsgAMGetLicensesResponse](Divine.Protobufs.Steam.CMsgAMGetLicensesResponse.md)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgAMGetLicensesResponse_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

