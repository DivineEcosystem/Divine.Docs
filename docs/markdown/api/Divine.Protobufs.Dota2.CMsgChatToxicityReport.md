# <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport"></a> Class CMsgChatToxicityReport

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgChatToxicityReport : IMessage<CMsgChatToxicityReport>, IEquatable<CMsgChatToxicityReport>, IDeepCloneable<CMsgChatToxicityReport>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgChatToxicityReport](Divine.Protobufs.Dota2.CMsgChatToxicityReport.md)

#### Implements

IMessage<CMsgChatToxicityReport\>, 
[IEquatable<CMsgChatToxicityReport\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgChatToxicityReport\>, 
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
[EnumerableExtensions.In<CMsgChatToxicityReport\>\(CMsgChatToxicityReport, params CMsgChatToxicityReport\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport__ctor"></a> CMsgChatToxicityReport\(\)

```csharp
public CMsgChatToxicityReport()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport__ctor_Divine_Protobufs_Dota2_CMsgChatToxicityReport_"></a> CMsgChatToxicityReport\(CMsgChatToxicityReport\)

```csharp
public CMsgChatToxicityReport(CMsgChatToxicityReport other)
```

#### Parameters

`other` [CMsgChatToxicityReport](Divine.Protobufs.Dota2.CMsgChatToxicityReport.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_MessageFieldNumber"></a> MessageFieldNumber

```csharp
public const int MessageFieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_NumMatchesSeenFieldNumber"></a> NumMatchesSeenFieldNumber

```csharp
public const int NumMatchesSeenFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_NumMessagesFieldNumber"></a> NumMessagesFieldNumber

```csharp
public const int NumMessagesFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_NumMessagesMlThinksToxicFieldNumber"></a> NumMessagesMlThinksToxicFieldNumber

```csharp
public const int NumMessagesMlThinksToxicFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_StatusFieldNumber"></a> StatusFieldNumber

```csharp
public const int StatusFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_HasMessage"></a> HasMessage

```csharp
public bool HasMessage { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_HasNumMatchesSeen"></a> HasNumMatchesSeen

```csharp
public bool HasNumMatchesSeen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_HasNumMessages"></a> HasNumMessages

```csharp
public bool HasNumMessages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_HasNumMessagesMlThinksToxic"></a> HasNumMessagesMlThinksToxic

```csharp
public bool HasNumMessagesMlThinksToxic { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_HasStatus"></a> HasStatus

```csharp
public bool HasStatus { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Message"></a> Message

```csharp
public string Message { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_NumMatchesSeen"></a> NumMatchesSeen

```csharp
public uint NumMatchesSeen { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_NumMessages"></a> NumMessages

```csharp
public uint NumMessages { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_NumMessagesMlThinksToxic"></a> NumMessagesMlThinksToxic

```csharp
public uint NumMessagesMlThinksToxic { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Parser"></a> Parser

```csharp
public static MessageParser<CMsgChatToxicityReport> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgChatToxicityReport](Divine.Protobufs.Dota2.CMsgChatToxicityReport.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Status"></a> Status

```csharp
public string Status { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ClearMessage"></a> ClearMessage\(\)

```csharp
public void ClearMessage()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ClearNumMatchesSeen"></a> ClearNumMatchesSeen\(\)

```csharp
public void ClearNumMatchesSeen()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ClearNumMessages"></a> ClearNumMessages\(\)

```csharp
public void ClearNumMessages()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ClearNumMessagesMlThinksToxic"></a> ClearNumMessagesMlThinksToxic\(\)

```csharp
public void ClearNumMessagesMlThinksToxic()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ClearStatus"></a> ClearStatus\(\)

```csharp
public void ClearStatus()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Clone"></a> Clone\(\)

```csharp
public CMsgChatToxicityReport Clone()
```

#### Returns

 [CMsgChatToxicityReport](Divine.Protobufs.Dota2.CMsgChatToxicityReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_Equals_Divine_Protobufs_Dota2_CMsgChatToxicityReport_"></a> Equals\(CMsgChatToxicityReport\)

```csharp
public bool Equals(CMsgChatToxicityReport other)
```

#### Parameters

`other` [CMsgChatToxicityReport](Divine.Protobufs.Dota2.CMsgChatToxicityReport.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_MergeFrom_Divine_Protobufs_Dota2_CMsgChatToxicityReport_"></a> MergeFrom\(CMsgChatToxicityReport\)

```csharp
public void MergeFrom(CMsgChatToxicityReport other)
```

#### Parameters

`other` [CMsgChatToxicityReport](Divine.Protobufs.Dota2.CMsgChatToxicityReport.md)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityReport_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

