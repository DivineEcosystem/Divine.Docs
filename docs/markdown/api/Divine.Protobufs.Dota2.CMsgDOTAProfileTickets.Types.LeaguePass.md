# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass"></a> Class CMsgDOTAProfileTickets.Types.LeaguePass

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileTickets.Types.LeaguePass : IMessage<CMsgDOTAProfileTickets.Types.LeaguePass>, IEquatable<CMsgDOTAProfileTickets.Types.LeaguePass>, IDeepCloneable<CMsgDOTAProfileTickets.Types.LeaguePass>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileTickets.Types.LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)

#### Implements

IMessage<CMsgDOTAProfileTickets.Types.LeaguePass\>, 
[IEquatable<CMsgDOTAProfileTickets.Types.LeaguePass\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileTickets.Types.LeaguePass\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileTickets.Types.LeaguePass\>\(CMsgDOTAProfileTickets.Types.LeaguePass, params CMsgDOTAProfileTickets.Types.LeaguePass\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass__ctor"></a> LeaguePass\(\)

```csharp
public LeaguePass()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_"></a> LeaguePass\(LeaguePass\)

```csharp
public LeaguePass(CMsgDOTAProfileTickets.Types.LeaguePass other)
```

#### Parameters

`other` [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.md).[LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_ItemDefFieldNumber"></a> ItemDefFieldNumber

```csharp
public const int ItemDefFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_LeagueIdFieldNumber"></a> LeagueIdFieldNumber

```csharp
public const int LeagueIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_HasItemDef"></a> HasItemDef

```csharp
public bool HasItemDef { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_HasLeagueId"></a> HasLeagueId

```csharp
public bool HasLeagueId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_ItemDef"></a> ItemDef

```csharp
public uint ItemDef { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_LeagueId"></a> LeagueId

```csharp
public uint LeagueId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileTickets.Types.LeaguePass> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.md).[LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_ClearItemDef"></a> ClearItemDef\(\)

```csharp
public void ClearItemDef()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_ClearLeagueId"></a> ClearLeagueId\(\)

```csharp
public void ClearLeagueId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileTickets.Types.LeaguePass Clone()
```

#### Returns

 [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.md).[LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_"></a> Equals\(LeaguePass\)

```csharp
public bool Equals(CMsgDOTAProfileTickets.Types.LeaguePass other)
```

#### Parameters

`other` [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.md).[LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_"></a> MergeFrom\(LeaguePass\)

```csharp
public void MergeFrom(CMsgDOTAProfileTickets.Types.LeaguePass other)
```

#### Parameters

`other` [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.md).[LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Types_LeaguePass_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

