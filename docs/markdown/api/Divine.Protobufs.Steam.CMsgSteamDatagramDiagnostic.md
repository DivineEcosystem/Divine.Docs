# <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic"></a> Class CMsgSteamDatagramDiagnostic

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamDatagramDiagnostic : IMessage<CMsgSteamDatagramDiagnostic>, IEquatable<CMsgSteamDatagramDiagnostic>, IDeepCloneable<CMsgSteamDatagramDiagnostic>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamDatagramDiagnostic](Divine.Protobufs.Steam.CMsgSteamDatagramDiagnostic.md)

#### Implements

IMessage<CMsgSteamDatagramDiagnostic\>, 
[IEquatable<CMsgSteamDatagramDiagnostic\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamDatagramDiagnostic\>, 
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
[EnumerableExtensions.In<CMsgSteamDatagramDiagnostic\>\(CMsgSteamDatagramDiagnostic, params CMsgSteamDatagramDiagnostic\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic__ctor"></a> CMsgSteamDatagramDiagnostic\(\)

```csharp
public CMsgSteamDatagramDiagnostic()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic__ctor_Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_"></a> CMsgSteamDatagramDiagnostic\(CMsgSteamDatagramDiagnostic\)

```csharp
public CMsgSteamDatagramDiagnostic(CMsgSteamDatagramDiagnostic other)
```

#### Parameters

`other` [CMsgSteamDatagramDiagnostic](Divine.Protobufs.Steam.CMsgSteamDatagramDiagnostic.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_SeverityFieldNumber"></a> SeverityFieldNumber

```csharp
public const int SeverityFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_HasSeverity"></a> HasSeverity

```csharp
public bool HasSeverity { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamDatagramDiagnostic> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamDatagramDiagnostic](Divine.Protobufs.Steam.CMsgSteamDatagramDiagnostic.md)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Severity"></a> Severity

```csharp
public uint Severity { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_ClearSeverity"></a> ClearSeverity\(\)

```csharp
public void ClearSeverity()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Clone"></a> Clone\(\)

```csharp
public CMsgSteamDatagramDiagnostic Clone()
```

#### Returns

 [CMsgSteamDatagramDiagnostic](Divine.Protobufs.Steam.CMsgSteamDatagramDiagnostic.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_Equals_Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_"></a> Equals\(CMsgSteamDatagramDiagnostic\)

```csharp
public bool Equals(CMsgSteamDatagramDiagnostic other)
```

#### Parameters

`other` [CMsgSteamDatagramDiagnostic](Divine.Protobufs.Steam.CMsgSteamDatagramDiagnostic.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_MergeFrom_Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_"></a> MergeFrom\(CMsgSteamDatagramDiagnostic\)

```csharp
public void MergeFrom(CMsgSteamDatagramDiagnostic other)
```

#### Parameters

`other` [CMsgSteamDatagramDiagnostic](Divine.Protobufs.Steam.CMsgSteamDatagramDiagnostic.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamDatagramDiagnostic_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

