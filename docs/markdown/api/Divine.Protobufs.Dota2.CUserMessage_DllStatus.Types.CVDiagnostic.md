# <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic"></a> Class CUserMessage\_DllStatus.Types.CVDiagnostic

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_DllStatus.Types.CVDiagnostic : IMessage<CUserMessage_DllStatus.Types.CVDiagnostic>, IEquatable<CUserMessage_DllStatus.Types.CVDiagnostic>, IDeepCloneable<CUserMessage_DllStatus.Types.CVDiagnostic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_DllStatus.Types.CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)

#### Implements

IMessage<CUserMessage\_DllStatus.Types.CVDiagnostic\>, 
[IEquatable<CUserMessage\_DllStatus.Types.CVDiagnostic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_DllStatus.Types.CVDiagnostic\>, 
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
[EnumerableExtensions.In<CUserMessage\_DllStatus.Types.CVDiagnostic\>\(CUserMessage\_DllStatus.Types.CVDiagnostic, params CUserMessage\_DllStatus.Types.CVDiagnostic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic__ctor"></a> CVDiagnostic\(\)

```csharp
public CVDiagnostic()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic__ctor_Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_"></a> CVDiagnostic\(CVDiagnostic\)

```csharp
public CVDiagnostic(CUserMessage_DllStatus.Types.CVDiagnostic other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ExtendedFieldNumber"></a> ExtendedFieldNumber

```csharp
public const int ExtendedFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_IdFieldNumber"></a> IdFieldNumber

```csharp
public const int IdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_StringValueFieldNumber"></a> StringValueFieldNumber

```csharp
public const int StringValueFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Extended"></a> Extended

```csharp
public uint Extended { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_HasExtended"></a> HasExtended

```csharp
public bool HasExtended { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_HasId"></a> HasId

```csharp
public bool HasId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_HasStringValue"></a> HasStringValue

```csharp
public bool HasStringValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Id"></a> Id

```csharp
public uint Id { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_DllStatus.Types.CVDiagnostic> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_StringValue"></a> StringValue

```csharp
public string StringValue { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Value"></a> Value

```csharp
public ulong Value { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ClearExtended"></a> ClearExtended\(\)

```csharp
public void ClearExtended()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ClearId"></a> ClearId\(\)

```csharp
public void ClearId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ClearStringValue"></a> ClearStringValue\(\)

```csharp
public void ClearStringValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Clone"></a> Clone\(\)

```csharp
public CUserMessage_DllStatus.Types.CVDiagnostic Clone()
```

#### Returns

 [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_Equals_Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_"></a> Equals\(CVDiagnostic\)

```csharp
public bool Equals(CUserMessage_DllStatus.Types.CVDiagnostic other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_"></a> MergeFrom\(CVDiagnostic\)

```csharp
public void MergeFrom(CUserMessage_DllStatus.Types.CVDiagnostic other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Types_CVDiagnostic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

