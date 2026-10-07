# <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets"></a> Class CMsgDOTAProfileTickets

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgDOTAProfileTickets : IMessage<CMsgDOTAProfileTickets>, IEquatable<CMsgDOTAProfileTickets>, IDeepCloneable<CMsgDOTAProfileTickets>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md)

#### Implements

IMessage<CMsgDOTAProfileTickets\>, 
[IEquatable<CMsgDOTAProfileTickets\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgDOTAProfileTickets\>, 
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
[EnumerableExtensions.In<CMsgDOTAProfileTickets\>\(CMsgDOTAProfileTickets, params CMsgDOTAProfileTickets\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets__ctor"></a> CMsgDOTAProfileTickets\(\)

```csharp
public CMsgDOTAProfileTickets()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets__ctor_Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_"></a> CMsgDOTAProfileTickets\(CMsgDOTAProfileTickets\)

```csharp
public CMsgDOTAProfileTickets(CMsgDOTAProfileTickets other)
```

#### Parameters

`other` [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_AccountIdFieldNumber"></a> AccountIdFieldNumber

```csharp
public const int AccountIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_LeaguePassesFieldNumber"></a> LeaguePassesFieldNumber

```csharp
public const int LeaguePassesFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_ResultFieldNumber"></a> ResultFieldNumber

```csharp
public const int ResultFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_AccountId"></a> AccountId

```csharp
public uint AccountId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_HasAccountId"></a> HasAccountId

```csharp
public bool HasAccountId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_HasResult"></a> HasResult

```csharp
public bool HasResult { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_LeaguePasses"></a> LeaguePasses

```csharp
public RepeatedField<CMsgDOTAProfileTickets.Types.LeaguePass> LeaguePasses { get; }
```

#### Property Value

 RepeatedField<[CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md).[Types](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.md).[LeaguePass](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.Types.LeaguePass.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Parser"></a> Parser

```csharp
public static MessageParser<CMsgDOTAProfileTickets> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Result"></a> Result

```csharp
public uint Result { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_ClearAccountId"></a> ClearAccountId\(\)

```csharp
public void ClearAccountId()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_ClearResult"></a> ClearResult\(\)

```csharp
public void ClearResult()
```

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Clone"></a> Clone\(\)

```csharp
public CMsgDOTAProfileTickets Clone()
```

#### Returns

 [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_Equals_Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_"></a> Equals\(CMsgDOTAProfileTickets\)

```csharp
public bool Equals(CMsgDOTAProfileTickets other)
```

#### Parameters

`other` [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_MergeFrom_Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_"></a> MergeFrom\(CMsgDOTAProfileTickets\)

```csharp
public void MergeFrom(CMsgDOTAProfileTickets other)
```

#### Parameters

`other` [CMsgDOTAProfileTickets](Divine.Protobufs.Dota2.CMsgDOTAProfileTickets.md)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgDOTAProfileTickets_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

