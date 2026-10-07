# <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug"></a> Class CUserMessage\_UserSentBugBug

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMessage_UserSentBugBug : IMessage<CUserMessage_UserSentBugBug>, IEquatable<CUserMessage_UserSentBugBug>, IDeepCloneable<CUserMessage_UserSentBugBug>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMessage\_UserSentBugBug](Divine.Protobufs.Dota2.CUserMessage\_UserSentBugBug.md)

#### Implements

IMessage<CUserMessage\_UserSentBugBug\>, 
[IEquatable<CUserMessage\_UserSentBugBug\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMessage\_UserSentBugBug\>, 
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
[EnumerableExtensions.In<CUserMessage\_UserSentBugBug\>\(CUserMessage\_UserSentBugBug, params CUserMessage\_UserSentBugBug\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug__ctor"></a> CUserMessage\_UserSentBugBug\(\)

```csharp
public CUserMessage_UserSentBugBug()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug__ctor_Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_"></a> CUserMessage\_UserSentBugBug\(CUserMessage\_UserSentBugBug\)

```csharp
public CUserMessage_UserSentBugBug(CUserMessage_UserSentBugBug other)
```

#### Parameters

`other` [CUserMessage\_UserSentBugBug](Divine.Protobufs.Dota2.CUserMessage\_UserSentBugBug.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_AutoexecCfgFieldNumber"></a> AutoexecCfgFieldNumber

```csharp
public const int AutoexecCfgFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_BugbugNoFieldNumber"></a> BugbugNoFieldNumber

```csharp
public const int BugbugNoFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_BuildIdFieldNumber"></a> BuildIdFieldNumber

```csharp
public const int BuildIdFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_CommandLineFieldNumber"></a> CommandLineFieldNumber

```csharp
public const int CommandLineFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_CommandLogsFieldNumber"></a> CommandLogsFieldNumber

```csharp
public const int CommandLogsFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_OsversionFieldNumber"></a> OsversionFieldNumber

```csharp
public const int OsversionFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_SystemSpecsFieldNumber"></a> SystemSpecsFieldNumber

```csharp
public const int SystemSpecsFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_AutoexecCfg"></a> AutoexecCfg

```csharp
public string AutoexecCfg { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_BugbugNo"></a> BugbugNo

```csharp
public int BugbugNo { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_BuildId"></a> BuildId

```csharp
public uint BuildId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_CommandLine"></a> CommandLine

```csharp
public string CommandLine { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_CommandLogs"></a> CommandLogs

```csharp
public string CommandLogs { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_HasAutoexecCfg"></a> HasAutoexecCfg

```csharp
public bool HasAutoexecCfg { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_HasBugbugNo"></a> HasBugbugNo

```csharp
public bool HasBugbugNo { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_HasBuildId"></a> HasBuildId

```csharp
public bool HasBuildId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_HasCommandLine"></a> HasCommandLine

```csharp
public bool HasCommandLine { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_HasCommandLogs"></a> HasCommandLogs

```csharp
public bool HasCommandLogs { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_HasOsversion"></a> HasOsversion

```csharp
public bool HasOsversion { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_Osversion"></a> Osversion

```csharp
public int Osversion { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_Parser"></a> Parser

```csharp
public static MessageParser<CUserMessage_UserSentBugBug> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMessage\_UserSentBugBug](Divine.Protobufs.Dota2.CUserMessage\_UserSentBugBug.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_SystemSpecs"></a> SystemSpecs

```csharp
public CMsgSource2SystemSpecs SystemSpecs { get; set; }
```

#### Property Value

 [CMsgSource2SystemSpecs](Divine.Protobufs.Dota2.CMsgSource2SystemSpecs.md)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ClearAutoexecCfg"></a> ClearAutoexecCfg\(\)

```csharp
public void ClearAutoexecCfg()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ClearBugbugNo"></a> ClearBugbugNo\(\)

```csharp
public void ClearBugbugNo()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ClearBuildId"></a> ClearBuildId\(\)

```csharp
public void ClearBuildId()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ClearCommandLine"></a> ClearCommandLine\(\)

```csharp
public void ClearCommandLine()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ClearCommandLogs"></a> ClearCommandLogs\(\)

```csharp
public void ClearCommandLogs()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ClearOsversion"></a> ClearOsversion\(\)

```csharp
public void ClearOsversion()
```

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_Clone"></a> Clone\(\)

```csharp
public CUserMessage_UserSentBugBug Clone()
```

#### Returns

 [CUserMessage\_UserSentBugBug](Divine.Protobufs.Dota2.CUserMessage\_UserSentBugBug.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_Equals_Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_"></a> Equals\(CUserMessage\_UserSentBugBug\)

```csharp
public bool Equals(CUserMessage_UserSentBugBug other)
```

#### Parameters

`other` [CUserMessage\_UserSentBugBug](Divine.Protobufs.Dota2.CUserMessage\_UserSentBugBug.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_MergeFrom_Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_"></a> MergeFrom\(CUserMessage\_UserSentBugBug\)

```csharp
public void MergeFrom(CUserMessage_UserSentBugBug other)
```

#### Parameters

`other` [CUserMessage\_UserSentBugBug](Divine.Protobufs.Dota2.CUserMessage\_UserSentBugBug.md)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMessage_UserSentBugBug_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

