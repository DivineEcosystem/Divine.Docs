# <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow"></a> Class CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow : IMessage<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow>, IEquatable<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow>, IDeepCloneable<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)

#### Implements

IMessage<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow\>, 
[IEquatable<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow\>, 
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
[EnumerableExtensions.In<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow\>\(CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow, params CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow__ctor"></a> IndividualRow\(\)

```csharp
public IndividualRow()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow__ctor_Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_"></a> IndividualRow\(IndividualRow\)

```csharp
public IndividualRow(CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow other)
```

#### Parameters

`other` [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md).[Types](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.md).[IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_FirstMatchSeenFieldNumber"></a> FirstMatchSeenFieldNumber

```csharp
public const int FirstMatchSeenFieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_LastMatchSeenFieldNumber"></a> LastMatchSeenFieldNumber

```csharp
public const int LastMatchSeenFieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_NumMatchesSeenFieldNumber"></a> NumMatchesSeenFieldNumber

```csharp
public const int NumMatchesSeenFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_NumMessagesFieldNumber"></a> NumMessagesFieldNumber

```csharp
public const int NumMessagesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_NumMessagesToxicFieldNumber"></a> NumMessagesToxicFieldNumber

```csharp
public const int NumMessagesToxicFieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_PlayerAccountIdFieldNumber"></a> PlayerAccountIdFieldNumber

```csharp
public const int PlayerAccountIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_FirstMatchSeen"></a> FirstMatchSeen

```csharp
public ulong FirstMatchSeen { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_HasFirstMatchSeen"></a> HasFirstMatchSeen

```csharp
public bool HasFirstMatchSeen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_HasLastMatchSeen"></a> HasLastMatchSeen

```csharp
public bool HasLastMatchSeen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_HasNumMatchesSeen"></a> HasNumMatchesSeen

```csharp
public bool HasNumMatchesSeen { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_HasNumMessages"></a> HasNumMessages

```csharp
public bool HasNumMessages { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_HasNumMessagesToxic"></a> HasNumMessagesToxic

```csharp
public bool HasNumMessagesToxic { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_HasPlayerAccountId"></a> HasPlayerAccountId

```csharp
public bool HasPlayerAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_LastMatchSeen"></a> LastMatchSeen

```csharp
public ulong LastMatchSeen { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_NumMatchesSeen"></a> NumMatchesSeen

```csharp
public uint NumMatchesSeen { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_NumMessages"></a> NumMessages

```csharp
public uint NumMessages { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_NumMessagesToxic"></a> NumMessagesToxic

```csharp
public uint NumMessagesToxic { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_Parser"></a> Parser

```csharp
public static MessageParser<CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md).[Types](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.md).[IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_PlayerAccountId"></a> PlayerAccountId

```csharp
public uint PlayerAccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ClearFirstMatchSeen"></a> ClearFirstMatchSeen\(\)

```csharp
public void ClearFirstMatchSeen()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ClearLastMatchSeen"></a> ClearLastMatchSeen\(\)

```csharp
public void ClearLastMatchSeen()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ClearNumMatchesSeen"></a> ClearNumMatchesSeen\(\)

```csharp
public void ClearNumMatchesSeen()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ClearNumMessages"></a> ClearNumMessages\(\)

```csharp
public void ClearNumMessages()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ClearNumMessagesToxic"></a> ClearNumMessagesToxic\(\)

```csharp
public void ClearNumMessagesToxic()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ClearPlayerAccountId"></a> ClearPlayerAccountId\(\)

```csharp
public void ClearPlayerAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_Clone"></a> Clone\(\)

```csharp
public CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow Clone()
```

#### Returns

 [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md).[Types](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.md).[IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_Equals_Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_"></a> Equals\(IndividualRow\)

```csharp
public bool Equals(CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow other)
```

#### Parameters

`other` [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md).[Types](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.md).[IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_MergeFrom_Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_"></a> MergeFrom\(IndividualRow\)

```csharp
public void MergeFrom(CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow other)
```

#### Parameters

`other` [CMsgChatToxicityToxicPlayerMatchesReport](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.md).[Types](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.md).[IndividualRow](Divine.Protobufs.Dota2.CMsgChatToxicityToxicPlayerMatchesReport.Types.IndividualRow.md)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgChatToxicityToxicPlayerMatchesReport_Types_IndividualRow_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

