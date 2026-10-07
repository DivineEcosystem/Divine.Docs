# <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus"></a> Class CUserMessage\_DllStatus

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_DllStatus : IMessage<CUserMessage_DllStatus>, IEquatable<CUserMessage_DllStatus>, IDeepCloneable<CUserMessage_DllStatus>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md)

#### Implements

IMessage<CUserMessage\_DllStatus\>, 
[IEquatable<CUserMessage\_DllStatus\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_DllStatus\>, 
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
[EnumerableExtensions.In<CUserMessage\_DllStatus\>\(CUserMessage\_DllStatus, params CUserMessage\_DllStatus\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus__ctor"></a> CUserMessage\_DllStatus\(\)

```csharp
public CUserMessage_DllStatus()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus__ctor_Divine_Protobufs_Dota2_CUserMessage_DllStatus_"></a> CUserMessage\_DllStatus\(CUserMessage\_DllStatus\)

```csharp
public CUserMessage_DllStatus(CUserMessage_DllStatus other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClientTimeFieldNumber"></a> ClientTimeFieldNumber

```csharp
public const int ClientTimeFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_CommandLineFieldNumber"></a> CommandLineFieldNumber

```csharp
public const int CommandLineFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_DiagnosticsFieldNumber"></a> DiagnosticsFieldNumber

```csharp
public const int DiagnosticsFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_FileReportFieldNumber"></a> FileReportFieldNumber

```csharp
public const int FileReportFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ModulesFieldNumber"></a> ModulesFieldNumber

```csharp
public const int ModulesFieldNumber = 8
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_OsversionFieldNumber"></a> OsversionFieldNumber

```csharp
public const int OsversionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ProcessIdFieldNumber"></a> ProcessIdFieldNumber

```csharp
public const int ProcessIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_TotalFilesFieldNumber"></a> TotalFilesFieldNumber

```csharp
public const int TotalFilesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClientTime"></a> ClientTime

```csharp
public ulong ClientTime { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_CommandLine"></a> CommandLine

```csharp
public string CommandLine { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Diagnostics"></a> Diagnostics

```csharp
public RepeatedField<CUserMessage_DllStatus.Types.CVDiagnostic> Diagnostics { get; }
```

#### Property Value

 RepeatedField<[CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CVDiagnostic](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CVDiagnostic.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_FileReport"></a> FileReport

```csharp
public string FileReport { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_HasClientTime"></a> HasClientTime

```csharp
public bool HasClientTime { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_HasCommandLine"></a> HasCommandLine

```csharp
public bool HasCommandLine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_HasFileReport"></a> HasFileReport

```csharp
public bool HasFileReport { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_HasOsversion"></a> HasOsversion

```csharp
public bool HasOsversion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_HasProcessId"></a> HasProcessId

```csharp
public bool HasProcessId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_HasTotalFiles"></a> HasTotalFiles

```csharp
public bool HasTotalFiles { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Modules"></a> Modules

```csharp
public RepeatedField<CUserMessage_DllStatus.Types.CModule> Modules { get; }
```

#### Property Value

 RepeatedField<[CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md).[Types](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.md).[CModule](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.Types.CModule.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Osversion"></a> Osversion

```csharp
public int Osversion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_DllStatus> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ProcessId"></a> ProcessId

```csharp
public uint ProcessId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_TotalFiles"></a> TotalFiles

```csharp
public uint TotalFiles { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClearClientTime"></a> ClearClientTime\(\)

```csharp
public void ClearClientTime()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClearCommandLine"></a> ClearCommandLine\(\)

```csharp
public void ClearCommandLine()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClearFileReport"></a> ClearFileReport\(\)

```csharp
public void ClearFileReport()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClearOsversion"></a> ClearOsversion\(\)

```csharp
public void ClearOsversion()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClearProcessId"></a> ClearProcessId\(\)

```csharp
public void ClearProcessId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ClearTotalFiles"></a> ClearTotalFiles\(\)

```csharp
public void ClearTotalFiles()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Clone"></a> Clone\(\)

```csharp
public CUserMessage_DllStatus Clone()
```

#### Returns

 [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_Equals_Divine_Protobufs_Dota2_CUserMessage_DllStatus_"></a> Equals\(CUserMessage\_DllStatus\)

```csharp
public bool Equals(CUserMessage_DllStatus other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_DllStatus_"></a> MergeFrom\(CUserMessage\_DllStatus\)

```csharp
public void MergeFrom(CUserMessage_DllStatus other)
```

#### Parameters

`other` [CUserMessage\_DllStatus](Divine.Protobufs.Dota2.CUserMessage\_DllStatus.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_DllStatus_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

