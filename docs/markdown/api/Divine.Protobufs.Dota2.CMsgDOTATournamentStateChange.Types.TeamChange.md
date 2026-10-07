# <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange"></a> Class CMsgDOTATournamentStateChange.Types.TeamChange

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTATournamentStateChange.Types.TeamChange : IMessage<CMsgDOTATournamentStateChange.Types.TeamChange>, IEquatable<CMsgDOTATournamentStateChange.Types.TeamChange>, IDeepCloneable<CMsgDOTATournamentStateChange.Types.TeamChange>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTATournamentStateChange.Types.TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)

#### Implements

IMessage<CMsgDOTATournamentStateChange.Types.TeamChange\>, 
[IEquatable<CMsgDOTATournamentStateChange.Types.TeamChange\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTATournamentStateChange.Types.TeamChange\>, 
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
[EnumerableExtensions.In<CMsgDOTATournamentStateChange.Types.TeamChange\>\(CMsgDOTATournamentStateChange.Types.TeamChange, params CMsgDOTATournamentStateChange.Types.TeamChange\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange__ctor"></a> TeamChange\(\)

```csharp
public TeamChange()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange__ctor_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_"></a> TeamChange\(TeamChange\)

```csharp
public TeamChange(CMsgDOTATournamentStateChange.Types.TeamChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_NewNodeOrStateFieldNumber"></a> NewNodeOrStateFieldNumber

```csharp
public const int NewNodeOrStateFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_OldNodeOrStateFieldNumber"></a> OldNodeOrStateFieldNumber

```csharp
public const int OldNodeOrStateFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_TeamGidFieldNumber"></a> TeamGidFieldNumber

```csharp
public const int TeamGidFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_HasNewNodeOrState"></a> HasNewNodeOrState

```csharp
public bool HasNewNodeOrState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_HasOldNodeOrState"></a> HasOldNodeOrState

```csharp
public bool HasOldNodeOrState { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_HasTeamGid"></a> HasTeamGid

```csharp
public bool HasTeamGid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_NewNodeOrState"></a> NewNodeOrState

```csharp
public uint NewNodeOrState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_OldNodeOrState"></a> OldNodeOrState

```csharp
public uint OldNodeOrState { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTATournamentStateChange.Types.TeamChange> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_TeamGid"></a> TeamGid

```csharp
public ulong TeamGid { get; set; }
```

#### Property Value

 [ulong](https://learn.microsoft.com/dotnet/api/system.uint64)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_ClearNewNodeOrState"></a> ClearNewNodeOrState\(\)

```csharp
public void ClearNewNodeOrState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_ClearOldNodeOrState"></a> ClearOldNodeOrState\(\)

```csharp
public void ClearOldNodeOrState()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_ClearTeamGid"></a> ClearTeamGid\(\)

```csharp
public void ClearTeamGid()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_Clone"></a> Clone\(\)

```csharp
public CMsgDOTATournamentStateChange.Types.TeamChange Clone()
```

#### Returns

 [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_Equals_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_"></a> Equals\(TeamChange\)

```csharp
public bool Equals(CMsgDOTATournamentStateChange.Types.TeamChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_"></a> MergeFrom\(TeamChange\)

```csharp
public void MergeFrom(CMsgDOTATournamentStateChange.Types.TeamChange other)
```

#### Parameters

`other` [CMsgDOTATournamentStateChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.md).[Types](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.md).[TeamChange](Divine.Protobufs.Dota2.CMsgDOTATournamentStateChange.Types.TeamChange.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTATournamentStateChange_Types_TeamChange_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

