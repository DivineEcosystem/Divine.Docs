# <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus"></a> Class CMsgClientToGCIntegrityStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCIntegrityStatus : IMessage<CMsgClientToGCIntegrityStatus>, IEquatable<CMsgClientToGCIntegrityStatus>, IDeepCloneable<CMsgClientToGCIntegrityStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md)

#### Implements

IMessage<CMsgClientToGCIntegrityStatus\>, 
[IEquatable<CMsgClientToGCIntegrityStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCIntegrityStatus\>, 
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
[EnumerableExtensions.In<CMsgClientToGCIntegrityStatus\>\(CMsgClientToGCIntegrityStatus, params CMsgClientToGCIntegrityStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus__ctor"></a> CMsgClientToGCIntegrityStatus\(\)

```csharp
public CMsgClientToGCIntegrityStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus__ctor_Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_"></a> CMsgClientToGCIntegrityStatus\(CMsgClientToGCIntegrityStatus\)

```csharp
public CMsgClientToGCIntegrityStatus(CMsgClientToGCIntegrityStatus other)
```

#### Parameters

`other` [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_DiagnosticsFieldNumber"></a> DiagnosticsFieldNumber

```csharp
public const int DiagnosticsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_ReportFieldNumber"></a> ReportFieldNumber

```csharp
public const int ReportFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_SecureAllowedFieldNumber"></a> SecureAllowedFieldNumber

```csharp
public const int SecureAllowedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Diagnostics"></a> Diagnostics

```csharp
public RepeatedField<CMsgClientToGCIntegrityStatus.Types.keyvalue> Diagnostics { get; }
```

#### Property Value

 RepeatedField<[CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md).[Types](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.md).[keyvalue](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.Types.keyvalue.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_HasReport"></a> HasReport

```csharp
public bool HasReport { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_HasSecureAllowed"></a> HasSecureAllowed

```csharp
public bool HasSecureAllowed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCIntegrityStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Report"></a> Report

```csharp
public string Report { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_SecureAllowed"></a> SecureAllowed

```csharp
public bool SecureAllowed { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_ClearReport"></a> ClearReport\(\)

```csharp
public void ClearReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_ClearSecureAllowed"></a> ClearSecureAllowed\(\)

```csharp
public void ClearSecureAllowed()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCIntegrityStatus Clone()
```

#### Returns

 [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_Equals_Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_"></a> Equals\(CMsgClientToGCIntegrityStatus\)

```csharp
public bool Equals(CMsgClientToGCIntegrityStatus other)
```

#### Parameters

`other` [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_"></a> MergeFrom\(CMsgClientToGCIntegrityStatus\)

```csharp
public void MergeFrom(CMsgClientToGCIntegrityStatus other)
```

#### Parameters

`other` [CMsgClientToGCIntegrityStatus](Divine.Protobufs.Dota2.CMsgClientToGCIntegrityStatus.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCIntegrityStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

