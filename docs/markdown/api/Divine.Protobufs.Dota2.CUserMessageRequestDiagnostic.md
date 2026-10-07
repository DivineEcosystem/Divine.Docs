# <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic"></a> Class CUserMessageRequestDiagnostic

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessageRequestDiagnostic : IMessage<CUserMessageRequestDiagnostic>, IEquatable<CUserMessageRequestDiagnostic>, IDeepCloneable<CUserMessageRequestDiagnostic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md)

#### Implements

IMessage<CUserMessageRequestDiagnostic\>, 
[IEquatable<CUserMessageRequestDiagnostic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessageRequestDiagnostic\>, 
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
[EnumerableExtensions.In<CUserMessageRequestDiagnostic\>\(CUserMessageRequestDiagnostic, params CUserMessageRequestDiagnostic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic__ctor"></a> CUserMessageRequestDiagnostic\(\)

```csharp
public CUserMessageRequestDiagnostic()
```

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic__ctor_Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_"></a> CUserMessageRequestDiagnostic\(CUserMessageRequestDiagnostic\)

```csharp
public CUserMessageRequestDiagnostic(CUserMessageRequestDiagnostic other)
```

#### Parameters

`other` [CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_DiagnosticsFieldNumber"></a> DiagnosticsFieldNumber

```csharp
public const int DiagnosticsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_Diagnostics"></a> Diagnostics

```csharp
public RepeatedField<CUserMessageRequestDiagnostic.Types.Diagnostic> Diagnostics { get; }
```

#### Property Value

 RepeatedField<[CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md).[Types](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.Types.md).[Diagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.Types.Diagnostic.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessageRequestDiagnostic> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_Clone"></a> Clone\(\)

```csharp
public CUserMessageRequestDiagnostic Clone()
```

#### Returns

 [CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_Equals_Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_"></a> Equals\(CUserMessageRequestDiagnostic\)

```csharp
public bool Equals(CUserMessageRequestDiagnostic other)
```

#### Parameters

`other` [CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_MergeFrom_Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_"></a> MergeFrom\(CUserMessageRequestDiagnostic\)

```csharp
public void MergeFrom(CUserMessageRequestDiagnostic other)
```

#### Parameters

`other` [CUserMessageRequestDiagnostic](Divine.Protobufs.Dota2.CUserMessageRequestDiagnostic.md)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessageRequestDiagnostic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

