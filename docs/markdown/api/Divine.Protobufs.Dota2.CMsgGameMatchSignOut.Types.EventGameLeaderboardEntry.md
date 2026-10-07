# <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry"></a> Class CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry : IMessage<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry>, IEquatable<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry>, IDeepCloneable<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)

#### Implements

IMessage<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry\>, 
[IEquatable<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry\>, 
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
[EnumerableExtensions.In<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry\>\(CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry, params CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry__ctor"></a> EventGameLeaderboardEntry\(\)

```csharp
public EventGameLeaderboardEntry()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry__ctor_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_"></a> EventGameLeaderboardEntry\(EventGameLeaderboardEntry\)

```csharp
public EventGameLeaderboardEntry(CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData1FieldNumber"></a> ExtraData1FieldNumber

```csharp
public const int ExtraData1FieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData2FieldNumber"></a> ExtraData2FieldNumber

```csharp
public const int ExtraData2FieldNumber = 4
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData3FieldNumber"></a> ExtraData3FieldNumber

```csharp
public const int ExtraData3FieldNumber = 5
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData4FieldNumber"></a> ExtraData4FieldNumber

```csharp
public const int ExtraData4FieldNumber = 6
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData5FieldNumber"></a> ExtraData5FieldNumber

```csharp
public const int ExtraData5FieldNumber = 7
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_NameSuffixFieldNumber"></a> NameSuffixFieldNumber

```csharp
public const int NameSuffixFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ScoreFieldNumber"></a> ScoreFieldNumber

```csharp
public const int ScoreFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData1"></a> ExtraData1

```csharp
public uint ExtraData1 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData2"></a> ExtraData2

```csharp
public uint ExtraData2 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData3"></a> ExtraData3

```csharp
public uint ExtraData3 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData4"></a> ExtraData4

```csharp
public uint ExtraData4 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ExtraData5"></a> ExtraData5

```csharp
public uint ExtraData5 { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasExtraData1"></a> HasExtraData1

```csharp
public bool HasExtraData1 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasExtraData2"></a> HasExtraData2

```csharp
public bool HasExtraData2 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasExtraData3"></a> HasExtraData3

```csharp
public bool HasExtraData3 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasExtraData4"></a> HasExtraData4

```csharp
public bool HasExtraData4 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasExtraData5"></a> HasExtraData5

```csharp
public bool HasExtraData5 { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasNameSuffix"></a> HasNameSuffix

```csharp
public bool HasNameSuffix { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_HasScore"></a> HasScore

```csharp
public bool HasScore { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_NameSuffix"></a> NameSuffix

```csharp
public string NameSuffix { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_Parser"></a> Parser

```csharp
public static MessageParser<CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_Score"></a> Score

```csharp
public int Score { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearExtraData1"></a> ClearExtraData1\(\)

```csharp
public void ClearExtraData1()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearExtraData2"></a> ClearExtraData2\(\)

```csharp
public void ClearExtraData2()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearExtraData3"></a> ClearExtraData3\(\)

```csharp
public void ClearExtraData3()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearExtraData4"></a> ClearExtraData4\(\)

```csharp
public void ClearExtraData4()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearExtraData5"></a> ClearExtraData5\(\)

```csharp
public void ClearExtraData5()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearNameSuffix"></a> ClearNameSuffix\(\)

```csharp
public void ClearNameSuffix()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ClearScore"></a> ClearScore\(\)

```csharp
public void ClearScore()
```

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_Clone"></a> Clone\(\)

```csharp
public CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry Clone()
```

#### Returns

 [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_Equals_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_"></a> Equals\(EventGameLeaderboardEntry\)

```csharp
public bool Equals(CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_MergeFrom_Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_"></a> MergeFrom\(EventGameLeaderboardEntry\)

```csharp
public void MergeFrom(CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry other)
```

#### Parameters

`other` [CMsgGameMatchSignOut](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.md).[Types](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.md).[EventGameLeaderboardEntry](Divine.Protobufs.Dota2.CMsgGameMatchSignOut.Types.EventGameLeaderboardEntry.md)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgGameMatchSignOut_Types_EventGameLeaderboardEntry_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

